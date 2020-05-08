---
title: "Create an FTP Authentication Provider using an XML Database"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features tha..."
ms.date: 07/23/2009
ms.assetid: ab257257-4b17-4964-95bc-4db440db2c99
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database
msc.type: authoredcontent
---
# Create an FTP Authentication Provider using an XML Database

by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options. The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication, home directory, and logging providers.

This walkthrough will lead you through the steps to use managed code to an FTP authentication provider that uses the sample XML file from the following walkthrough for users and roles:

- [How to use the Sample Read-Only XML Membership and Role Providers with IIS](../../application-frameworks/building-and-running-aspnet-applications/how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis.md)

## Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the <https://www.iis.net/> web site using one of the following links:

   - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
   - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)

3. You must have FTP publishing enabled for a site.
4. You must use Visual Studio 2008.

    > [!NOTE]
    > If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.

### Important

To help improve the performance for authentication requests, the FTP service caches the credentials for successful logins for 15 minutes by default. This means that if you change the password in your XML file, this change may not be reflected for the cache duration. To alleviate this, you can disable credential caching for the FTP service. To do so, use the following steps:

1. Open a command prompt.
2. Type the following commands:

    [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database/samples/sample1.cmd)]
3. Close the command prompt.

<a id="01"></a>

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box:

   - Choose **Visual C#** as the project type.
   - Choose **Class Library** as the template.
   - Type **FtpXmlAuthentication** as the name of the project.
   - Click **OK**.

4. When the project opens, add a reference path to the FTP extensibility library:

   - Click **Project**, and then click **FtpXmlAuthentication Properties**.
   - Click the **Reference Paths** tab.
   - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive.

     -For Windows Server 2008 and Windows Vista: `C:\Windows\assembly\GAC\_MSIL\Microsoft.Web.FtpServer\7.5.0.0\_\_31bf3856ad364e35`
     -For Windows 7: `C:\Program Files\Reference Assemblies\Microsoft\IIS`
   - Click **Add Folder**.

5. Add a strong name key to the project:

   - Click **Project**, and then click **FtpXmlAuthentication Properties**.
   - Click the **Signing** tab.
   - Check the **Sign the assembly** check box.
   - Choose **&lt;New...&gt;** from the strong key name drop-down box.
   - Enter **FtpXmlAuthenticationKey** for the key file name.
   - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
   - Click **OK**.

6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer:

   - Click **Project**, and then click **FtpXmlAuthentication Properties**.
   - Click the **Build Events** tab.
   - Enter the following in the **Post-build event command line** dialog box:

      [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database/samples/sample2.cmd)]

7. Save the project.

<a id="02"></a>

## Step 2: Create the Extensibility Class

In this step, you will implement the logging extensibility interface for the demo provider.

1. Add a reference to the FTP extensibility library for the project:

   - Click **Project**, and then click **Add Reference**.
   - On the **.NET** tab, click **Microsoft.Web.FtpServer**.
   - Click **OK**.

2. Add a reference to System.Web for the project:

   - Click **Project**, and then click **Add Reference**.
   - On the **.NET** tab, click **System.Web**.
   - Click **OK**.

3. Add a reference to System.Configuration for the project:

   - Click **Project**, and then click **Add Reference**.
   - On the **.NET** tab, click **System.Configuration**.
   - Click **OK**.

4. Add the code for the authentication class:

   - In **Solution Explorer**, double-click the **Class1.cs** file.
   - Remove the existing code.
   - Paste the following code into the editor:

      [!code-csharp[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database/samples/sample3.cs)]

5. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see [Gacutil.exe (Global Assembly Cache Tool)](https://docs.microsoft.com/dotnet/framework/tools/gacutil-exe-gac-tool).

<a id="03"></a>

## Step 3: Add the Demo Provider to FTP

In this step, you will add the demo provider to your FTP service and the default Web site.

### Adding the XML File

Create an XML file for the membership users and roles:

- Paste the following code into a text editor:

   [!code-xml[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database/samples/sample4.xml)]

- Save the code as "Users.xml" to your computer. For example, you could use the path `C:\Inetpub\XmlSample\Users.xml`.

> [!NOTE]
> For security reasons, this file should not be stored in a folder that is located in your Web site's content area.

### Adding the Provider

1. Determine the assembly information for the extensibility provider:

   - In Windows Explorer, open your `C:\Windows\assembly` path, where C: is your operating system drive.
   - Locate the **FtpXmlAuthentication** assembly.
   - Right-click the assembly, and then click **Properties**.
   - Copy the **Culture** value; for example: **Neutral**.
   - Copy the **Version** number; for example: **1.0.0.0**.
   - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
   - Click **Cancel**.

2. Using the information from the previous steps, add the extensibility provider to the global list of FTP providers and configure the options for the provider:

   - At the moment there is no user interface that enables you to add properties for a custom authentication module, so you will have to use the following command line:

      [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database/samples/sample5.cmd)]

   > [!NOTE]
   > The file path that you specify in the *xmlFileName* attribute must match the path where you saved the "Users.xml" file on your computer in the earlier in this walkthrough.

3. Add the custom authentication provider for an FTP site:

   - Open an FTP site in the Internet Information Services (IIS) Manager.
   - Double-click **FTP Authentication** in the main window.
   - Click **Custom Providers...** in the **Actions** pane.
   - Check **FtpXmlAuthentication** in the providers list.
   - Click **OK**.

4. Add an authorization rule for the authentication provider:

   - Double-click **FTP Authorization Rules** in the main window.
   - Click **Add Allow Rule...** in the **Actions** pane.
   - You can add either of the following authorization rules:

     -For a specific user:

       - Select **Specified users** for the access option.
       - Enter the user name. For example, using the XML sample in this walkthrough you could enter "Alice" or "Bob".

     -For a role or group:

       - Select **Specified roles or user groups** for the access option.
       - Enter the role or group name. For example, using the XML sample in this walkthrough you could enter "Members" or "Administrators".

     -Select **Read** and/or **Write** for the **Permissions** option.
   - Click **OK**.

<a id="04"></a>

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2008 for a custom FTP authentication provider.
- Implement the extensibility interface for custom FTP authentication.
- Add a custom authentication provider to your FTP service.

When users connect to your FTP site, the FTP service will attempt to authenticate users with your custom authentication provider. If this fails, the FTP service will use other built-in or authentication providers to authenticate users.
