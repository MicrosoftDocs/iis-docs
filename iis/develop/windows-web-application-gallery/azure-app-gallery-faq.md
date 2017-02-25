---
title: "Azure App Gallery FAQ | Microsoft Docs"
author: rick-anderson
description: "With just a few mouse clicks the Windows Web Application Gallery lets you select, download and install popular web applications like blogs, content managemen..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 06/14/2012
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/develop/windows-web-application-gallery/azure-app-gallery-faq
msc.type: authoredcontent
---
Azure App Gallery FAQ
====================
by Sunitha Muthukrishna

## Introduction

With just a few mouse clicks the Windows Web Application Gallery lets you select, download and install popular web applications like blogs, content management systems, wikis or media galleries onto Azure. The following FAQ describes additional information that you may need when you are configuring several popular applications on Azure.

## DotNetNuke Community and Professional Editions:

The database information must be re-entered to complete installation of DotNetNuke. You can view this information in the dashboard of your newly created site on the right side.

[![](azure-app-gallery-faq/_static/image2.png)](azure-app-gallery-faq/_static/image1.png)

Once you have the database information, in the Database configuration step of DotNetNuke install wizard enter this database information as seen below

[![](azure-app-gallery-faq/_static/image4.png)](azure-app-gallery-faq/_static/image3.png)

## Acquia Drupal and Drupal Commerce:

Once either of these apps are deployed; the app runtime installer needs to run. Please click on the &quot;Setup&quot; icon to continue the installation.

[![](azure-app-gallery-faq/_static/image6.png)](azure-app-gallery-faq/_static/image5.png)

If &quot;Setup&quot; is not clicked and you browse the site you may see this error. This occurs since the app is not configured yet. To resolve this append install.php to the URL and run this script; for example [http://mysitename.azurewebsites.net/install.php](http://mysitename.azurewebsites.net/install.php)

[![](azure-app-gallery-faq/_static/image8.png)](azure-app-gallery-faq/_static/image7.png)

## Umbraco CMS

Click on Setup in the notification bar once Umbraco is successfully deployed to configure your Umbraco site.

[![](azure-app-gallery-faq/_static/image10.png)](azure-app-gallery-faq/_static/image9.png)

Umbraco install wizard will request you to re-enter the database information. You can view this information in the dashboard of your newly created site on the right side

[![](azure-app-gallery-faq/_static/image12.png)](azure-app-gallery-faq/_static/image11.png)

Once you have the database information, re-enter this is the Umbraco install wizard

[![](azure-app-gallery-faq/_static/image14.png)](azure-app-gallery-faq/_static/image13.png)

## Kentico CMS

 The database information must be re-entered to complete installation of Kentico CMS. You can view this information in the dashboard of your newly created site on the right side.

[![](azure-app-gallery-faq/_static/image16.png)](azure-app-gallery-faq/_static/image15.png)

When you browse the app, Kentico CMS installation wizard request the database server name and database user information to be entered. Please refer to the connection string for this information.

[![](azure-app-gallery-faq/_static/image18.png)](azure-app-gallery-faq/_static/image17.png)

Now select &quot;Existing database&quot; and enter the database name from the connection string.

[![](azure-app-gallery-faq/_static/image20.png)](azure-app-gallery-faq/_static/image19.png)

Finally, a license needs to be created for the app as seen here. Continue with the wizard to complete the app installation.

[![](azure-app-gallery-faq/_static/image22.png)](azure-app-gallery-faq/_static/image21.png)