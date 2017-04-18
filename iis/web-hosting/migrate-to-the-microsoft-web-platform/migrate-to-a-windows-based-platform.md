---
title: "Migrate to a Windows-Based Platform | Microsoft Docs"
author: rick-anderson
description: "Microsoft embraces hosting PHP applications on the Windows ® operating system, both by building enabling technologies and by working with the PHP community t..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 98902a0b-c6f3-420b-b7e5-23afb2b640e8
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/migrate-to-the-microsoft-web-platform/migrate-to-a-windows-based-platform
msc.type: authoredcontent
---
Migrate to a Windows-Based Platform
====================
by Tali Smith

## Introduction

Microsoft embraces hosting PHP applications on the Windows® operating system, both by building enabling technologies and by working with the PHP community to ensure that popular PHP applications run well on the Windows platform. Customers appreciate the convenience of being able to run PHP applications on a Windows-based system because they are likely to have other computers running the operating system and are familiar with the user interface. The capabilities built into Windows Server® 2008, such as Internet Information Services 7 (IIS 7) and above, and FastCGI, make seamless operation of PHP applications possible. With the advent of the SQL Server Connector for PHP, users can add Microsoft® SQL Server® 2008 to the software stack if they desire, providing a top-to-bottom solution for PHP applications based on Microsoft® technology.

PHP is quite portable. Cross-platform development has been a major goal in the development of PHP since the days of version 3. In most cases, PHP scripts are easily ported from Linux to Windows with very few problems. Microsoft has also produced a rich set of PHP migration documentation and a toolkit to assist in basic PHP application deployment; these are located on the [IIS Web site](../../application-frameworks/install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis-60.md).

Many popular PHP applications that have been written on and currently run on the LAMP (Linux–Apache–MySQL–PHP) stack can be successfully migrated to a Windows-based stack (Windows–IIS–MySQL–PHP. The SQL Server Driver for PHP can also make it possible to migrate applications to a Windows–IIS–SQL Server–PHP) stack. This lets customers enjoy the convenience and familiarity of the Windows operating system.

Note that a Web site already hosted in the Apache/Windows environment takes less time to migrate than a Web site completely hosted in a LAMP (Linux, Apache, MySQL and PHP) environment. There are two types of migration processes (depending on the base operating system):

- Migration of a Web site from Apache on Linux to IIS 7 or above on Windows Server 2008 or Windows Server® 2008 R2.
- Migration of a Web site from Apache on Windows Server® 2003, Windows® 2000, or Windows® XP to IIS 7.0 or above on Windows Server 2008 or Windows Server 2008 R2.

<a id="_Toc221956168"></a>

## Basic Steps in Server Migration

The basic steps for migration of a PHP application from Linux to Windows are:

1. Plan your migration.
2. Install the Windows environment. Articles on the learn.iis.net Web site can step you through these procedures.
3. Migrate files. Migrating Web site files from one server to another can be done using the three different methods:  

    - Migrating files using Windows Sharing
    - Migrating files using File Transfer Protocol (FTP)
    - Migrating files using Hypertext Transfer Protocol (HTTP)
4. Move databases. The two methods for migrating databases from one server to another include:  

    - Migrating a database from MySQL on Windows Server 2003 to MySQL on Windows Server 2008 or Windows Server 2008 R2.
    - Migrating a database from MySQL on Linux to Microsoft® SQL Server® 2005 or Microsoft® SQL Server® 2008 on Windows Server 2008.
