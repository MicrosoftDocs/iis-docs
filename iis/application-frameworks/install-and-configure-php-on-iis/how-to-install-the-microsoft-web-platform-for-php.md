---
title: "How to Install the Microsoft Web Platform for PHP"
author: rick-anderson
description: "Introduction Microsoft embraces hosting PHP applications on the Windows ® operating system, both by building enabling technologies and by working with the PH..."
ms.date: 11/15/2009
ms.assetid: 3deeba26-60a8-4277-a489-4acd5ae6486c
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/how-to-install-the-microsoft-web-platform-for-php
msc.type: authoredcontent
---
How to Install the Microsoft Web Platform for PHP
====================
by Tali Smith

## Introduction

Microsoft embraces hosting PHP applications on the Windows® operating system, both by building enabling technologies and by working with the PHP community to ensure that popular PHP applications run performantly on the Windows operating system. Customers appreciate the convenience and familiarity of the Windows operating system to run PHP applications. The capabilities built into Windows Server® 2008, such as Internet Information Services 7 (IIS 7) and above and FastCGI, make seamless operation of PHP applications possible. With the advent of the SQL Server Connector for PHP, users can add Microsoft® SQL Server® 2008 to the stack if they desire, providing a top-to-bottom solution for PHP applications based on Microsoft® technology.

The Microsoft® Web Platform provides advantages for PHP hosters, Web farm managers, self-hosters, server administrators, PHP application developers, and many others. PHP hosters can refer to the [Shared Hosting Guidance Content Map](../../web-hosting/getting-started/shared-hosting-content-map.md) for a wealth of articles and videos, including [Shared Hoster Configuration](../../web-hosting/planning-the-web-hosting-architecture/shared-hosting-configuration.md) and [Configuring a Web Farm Using IIS Shared Configuration](../../manage/managing-your-configuration-settings/configuring-a-web-farm-using-iis-shared-configuration.md).

To host PHP applications on the Microsoft® Web Platform, you must first set up the platform component.

## Install the Operating System

At the base of the Microsoft Web Platform is Windows Server 2008, Windows Server® 2008 R2, or another Windows Server® operating system version.

- [Install Windows Server 2008 and Windows Server 2008 R2](../../install/installing-iis-7/install-windows-server-2008-and-windows-server-2008-r2.md)

## Use Microsoft Web PI to Install the Microsoft Web Platform

The easiest way to install the rest of the Microsoft Web Platform is by using the Microsoft® Web Platform Installer (Web PI), a free tool that makes it easy to get the latest components of the Microsoft Web Platform, including Internet Information Services (IIS), Microsoft® SQL Server® Express, the Microsoft® .NET Framework, and Microsoft® Visual Web Developer. Web PI also makes it easy to install and run the most popular free Web applications for blogging, content management, and more with the built-in [Windows Web Application Gallery](https://www.microsoft.com/web/gallery/ "Windows Web Application Gallery").

- [Use the Microsoft Web Platform Installer](../../install/web-platform-installer/using-the-microsoft-web-platform-installer.md).

## Install the Microsoft Web Platform Manually

It is also possible to install IIS, PHP, and a database manually.

1. **Install and configure IIS.** IIS is the Web server role in the Windows Server operating systems. The following articles provide guidance in installing IIS:  

    - [Install IIS 7 and Above on Windows Server 2008 or Windows Server 2008 R2](../../install/installing-iis-7/installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md).
    - [Install IIS 7 and Above on Windows Vista® and Windows® 7](../../install/installing-iis-7/installing-iis-on-windows-vista-and-windows-7.md).
    - [Install and Configure IIS 7 and Above on Server Core](../../install/installing-iis-7/install-and-configure-iis-on-server-core.md).
2. **Install and configure PHP.**  

    The following articles provide guidance on installing PHP:

    - [Install and Configure PHP](install-and-configure-php.md).
    - [Install PHP and FastCGI Support on Server Core](install-php-and-fastcgi-support-on-server-core.md).
3. **Enable FastCGI support.** FastCGI is an open protocol supported by many open-source application frameworks that otherwise may not support stable and high-performance native integration with IIS. The following articles provide guidance in enabling FastCGI:  

    - [Enable FastCGI Support in IIS 7 and Above on Windows Server 2008, Windows Server 2008 R2. Windows Vista, or Windows 7](enable-fastcgi-support-in-iis-7-on-windows-server-2008-windows-server-2008-r2-windows-vista-or-windows-7.md).
    - [Install PHP and FastCGI Support on Server Core](install-php-and-fastcgi-support-on-server-core.md).
    - [Configure the FastCGI Extension for IIS 6.0](configuring-the-fastcgi-extension-for-iis-60.md).
    - [Videocast: Set Up FastCGI for PHP](../running-php-applications-on-iis/set-up-fastcgi-for-php.md).
4. **Install a database.** You can use either MySQL or SQL Server in the Microsoft Web Platform.  

    - [Install and Configure MySQL for PHP Applications on IIS 7 and Above](install-and-configure-mysql-for-php-applications-on-iis-7-and-above.md).
    - [Install and Configure SQL Server for PHP Applications on IIS 7 and Above](install-and-configure-sql-server-2008-for-php-applications-on-iis-7-and-above.md).

You are now ready to configure and optimize the Microsoft Web Platform.
