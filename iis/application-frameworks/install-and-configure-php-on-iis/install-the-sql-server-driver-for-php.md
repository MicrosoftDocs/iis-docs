---
title: "Install the Microsoft Drivers for PHP for SQL Server"
author: david-puglielli
description: "Introduction The Microsoft Drivers for PHP for SQL Server are designed to enable reliable, scalable integration with SQL Server for PHP applications on..."
ms.date: "02/06/2020"
ms.assetid: 2e1b4523-a32f-4390-bf9f-552f21ecc93b
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/install-the-sql-server-driver-for-php
msc.type: authoredcontent
---
Install the Microsoft Drivers for PHP for SQL Server
====================
by Tali Smith

## Introduction

The Microsoft Drivers for PHP for SQL Server are designed to enable reliable, scalable integration with SQL Server for PHP applications on Windows, Linux, and macOS platforms. The drivers are PHP extensions that allow reading from and writing to SQL Server databases in all editions of SQL Server (including Express editions) within PHP scripts. Two drivers are available: The SQLSRV driver provides a procedural interface for interacting with SQL Server. The PDO_SQLSRV driver implements PHP's object-oriented PDO interface for working with databases. 

The drivers' application programming interface (API) includes support for Active Directory authentication, transactions, parameter binding, streaming, metadata access, Unicode data handling, and error handling. The drivers rely on the Microsoft ODBC Driver for SQL Server to communicate with SQL Server. The drivers also support Microsoft SQL Azure Database, enabling developers to build PHP applications with relational capabilities using SQL Azure Database. 

