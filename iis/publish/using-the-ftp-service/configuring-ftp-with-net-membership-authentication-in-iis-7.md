---
title: "Configuring FTP with .NET Membership Authentication in IIS 7 | Microsoft Docs"
author: rmcmurray
description: "Version Notes IIS 7.5 The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. IIS 7.0 The FTP 7.0 and FTP 7.5 services we..."
ms.author: iiscontent
manager: soshir
ms.date: 03/09/2008
ms.topic: article
ms.assetid: aae75692-8895-45f2-b3d4-027e22295a5a
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/using-the-ftp-service/configuring-ftp-with-net-membership-authentication-in-iis-7
msc.type: authoredcontent
---
Configuring FTP with .NET Membership Authentication in IIS 7
====================
by [Robert McMurray](https://github.com/rmcmurray)

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 7.5 | The FTP 7.5 service ships as a feature for IIS 7.5 in Windows 7 and Windows Server 2008 R2. |
| IIS 7.0 | The FTP 7.0 and FTP 7.5 services were shipped out-of-band for IIS 7.0, which required downloading and installing the service from the following URL: [https://www.iis.net/download/FTP](https://www.iis.net/downloads/microsoft/ftp). |

<a id="00"></a>

## Introduction

Microsoft has created a new FTP service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable web authors to publish content better than before, and offers web administrators more security and deployment options.

This document walks you through configuring your Default Web Site for FTP membership-based authentication.

> [!NOTE]
> This document was written using an instance of SQL server that is installed on the local web server.

### Prerequisites

The following items are required to complete the procedures in this article:

1. IIS 7.0 must be installed on your Windows Server 2008, and the following must be configured: 

    - The Default Web Site that is created by the IIS 7.0 installation must still exist.
    - The Internet Information Services Manager must be installed.
2. The new FTP service must be installed. You can download and install the FTP service from the [https://www.iis.net/](https://www.iis.net/) web site using one of the following links: 

    - [FTP 7.5 for IIS 7.0 (x64)](https://go.microsoft.com/fwlink/?LinkId=143197)
    - [FTP 7.5 for IIS 7.0 (x86)](https://go.microsoft.com/fwlink/?LinkId=143196)
3. Set the content permissions to allow access for the extensibility COM process that handles authentication: 

    - Open a command prompt.
    - Type the following command:

        [!code-console[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample1.cmd)]
    - Close the command prompt.

<a id="001"></a>

## Adding FTP Publishing to the Default Web Site

In this first section, you add FTP publishing to the Default Web site, and add the required settings to allow the local administrator account to edit the content.

1. In IIS 7.0 Manager, in the **Connections** pane, expand the **Sites** node in the tree, then click the Default Web Site.
2. Click **Add FTP Publishing** in the **Actions** pane.  
     [![](configuring-ftp-with-net-membership-authentication-in-iis-7/_static/image3.jpg)](configuring-ftp-with-net-membership-authentication-in-iis-7/_static/image1.jpg)
3. When the **Add FTP Site Publishing** wizard appears: 

    - Choose an IP address for your FTP site from the **IP Address** drop-down, or choose to accept the default selection of "All Unassigned." For this walkthrough, enter the local loopback IP address for your computer by typing "127.0.0.1" in the **IP Address** box.
	
	    > [!NOTE]
	    > If you are using IPv6, you should also add the IPv6 localhost binding of "::1".
    - Normally, you would enter the TCP/IP port for the FTP site in the **Port** box. For this walk-through, choose to accept the default port of 21.
    - For this walkthrough, we will not use a host name, so make sure that the **Virtual Host** box is blank.
    - Make sure that the **SSL Certificate** drop-down is set to "Not Selected" and that the **Allow SSL** option is selected.
    - When you have completed these items, click **Next**.

     [![](configuring-ftp-with-net-membership-authentication-in-iis-7/_static/image8.jpg)](configuring-ftp-with-net-membership-authentication-in-iis-7/_static/image7.jpg)
4. On the next page of the wizard, you will not configure any authentication or authorization settings because these settings will be configured later. Click **Finish** to complete the wizard.  
     [![](configuring-ftp-with-net-membership-authentication-in-iis-7/_static/image11.jpg)](configuring-ftp-with-net-membership-authentication-in-iis-7/_static/image9.jpg)

#### Summary

To recap the items that you completed in this section -- we added FTP publishing to the "Default Web Site" by:

- Adding an FTP binding for the Web site for the local loopback IP address on port 21
- Choosing not to use Secure Sockets Layer (SSL) for the FTP site.

> [!NOTE]
> You have not yet enabled any authentication or authorization settings.

<a id="002"></a>

## Configuring ASP.NET for Membership Authentication

### Configure your Local SQL Server for ASP.NET Membership

This section describes the basic process for configuring ASP.NET for membership authentication. For detailed information, please see the "Configure ASP.NET for Membership" section in the [How To: Use Forms Authentication with SQL Server in ASP.NET 2.0](https://msdn.microsoft.com/en-US/library/ms998317.aspx) topic on the MSDN web site.

If you do not have access to an existing SQL Server, you must install SQL Server.

If you do not already have an ASP.NET database created, you need to build the ASP.NET database on the SQL server using the appropriate command from the following list for the version of the framework that you are using:

- **32-bit Framework**: 

    [!code-console[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample2.cmd)]
- **64-bit Framework**: 

    [!code-console[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample3.cmd)]

> [!NOTE]
> To use a remote SQL server instead of "localhost" as shown in the above example, see the "Deployment Considerations" section in the [How To: Use Forms Authentication with SQL Server in ASP.NET 2.0](https://msdn.microsoft.com/en-us/library/ms998317.aspx) topic on the MSDN web site.

Because the COM process for FTP extensibility runs as "NT AUTHORITY\Network Service", you need to add the "NT AUTHORITY\Network Service" account to the ASP.NET database on your SQL Server. To do so, use the following steps:

1. Open the SQL Server Enterprise Manager.
2. Create a SQL Server login for NT AUTHORITY\Network Service.
3. Grant the login access to the Aspnetdb database by creating a database user.
4. Add the database user to the aspnet\_Membership\_FullAccess database role.

### Configure ASP.NET for FTP Membership

The following steps describe the process for configuring ASP.NET to allow membership authentication for FTP access.

1. Using a text editor such as Windows Notepad, open your root web.config file, which should be located at the appropriate path for the version of the framework that you are using: 

    - 32-bit Framework: 

        [!code-console[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample4.cmd)]
    - 64-bit Framework: 

        [!code-console[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample5.cmd)]
2. Scroll to the bottom and paste the following code before the closing &lt;/configuration&gt; tag: 

    [!code-xml[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample6.xml)]
3. Save and close your root web.config file.

#### Summary

You have configured ASP.NET for membership authentication. To recap the items that you completed in this section, we configured your server by:

- Configuring your Local SQL Server for ASP.NET Membership
- Configuring ASP.NET for FTP Membership

<a id="003"></a>

## Configuring FTP Membership Authentication

This section describes how to configure a membership database using the Default Web Site that is used for creating users that the FTP-based membership authentication will use later. To do so, use the following steps:

#### Prerequisite Steps

1. Open the **Internet Information Services (IIS) Manager**.
2. Expand your computer at the top node of the **Connections** tree.
3. Expand the **Sites** node in the tree.

### Configuring .NET Membership Settings

#### Step 1: Add a Connection String

Highlight the **Default Web Site** in the tree and double-click **Connection Strings**, then follow these steps:

1. Click **Add...** in the **Actions** pane.
2. Configure the following options: 

    - Name: "FtpLocalSQLServer"
    - Server: "localhost"
    - Database: "aspnetdb"
3. Click **OK**.

#### Step 2: Add a Role Provider

Highlight the **Default Web Site** in the tree and double-click **Providers**, then follow these steps:

1. Choose **.NET Roles** from the drop-down.
2. Click **Add...** in the **Actions** pane.
3. Choose **SqlRoleProvider** from the drop-down.
4. Configure the following options: 

    - Name: "FtpSqlRoleProvider"
    - Connection string name: "FtpLocalSQLServer"
    - Application name: "/"
5. Click **OK**.

#### Step 3: Add a Membership Provider

Highlight the **Default Web Site** in the tree and double-click **Providers**, then follow these steps:

1. Choose **.NET Users** from the drop-down.
2. Click **Add...** in the **Actions** pane.
3. Choose **SqlMembershipProvider** from the drop-down.
4. Configure the following options: 

    - Name: "FtpSqlMembershipProvider"
    - Connection string name: "FtpLocalSQLServer"
    - Application name: "/"
5. Click **OK**.

#### Step 4: Add a Role for FTP Membership

Highlight the **Default Web Site** in the tree and double-click **.NET Roles**, then follow these steps:

1. You may see an error dialog about connecting. If so, click **OK** to close the error dialog, then configure the default provider using the following steps: 

    - Click **Set Default Provider...** in the **Actions** pane.
    - Choose **FtpSqlRoleProvider** from the drop-down.
    - Click **OK**.
2. Click **Add...** in the Actions pane.
3. Configure the following options: 

    - Name: "ftprole"
4. Click **OK**.

#### Step 5: Add a User Account for FTP Membership

Highlight the **Default Web Site** in the tree and double-click **.NET Users**, then follow these steps:

1. You may see an error dialog about connecting. If so, click **OK** to close the error dialog, then configure the default provider using the following steps: 

    - Click **Set Default Provider...** in the **Actions** pane.
    - Choose **FtpSqlMembershipProvider** from the drop-down.
    - Click **OK**.
2. Click **Add...** in the Actions pane.
3. Configure the following options: 

    - User Name: "ftpuser"
    - Email: "ftpuser@localhost.local"
    - Password: "P@ssw0rd"
4. Click **Next**.
5. Add the user to "ftprole", then click **Finish**.

### Enabling Membership Authentication for FTP

#### Configure FTP for Membership Authentication

Highlight the **Default Web Site** in the tree and double-click **FTP Authentication**, then follow these steps:

1. Click **Custom Providers...** in the **Actions** pane.
2. Check the box for **AspNetAuth**.
3. Click **OK**.

You can now authorize the FTP user using one of two methods:

#### Method 1: Configure an FTP Authorization Rule for a Membership Role

Highlight the **Default Web Site** in the tree and double-click **FTP Authorization Rules**, then follow these steps:

1. Click **Add Allow Rule...** in the **Actions** pane.
2. Select **Specified roles or user groups** for the access option.
3. Type "ftprole" for role name.
4. Select **Read** and **Write** for the **Permissions** option.
5. Click **OK**.

#### Method 2: Configure an FTP Authorization Rule for a Membership User

Highlight the **Default Web Site** in the tree and double-click **FTP Authorization Rules**, then follow these steps:

1. Click **Add Allow Rule...** in the **Actions** pane.
2. Select **Specified users** for the access option.
3. Type "ftpuser" for the user name.
4. Select **Read** and **Write** for the **Permissions** option.
5. Click **OK**.

#### Summary

To recap the items that you completed in this section, we configured your server by:

- Configuring .NET Membership Settings: 

    - Adding a Connection String
    - Adding a Role Provider
    - Adding a Membership Provider
    - Add a Role for FTP Membership
    - Adding a User Account for FTP Membership
- Enabling Membership Authentication for FTP: 

    - Configuring FTP Authentication for Membership
    - Configuring an FTP Authorization Rule for a Membership User
    - Configuring an FTP Authorization Rule for a Membership Role

### Troubleshooting

If you are using Membership Roles, you may need to install the hotfix that is described in the following Microsoft Knowledgebase Article:

> [https://support.microsoft.com/kb/955136/](https://support.microsoft.com/kb/955136/)


When attempting to log in, you receive the following reply:

[!code-console[Main](configuring-ftp-with-net-membership-authentication-in-iis-7/samples/sample7.cmd)]

This error is caused when you have not configured your SQL server to accept remote connections.