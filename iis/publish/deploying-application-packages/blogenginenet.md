---
title: "BlogEngine.NET | Microsoft Docs"
author: simtan
description: "Introduction BlogEngine.NET is an open source .NET blogging platform for Microsoft .NET. For more information about BlogEngine.Net, refer to the BlogEngine.N..."
ms.author: iiscontent
manager: soshir
ms.date: 03/10/2011
ms.topic: article
ms.assetid: 
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/deploying-application-packages/blogenginenet
msc.type: authoredcontent
---
BlogEngine.NET
====================
by [Simon Tan](https://github.com/simtan)

## Introduction

BlogEngine.NET is an open source .NET blogging platform for Microsoft .NET. For more information about BlogEngine.Net, refer to the [BlogEngine.NET](http://www.dotnetblogengine.net/) Web site. For step-by-step instructions on installing this application in an IIS environment, see the *Procedure* section of this document.

## Requirements

For information about technical requirements for your IIS environment, refer to [Install Server Components](../../web-hosting/joining-the-web-hosting-gallery/install-server-components.md).

## Procedure

### Step 1. Install the application in an IIS test environment.

To install the application, you can use Web Platform Installer or WebMatrix. These procedures are described in this step.

#### Web Platform Installer

The Microsoft Web Platform Installer 2.0 (Web PI) is a free tool that allows you to easily install and run the most popular free web applications for blogging, content management and more with the built-in Windows Web Application Gallery. For more information about Web PI, refer to the [Microsoft Web Platform Installer 2.0](https://www.microsoft.com/web/downloads/platform.aspx) Web site.

To use Web PI to install this application, complete these steps:

1. From the Windows Start menu, click **Programs**, and then click **Web Platform Installer**.  
  
 The Web Platform Installation window appears.  
    [![](blogenginenet/_static/image3.jpg)](blogenginenet/_static/image2.jpg)
2. Click the **Web Applications** tab, select the **BlogEngine.NET** check box, and click **Install**.  
  
    [![](blogenginenet/_static/image5.jpg)](blogenginenet/_static/image4.jpg)
3. Select the **BlogEngine.NET** check box, and click **I Accept**.  
  
    [![](blogenginenet/_static/image7.jpg)](blogenginenet/_static/image6.jpg)
4. Select **Mixed Mode Authentication**, enter a password, and click **Continue**. 

    Once the preinstallation steps complete, the site information window appears.  
[![](blogenginenet/_static/image9.jpg)](blogenginenet/_static/image8.jpg)
5. In the Web Site list, click **New Web Site**.
6. Enter an application name in the application name field.
7. Enter a web site name in the Web Site Name field.
8. Enter a physical path in the Physical path field.
9. In the IP address list, click **All Unassigned**, and enter **80** in the Port field.
10. Enter a host name in the Host Name field, and click **Continue**.  
  
 The application information window appears.  
    [![](blogenginenet/_static/image11.jpg)](blogenginenet/_static/image10.jpg)
11. In the Choose your database list, click **SQL Server**.
12. In the Create a new or use an existing database list, click **Create new database**.
13. Enter a database administrator user name in the Database Admin Username field.
14. Enter a password in the Database Admin Password field.
15. Click **Continue**.  
  
 Once the installation process completes, the final installation window appears.  
    [![](blogenginenet/_static/image13.jpg)](blogenginenet/_static/image12.jpg)
16. Click **Finish**.  
  
 The BlogEngine.NET web page appears.  
    [![](blogenginenet/_static/image15.jpg)](blogenginenet/_static/image14.jpg)

#### WebMatrix

WebMatrix is a free, easy way to customize and build Web sites from popular open-source applications, such as WordPress, Drupal, and Joomla. In addition, you can build sites from the ground up using ASP.NET, PHP, HTML and a number of other leading technologies. For more information about WebMatrix, refer to the [WebMatrix](https://www.microsoft.com/web/webmatrix/) Web site.

To use WebMatrix to install this application, complete these steps:

1. Launch WebMatrix.  
  
 The WebMatrix home page appears.  
    [![](blogenginenet/_static/image17.jpg)](blogenginenet/_static/image16.jpg)
2. Click **Site From Web Gallery**.   
  
 The Site from Web Gallery page appears.  
    [![](blogenginenet/_static/image19.jpg)](blogenginenet/_static/image18.jpg)
3. Click **BlogEngine.NET**, and click **Next**.  
  
 The Accept EULA page appears.  
    [![](blogenginenet/_static/image21.jpg)](blogenginenet/_static/image20.jpg)
4. Click **I Accept** to agree to the end-user license agreement.  
  
 WebMatrix installs the BlogEngine.NET software on your local computer. This page appears once installation is complete.    [![](blogenginenet/_static/image23.jpg)](blogenginenet/_static/image22.jpg)
5. Click **OK**.   
  
 The BlogEngine.NET application starts as indicated in bottom-left corner of the page.  
    [![](blogenginenet/_static/image25.jpg)](blogenginenet/_static/image24.jpg)
6. Click **Settings** in the left navigation area.
7. Select **.Net 4 (Integrated)** from the Select .NET Framework Version drop-down list.
8. To configure the settings for your hosting provider and domain, select **Publish &gt; Configure**.  
  
    [![](blogenginenet/_static/image28.jpg)](blogenginenet/_static/image27.jpg)
9. Add your hosting provide and domain-specific information, and click **Validate Connection**.
10. If the connection was successful, click **Apply**, and then click **Publish**.  
  
 WebMatrix determines changes to be made.  
    [![](blogenginenet/_static/image30.jpg)](blogenginenet/_static/image29.jpg)
11. Once changes have been determined, check the **Publish to SQL Server** check box, and click **Continue**.  
  
 Once the process completes, the Publish Preview dialog box appears.  
    [![](blogenginenet/_static/image32.jpg)](blogenginenet/_static/image31.jpg)
12. Click **Continue**.  
  
 The status of the publishing process is indicated in the bottom-left corner of the page.  
    [![](blogenginenet/_static/image34.jpg)](blogenginenet/_static/image33.jpg)
13. Once publishing is complete, go to your domain, and verify BlogEngine.NET is running.  
    [![](blogenginenet/_static/image36.jpg)](blogenginenet/_static/image35.jpg)

### Step 2. Build the application package from the IIS site.

To build the application package from the IIS site, complete the steps described in [Export a Package through IIS Manager](../using-web-deploy/export-a-package-through-iis-manager.md).

### Step 3. Install the application on the target server.

To install the application on the target server, complete the steps described in [Import a Package through IIS Manager](../using-web-deploy/import-a-package-through-iis-manager.md).