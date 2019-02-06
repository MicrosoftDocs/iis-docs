---
title: "How to Use Managed Code (C#) to Create a Simple FTP Authentication Provider"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features tha..."
ms.date: 03/18/2009
ms.assetid: ed1d58d8-cd6e-43f2-b57c-4fac38b38e1b
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-a-simple-ftp-authentication-provider
msc.type: authoredcontent
---
How to Use Managed Code (C#) to Create a Simple FTP Authentication Provider
====================
by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

This walkthrough will lead you through the steps to use managed code to create a simple FTP authentication provider.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the [https://www.iis.net/](https://www.iis.net/) Web site by using one of the following links: 

    - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
    - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
3. You must create a root folder for FTP publishing.
4. You must use Visual Studio 2008.
    > [!NOTE]
    > If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box: 

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **FtpAuthenticationDemo** as the name of the project.
    - Click **OK**.
4. When the project opens, add a reference path to the FTP extensibility library: 

    - Click **Project**, and then click **FtpAuthenticationDemo Properties**.
    - Click the **Reference Paths** tab.
    - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive:

        - For Windows Server 2008 and Windows Vista: `C:\Windows\assembly\GAC\_MSIL\Microsoft.Web.FtpServer\7.5.0.0\_\_31bf3856ad364e35`
        - For Windows 7: `C:\Program Files\Reference Assemblies\Microsoft\IIS`
    - Click **Add Folder**.
5. Add a strong name key to the project: 

    - Click **Project**, and then click **FtpAuthenticationDemo Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **FtpAuthenticationDemoKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
    - Click **OK**.
6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer: 

    - Click **Project**, and then click **FtpAuthenticationDemo Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** dialog box: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-authentication-provider/samples/sample1.cmd)]
7. Save the project.

## Step 2: Create the Extensibility Class

In this step, you will implement the extensibility interfaces for the demo provider.

1. Add a reference to FTP extensibility library for the project: 

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

        [!code-csharp[Main](how-to-use-managed-code-c-to-create-a-simple-ftp-authentication-provider/samples/sample2.cs)]
4. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the following topic on Microsoft the MSDN Web site:
> - [Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/en-us/library/ex0ss12c(VS.80).aspx)


## Step 3: Add the Authentication Provider to FTP

In this step, you will add the demo provider to your FTP service and the default Web site.

1. Determine the assembly information for the extensibility provider: 

    - In Windows Explorer, open your `C:\Windows\assembly` path, where C: is your operating system drive.
    - Locate the **FtpAuthenticationDemo** assembly.
    - Right-click the assembly, and then click **Properties**.
    - Copy the **Culture** value; for example: **Neutral**.
    - Copy the **Version** number; for example: **1.0.0.0**.
    - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Add the extensibility provider to the global list of FTP authentication providers: 

    - Open the **Internet Information Services (IIS) Manager**.
    - Click your computer name in the **Connections** pane.
    - Double-click **FTP Authentication** in the main window.
    - Click **Custom Providers...** in the **Actions** pane.
    - Click **Register**.
    - Enter **FtpAuthenticationDemo** for the provider **Name**.
    - Click **Managed Provider (.NET)**.
    - Enter the assembly information for the extensibility provider using the information that you copied earlier. For example:  
        **FtpAuthentication.FtpAuthDemo,FtpAuthenticationDemo,version=1.0.0.0,Culture=neutral,PublicKeyToken=426f62526f636b73**
    - Click **OK**.
    - Clear the **FtpAuthenticationDemo** check box in the providers list.
    - Click **OK**.
3. Add the custom authentication provider for an FTP site: 

    - Open an FTP site in the **Internet Information Services (IIS) Manager**.
    - Double-click **FTP Authentication** in the main window.
    - Click **Custom Providers...** in the **Actions** pane.
    - Check **FtpAuthenticationDemo** in the providers list.
    - Click **OK**.
4. Add an authorization rule for the authentication provider: 

    - Double-click **FTP Authorization Rules** in the main window.
    - Click **Add Allow Rule...** in the **Actions** pane.
    - You can add either of the following authorization rules: 

        - For a specific user: 

            - Select **Specified users** for the access option.
            - Type "MyUser" for the user name.
        - For a role or group: 

            - Select **Specified roles or user groups** for the access option.
            - Type "MyRole" for the role name.
    - Select **Read** and **Write** for the **Permissions** option.
    - Click **OK**.

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2008 for a custom FTP authentication provider.
- Implement the extensibility interface for custom FTP authentication.
- Add a custom authentication provider to your FTP service.

When users connect to your FTP site, the FTP service will attempt to authenticate users with your custom authentication provider. If this fails, the FTP service will use other built-in or authentication providers to authenticate users.