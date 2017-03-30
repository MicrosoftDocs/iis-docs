---
title: "Setting Up a Database for a PHP Application on IIS | Microsoft Docs"
author: rick-anderson
description: "SQL Server is a database built and supported by Microsoft. Many PHP applications support SQL Server as their back end data repository. These instructions ass..."
ms.author: iiscontent
manager: soshir
ms.date: 01/14/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/setting-up-a-database-for-a-php-application-on-iis
msc.type: authoredcontent
---
Setting Up a Database for a PHP Application on IIS
====================
by Eric Woersching

## Set Up a SQL Server Database from Microsoft SQL Server Management Studio Express

SQL Server is a database built and supported by Microsoft. Many PHP applications support SQL Server as their back end data repository. These instructions assume that you already have SQL Server installed and running. For this walkthrough, we used SQL Server® 2005. You can also use MySQL, SQL Server® Express or others.

Before starting the install, create a database on your database server. Also create a user and grant this user ownership permission to the database. If you are using SQL Server 2005, then open Microsoft SQL Server Management Studio and click "New Query" button. Enter the following script into the query window (this script creates the database and user).


[!code-sql[Main](setting-up-a-database-for-a-php-application-on-iis/samples/sample1.sql)]


In addition, grant the newly created user the db\_owner permissions to my\_DB database:

[![](setting-up-a-database-for-a-php-application-on-iis/_static/image3.jpg)](setting-up-a-database-for-a-php-application-on-iis/_static/image1.jpg)

## Setup a MySQL Database from the Command Line

MySQL is a popular database supported by most PHP applications as their back end data repository. These instructions assume that you already have MySQL installed and running.

Before starting the installation procedure for your PHP application, create a database on your server. Also create a database user and grant this user ownership permission to the database. First, log on to your MySQL server with a command similar to the following (you must log on with an account with admin privileges; in our case 'root'):


[!code-console[Main](setting-up-a-database-for-a-php-application-on-iis/samples/sample2.cmd)]


You then must provide the password to your root or admin account on the MySQL server.

Next, create a database for the your application at the MySQL prompt after logging in:

[!code-unknown[Main](setting-up-a-database-for-a-php-application-on-iis/samples/sample-127386-3.unknown)]

To create the database, download the MySql GUI-Tools from: [http://dev.mysql.com/downloads/gui-tools/5.0.html](http://dev.mysql.com/downloads/gui-tools/5.0.html). Then you can create the database using a simple "**create database cslh**" command using the MySQL Query Browser. 

Next, create the account that will be used with your PHP application to access this particular database:


[!code-unknown[Main](setting-up-a-database-for-a-php-application-on-iis/samples/sample-127386-4.unknown)]


This command creates the account, sets the password, and sets the privileges all in one line:

- **GRANT ALL PRIVILEGES** **ON my\_DB.\*** - This statement says to allow all privileges for the account but only for the 'my\_DB' database and all of its tables.
- **TO 'my\_DBuser'@'%'** - This statement specifies the account name and which machines can login with this account. In this case, 'my\_DBuser' is the name of the account that will be created and '%' means that you can login to the account from anywhere. If '%' was replaced with localhost or a specific IP address you could only login to the database from that location.
- **IDENTIFIED BY 'my\_DBpass';** - This statement sets the password for the account to 'my\_DBpass' and ends the entire command with a semi-colon.

> [!NOTE]
> Refer to the MySQL documentation for more complete information on managing user accounts and privileges.