---
title: "CubeCart on IIS | Microsoft Docs"
author: rick-anderson
description: "Introduction CubeCart is a powerful eCommerce script written with PHP and MySQL. With CubeCart, you can setup a powerful online store with hosting that suppo..."
ms.author: iiscontent
manager: soshir
ms.date: 01/17/2008
ms.topic: article
ms.assetid: 8f3e0858-60eb-44ca-a09d-2179b395d359
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/cubecart-on-iis
msc.type: authoredcontent
---
CubeCart on IIS
====================
by Eric Woersching

## Introduction

CubeCart is a powerful eCommerce script written with PHP and MySQL. With CubeCart, you can setup a powerful online store with hosting that supports PHP and one MySQL database.

For more information about CubeCart, see [http://www.cubecart.com](http://www.cubecart.com/).

In this section, we go through the steps required to install CubeCart to work with FastCGI extension on IIS 7.0 and above. To find out more about FastCGI support in IIS, see [https://www.iis.net/fastcgi](https://www.iis.net/downloads/microsoft/fastcgi-for-iis)

The following steps assume that you have completed the setup and configuration of FastCGI extension and PHP libraries as described here [https://www.iis.net/fastcgi/phpon60](using-fastcgi-to-host-php-applications-on-iis-60.md).

## Download and Unpack the CubeCart

First you will need to download latest stable release of CubeCart application. For this article we used CubeCart\_3.0.17 Full Package that can be downloaded from the mirror   
[https://www.cubecart.com/site/helpdesk/index.php?\_m=downloads&amp;\_a=view&amp;parentcategoryid=1&amp;pcid=5&amp;nav=0,5](https://www.cubecart.com/site/helpdesk/index.php?_m=downloads&amp;_a=view&amp;parentcategoryid=1&amp;pcid=5&amp;nav=0,5)

Once you downloaded the package, uncompress it and copy files and folders to `C:\Inetpub\wwwroot\cubecart`.

## Set Up the Database

Before starting the installation of CubeCart, create a database on your database server. Also create a user and grant this user db ownership permission to the database. Follow the instructions in the [Setting Up a Database for a PHP Application on IIS](../install-and-configure-php-on-iis/setting-up-a-database-for-a-php-application-on-iis.md) article for a MySQL database. This walkthrough uses the following database information:

- Database Name: 'cubecart'
- Database User: 'cubecart'
- Account Password: 'cubecart'

## Setup and Configuration

Follow these steps:

1. Go to [https://www.cubecart.com/build](https://www.cubecart.com/build) to generate the configuration setup script after creating the database for the project.  
    [![](cubecart-on-iis/_static/image2.jpg)](cubecart-on-iis/_static/image1.jpg)
2. Click Continue to go to the next step.  

    [![](cubecart-on-iis/_static/image4.jpg)](cubecart-on-iis/_static/image3.jpg)

    [![](cubecart-on-iis/_static/image6.jpg)](cubecart-on-iis/_static/image5.jpg)
3. Provide the database details and click Continue. We used the following details for our application:  

    - Database Type: MySql
    - Host Name: localhost
    - Username: cubecartuser
    - Password: cubecart
    - Database: cubecart

    [![](cubecart-on-iis/_static/image8.jpg)](cubecart-on-iis/_static/image7.jpg)

    [![](cubecart-on-iis/_static/image10.jpg)](cubecart-on-iis/_static/image9.jpg)

    It generates 2 files:

    - global.inc.php - Open includes/global.inc.php and paste in the code created for you.
    - db.sql - Execute the sql queries generated for you.

    [![](cubecart-on-iis/_static/image12.jpg)](cubecart-on-iis/_static/image11.jpg)

    [![](cubecart-on-iis/_static/image14.jpg)](cubecart-on-iis/_static/image13.jpg)
4. Give write access permissions to images/upload folder.  

    [![](cubecart-on-iis/_static/image16.jpg)](cubecart-on-iis/_static/image15.jpg)
5. Delete the install folder from the directory before accessing the installed application.

Installation is complete. Access the application by browsing the index.php file using the path [http://localhost/cubecart/index.php](http://localhost/cubecart/index.php).

[![](cubecart-on-iis/_static/image18.jpg)](cubecart-on-iis/_static/image17.jpg)

[![](cubecart-on-iis/_static/image20.jpg)](cubecart-on-iis/_static/image19.jpg)

## Getting More Information

To discuss the FastCGI Extension for IIS 6.0, or file bug reports, please use the FastCGI forums:

- [IIS.NET / IIS 6.0 FastCGI forums](https://forums.iis.net/1103.aspx).

To get more information regarding running various PHP applications on IIS, refer to:

- [PHP on IIS portal](https://php.iis.net/)
- [PHP community forum](https://forums.iis.net/1102.aspx).