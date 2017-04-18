---
title: "XOOPS on IIS | Microsoft Docs"
author: rick-anderson
description: "XOOPS is a popular open source portal and content management system. It serves as a web framework for use by small, medium and large sites. It allows adminis..."
ms.author: iiscontent
manager: soshir
ms.date: 12/18/2007
ms.topic: article
ms.assetid: 6c81b442-b873-4b8b-93a8-ee1cbd1b9c46
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/xoops-on-iis
msc.type: authoredcontent
---
XOOPS on IIS
====================
by Eric Woersching

## Introduction

XOOPS is a popular open source portal and content management system. It serves as a web framework for use by small, medium and large sites. It allows administrators to easily create dynamic websites with great content and many outstanding features. It is a tool for developing small to large dynamic community websites, intra company portals, corporate portals, weblogs and much more. The following sections describe how to install and configure XOOPS for use with FastCGI on IIS 6.0. This document assumes that you have completed the setup and configuration of the FastCGI extension and PHP libraries as described in [https://www.iis.net/fastcgi/phpon60](using-fastcgi-to-host-php-applications-on-iis-60.md).

The instructions have been tested and found to work in the following configurations:

- Windows Server® 2003 operating system
- IIS 6.0
- PHP 5.2.4
- MySQL 5.0.45
- XOOPS 2.0.17

## Notes on PHP Setup

XOOPS does not require many modifications beyond the default configuration provided by PHP **.** From the base configuration file provided by PHP, you only need to modify the following lines in your php.ini configuration file to get XOOPS working:

- Define 'extension\_dir' as 'c:\php\ext' (i.e., the location of your php extensions directory)
- Uncomment 'extension=php\_mysql.dll' in the extensions list to enable MySQL support

## Download and Unzip XOOPS

The latest release of XOOPS is at [http://www.xoops.org/](http://www.xoops.org/). The instructions in this document are based on version 2.0.17, but future versions are likely to be very similar as far as installation is concerned. After downloading the zip package, extract the contents of the 'htdocs' folder from the archive into C:\Inetpub\wwwroot\xoops or another directory of your choosing.

## Access Permissions

In order for XOOPS installation to work, you must make sure that the IIS application pool worker process has write access to the following directories and files:

- mainfile.php
- cache
- templates\_c
- uploads

> [!NOTE]
> FastCGI impersonates the requests from all users. Make sure that the user account used for impersonation has write access to those files.

For example, if the web site or virtual directory is configured for Anonymous authentication, then grant "Internet Guest Account" write access to those files.

## Set Up the Database

Before starting the installation procedure for XOOPS, create a database on your server. Also create a user and grant this user db ownership permission to the database. Follow the instructions in the [Setting Up a Database for a PHP Application on IIS](../install-and-configure-php-on-iis/setting-up-a-database-for-a-php-application-on-iis.md) article for a MySQL database. This walkthrough uses the following database information:

- Database Name: 'xoops'
- Database User: 'xoops'
- Account Password: 'xoops'

## Set Up and Configure the Application

Begin the graphical XOOPS installation procedure by pointing your browser at [http://localhost/xoops](http://localhost/xoops) . You see the following page.

1. Click 'Next' to go to the next screen.  

    [![](xoops-on-iis/_static/image2.png)](xoops-on-iis/_static/image1.png)
2. Proceed through the installation screens until you get to the most important page-- the setup for configuring the database connection. Fill in the information as appropriate:  

    [![](xoops-on-iis/_static/image4.png)](xoops-on-iis/_static/image3.png)

    > [!NOTE]
    > The XOOPS root path is shown with the wrong slashes, but the install still works.
3. Now that the database connection is configured, proceed to the following screens that verify the connection and set up the database tables. Keep clicking "Next" and several screens later XOOPS will be successfully installed.

## Getting More Information

To discuss the FastCGI Extension for IIS 6.0, or file bug reports, use the FastCGI forums:

- [IIS.NET / IIS 6.0 FastCGI forums](https://forums.iis.net/1103.aspx).

To get more information regarding running various PHP applications on IIS, refer to:

- [PHP on IIS portal](https://php.iis.net/)
- [PHP community forum](https://forums.iis.net/1102.aspx).