The Microsoft Drivers for PHP for SQL Server download is freely available to all SQL Server users. Releases and source code for the drivers are available from the [Github project page](https://github.com/microsoft/msphpsql). Full documentation for the drivers is available on [Microsoft Docs](https://docs.microsoft.com/sql/connect/php/microsoft-php-driver-for-sql-server?view=sql-server-2017); what follows is a brief overview of installation and configuration on Windows and IIS.

## System Requirements

Full details on the system requirements for all supported versions of the driver can be found on the [system requirements page](https://docs.microsoft.com/sql/connect/php/system-requirements-for-the-php-sql-driver?view=sql-server-2017). The following software is required:

- On the client machine:
  - A supported Windows, Linux, or macOS operating system
  - A supported version of PHP
  - A supported version of the Microsoft ODBC Driver for SQL Server
  - A Web server configured to run PHP
- On the server:
  - A supported version of SQL Server or Azure SQL Database

## Install the Drivers

The Microsoft Drivers for PHP for SQL Server can be installed using the [Web Platform Installer](https://www.microsoft.com/web/downloads/platform.aspx). To download and install the drivers manually instead, perform the following steps:

1. Download and run the installation package from the appropriate link on the [download page](https://docs.microsoft.com/sql/connect/php/download-drivers-php-sql-server?view=sql-server-2017).
2. Enter a directory to extract the package into when prompted. 
3. Open the directory you chose in step 3 and copy the required dll libraries to your PHP extension directory. The filenames indicate which PHP version, threadedness, and architecture each dll file is for. For example, `php_sqlsrv_73_ts_x64.dll` is the 64-bit SQLSRV driver for thread-safe (ts) PHP 7.3.
4. Download and install the Microsoft ODBC Driver for SQL Server from the appropriate link on the [ODBC download page](https://docs.microsoft.com/sql/connect/odbc/download-odbc-driver-for-sql-server?view=sql-server-2017).
5. Edit your `php.ini` file to add the following lines in the `Extensions` section:  

    [!code-console[Main](install-the-sql-server-driver-for-php/samples/sample1.cmd)]

    Substitute the names of the files you copied to your PHP extension directory as required. Full instructions for loading the drivers can be found [here](https://docs.microsoft.com/sql/connect/php/loading-the-php-sql-driver?view=sql-server-2017).
6. Start a command prompt as administrator and run `iisreset` to restart your IIS server.

## Configure the Drivers

1. Retrieve the current configuration settings for the SQLSRV driver using the [`sqlsrv_get_config` function](https://docs.microsoft.com/sql/connect/php/sqlsrv-get-config?view=sql-server-2017), or for the PDO_SQLSRV driver using the [`PDO::getAttribute` function](https://docs.microsoft.com/sql/connect/php/pdo-getattribute?view=sql-server-2017).
2. Change the configuration settings for the SQLSRV driver using the [`sqlsrv_configure` function](https://docs.microsoft.com/sql/connect/php/sqlsrv-configure?view=sql-server-2017), or for the PDO_SQLSRV driver using the [`PDO::setAttribute` function](https://docs.microsoft.com/sql/connect/php/pdo-setattribute?view=sql-server-2017).
3. Ensure that the drivers are loaded and verify the configuration settings by running a script that calls the phpinfo() function:  

    1. Open a text file, and copy the following code into it:  

        [!code-xml[Main](install-the-sql-server-driver-for-php/samples/sample2.xml)]
    2. Save the file as `info.php` in the IIS root directory.
    3. Open a browser, and go to [http://localhost/info.php](http://localhost/info.php).
    4. Scroll down the resulting page to find the `sqlsrv` and `pdo_sqlsrv` sections. Confirm that the drivers are loaded and the configuration settings are set to the default values (see Figure 1).  

        [![](install-the-sql-server-driver-for-php/_static/image2.jpg)](install-the-sql-server-driver-for-php/_static/image1.jpg)

        *Figure 1: SQL Server configuration settings page*

## Create a Connection to the Database

When using the SQLSRV driver, the [`sqlsrv_connect()` function](https://docs.microsoft.com/sql/connect/php/sqlsrv-connect?view=sql-server-2017) is used to establish a connection to the server. When using the PDO_SQLSRV driver, the [`PDO::__construct` function](https://docs.microsoft.com/sql/connect/php/pdo-construct?view=sql-server-2017) is used to establish a connection to the server.

Connections can be made using [Windows authentication](https://docs.microsoft.com/sql/connect/php/how-to-connect-using-windows-authentication?view=sql-server-2017), [SQL Server authentication](https://docs.microsoft.com/sql/connect/php/how-to-connect-using-sql-server-authentication?view=sql-server-2017), or [Azure Active Directory authentication](https://docs.microsoft.com/sql/connect/php/azure-active-directory?view=sql-server-2017). The default is to use Windows authentication. In most scenarios, this means that the Web server's process identity or thread identity (if the Web server is using impersonation) is used to connect to the server, not a user's identity.

## Links for Further Information

- [Microsoft Drivers for PHP for SQL Server](https://github.com/microsoft/msphpsql)
- [Download the Microsoft Drivers for PHP for SQL Server](https://docs.microsoft.com/sql/connect/php/download-drivers-php-sql-server?view=sql-server-2017)
- [Overview of the Microsoft Drivers for PHP for SQL Server](https://docs.microsoft.com/sql/connect/php/overview-of-the-php-sql-driver?view=sql-server-2017)
- [Programming Guide](https://docs.microsoft.com/sql/connect/php/programming-guide-for-php-sql-driver?view=sql-server-2017)
- [SQLSRV Example Application](https://docs.microsoft.com/sql/connect/php/example-application-sqlsrv-driver?view=sql-server-2017)
- [PDO_SQLSRV Example Application](https://docs.microsoft.com/sql/connect/php/example-application-pdo-sqlsrv-driver?view=sql-server-2017)
- [PHP Homepage](http://php.net/)
- [Whitepaper: Accessing SQL Server Databases with PHP](https://social.technet.microsoft.com/wiki/contents/articles/1258.accessing-sql-server-databases-from-php.aspx)
- [Drivers for SQL Server Team Blog](https://techcommunity.microsoft.com/t5/SQL-Server/bg-p/SQLServer/label-name/SQLServerDrivers)
- [SQL Azure Team Blog](https://techcommunity.microsoft.com/t5/Azure-SQL-Database/bg-p/Azure-SQL-Database)
