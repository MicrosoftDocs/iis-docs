---
title: "Verifying the Developer Experience - ASP.NET | Microsoft Docs"
author: rick-anderson
description: "Introduction This walkthrough is intended to help hosters verify that their customers can use the Windows Web Platform tools and services to download, custom..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 01/18/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/verifying-the-deployment/verifying-the-developer-experience-aspnet
msc.type: authoredcontent
---
Verifying the Developer Experience - ASP.NET
====================
by Walter Oliver

## Introduction

This walkthrough is intended to help hosters verify that their customers can use the Windows Web Platform tools and services to download, customize, publish, and manage their applications in a Hosted Environment.

In this case we'll play the role of the developer and use the Microsoft Web Patform Installer to deploy a popular CMS ASP.NET application called "Graffiti CMS" in the local developer machine. Once we verify that works we'll proceed to deploy it in the hosted server.

In summary this walkthrough covers:

1. Using Web Platform Installer to install Graffiti CMS in a developer machine
2. Configuring the application to use SQL Server and test it locally
3. Using Visual Web Developer to modify and publish the application to the remote server.
4. Using IIS Manager Remote Administration feature to change the application Connection String to point to the new SQL Server.

## Prerequisites

1. The hoster must have provided the developer with credentials that have access to an FTP site that shared its content with the corresponding Web Site. See FTP and VWD articles &lt;link: [https://www.iis.net/learn/web-hosting/configuring-servers-in-the-windows-web-platform/guide-to-deploy-ftp-and-publish-with-vwd](../configuring-servers-in-the-windows-web-platform/guide-to-deploy-ftp-and-publish-with-vwd.md)&gt; for details on how to setup this configuration so that users are isolated from each other.
2. The hoster must have provided the developer with a SQL Server database.
3. The developer must have installed Visual Web Developer (VWD) and SQL Server.
4. The developer must have installed the Web Platform Installer (WPI). Follow the instructions at &lt;link: [https://go.microsoft.com/fwlink/?LinkId=145510](https://go.microsoft.com/fwlink/?LinkId=145510)&gt;

## Step 1: Using WPI, install the Graffiti CMS application on your development machine

As of the writing of this article a new version of Web Platform Installer is being released to the Web. Please visit [https://go.microsoft.com/fwlink/?LinkId=145510](https://go.microsoft.com/fwlink/?LinkId=145510) for more information. The set of applications include Graffiti CMS.

1. 

## Step 2: Verify the existence of the Graffiti CMS Site and corresponding Database:

1. Run IISMgr and view the Sites folder in the left-hand panel.  
    [![](verifying-the-developer-experience-aspnet/_static/image7.jpg)](verifying-the-developer-experience-aspnet/_static/image5.jpg)
2. Run SQL Management Studio and view the Graffiti DB in the database tables:  
    [![](verifying-the-developer-experience-aspnet/_static/image11.jpg)](verifying-the-developer-experience-aspnet/_static/image9.jpg)
3. Use IE to browse to the site:  
    [![](verifying-the-developer-experience-aspnet/_static/image15.jpg)](verifying-the-developer-experience-aspnet/_static/image13.jpg)

## Step 3: Configure Graffiti to use the SQL Server Database already created.

At this point you have the Graffiti application running and a SQL db created for it. However, the SQL database is not the one used by the application by default. Out-of-the box it uses its own db system (VistaDB), see connection string dialog below for the site:

[![](verifying-the-developer-experience-aspnet/_static/image19.jpg)](verifying-the-developer-experience-aspnet/_static/image17.jpg)

The steps to setting up SQL Server are very simple:

1. Using the Graffiti database:

    - Execute the Graffiti\_SQL\_Schema.sql file found in the Data folder.
    - Execute the Graffiti\_SQL\_Data.sql file found in the Data folder.
2. Add the connection string of your database to the web.config file. It should have the name "Graffiti":  

    [!code-xml[Main](verifying-the-developer-experience-aspnet/samples/sample1.xml)]

    You can accomplish it through the Connection Strings Module in IIS Manager:

    [![](verifying-the-developer-experience-aspnet/_static/image23.jpg)](verifying-the-developer-experience-aspnet/_static/image21.jpg)
3. Change the AppSetting key DataBuddy::Provider value to DataBuddy.SQLDataProvider, DataBuddy in the web.config file.  
    [![](verifying-the-developer-experience-aspnet/_static/image27.jpg)](verifying-the-developer-experience-aspnet/_static/image25.jpg)
4. With Internet Explorer browse to the Graffiti site. Notice that since the SQL db does not render the same data that comes in the default database:  
    [![](verifying-the-developer-experience-aspnet/_static/image31.jpg)](verifying-the-developer-experience-aspnet/_static/image29.jpg)
5. Verify that the Application Admin credentials work the temporary password for the admin user can be found in the web.confg file:  
    [![](verifying-the-developer-experience-aspnet/_static/image35.jpg)](verifying-the-developer-experience-aspnet/_static/image33.jpg)
6. Enter the credentials and press Login:  
    [![](verifying-the-developer-experience-aspnet/_static/image39.jpg)](verifying-the-developer-experience-aspnet/_static/image37.jpg)
7. The Admin Control Panel page is display:  
    [![](verifying-the-developer-experience-aspnet/_static/image43.jpg)](verifying-the-developer-experience-aspnet/_static/image41.jpg)

Now you are ready to publish the application.
  

## Step 4: Use Visual Web Developer (VWD) to Modify and Publish Your Application

1. Open your Graffiti Site with VWD. The following dialog will display, press Yes to upgrade the site to .NET Framework version 3.5.  
    [![](verifying-the-developer-experience-aspnet/_static/image47.jpg)](verifying-the-developer-experience-aspnet/_static/image45.jpg)  
    [![](verifying-the-developer-experience-aspnet/_static/image51.jpg)](verifying-the-developer-experience-aspnet/_static/image49.jpg)
2. Open the menu Website and select "Copy Web Site":  
    [![](verifying-the-developer-experience-aspnet/_static/image57.jpg)](verifying-the-developer-experience-aspnet/_static/image55.jpg)
3. Select FTP Site and enter the Server name, Port and user account credentials. Ensure that "Passive Mode" is checked and press Open:  
    [![](verifying-the-developer-experience-aspnet/_static/image63.jpg)](verifying-the-developer-experience-aspnet/_static/image61.jpg)
4. Publish the entire content to the target server.  
    [![](verifying-the-developer-experience-aspnet/_static/image67.jpg)](verifying-the-developer-experience-aspnet/_static/image65.jpg)

## Step 5: Use IIS Manager Remote Administration to change the Graffiti Site Connection String to point to the new SQL server.

1. Start IISMgr, if you are running Vista ensure that you are running the remote version of IISMgr:  
    [![](verifying-the-developer-experience-aspnet/_static/image71.jpg)](verifying-the-developer-experience-aspnet/_static/image69.jpg)
2. Connect to the Remote Site:  
    [![](verifying-the-developer-experience-aspnet/_static/image75.jpg)](verifying-the-developer-experience-aspnet/_static/image73.jpg)
3. Enter the Hoster provided user credentials:  
    [![](verifying-the-developer-experience-aspnet/_static/image79.jpg)](verifying-the-developer-experience-aspnet/_static/image77.jpg)
4. Assign a name to the new connection:  
    [![](verifying-the-developer-experience-aspnet/_static/image83.jpg)](verifying-the-developer-experience-aspnet/_static/image81.jpg)
5. Install any IIS Manager extension modules that are offered in the following dialog:  
    [![](verifying-the-developer-experience-aspnet/_static/image89.jpg)](verifying-the-developer-experience-aspnet/_static/image87.jpg)
6. Select your new Graffiti site, find the Connection String icon and double click on it:  
    [![](verifying-the-developer-experience-aspnet/_static/image97.jpg)](verifying-the-developer-experience-aspnet/_static/image95.jpg)
7. Change the Server Name to the new target SQL Server  
    [![](verifying-the-developer-experience-aspnet/_static/image101.jpg)](verifying-the-developer-experience-aspnet/_static/image99.jpg)
8. To upload the database you can use the facilities provided by the hoster. Either through database backup and restore process through FTPor any other control panel facility that would let you run the Graffiti\_SQL\_Schema.sql and Graffiti\_SQL\_Data.sql files.
9. Test that the application works in the new hosting environment. Here is a screen shot after creating a post as the Admin user:  
    [![](verifying-the-developer-experience-aspnet/_static/image105.jpg)](verifying-the-developer-experience-aspnet/_static/image103.jpg)

## Conclusion

This walkthrough covered:

1. Using Web Application Installer to install Graffiti CMS in a developer machine
2. Configuring the application to use SQL Server and test it locally
3. Using Visual Web Developer to modify and publish the application to the remote server.
4. Using IIS Manager Remote Administration feature to change the application Connection String to point to the new SQL Server.