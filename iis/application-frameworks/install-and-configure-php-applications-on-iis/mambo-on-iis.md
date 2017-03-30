---
title: "Mambo on IIS | Microsoft Docs"
author: rick-anderson
description: "Mambo is a free, open source content management system (CMS) that is developed in the PHP scripting language. It is a dynamic CMS and uses the free MySQL dat..."
ms.author: iiscontent
manager: soshir
ms.date: 12/18/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/mambo-on-iis
msc.type: authoredcontent
---
Mambo on IIS
====================
by Eric Woersching

## Introduction

Mambo is a free, open source content management system (CMS) that is developed in the PHP scripting language. It is a dynamic CMS and uses the free MySQL database for storing data. The following sections describe how to install and configure Mambo for use with FastCGI on IIS 6.0. This document assumes that you have completed the setup and configuration of the FastCGI extension and PHP libraries as described in [https://www.iis.net/fastcgi/phpon60](using-fastcgi-to-host-php-applications-on-iis-60.md).

## Notes on PHP Setup

Mambo does not require many modifications beyond the default configuration provided by PHP **.** From the base configuration file provided by PHP, you only need to modify the following lines in your php.ini configuration file to get Mambo working:

- Define 'extension\_dir' as 'c:\php\ext' (i.e. the location of your php extensions directory)
- Uncomment 'extension=php\_mysql.dll' in the extensions list to enable MySQL support

## Download and Unpack the Application

Download the latest stable release of Mambo. For this article we, use Mambo 4.6.2 downloaded from [here](http://www.source.mambo-foundation.org/content/view/90/63/). After downloading the zip package, extract its contents to C:\Inetpub\wwwroot\mambo or another directory of your choosing.

## Set Up the Database

Before starting the installation procedure for Mambo, create a database on your server. Also create a database user and grant this user db ownership permission to the database. Follow the instructions in the [Setting Up a Database for a PHP Application on IIS](../install-and-configure-php-on-iis/setting-up-a-database-for-a-php-application-on-iis.md) article for a MySQL database. This walkthrough uses the following database information

- Database Name: 'mambo'
- Database User: 'mambouser'
- Account Password: 'mambo'

## Directory Permissions Setup

Enable write permission on the Mambo directory for the account that your web server uses for impersonation. For example, if you have configured the web site to impersonate Anonymous users to "Internet Guest Account" (IUSR\_\*), then you must grant this user write access to the directory:

[![](mambo-on-iis/_static/image2.png)](mambo-on-iis/_static/image1.png)

## Configure the Application

1. Open your web browser and browse to [http://localhost/mambo/installation/index.php](http://localhost/mambo/installation/index.php). This takes you to the Mambo setup page, where you see the results of the Mambo pre-installation tests.
2. When you have ensured that all the tests have passed, click "Next&gt;&gt;" at the top of the page.  

    > [!NOTE]
    > You can safely ignore the Session save path at this stage. If it is not set, Mambo will still function.

    [![](mambo-on-iis/_static/image4.png)](mambo-on-iis/_static/image3.png)
3. On the next page Mambo, asks you to enter the DB information. Enter the correct information and click "Next &gt;&gt;".  

    > [!NOTE]
    > If your MySQL Server is configured to have strict mode enabled, then this step may fail. You must disable strict mode for MySQL in order for Mambo to succeed with the database setup.

    [![](mambo-on-iis/_static/image6.png)](mambo-on-iis/_static/image5.png)
4. Enter your site's name. This is the global title of your Mambo-driven site. Enter a name, then press "Next &gt;&gt;"  

    [![](mambo-on-iis/_static/image8.png)](mambo-on-iis/_static/image7.png)
5. In the next step, enter details for your site. The URL should be set to the external sitename to ensure proper configuration. In a local test setup, the URL may have an extra Mambo at the end (ex: [http://localhost/Mambo/Mambo](http://localhost/Mambo/Mambo)). Enter your administrator email and password. The final two options should be left in the default choices. Press "Next &gt;&gt;"  

    [![](mambo-on-iis/_static/image10.png)](mambo-on-iis/_static/image9.png)
6. You are now finished setting up Mambo. Record your admin password. Delete the "installation" folder from C:\Inetpub\wwwroot\Mambo  

    > [!NOTE]
    > You must change the access permissions on the Mambo folder. Now that installation is complete, write access is not needed.

    Once the permissions have been specified, browse to [http://localhost/Mambo/index.php](http://localhost/Mambo/index.php) for the "public" site, or log on at [http://localhost/Mambo/administrator/index.php](http://localhost/Mambo/administrator/index.php) using the administrative username and password that you specified earlier.

    ## Enabling search engine friendly URLs

    When hosting Mambo on IIS 7.0 is is possible to configure it to enable search engine friendly URLs. To do that follow these steps:

    1. Install [Microsoft URL Rewrite Module for IIS 7.0](https://www.iis.net/downloads/microsoft/url-rewrite "URL rewrite module")
    2. Open configuration.php file in the folder where Mambo is installed and set $mosConfig\_sef= "1"
    3. Create a web.config file in the same folder where Mambo is installed and paste into it the following:  

        [!code-xml[Main](mambo-on-iis/samples/sample1.xml)]

    ## Getting More Information

    To discuss the FastCGI Extension for IIS 6.0, or file bug reports, use the FastCGI forums:

    - [IIS.NET/ IIS 6 FastCGI forums](https://forums.iis.net/1103.aspx).

    To get more information regarding running various PHP applications on IIS, refer to:

    - [PHP on IIS portal](https://php.iis.net/)
    - [PHP community forum](https://forums.iis.net/1102.aspx).