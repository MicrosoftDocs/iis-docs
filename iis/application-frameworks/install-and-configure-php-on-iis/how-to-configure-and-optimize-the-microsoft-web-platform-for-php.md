---
title: "How to Configure and Optimize the Microsoft Web Platform for PHP | Microsoft Docs"
author: rick-anderson
description: "There are various steps you can take to optimize Windows Server ® 2008 R2 or Windows Server ® 2008, Internet Information Services 7 (IIS 7) and above, and Fa..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/how-to-configure-and-optimize-the-microsoft-web-platform-for-php
msc.type: authoredcontent
---
How to Configure and Optimize the Microsoft Web Platform for PHP
====================
by Tali Smith

There are various steps you can take to optimize Windows Server® 2008 R2 or Windows Server® 2008, Internet Information Services 7 (IIS 7) and above, and FastCGI performance for your Web workloads and PHP applications. These include:

- [Use the Windows Cache Extension](use-the-windows-cache-extension-for-php.md). The Windows Cache Extension for PHP is a PHP accelerator that is used to significantly increase the speed of PHP applications running on the Windows® operating system. PHP applications can take advantage of the functionality provided by the Windows Cache Extension for PHP without code modifications.
- [Configure IIS 7 and Above Output Caching](../../manage/managing-performance-settings/configure-iis-7-output-caching.md). This feature can cache dynamic PHP content in memory so that the script used to generate the dynamic output does not need to run for each request.See also [Walkthrough: IIS 7.0 and Above Output Caching](../../manage/managing-performance-settings/walkthrough-iis-output-caching.md) and [Videocast: Improving Performance with Native Output Caching](../../manage/managing-performance-settings/improving-performance-with-native-output-caching.md).
- [Configure PHP Recycling Behavior](../running-php-applications-on-iis/configure-php-process-recycling-behavior.md). Make sure FastCGI always recycles the Php-cgi.exe processes before the native PHP recycling starts.
- [Enable Per-Site PHP Configuration for PHP on IIS 6.0 and IIS 7 and Above](enable-per-site-php-configuration-on-iis-60-and-iis-7-and-above.md). This feature is particularly important in a shared hosting environment, letting customers control PHP configuration.
- [Configure SMTP E-Mail in IIS 7 and Above](configure-smtp-e-mail-in-iis-7-and-above.md). Configure Simple Mail Transfer Protocol (SMTP) e-mail in IIS when you want to deliver e-mail messages from your site. Mail can be delivered immediately or it can be delivered to a file location on disk where it can be retrieved for delivery later.
- [Create a Separate Site or Virtual Directory for PHP Content](create-a-separate-site-or-virtual-directory-for-php-content.md). Self-hosters or very small hosters may need create a separate site or virtual directory to host their PHP content on a system that is also used for other workloads.

[Best Practices for PHP on the Microsoft Web Platform](../running-php-applications-on-iis/best-practices-for-php-on-the-microsoft-web-platform.md) provides a summary of additional steps you can take.

[Discuss in IIS Forums](https://forums.iis.net/1102.aspx)