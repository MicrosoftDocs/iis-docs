---
title: "pMachinePro on IIS"
author: rick-anderson
description: "The application pMachine Pro is a popular open source blogging solution. It includes all the features of traditional blog tools, and supports multiple langua..."
ms.date: 01/18/2008
ms.assetid: 8ffe0ee7-c74c-4a6b-83aa-3ed6009e03fc
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/pmachinepro-on-iis
msc.type: authoredcontent
---
# pMachinePro on IIS

by Eric Woersching

## Introduction

The application pMachine Pro is a popular open source blogging solution. It includes all the features of traditional blog tools, and supports multiple languages. ExpressionEngine has replaced it. The existing pMachine Pro is still available for free download, but it is no longer supported.

For more information about pMachine Pro, see [http://www.ellislab.com/](http://www.ellislab.com/).

The following sections describe how to install and configure pMachinePro for use with FastCGI on IIS 6.0. This document assumes that you have completed the setup and configuration of the FastCGI extension and PHP libraries as described in [https://www.iis.net/fastcgi/phpon60](using-fastcgi-to-host-php-applications-on-iis-60.md).

## Notes on PHP Setup

pMachine Pro does not require many modifications beyond the default configuration provided by PHP. From the base configuration file provided by PHP, you only need to modify the following lines in your php.ini configuration file to get pMachine Pro working:

- Define `extension\_dir` as `c:\php\ext` (i.e., the location of your PHP extensions directory)
- Uncomment `extension=php\_mysql.dll` in the extensions list to enable MySQL support

## Download and Unpack pMachinePro

First, download the latest stable release of pMachine Pro. For this article, we use pMachine Pro 2.4.1 downloaded from here **&lt;ISSUE: Missing link&gt;.** Once you download the package, uncompress it and copy all the files and folders to `C:\Inetpub\wwwroot\pMachine`.

## Set Up the Database

Before starting the installation procedure for pMachinePro, create a database on your server. Also create a user and grant this user db ownership permission to the database. Follow the instructions in the [Setting Up a Database for a PHP Application on IIS](../install-and-configure-php-on-iis/setting-up-a-database-for-a-php-application-on-iis.md) article for a MySQL database. This walkthrough uses the following database information:

- Database Name: 'pmachine'
- Database User: 'pmachine'
- Account Password: 'pmachine'

## Set Up and Configure pMachinePro

To ensure that the Installation process can complete without errors, follow the instructions to set the file and directory permissions described in the installation document contained in the package. For this walkthrough, we provide modify permissions to the local machine "Internet Guest Account" for the following directories and file:

- /images/uploads
- /images/captchas
- /pm/config.php

Change the database connection setting in the config.php file to point to your installed MySQL instance.

Browse to the [http://localhost/pMachine/pm/install.php](http://localhost/pMachine/pm/install.php) page for detailed setup instructions. Click the Install link on the top of the page to redirect to the Install Wizard.

[![Screenshot of the local host slash p Machine slash p m slash install dot p h p page.The Version two dot four Installation Script is shown.](pmachinepro-on-iis/_static/image2.jpg)](pmachinepro-on-iis/_static/image1.jpg)

The data population SQL scripts in the install.php are out of sync with the actual table schema created in MySQL 5.0.45. You must update the insert scripts contained in install.php, and in template.data.php.  
This results in creating all the tables and you see the registration form to register the admin user.

## Test pMachinePro

To test that pMachine has been installed successfully, create a blog postings and view it as a site visitor would. Follow these steps:

1. Navigate to [http://localhost/pMachine/pm/index.php](http://localhost/pMachine/pm/index.php).
2. Enter the administrator username and password created in the last installation step.  
    [![Screenshot of the local host slash p Machine slash p m slash install dot p h p page. The administrator page is shown.](pmachinepro-on-iis/_static/image4.jpg)](pmachinepro-on-iis/_static/image3.jpg)
3. Once logged in, enter a title for your post and some content and click Preview. This displays what the post looks like.  

    [![Screenshot of Machine Control Panel page. A box for the title and content for a post is shown.](pmachinepro-on-iis/_static/image6.jpg)](pmachinepro-on-iis/_static/image5.jpg)

    [![Screenshot of the Machine Control Panel page. The text Test Blog Entry is shown. The submit and continue editing buttons are found below the text.](pmachinepro-on-iis/_static/image8.jpg)](pmachinepro-on-iis/_static/image7.jpg)
4. Click Submit to publish this content to the Blog selected (Blog A in the case above).
5. Navigate to [http://localhost/pmachine/weblog.php](http://localhost/pmachine/weblog.php) to browse to the actual blog site. See the actual blog as seen by site visitors.  

    [![Screenshot of the local host slash p machine slash web blog dot p h p page. The date Sunday September sixteenth two thousand seven is shown above the text Test Blog Entry.](pmachinepro-on-iis/_static/image10.jpg)](pmachinepro-on-iis/_static/image9.jpg)

## Getting More Information

To discuss the FastCGI support in IIS, or file bug reports, use the FastCGI forums:

- [IIS.NET / IIS 6.0 FastCGI forums](https://forums.iis.net/1103.aspx).
- [IIS 7.0 FastCGI forums](https://forums.iis.net/1104.aspx)

To get more information regarding running various PHP applications on IIS, refer to:

- [PHP on IIS portal](https://php.iis.net/)
- [PHP community forum](https://forums.iis.net/1102.aspx)
