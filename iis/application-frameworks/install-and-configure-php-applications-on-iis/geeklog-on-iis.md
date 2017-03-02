---
title: "Geeklog on IIS | Microsoft Docs"
author: rick-anderson
description: "Geeklog is a PHP/MySQL based application for managing dynamic web content. It is a blog engine, or a CMS with support for comments, track backs, multiple syn..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/18/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/geeklog-on-iis
msc.type: authoredcontent
---
Geeklog on IIS
====================
by Eric Woersching

## Introduction

Geeklog is a PHP/MySQL based application for managing dynamic web content. It is a blog engine, or a [CMS](http://en.wikipedia.org/wiki/Web_content_management_system "Click to look up 'CMS' on Wikipedia") with support for comments, track backs, multiple syndication formats, spam protection, and all the other vital features of such a system. The core Geeklog distribution is easily extended by community-developed plugins, including forums and image galleries.

For more information about Geeklog, see [http://www.geeklog.net](http://www.geeklog.net/).

In this article, we go through the steps that would be required to install Geeklog to work with FastCGI extension on IIS6.0. To find out more about FastCGI support in IIS, see [https://www.iis.net/fastcgi](https://www.iis.net/downloads/microsoft/fastcgi-for-iis)

The following steps assume that you have completed the setup and configuration of FastCGI extension and PHP libraries as described in [https://www.iis.net/fastcgi/phpon60](using-fastcgi-to-host-php-applications-on-iis-60.md).

## Download and Unpack the Application

First, download the latest stable release of Geeklog. For this article, we use Geeklog 1.4.1 downloaded from [here](http://www.geeklog.net/filemgmt/viewcat.php?cid=8). Once you downloaded the package, uncompress it

> [!NOTE]
> For this walkthrough, we extracted the files to D:\Geeklog.

Everything outside the public\_html directory should not be visible over the web, as it contains sensitive information. Hence, copy the content of public\_html out into a directory served by your web server

> [!NOTE]
> For this walkthrough, we copied the content to directory D:\public\_html and created a virtual directory called 'Geeklog' pointing to D:\public\_html.

## Set Up the Database

In order to use Geeklog, you must have access to a database. For this walkthrough, we use MS SQL Server 2005. You can also use MySQL or MS SQL Express.

Before starting the install, create a database on your server. Also create a database user and grant this user db ownership permission to the database. If you are using MS SQL Server 2005, then open Microsoft SQL Server Management Studio and click the "New Query" button. Enter the following script into the query window (this script creates the database and user that are necessary for the Geeklog application).

[!code-sql[Main](geeklog-on-iis/samples/sample1.sql)]

> [!NOTE]
> Make sure the login Geeklog has permission to create tables inside the Geeklog database.

## Configure the Application

1. Start by making the following updates to config.php. The examples that follow are specific to this walkthrough.  

    - Set $\_CONF['path'] to point to the directory where your config.php file resides.  

        [!code-powershell[Main](geeklog-on-iis/samples/sample2.ps1)]
    - Set $\_CONF['path\_html'] to point to where the contents of public\_html have been placed.  

        [!code-powershell[Main](geeklog-on-iis/samples/sample3.ps1)]
    - Set Geeklog to use MSSQL and configure the Sql login credentials.  

        [!code-powershell[Main](geeklog-on-iis/samples/sample4.ps1)]
    - Set $\_CONF['site\_url']  

        [!code-unknown[Main](geeklog-on-iis/samples/sample-127106-5.unknown)]
2. Edit lib-common.php and change the require\_once() at the top to point to the location of your config.php file.  

    For more information on how to install Geeklog, refer to [http://www.geeklog.net/docs/install.html](http://www.geeklog.net/docs/install.html).
3. Afterwards, open your web browser and browse to [http://localhost/geeklog/admin/install/install.php](http://localhost/geeklog/admin/install/install.php).  

    [![](geeklog-on-iis/_static/image2.png)](geeklog-on-iis/_static/image1.png)
4. Select the installation type from the drop down. For this walkthrough, we set up a new Microsoft SQL Server database. Set the path to config.php and click Next.  

    [![](geeklog-on-iis/_static/image4.png)](geeklog-on-iis/_static/image3.png)
5. We are now ready to setup the database and complete the installation. Click Next.  
    [![](geeklog-on-iis/_static/image6.png)](geeklog-on-iis/_static/image5.png)

## Getting More Information

To discuss the FastCGI Extension for IIS 6.0, or file bug reports, please use the FastCGI forums:

- [IIS.NET / IIS 6 FastCGI forums](https://forums.iis.net/1103.aspx).

To get more information regarding running various PHP applications on IIS refer to:

- [PHP on IIS portal](https://php.iis.net/)
- [PHP community forum](https://forums.iis.net/1102.aspx)