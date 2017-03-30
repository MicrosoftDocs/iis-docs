---
title: "How to Develop on the Microsoft Web Platform | Microsoft Docs"
author: rick-anderson
description: "The Windows ® and Linux operating systems approach Web development in different ways. Linux is easily configured, and it lets enthusiasts get “under the hood..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/running-php-applications-on-iis/how-to-develop-on-the-microsoft-web-platform
msc.type: authoredcontent
---
How to Develop on the Microsoft Web Platform
====================
by Tali Smith

The Windows® and Linux operating systems approach Web development in different ways. Linux is easily configured, and it lets enthusiasts get "under the hood" and tweak every aspect of the environment. Scripting languages, with their ability to morph and adapt, can automate the tweaking of the system. In contrast, the Windows-based, Microsoft® Web Platform is not designed to be tweaked by going to bare metal. Instead, the system is monitored, controlled, and modified by using well-defined interfaces, plug-in boards, and so on. Scripting languages are most often used in Windows to drive systems through APIs not through the modification of configuration files. Understanding this difference in philosophy is key to the effective use of scripting languages on the Windows-based platform.

Until now, PHP developers may have written their applications on Windows, reaping the benefits of the intuitive user interfaces, but then used the open-source Linux-Apache-MySQL-PHP (LAMP) platform to run their applications. With FastCGI support native to Windows Server® 2008, and available as an extension for Windows Server® 2003, PHP developers now have a strong platform in Windows Server for both developing and running Web applications.

The following articles provide guidance for software developers using the Microsoft Web Platform:

- [Provision Web Sites for PHP Applications Using Managed Code](provision-web-sites-for-php-applications-using-managed-code.md). This article describes how to implement the provisioning aspect of features such as File Transfer Protocol (FTP) capabilities, creation of virtual directories, and the amount of disk space through C#.
- [Package an Application for the Windows® Web Application Gallery](../../develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery.md). This article describes how to prepare your application for the [Windows Web App Gallery](https://www.microsoft.com/web/gallery/).
- [Reference for the Web Application Package](../../develop/windows-web-application-gallery/reference-for-the-web-application-package.md). This article provides in-depth information to support the guidance in [Package an Application for the Windows Web Application Gallery](../../develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery.md).
- [Integrate the Windows Web Application Gallery in to a Control Panel](../../develop/windows-web-application-gallery/integrate-the-windows-web-application-gallery-into-a-control-panel.md). This article describes how you can integrate the Windows Web Application Gallery applications in your application.
- [Enable PHP Syntax Highlighting](enable-php-syntax-highlighting-on-iis-7-and-above.md). You can configure Internet Information Services 7 (IIS 7) and above to output syntax-highlighted source code for PHP files stored on the Web server or Web site. This feature can be very useful in development environments because you can quickly make the source code accessible to other team members.

Additional resources for developers can be found in:

- [Develop on IIS 7 and Above](develop-on-iis-7-and-above.md). This article provides links to information that is useful for software developers.