---
title: "How to Migrate to the Microsoft Web Platform | Microsoft Docs"
author: rick-anderson
description: "PHP is quite portable, and cross-platform development has been a major goal in its development. In most cases, PHP scripts are easily ported from Linux to th..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/migrate-to-the-microsoft-web-platform/how-to-migrate-to-the-microsoft-web-platform
msc.type: authoredcontent
---
How to Migrate to the Microsoft Web Platform
====================
by Tali Smith

PHP is quite portable, and cross-platform development has been a major goal in its development. In most cases, PHP scripts are easily ported from Linux to the Windows® operating system with very few problems. Microsoft has also produced a rich set of PHP migration documentation and a toolkit to assist in basic PHP application deployment; these are located on the Internet Information Services (IIS) Web site ([https://www.iis.net/](https://www.iis.net/)).

Many popular PHP applications that have been written on and currently run on the LAMP (Linux–Apache–MySQL–PHP) stack can be successfully migrated to a Windows-based stack (Windows–IIS–MySQL–PHP). The article [IIS for Apache Administrators](iis-for-apache-administrators.md) compares common IIS 7 and above tools and management scenarios with Apache tools and management scenarios. The SQL Server Driver for PHP can also make it possible to migrate applications to a Windows–IIS–SQL Server–PHP stack. This lets customers enjoy the convenience and familiarity of the Windows operating system.

There are also many other migration scenarios. You may want to migrate to a newer version of IIS, or you may want to migrate to Microsoft® SQL Server® 2008 from MySQL. The following articles can provide guidance for various migration scenarios:

- [Migrate to a Windows-Based Platform](migrate-to-a-windows-based-platform.md). Provides general migration guidance.
- [Import Apache mod\_rewrite Rules](../../extensions/url-rewrite-module/importing-apache-modrewrite-rules.md). Guides you through the process of converting Apache mod\_rewrite rules to IIS URL rewrite rules.
- [Migrate from MySQL to SQL Server 2008](migrate-from-mysql-to-sql-server-2008.md). Provides guidance on migrating from MySQL to SQL Server 2008.
- [Migrate from IIS 6.0 to IIS 7 or Above](../../publish/using-web-deploy/migrate-a-web-site-from-iis-60-to-iis-7-or-above.md). Helps you migrate a Web site from IIS 6.0 to IIS 7.0 or above using the Microsoft® Web Deployment Tool.