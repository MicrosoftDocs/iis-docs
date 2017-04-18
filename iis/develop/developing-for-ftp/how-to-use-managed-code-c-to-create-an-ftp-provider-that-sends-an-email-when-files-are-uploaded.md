---
title: "How to Use Managed Code (C#) to Create an FTP Provider that Sends an Email when Files are Uploaded | Microsoft Docs"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008 . This new FTP service incorporates many new features tha..."
ms.author: iiscontent
manager: soshir
ms.date: 04/30/2009
ms.topic: article
ms.assetid: 4df497d3-fdfc-4772-ae97-579f9aef1fc5
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded
msc.type: authoredcontent
---
How to Use Managed Code (C#) to Create an FTP Provider that Sends an Email when Files are Uploaded
====================
by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

FTP 7.5 extensibility does not have a request-processing pipeline like the HTTP process model in IIS 7.0 and above, but you can use the IFtpLogProvider.Log() method to implement custom actions in response to FTP commands that have been sent by FTP clients, and you can examine the FTP status code to determine whether the FTP command succeeded or failed. (> [!NOTE]
> You do not have to have to actually write to a log file when you implement the IFtpLogProvider.Log() method in your providers.)

As a practical illustration, this walkthrough will lead you through the steps to use managed code to create a simple FTP provider that sends an email whenever a file is uploaded, and changes the text of the email message depending on whether the upload succeeded or failed.

The FTP provider in this walkthrough implements the IFtpLogProvider.Log() method and uses the FtpLogEntry.Command and FtpLogEntry.FtpStatus values to determine the FTP command from the client and the response status from FTP service. In addition, the provider overrides the IFtpLogProvider.Initialize() method to retrieve the SMTP server name/port and email addresses for the email message from the provider settings in your provider's entry in the ApplicationHost.config file. If the SMTP settings have not been added to the configuration settings, the FTP provider will return a simple exception to the FTP service and do nothing. You can monitor for these exceptions using ETW tracing, or you could add Debug.WriteLine() statements to write that status to the debug channel.

When an FTP client sends a file to the FTP service, the client will send a STOR command to the server. The FTP server should respond with a 226 status if the command succeeded, or a different status if the command failed. For example, the FTP service might return a 550 status if the user's disk quota has been exceeded.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the [https://www.iis.net/](https://www.iis.net/) web site using one of the following links: 

    - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
    - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
3. You must use Visual Studio 2008. (> [!NOTE]
> If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.)

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box: 

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **FtpMailDemo** as the name of the project.
    - Click **OK**.
4. When the project opens, add a reference path to the FTP extensibility library: 

    - Click **Project**, and then click **FtpMailDemo Properties**.
    - Click the **Reference Paths** tab.
    - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive:

        - For Windows Server 2008 and Windows Vista:

            [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded/samples/sample1.cmd)]
        - For Windows 7:

            [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded/samples/sample2.cmd)]
    - Click **Add Folder**.
5. Add a strong name key to the project: 

    - Click **Project**, and then click **FtpMailDemo Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **FtpMailDemoKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
    - Click **OK**.
6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer: 

    - Click **Project**, and then click **FtpMailDemo Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** dialog box: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded/samples/sample3.cmd)]
7. Save the project.

## Step 2: Create the Extensibility Class

In this step, you will implement the extensibility interface for the demo provider.

1. Add a reference to the FTP extensibility library for the project: 

    - Click **Project**, and then click **Add Reference...**
    - On the **.NET** tab, click **Microsoft.Web.FtpServer**.
    - Click **OK**.
2. Add a reference to System.Web for the project: 

    - Click **Project**, and then click **Add Reference...**
    - On the **.NET** tab, click **System.Web**.
    - Click **OK**.
3. Add the code for the authentication class: 

    - In **Solution Explorer**, double-click the **Class1.cs** file.
    - Remove the existing code.
    - Paste the following code into the editor: 

        [!code-csharp[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded/samples/sample4.cs)]
4. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the following topic on Microsoft the MSDN Web site:

> [Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/en-us/library/ex0ss12c(VS.80).aspx)


## Step 3: Add the Custom Provider to FTP

In this step, you will add the demo provider to your FTP service and an FTP site.

1. Determine the assembly information for the extensibility provider: 

    - In Windows Explorer, open your "C:\Windows\assembly" path, where C: is your operating system drive.
    - Locate the **FtpMailDemo** assembly.
    - Right-click the assembly, and then click **Properties**.
    - Copy the **Culture** value; for example: **Neutral**.
    - Copy the **Version** number; for example: **1.0.0.0**.
    - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Add the extensibility provider to the global list of FTP providers: 

    - At the moment there is no UI that enables you to add a custom provider with its related configuration settings to IIS, so you will have to use command line syntax like the following example:

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded/samples/sample5.cmd)]

        > [!NOTE]
        > You need to update the above syntax using the managed type information for your provider and the configuration settings for your SMTP server and email addresses.
3. Add the custom provider to a site: 

    - At the moment there is no UI that enables you to add custom features to a site, so you will have to use command line syntax like the following example that configures the Default Web Site:

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded/samples/sample6.cmd)]

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2008 for a custom FTP provider.
- Implement the extensibility interface for custom FTP functionality.
- Add a custom provider to your FTP service.

When users attempt to upload files to your FTP site, the FTP service will send an email message with a success or failure message using the SMTP server settings that you specified in your provider definition.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1045.aspx)