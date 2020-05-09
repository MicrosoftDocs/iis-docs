---
title: "Create an FTP Authentication and Authorization Provider using an XML Database"
author: rmcmurray
description: "[This documentation is preliminary and is subject to change.] Compatibility Version Notes IIS 8.0 The FTP 8.0 service is required for custom authorization. I..."
ms.date: 04/10/2012
ms.assetid: f9e04ce5-c2e2-406f-a61c-fc4b5a90fedf
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-and-authorization-provider-using-an-xml-database
msc.type: authoredcontent
---
# Create an FTP Authentication and Authorization Provider using an XML Database

by [Robert McMurray](https://github.com/rmcmurray)

[This documentation is preliminary and is subject to change.]

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 8.0 | The FTP 8.0 service is required for custom authorization. |
| IIS 7.5 | Custom authorization is not supported in FTP 7.5. |
| IIS 7.0 | Custom authorization is not supported in FTP 7.0. |

Note: The FTP 8.0 service ships as a feature for IIS 8.0 in Windows 8 and Windows 8 Server.

## Introduction

Microsoft has created a new FTP 8.0 service for Windows Server® 2012 that builds upon the rich set of features that were introduced in FTP 7.0 and FTP 7.5. In addition, this new FTP service extends the list of Application Programming Interfaces (APIs) for FTP with new extensibility features like support for custom authorization and simple event processing.

This walkthrough will lead you through the steps to use managed code to an FTP authentication and authorization provider that uses the sample XML file from the following walkthrough for users and roles, with the necessary changes that are required to support custom authorization rules:

- [How to use the Sample Read-Only XML Membership and Role Providers with IIS](../../application-frameworks/building-and-running-aspnet-applications/how-to-use-the-sample-read-only-xml-membership-and-role-providers-with-iis.md)

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 8 must be installed on your Windows Server 8 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The FTP 8 service must be installed.
3. You must have FTP publishing enabled for a site.
4. You should use Visual Studio 2008 or later.

   > [!NOTE]
   > You can use a different version of Visual Studio, but some of the steps in this walkthrough may be different.

#### Important

To help improve the performance for authentication requests, the FTP service caches the credentials for successful logins for 15 minutes by default. This means that if you change the password in your XML file, this change may not be reflected for the cache duration. To alleviate this, you can disable credential caching for the FTP service. To do so, use the following steps:

1. Open a command prompt.
2. Type the following commands:

   [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-and-authorization-provider-using-an-xml-database/samples/sample1.cmd)]

3. Close the command prompt.

<a id="01"></a>

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio for the demo provider.

1. Open Microsoft Visual Studio 2008 or later.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box:

   - Choose **Visual C#** as the project type.
   - Choose **Class Library** as the template.
   - Type **FtpXmlAuthorization** as the name of the project.
   - Click **OK**.

4. When the project opens, add a reference path to the FTP extensibility library:

   - Click **Project**, and then click **FtpXmlAuthorization Properties**.
   - Click the **Reference Paths** tab.
   - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive.

     - `C:\Program Files\Reference Assemblies\Microsoft\IIS`

   - Click **Add Folder**.

5. Add a strong name key to the project:

   - Click **Project**, and then click **FtpXmlAuthorization Properties**.
   - Click the **Signing** tab.
   - Check the **Sign the assembly** check box.
   - Choose **&lt;New...&gt;** from the strong key name drop-down box.
   - Enter **FtpXmlAuthorizationKey** for the key file name.
   - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
   - Click **OK**.

6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer:

   - Click **Project**, and then click **FtpXmlAuthorization Properties**.
   - Click the **Build Events** tab.
   - Enter the following in the **Post-build event command line** dialog box:

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-and-authorization-provider-using-an-xml-database/samples/sample2.cmd)]

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

4. Add the code for the authentication and authorization class:

   - In **Solution Explorer**, double-click the **Class1.cs** file.
   - Remove the existing code.
   - Paste the following code into the editor:

      [!code-csharp[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-and-authorization-provider-using-an-xml-database/samples/sample3.cs)]

5. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see [Gacutil.exe (Global Assembly Cache Tool)](https://docs.microsoft.com/dotnet/framework/tools/gacutil-exe-gac-tool).

<a id="03"></a>

## Step 3: Add the Demo Provider to FTP

In this step, you will add the demo provider to your FTP service and the default Web site.

### Adding the XML File

Create an XML file for the membership users and roles:

- Paste the following code into a text editor:

   [!code-xml[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-and-authorization-provider-using-an-xml-database/samples/sample4.xml)]

- Save the code as "Users.xml" to your computer. For example, you could use the path `C:\Inetpub\XmlSample\Users.xml`.

> [!NOTE]
> For security reasons, this file should not be stored in a folder that is located in your Web site's content area.

### Adding the Provider

1. Determine the assembly information for the extensibility provider:

   - In Windows Explorer, open your `C:\Windows\assembly` path, where C: is your operating system drive.
   - Locate the **FtpXmlAuthorization** assembly.
   - Right-click the assembly, and then click **Properties**.
   - Copy the **Culture** value; for example: **Neutral**.
   - Copy the **Version** number; for example: **1.0.0.0**.
   - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
   - Click **Cancel**.

2. Using the information from the previous steps, add the extensibility provider to the global list of FTP providers and configure the options for the provider:

   - At the moment there is no user interface that enables you to add properties for custom authentication or authorization modules, so you will have to use the following command line:

      [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-and-authorization-provider-using-an-xml-database/samples/sample5.cmd)]

   > [!NOTE]
   > The file path that you specify in the *xmlFileName* attribute must match the path where you saved the "Users.xml" file on your computer in the earlier in this walkthrough.

3. Specify the custom authentication provider for an FTP site:

   - Open an FTP site in the Internet Information Services (IIS) Manager.
   - Double-click **FTP Authentication** in the main window.
   - Click **Custom Providers...** in the **Actions** pane.
   - Check **FtpXmlAuthorization** in the providers list.
   - Click **OK**.

4. Specify the custom authorization provider for an FTP site:

   - Open an FTP site in the Internet Information Services (IIS) Manager.
   - Double-click **FTP Authorization Rules** in the main window.
   - Click **Edit Feature Settings...** in the **Actions** pane.
   - Click to select **Choose a custom authorization provider**.
   - Select **FtpXmlAuthorization** in the drop-down menu.
   - Click **OK**.

<a id="04"></a>

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio for a custom FTP authentication and authorization provider.
- Implement the extensibility interfaces for custom FTP authentication and authorization.
- Add a custom authentication and authorization provider to your FTP service.

When users connect to your FTP site, the FTP service will attempt to authenticate users with your custom authentication provider. If this fails, the FTP service will use other built-in or authentication providers to authenticate users. After users have been authenticated, the FTP service will call the custom authorization provider to authorize users. If this succeeds, the users will be granted access to your server. If this fails, users will not be able to access your server.
