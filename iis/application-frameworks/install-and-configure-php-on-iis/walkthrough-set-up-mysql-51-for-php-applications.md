---
title: "Walkthrough - Set Up MySQL 5.1 for PHP applications"
author: ruslany
description: "Overview This article provides a basic step by step guide on how to install and configure MySQL on the Windows Operating System. For more detailed instructio..."
ms.date: 03/18/2009
ms.assetid: 361e07d9-1737-4f84-890b-406bd8c51506
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/walkthrough-set-up-mysql-51-for-php-applications
msc.type: authoredcontent
---
# Walkthrough - Set Up MySQL 5.1 for PHP applications

by [Ruslan Yakushev](https://github.com/ruslany)

## Overview

This article provides a basic step by step guide on how to install and configure MySQL on the Windows Operating System. For more detailed instructions about installing and configuring MySQL on Windows refer to the [official MySQL documentation](http://dev.mysql.com/doc/refman/5.1/en/windows-installation.html).

## Downloading and Installing MySQL

The MySQL binaries and installer can be downloaded from the [official MySQL site](http://dev.mysql.com/downloads/mysql/5.1.html). The instructions in this article are based on MySQL version 5.1 Community Edition installed with the Windows MSI installer.

Run the installer and choose the installation option. For a majority of the cases, the typical installation is sufficient:

![Screenshot of the My S Q L Setup Wizard screen with the Typical Setup type selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image2.png)

However, if you want to control which components get installed or if you want to use a non-default installation path then choose the "Custom" option.

When the installation is complete, make sure to check the box to "Configure the MySQL Server now". This will launch the "MySQL Server Instance Configuration Wizard" that will guide you through the configuration process for the MySQL instance.

![Screenshot of the My S Q L Server Setup Wizard on the Wizard Completed page.](walkthrough-set-up-mysql-51-for-php-applications/_static/image4.png)

## Configuring MySQL instance

Follow these steps in the "MySQL Server Instance Configuration Wizard" to optimize the MySQL configuration for the kind of tasks you expect it to perform.

On the first page of the wizard choose "Detailed Configuration":

![Screenshot of the My S Q L Server Instance Configuration Wizard on the configuration type page. The Detailed Configuration type is selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image6.png)

On the next page choose the server type option:

![Screenshot of the My S Q L Server Instance Configuration Wizard on the server instance page. The Developer Machine option is selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image8.png)

Choose the "Database Usage" option:

![Screenshot of the My S Q L Server Instance Configuation Wizard on the database usage page. Non-Transactional Database Only is selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image10.png)

The Database usage options control what kind of database storage engine is used on the server:

- MyISAM – Optimized for high performance SELECT operations. It has low overhead in terms of memory usage and disk utilization, but at the cost of not supporting transactions
- InnoDB – Provides fully ACID transactional capabilities, but at the cost of more aggressive usage of disk space and memory

For an in-depth comparison of these database engines, refer to [MySQL Storage Engine Architecture](http://dev.mysql.com/tech-resources/articles/storage-engine/part_1.html). As a general recommendation – if the web applications on your server require multi-statement transactions, advanced isolation levels and row-level locking, foreign key constraints, or otherwise have a requirement for ACID features -- use InnoDB. Otherwise, use MyISAM.

Next choose the number of concurrent connections to the server:

![Screenshot of the My S Q L Server Instance Configuration Wizard on the concurrent connections page. Decision Support (D S S)/O L A P is selected. ](walkthrough-set-up-mysql-51-for-php-applications/_static/image12.png)

On the next page choose networking options :

![Screenshot of the My S Q L Server Instance Configuration Wizard on the networking options page. Enable T C P/I P Networking and Enable Strict Mode are selected. ](walkthrough-set-up-mysql-51-for-php-applications/_static/image14.png)

If you have mysql and web server on the same machine you may consider not enabling TCP/IP networking and instead use named pipes. Note though that some PHP applications may require TCP connection to MySQL. Refer to the application's documentation to confirm if it supports named pipes connection to MySQL.

Choose the default charset to use when creating new databases:

![Screenshot of the My S Q L Server Instance Configuration Wizard on the default character page. Standard Character Set is selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image16.png)

Next ensure that MySQL will be configured as a Windows Service:

![Screenshot of the My S Q L Server Instance Configuration Wizard on the Windows options page. Install as a Windows Service and Include Bin Directory in Windows Path are selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image18.png)

Optionally, you can add the MySQL Bin directory to the Windows PATH environment variable. That will make it easier to launch MySQL tools from the command line.

Finally provide the password for the database administrative account, which in called "root" in MySQL. Make sure that you leave the "Create an Anonymous Account" checkbox cleared:

![Screenshot of the My S Q L Server Instance Configuration Wizard on the security options page. Modify Security Settings is selected.](walkthrough-set-up-mysql-51-for-php-applications/_static/image20.png)

On the next page click "Execute" to apply all the configuration settings and to start the MySQL service:

![Screenshot of the My S Q L Server Instance Configuration Wizard completion page.](walkthrough-set-up-mysql-51-for-php-applications/_static/image22.png)

Now you can logon to MySQL by opening a command line window and typing:

[!code-console[Main](walkthrough-set-up-mysql-51-for-php-applications/samples/sample1.cmd)]

If MySQL was configured correctly then the MySQL prompt will be shown:

[!code-console[Main](walkthrough-set-up-mysql-51-for-php-applications/samples/sample2.cmd)]
