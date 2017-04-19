---
title: "Run Multiple Versions of PHP on IIS | Microsoft Docs"
author: rick-anderson
description: "The ability to run multiple versions of PHP on one Internet Information Services (IIS) server can provide advantages when using the Microsoft ® Web Platform...."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 48072e62-df8d-4278-866f-a68a4242e957
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/run-multiple-versions-of-php-on-iis
msc.type: authoredcontent
---
Run Multiple Versions of PHP on IIS
====================
by Tali Smith

## Introduction

The ability to run multiple versions of PHP on one Internet Information Services (IIS) server can provide advantages when using the Microsoft® Web Platform. Some PHP applications rely on functions or features that are available only in certain versions of PHP. If you want to host these applications on one server, you must run different PHP versions side by side. The ability to run multiple versions of PHP on one IIS server also lets you test the newest release of PHP before deploying it to your live Web sites.

The IIS FastCGI handler fully supports running multiple versions of PHP on the same server. You can either use a different extension for each PHP version (for example, .php406 and .php411), or you can use multiple sites with the same base directory and then map the .php extension to the different PHP versions. Note, however, that maintaining multiple instances of PHP means more administrative overhead and more complicated troubleshooting. It is important to consider the consequences carefully before adding extra PHP instances.

## Configure the Environment Variables

To run multiple versions of PHP on IIS, start by configuring the environment variables. For example, to use PHP 4 you must ensure that both the path to the PHP 4 root directory and the path to the dynamic-link libraries (DLLs) directory are included in your Path environment variable:

1. Right-click on **My Computer**.
2. Select **Properties**.
3. Click on the **Advanced** tab.
4. Click on the **Environment Variables** button.
5. In the **System Variables** pane, scroll down until you see the **Path** variable.
6. Select the **Path** variable, and then click the **Edit** button.
7. At the beginning of the **Variable Value** field, type the names of the full paths to the PHP 4 root directory and to the DLLs directory. The path names must be separated by a semicolon.  

    You must remove the PHPRC environment variable, because it tells PHP where to look for the Php.ini configuration file. If you have already set the PHPRC variable, follow the procedure above, but instead of editing the **Path** variable, select the **PHPRC** variable, and then press **Delete**.

## Create FastCGI Application Process Pools

Next, you create FastCGI application process pools. For example, suppose you want to support PHP 4.4.8, PHP 5.2.1, and PHP 5.2.5 non-thread-safe. Place the corresponding PHP binaries in separate folders on the file system (for example, `C:\php448\`, `C:\php521\` and `C:\php525nts`), and then create FastCGI application process pools for each PHP version:


[!code-console[Main](run-multiple-versions-of-php-on-iis/samples/sample1.cmd)]


If you have three Web sites (site1, site2, and site3) and each site must use a different PHP version, you can define handler mappings on each site to reference a corresponding FastCGI application process pool. Note that each FastCGI process pool is uniquely identified by a combination of fullPath and arguments properties.


[!code-console[Main](run-multiple-versions-of-php-on-iis/samples/sample2.cmd)]


> [!NOTE]
> *This article uses material from "[Using FastCGI to Host PHP Applications on IIS 7.0](../install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis.md)" published on June 26, 2009.*

## Links for Further Information

- [Using FastCGI to Host PHP Applications on IIS 7.0 and Above](../install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis.md). 
- [Another reason that IIS ROCKS and PHP is better on Microsoft Windows!](https://blogs.msdn.com/joestagner/archive/2005/10/30/487051.aspx)