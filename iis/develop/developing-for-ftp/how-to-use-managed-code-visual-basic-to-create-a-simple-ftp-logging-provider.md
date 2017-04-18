---
title: "How to Use Managed Code (Visual Basic) to Create a Simple FTP Logging Provider | Microsoft Docs"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008 . This new FTP service incorporates many new features tha..."
ms.author: iiscontent
manager: soshir
ms.date: 07/27/2009
ms.topic: article
ms.assetid: 2bdef4d0-a18b-4d98-9849-30600ebe8278
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-logging-provider
msc.type: authoredcontent
---
How to Use Managed Code (Visual Basic) to Create a Simple FTP Logging Provider
====================
by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication and authorization providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

This walkthrough will lead you through the steps to use managed code in Visual Basic to create a simple FTP logging provider.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the [https://www.iis.net/](https://www.iis.net/) web site using one of the following links: 

    - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
    - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
3. You must create a root folder for FTP publishing.
4. You must use Visual Studio 2008. (> [!NOTE]
> If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.)
5. A folder for logging must be created; the code sample uses C:\logfiles\myftpsite, but you can change that if necessary.

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box: 

    - Choose **Visual Basic** as the project type.
    - Choose **Class Library** as the template.
    - Type **FtpLoggingDemo** as the name of the project.
    - Click **OK**.
4. When the project opens, add the required references to the project: 

    - Click **Project**, and then click **FtpLoggingDemo Properties**.
    - Click the **References** tab.
    - Add a reference path for the FTP extensibility library: 

        - On the **References** tab, and then click the **Reference Paths** button.
        - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive: 

            - For Windows Server 2008 and Windows Vista: 

                - C:\Windows\assembly\GAC\_MSIL\Microsoft.Web.FtpServer\7.5.0.0\_\_31bf3856ad364e35
            - For Windows 7: 

                - C:\Program Files\Reference Assemblies\Microsoft\IIS
        - Click **Add Folder**.
        - Click **OK**.
    - Add a reference to the FTP extensibility library for the project: 

        - On the **References** tab, and then click the **Add** button.
        - Select **Microsoft.Web.FtpServer** in the list of components.
        - Click **OK**.
    - Add a reference to System.Web for the project: 

        - On the **References** tab, and then click the **Add** button.
        - Select **System.Web** in the list of components.
        - Click **OK**.
5. Add a strong name key to the project: 

    - Click **Project**, and then click **FtpLoggingDemo Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **FtpLoggingDemoKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
    - Click **OK**.
6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer: 

    - Click **Project**, and then click **FtpLoggingDemo Properties**.
    - Click the **Compile** tab.
    - Click the **Build Events** button.
    - Enter the following in the **Post-build event command line** dialog box: 

        [!code-console[Main](how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-logging-provider/samples/sample1.cmd)]
7. Save the project.

## Step 2: Create the Extensibility Class

In this step, you will implement the logging extensibility interface for the demo provider.

1. Add the code for the authentication class: 

    - In **Solution Explorer**, double-click the **Class1.cs** file.
    - Remove the existing code.
    - Paste the following code into the editor: 

        [!code-vb[Main](how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-logging-provider/samples/sample2.vb)]
2. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the following topic on Microsoft the MSDN Web site:

> [Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/en-us/library/ex0ss12c(VS.80).aspx)


## Step 3: Add the Logging Provider to FTP

In this step, you will add the demo provider to your FTP service and the default Web site.

1. Determine the assembly information for the extensibility provider: 

    - In Windows Explorer, open your "C:\Windows\assembly" path, where C: is your operating system drive.
    - Locate the **FtpLoggingDemo** assembly.
    - Right-click the assembly, and then click **Properties**.
    - Copy the **Culture** value; for example: **Neutral**.
    - Copy the **Version** number; for example: **1.0.0.0**.
    - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Add the extensibility provider to the global list of FTP providers: 

    - Open the **Internet Information Services (IIS) Manager**.
    - Click your computer name in the **Connections** pane.
    - Double-click **FTP Authentication** in the main window.
    - Click **Custom Providers...** in the **Actions** pane.
    - Click **Register**.
    - Enter **FtpLoggingDemo** for the provider **Name**.
    - Click **Managed Provider (.NET)**.
    - Enter the assembly information for the extensibility provider using the information that you copied earlier. For example:

        [!code-console[Main](how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-logging-provider/samples/sample3.cmd)]
    - Click **OK**.
    - Clear the **FtpLoggingDemo** check box in the providers list.
    - Click **OK**.
3. Add the custom provider to a site: 

    - At the moment there is no UI that enables you to add custom features to a site, so you will have to use the following command line: 

        [!code-console[Main](how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-logging-provider/samples/sample4.cmd)]

## Summary

In this walkthrough you learned how to:

- Create a Visual Basic project in Visual Studio 2008 for a custom FTP logging provider.
- Implement the extensibility interface for custom FTP logging.
- Add a custom logging provider to your FTP service.

When users connect to your FTP site, the FTP service will create a log file in the path that you specified in the demo provider.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1045.aspx)