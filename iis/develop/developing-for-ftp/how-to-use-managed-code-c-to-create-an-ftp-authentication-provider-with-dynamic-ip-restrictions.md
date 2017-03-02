---
title: "How to Use Managed Code (C#) to Create an FTP Authentication Provider with Dynamic IP Restrictions | Microsoft Docs"
author: rmcmurray
description: "Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008 . This new FTP service incorporates many new features tha..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 08/06/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions
msc.type: authoredcontent
---
How to Use Managed Code (C#) to Create an FTP Authentication Provider with Dynamic IP Restrictions
====================
by [Robert McMurray](https://github.com/rmcmurray)

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content more easily than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that lets you extend the built-in functionality that is included with the FTP service. More specifically, FTP 7.5 supports the creation of your own authentication providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

This walkthrough will lead you through the steps to use managed code to an FTP authentication provider that provides support for dynamic IP restrictions that uses a SQL Server database to store account information. This provider implements this logic by logging the number of failures from remote IP addresses and then using this information to block IP addresses that fail to log in to the server within a given time frame.

> [!IMPORTANT]
> The latest version of the FTP 7.5 service ***must be*** installed in order to use the provider in this walkthrough. A version FTP 7.5 was released on August 3, 2009 that addressed an issue where the local and remote IP addresses in the **IFtpLogProvider.Log()** method were incorrect. Because of this, using an earlier version of the FTP service will prevent this provider from working.

## Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 or above must be installed on your Windows Server 2008 server, and the Internet Information Services (IIS) Manager must also be installed.
2. The new FTP 7.5 service must be installed. You can download and install the FTP 7.5 service from the [https://www.iis.net/](https://www.iis.net/) Web site using one of the following links: 

    - [FTP 7.5 for IIS (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
    - [FTP 7.5 for IIS (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
    - > [!IMPORTANT]
 > As mentioned earlier in this walkthrough, the latest version of the FTP 7.5 service ***must be*** installed in order to use the provider in this walkthrough. A version FTP 7.5 was released on August 3, 2009 that addressed an issue where the local and remote IP addresses in the **IFtpLogProvider.Log()** method were incorrect. Because of this, using an earlier version of the FTP service will prevent this provider from working.
3. You must have FTP publishing enabled for a site.
4. You must use Visual Studio 2008. (> [!NOTE]
> If you use an earlier version of Visual Studio, some of the steps in this walkthrough may not be correct.)
5. You must use a SQL Server database for the list of user accounts and the associated restriction lists; this example cannot be used with FTP Basic authentication. The "**Additional Information**" section of this walkthrough contains a script for SQL Server that creates the necessary tables for this sample.
6. You will need Gacutil.exe on your IIS computer; this is required to add the assemblies to your Global Assembly Cache (GAC).

#### Important

To help improve the performance for authentication requests, the FTP service caches the credentials for successful logins for 15 minutes by default. This authentication provider will deny requests from an attacker immediately, but if the attacker were able to successfully guess the password for a user that has recently logged in, they may gain access through the cached credentials. This may have the unintentional consequence of allowing a malicious user to attack your server after this provider has blocked their IP address. To alleviate this potential avenue of attack, you should disable credential caching for the FTP service. To do so, use the following steps:

1. Open a command prompt.
2. Type the following commands: 

    [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample1.cmd)]
3. Close the command prompt.

After you have made these changes, the authentication provider in this example will be able to deny all requests from a potential attacker immediately.

<a id="00"></a>

## Provider Description

This walkthrough contains several points that necessitate some discussion. Internet-based attacks often exploit an FTP server in the attempt to gain the username and password for an account on a system. Detecting this behavior is possible through analysis of the FTP activity logs and examining the IP addresses that are being used to attack your system and blocking those addresses from future access. Unfortunately, this is something of a manual process, and even if that process is automated it will not be real-time.

The FTP service contains a feature for restricting connections based on IP addresses, but the list of IP addresses is stored in the IIS configuration files and requires administrative access to update. The extensibility process for the FTP service runs as a lower-privileged account that does not have permissions to update the requisite settings the IIS configuration files. You could write an FTP logging provider that detects username flooding and writes that information to a data store and a separate service that runs as a higher-privileged account that can update the IIS configuration files, but that requires a greater knowledge of system architecture and requires a number of difficult implementation details. Because of this, an alternative data store is necessary.

A database makes an ideal choice because of the ease of data access and the general availability of tools that are available for manipulating data in a database. The next challenge is to use the existing FTP extensibility interfaces to implement the necessary logic to detect login flooding that an attacker would use. By way of review, the available extensibility interfaces are:

- [IFtpAuthenticationProvider Interface](https://msdn.microsoft.com/en-us/library/dd692892.aspx)
- [IFtpHomeDirectoryProvider Interface](https://msdn.microsoft.com/en-us/library/dd692893.aspx)
- [IFtpLogProvider Interface](https://msdn.microsoft.com/en-us/library/dd692885.aspx)
- [IFtpRoleProvider Interface](https://msdn.microsoft.com/en-us/library/dd692895.aspx)

You could easily write a provider that takes advantage of all of these interfaces in order to tighten security to a greater degree, but the provider in this walkthrough will use only the following interfaces:

- **IFtpAuthenticationProvider** - The provider will use this interface to allow or deny access to the FTP server.
- **IFtpLogProvider** - The provider will use this interface as a generic event listener.

The FTP service does not have actual event notifications that a provider can register for, but you can write providers that use the **IFtpLogProvider.Log()** method to provide post-event processing. For example, any failed login attempts will log the "PASS" command with a status code other than "230", which is the status code for a successful FTP login. By capturing additional information about the failed login attempt, such as the IP address of the client that failed to log in, it becomes possible to use this information to provide additional functionality, such as blocking IP addresses from accessing your FTP server in the future.

#### Provider Architecture and Logic

The following descriptions summarize the behavior for this authentication provider:

- When you register the provider on your system, you specify the database connection to use and the values for the number of failed logon attempts and flood timeout in your IIS configuration files.
- When the FTP service loads your provider, it provides the values from your IIS configuration files to your provider's **Initialize()** method. After these values are stored in global settings, the **Initialize()** method performs some initial garbage collection to clean up any information from previous FTP sessions that might be in the database.
- When an FTP client connects to the FTP server, the provider's **Log()** method is sent the "ControlChannelOpened" message by the FTP service. The **Log()** method checks the database to see if the client's IP address has been blocked; if so, it flags the session in the database.
- When the user enters their username and password, the FTP service calls the provider's **AuthenticateUser()** method, which checks to see if the session is flagged. If the session is flagged, the provider returns *false*, signifying that the user failed to log in. If the session is not flagged, the username and password are checked with the database to see if they are valid. If they are valid, the method returns *true*, indicating that the user is valid and can log in.
- If the user fails to enter a valid username and password, the **Log()** method is called by the FTP service, and the method runs periodic garbage collection to make sure that the number of failures is less than the flood timeout. Next, the method checks to see if the remaining number of failures is less than the maximum number of failures: 

    - If the maximum number of failures has not been reached, the method adds a failure notification for the client's IP address to the database.
    - If the maximum number of failures has been reached, the method adds the client's IP address to the list of blocked IP addresses in the database.
- When an FTP client disconnects from the server, the FTP service calls the provider's **Log()** method and sends the "ControlChannelClosed" message. The **Log()** method takes advantage of this notification to perform garbage collection for the session.

**Additional Notes**:

- This provider exposes functionality for user and IP address validation, but does not provide an implementation for role lookups. That being said, it would be relatively easy to add an additional table for user-to-role mappings and add the **IFtpRoleProvider.IsUserInRole()** method to the provider, but that is outside the scope of this walkthrough.
- This provider makes a small number of calls to the SQL database server during the authentication process. Through consolidation of a few of the SQL statements into single compound queries or stored procedures you could further reduce the number of round-trips to the database, but that is outside the scope of this walkthrough.

<a id="01"></a>

## Step 1: Set up the Project Environment

In this step, you will create a project in Visual Studio 2008 for the demo provider.

1. Open Microsoft Visual Studio 2008.
2. Click the **File** menu, then **New**, then **Project**.
3. In the **New Project** dialog box: 

    - Choose **Visual C#** as the project type.
    - Choose **Class Library** as the template.
    - Type **FtpAddressRestrictionAuthentication** as the name of the project.
    - Click **OK**.
4. When the project opens, add a reference path to the FTP extensibility library: 

    - Click **Project**, and then click **FtpAddressRestrictionAuthentication Properties**.
    - Click the **Reference Paths** tab.
    - Enter the path to the FTP extensibility assembly for your version of Windows, where C: is your operating system drive. 

        - For Windows Server 2008 and Windows Vista:

            [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample2.cmd)]
        - For Windows 7:

            [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample3.cmd)]
    - Click **Add Folder**.
5. Add a strong name key to the project: 

    - Click **Project**, and then click **FtpAddressRestrictionAuthentication Properties**.
    - Click the **Signing** tab.
    - Check the **Sign the assembly** check box.
    - Choose **&lt;New...&gt;** from the strong key name drop-down box.
    - Enter **FtpAddressRestrictionAuthenticationKey** for the key file name.
    - If desired, enter a password for the key file; otherwise, clear the **Protect my key file with a password** check box.
    - Click **OK**.
6. Optional: You can add a custom build event to add the DLL automatically to the Global Assembly Cache (GAC) on your development computer: 

    - Click **Project**, and then click **FtpAddressRestrictionAuthentication Properties**.
    - Click the **Build Events** tab.
    - Enter the following in the **Post-build event command line** dialog box: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample4.cmd)]
7. Save the project.

<a id="02"></a>

## Step 2: Create the Extensibility Class

In this step, you will implement the logging extensibility interface for the demo provider.

1. Add a reference to the FTP extensibility library for the project: 

    - Click **Project**, and then click **Add Reference...**
    - On the **.NET** tab, click **Microsoft.Web.FtpServer**.
    - Click **OK**.
2. Add a reference to System.Web for the project: 

    - Click **Project**, and then click **Add Reference...**
    - On the **.NET** tab, click **System.Web**.
    - Click **OK**.
3. Add a reference to System.Configuration for the project: 

    - Click **Project**, and then click **Add Reference...**
    - On the **.NET** tab, click **System.Configuration**.
    - Click **OK**.
4. Add a reference to System.Data for the project: 

    - Click **Project**, and then click **Add Reference...**
    - On the **.NET** tab, click **System.Data**.
    - Click **OK**.
5. Add the code for the authentication class: 

    - In **Solution Explorer**, double-click the **Class1.cs** file.
    - Remove the existing code.
    - Paste the following code into the editor: 

        [!code-csharp[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample5.cs)]
6. Save and compile the project.

> [!NOTE]
> If you did not use the optional steps to register the assemblies in the GAC, you will need to manually copy the assemblies to your IIS computer and add the assemblies to the GAC using the Gacutil.exe tool. For more information, see the following topic on the Microsoft MSDN Web site:

> [Global Assembly Cache Tool (Gacutil.exe)](https://msdn.microsoft.com/en-us/library/ex0ss12c(VS.80).aspx)


<a id="03"></a>

## Step 3: Add the Demo Provider to FTP

In this step, you will add the demo provider to your FTP service and the Default Web Site.

1. Determine the assembly information for the extensibility provider: 

    - In Windows Explorer, open your "C:\Windows\assembly" path, where C: is your operating system drive.
    - Locate the **FtpAddressRestrictionAuthentication** assembly.
    - Right-click the assembly, and then click **Properties**.
    - Copy the **Culture** value; for example: **Neutral**.
    - Copy the **Version** number; for example: **1.0.0.0**.
    - Copy the **Public Key Token** value; for example: **426f62526f636b73**.
    - Click **Cancel**.
2. Using the information from the previous steps, add the extensibility provider to the global list of FTP providers and configure the options for the provider: 

    - At the moment there is no user interface that enables you to add properties for a custom authentication module, so you will have to use the following command line: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample6.cmd)]
    - > [!NOTE]
 > The connection string that you specify in the *connectionString* attribute must be a valid login for your database.
3. Add the custom provider to a site: 

    - At the moment there is no UI that enables you to add custom features to a site, so you will have to use the following command line: 

        [!code-console[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample7.cmd)]
    - > [!NOTE]
 > This syntax disables FTP Basic authentication, and it is important that you disable Basic authentication when using this authentication provider. Otherwise, when an attacker's IP address has been blocked by this authentication provider, an attacker would still be able to attack accounts that use Basic authentication.
4. Add an authorization rule for the authentication provider: 

    - Double-click **FTP Authorization Rules** in the main window.
    - Click **Add Allow Rule...** in the **Actions** pane.
    - Select **Specified users** for the access option.
    - Enter a user name. (> [!NOTE]
> The user name will need to be entered into the database outside of this list of steps.)
    - Select **Read** and/or **Write** for the **Permissions** option.
    - Click **OK**.

<a id="04"></a>

## Step 4: Using the provider with FTP 7.5

When FTP clients connect to your FTP site, the FTP service will attempt to authenticate users with your custom authentication provider using accounts that are stored in the database. If an FTP client fails to authenticate, the provider will track the IP address and date/time of the failure in the database. When an FTP client fails to log in from a specific IP address for the number of failures that is specified in the *logonAttempts* setting, and within the time frame that is specified in the *floodSeconds* setting, the provider will block the IP address from logging in to the FTP service.

> [!NOTE]
> This sample provider implements the authentication logic for the FTP service, but does not provide an admin module to manage the data in the database. For example, you cannot manage the list of FTP user accounts, banned IP addresses, or authentication failures using this provider. To manage the data using IIS Manager, you can use the IIS Database Manager. For more information, see the following topic:

> [https://www.iis.net/extensions/DatabaseManager](https://www.iis.net/downloads/microsoft/database-manager)


<a id="05"></a>

## Additional Information

You can use the following SQL Script for Microsoft SQL Server to create the necessary database and tables. To use this script, you need to update the name of the database and location of the database files. In SQL Server you would run the script in a new query window, and then create a database login that you will use with your connection string.

> [!NOTE]
> You might want to alter the SQL script to store the database in a location other than "c:\databases".

> [!code-sql[Main](how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions/samples/sample8.sql)]


<a id="06"></a>

## Summary

In this walkthrough you learned how to:

- Create a project in Visual Studio 2008 for a custom FTP provider.
- Implement the extensibility interfaces for a custom FTP provider.
- Add an FTP custom provider to your FTP service.