5. Update configurations.
6. Migrate applications.
7. Fine-tune any issues. See the [Troubleshoot](#_Troubleshoot) section below.

<a id="_Toc221956169"></a>

## Plan Your Migration

Before initiating the migration, it is important to plan ahead to effectively prepare for all of the issues that may occur during the migration process and to outline an overall migration framework and steps. Some of the issues to consider before you begin migration include:

- **Total time required for the migration**. The number of files (static HTML or PHP) and the number of tables and procedures have a significant impact on the overall time required to complete the migration, the type of migration process undertaken, and the database implemented.  
 A Web site consisting of a large number of PHP files and that has no centralized database management takes more time to migrate than a site using a centralized database configuration, because the aspects of the application, such as modifying queries and connection strings, need to be configured to work with the new database.  
 Similarly, a Web site with relatively high number of database tables may require modification of column types for the new database to run on SQL Server instead of MySQL.
- **Selection of database**. Databases can be migrated either from one MySQL instance of one server (Linux on Windows) to another MySQL instance of another server (Windows Server 2008 or Windows Server 2008 R2) or from MySQL on one server (Linux Windows) to SQL Server on another server (Windows Server 2008 or Windows Server 2008 R2).  
 Migrating data from MySQL to MySQL is simpler and more straightforward compared with migration from MySQL to SQL Server. Migration of data from MySQL to SQL Server requires migrating not just the tables and their fields, but the data types of the fields, indexes, keys, and others.   
 Migration of a database from MySQL to SQL Server also requires the installation of a MySQL Open Database Connectivity (ODBC) connector on Windows Server 2008. This driver helps create a link between the two types of database servers and facilitates the migration of tables. On the other hand, migrating data from MySQL on one server to MySQL on Windows Server 2008 does not require an ODBC driver.
- **Web site compatibility with IIS 7 and above and Windows Server 2008 or Windows Server 2008 R2**. The compatibility of an Apache-based Web site with IIS 7.0 and above and Windows Server 2008 or Windows Server 2008 R2 should be determined before proceeding with the actual migration. Web sites hosted on Apache and Linux have different dependencies compared with Web sites hosted on IIS 7 and above and Windows Server 2008 or Windows Server 2008 R2.

## Migration Considerations

Migration is easy, but you must test and fine-tune. Note that PHP, Apache HTTP server, and MySQL all run very well on Windows Server 2008 or Windows Server 2008 R2 and on the Server Core installation of Windows Server 2008 or Windows Server 2008 R2. You can easily replace Apache with IIS, and applications continue to run well. IIS stores a lot of configuration data in XML for easy editing, but unlike Apache, IIS can pick up changes dynamically without a restart of the system.

Consider the following information about how PHP interacts with Web servers:

- Php.ini settings on different servers can cause differences in how global variables are handled and what the PHP program accepts as legal PHP code.
- Many of the file system functions are Linux/UNIX-specific. Check each function in the PHP manual to find out whether or not the function works with Windows.
- Make sure that the parameters and file names you pass are case sensitive. Although you can set case sensitivity off in MySQL, most servers prefer to leave it on by default. On the Windows NT® version of MySQL, case sensitivity is off by default.

Currently, PHP uses more than 80 extensions, covering a wide range of services and functionality. Only about half of these extensions are available on both platforms. A handful of extensions, such as the Component Object Model (COM), Microsoft® .NET, and IIS extensions, are specific to Windows. If an extension you use in your scripts is not currently available for Windows, you must look at either porting that extension or converting your scripts to use functionality that is available for Windows.

Note that PHP has the following additional limitations:

- Support for XML is low compared to the Microsoft XML implementation. However, XML support has greatly improved under Windows as of PHP 4.3.11 and more recently PHP 5.0.4.
- Support for SOAP is low, though it has improved as of PHP 5.x.
- PHP cannot access the Windows registry.
- PHP does not include support for handling users and groups on Windows.
- PHP does not include full support for Unicode, as of version 4.0.5. However, Unicode in PHP works well as of version 4.3.x, especially with the mbstring extension. Using the Php.ini directive mbstring.func\_overload = 7 replaces all non-UTF-8 safe functions with the mbstring equivalent functions.

<a id="_Troubleshoot"></a>

## Troubleshoot

The following information may help you troubleshoot issues that you may encounter.

- The file transfer may require some "helper" applications:  

    - Smbclient is required for the Server Message Block (SMB) transfer.
    - The Net::FTP Perl module is required for FTP.
    - The Net::FTPSSL Perl module is required for FTP over Secure Sockets Layer (FTPS).
    - The Net::SFTP Perl module is required for SSH FTP (SFTP).
    - Openssh is required for the secure copy (SCP) transfer.
- If your PHP applications are timing out, you may be reaching the execution limit. Increase the value of max\_execution\_time in Php.ini.
- If your PHP applications are running out of memory, check the value of upload\_max\_filessize. Ensure that the value is adequate for your application.

> [!NOTE]
> : This article based on the white paper: "[Apache to IIS 7.0 Migration Guide](https://download.microsoft.com/download/2/D/8/2D863347-3AFF-48A6-9FCF-EC6554C18DCF/Apache%20to%20IIS%207%200%20Migration%20Guide.doc)" published in March, 2009.*

## Links for Further Information

[Linux-Apache-MySQL PHP Migration webcasts](http://blogs.technet.com/keithcombs/archive/2008/12/17/running-lamp-on-windows-server-2008-webcast-and-screencasts-now-available.aspx).

[Migrating Linux-Apache-MySQL-PHP to Windows 2000](https://www.microsoft.com/technet/archive/interopmigration/linux/mvc/miglamp.mspx?mfr=true.)