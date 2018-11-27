---
title: "Install the SQL Server Driver for PHP | Microsoft Docs"
author: rick-anderson
description: "Introduction The Microsoft® SQL Server® Driver for PHP is designed to enable reliable, scalable integration with SQL Server for PHP applications deployed on..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 2e1b4523-a32f-4390-bf9f-552f21ecc93b
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/install-the-sql-server-driver-for-php
msc.type: authoredcontent
ROBOTS: NOINDEX,NOFOLLOW
---
Install the SQL Server Driver for PHP
====================
by Tali Smith

[!include[outdatedContent](../../outdatedContentWarning.md)]

## Introduction

The Microsoft® SQL Server® Driver for PHP is designed to enable reliable, scalable integration with SQL Server for PHP applications deployed on the Windows® platform. The driver is a PHP extension that allows the reading and writing of SQL Server data from within PHP scripts. It provides a procedural interface for accessing data in all editions of SQL Server(including Express editions) and makes use of PHP features, including PHP streams, to read and write large objects. The SQL Server Driver for PHP relies on the Microsoft SQL Server Native Client to communicate with SQL Server.

The SQL Server Driver for PHP download is available to all SQL Server users at no additional charge. The most current version of the driver, Microsoft SQL Server Driver for PHP 1.1, provides new capabilities for building PHP applications, and the driver supports Microsoft® SQL Azure™ Database and PHP version 5.3, enabling developers to build PHP applications with relational capabilities using the SQL Azure Database.SQL Server Driver for PHP 1.1 also includes support for UTF-8 and for scrollable results.

Microsoft provides support for the SQL Server Driver for PHP under its normal support methods. Microsoft supports only the signed version of the driver from the Microsoft® Developer Network (MSDN®) download site.

## System Requirements

The SQL Server Driver for PHP application programming interface (API) includes support for Windows authentication, transactions, parameter binding, streaming, metadata access, and error handling. The SQL Server Driver for PHP relies on the Microsoft® SQL Server® 2005 Open Database Connectivity (ODBC) driver to handle the low-level communication with SQL Server and is therefore only supported on the Windows operating system.

You need to ensure that the following are installed:

- Supported operating systems:  

    - Windows Server® 2008 R2 or Windows Server® 2008
    - Windows® 7, Windows Vista® Service Pack 1 (SP1), Windows® XP SP3
    - Windows Server® 2003 SP2, Windows® 2000 SP4
- PHP 5.X.X. Microsoft SQL Server 2008 Native Client. You can download SQL Server Native Client from a Microsoft® SQL Server® 2008 Feature Pack, at: [https://www.microsoft.com/downloads/details.aspx?familyid=B33D2C78-1059-4CE2-B80D-2343C099BCB4&amp;displaylang=en%20](https://www.microsoft.com/downloads/details.aspx?familyid=B33D2C78-1059-4CE2-B80D-2343C099BCB4&amp;displaylang=en%20)
- Any edition of SQL Server 2005 or SQL Server 2008.
- A Web server configured to run PHP.

## Install the SQL Server Driver for PHP

Perform the following steps to download and install the SQL Server Driver for PHP.

1. Download %SQLServerDriverForPHP.EXE to a temporary directory.
2. Double-click to run %SQLServerDriverForPHP.EXE.
3. Enter an installation directory when prompted. It is recommended that you extract the file to `%ProgramFiles%` with the default directory **Microsoft SQL Server Driver for PHP**.
4. Double-click to open the **SQLServerDriverForPHP.chm** help file.
5. Install the **Microsoft SQL Server Native Client** from the link provided.
6. Copy the **php\_sqlsrv.dll** and **php\_sqlsrv\_ts.dll** files to the `C:\PHP\ext\` directory.
7. Open the `C:\PHP\php.ini` file, and add the following line in the **Extensions** section:  

    [!code-console[Main](install-the-sql-server-driver-for-php/samples/sample1.cmd)]
8. Click **Start**, and select the *search field*.
9. Type **iisreset**, and then press ENTER.

## Configure the Driver

1. Retrieve the driver's current configuration settings using the sqlsrv\_get\_config function.
2. Change the configuration settings using the sqlsrv\_configure function, or set values for the configuration settings in the php.ini file.
3. Ensure that the driver is loaded and verify the configuration settings by running a script that calls the phpinfo() function:  

    1. Open a text file, and copy the following code into it:  

        [!code-xml[Main](install-the-sql-server-driver-for-php/samples/sample2.xml)]
    2. Save the file as **info.php** in your Web server's root directory.
    3. Open a browser, and go to [http://localhost/info.php](http://localhost/info.php).
    4. Scroll down the resulting page to find the **sqlsrv** section. Confirm that the driver is loaded and the configuration settings are set to the default values (see Figure 1).  

        [![](install-the-sql-server-driver-for-php/_static/image2.jpg)](install-the-sql-server-driver-for-php/_static/image1.jpg)

        *Figure 1: SQL Server configuration settings page*

## Create a Connection to the Database

The sqlsrv\_connect function is used to establish a connection to the server.

By default, the **sqlsrv\_connect** function uses Windows authentication to establish a connection. In most scenarios, this means that the Web server's process identity or thread identity (if the Web server is using impersonation) is used to connect to the server, not a user's identity.

For more details on sqlsrv\_connect, see: [SQL Server Developer Center](https://msdn.microsoft.com/en-us/library/cc296161(SQL.90).aspx).

## Links for Further Information

- [PHP on Windows Training Kit (August 2009).](https://www.microsoft.com/downloads/details.aspx?familyid=C8498C9B-A85A-4AFA-90C0-593D0E4850CB&amp;displaylang=en)
- [SQL Azure Team Blog](https://blogs.msdn.com/ssds/default.aspx).
- [SQL Server Driver for PHP 1.1 - October 2009](https://www.microsoft.com/downloads/details.aspx?FamilyID=ccdf728b-1ea0-48a8-a84a-5052214caad9&amp;displaylang=en).
- [Microsoft SQL Server Driver for PHP team blog](https://blogs.msdn.com/sqlphp/default.aspx).
- [New SQL Server Driver for PHP Whitepaper](https://blogs.msdn.com/sqlphp/archive/2008/08/29/new-sql-server-driver-for-php-whitepaper-available.aspx).
- [SQL Server Driver for PHP example application](https://msdn.microsoft.com/en-us/library/cc296196(SQL.90).aspx).
- [php.net](http://php.net/).
- [Accessing SQL Server Databases with PHP](https://msdn.microsoft.com/en-us/library/cc793139(SQL.90).aspx)
- [Programming Tasks](https://technet.microsoft.com/en-us/library/cc644935(SQL.90).aspx).
- [Introducing the SQL Server Driver for PHP](https://msdn.microsoft.com/en-us/library/cc296172(SQL.90).aspx).