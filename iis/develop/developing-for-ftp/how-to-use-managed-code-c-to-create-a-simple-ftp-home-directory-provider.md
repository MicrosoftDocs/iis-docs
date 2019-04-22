---
title: "How to Use Managed Code (C#) to Create a Simple FTP Home Directory Provider"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features tha..."
ms.date: 03/18/2009
ms.assetid: b25f2dfa-a0f6-4ec7-9f6c-acd63ee57dac
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider
msc.type: authoredcontent
---
# How to Use Managed Code (C\#) to Create a Simple FTP Home Directory Provider

by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication and authorization providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

This walkthrough will lead you through the steps to use managed code to create a simple FTP home directory provider.

## Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the <https://www.iis.net/> web site using one of the following links:

    - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
    - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
3. You must create a root folder for FTP publishing.
4. You must use Visual Studio 2008.

    > [!NOTE]
    > If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.

5. A home directory for each user must be created; the code sample uses `C:\Ftpusers\%*UserName*%`, but you could change that as necessary.

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box:

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **FtpHomeDirectoryDemo** as the name of the project.
    - Click **OK**.
4. When the project opens, add a reference path to the FTP extensibility library:

    - Click **Project**, and then click **FtpHomeDirectoryDemo Properties**.
    - Click the **Reference Paths** tab.
    - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive:

        - For Windows Server 2008 and Windows Vista: `C:\Windows\assembly\GAC\_MSIL\Microsoft.Web.FtpServer\7.5.0.0\_\_31bf3856ad364e35`
        - For Windows 7: `C:\Program Files\Reference Assemblies\Microsoft\IIS`
    - Click **Add Folder**.
5. Add a strong name key to the project:

    - Click **Project**, and then click **FtpHomeDirectoryDemo Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New&gt;** from the strong key name drop-down box.
    - Enter **FtpHomeDirectoryDemoKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
    - Click **OK**.
6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer:

    - Click **Project**, and then click **FtpHomeDirectoryDemo Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** dialog box:

        [!code-console[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample1.cmd)]
7. Save the project.

## Step 2: Create the Extensibility Class

In this step, you will implement the extensibility interface for the demo provider.

1. Add a reference to the FTP extensibility library for the project:

    - Click **Project**, and then click **Add Reference**
    - On the **.NET** tab, click **Microsoft.Web.FtpServer**.
    - Click **OK**.
2. Add a reference to System.Web for the project:

    - Click **Project**, and then click **Add Reference**
    - On the **.NET** tab, click **System.Web**.
    - Click **OK**.
3. Add the code for the authentication class:

    - In **Solution Explorer**, double-click the **Class1.cs** file.
    - Remove the existing code.
    - Paste the following code into the editor:

        [!code-csharp[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample2.cs)]
4. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the [Gacutil.exe (Global Assembly Cache Tool)](https://docs.microsoft.com/dotnet/framework/tools/gacutil-exe-gac-tool) article.

## Step 3: Add the Home Directory Provider to FTP

In this step, you will add the demo provider to your FTP service and the default Web site.

1. Determine the assembly information for the extensibility provider:

    - In Windows Explorer, open your `C:\Windows\assembly` path, where C: is your operating system drive.
    - Locate the **FtpHomeDirectoryDemo** assembly.
    - Right-click the assembly, and then click **Properties**.
    - Copy the **Culture** value; for example: **Neutral**.
    - Copy the **Version** number; for example: **1.0.0.0**.
    - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Add the extensibility provider to the global list of FTP providers:

    - Open the **Internet Information Services (IIS) Manager**.
    - Click your computer name in the **Connections** pane.
    - Double-click **FTP Authentication** in the main window.
    - Click **Custom Providers** in the **Actions** pane.
    - Click **Register**.
    - Enter **FtpHomeDirectoryDemo** for the provider **Name**.
    - Click **Managed Provider (.NET)**.
    - Enter the assembly information for the extensibility provider using the information that you copied earlier. For example:

        [!code-console[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample3.cmd)]
    - Click **OK**.
    - Clear the **FtpHomeDirectoryDemo** check box in the providers list.
    - Click **OK**.
3. Add the custom provider to a site:

    - At the moment there is no UI that enables you to add custom features to a site, so you will have to use the following command line:

        [!code-console[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample4.cmd)]
4. Configure user isolation to use a custom provider:

    - At the moment there is no UI that enables you to specify custom features for user isolation, so you will have to use the following command line:

        [!code-console[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider/samples/sample5.cmd)]

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2008 for a custom FTP home directory provider.
- Implement the extensibility interface for custom FTP home directory lookups.
- Add a custom home directory provider to your FTP service.

When users connect to your FTP site, the FTP service will set each user's home directory to the path that you specified in the demo provider.