---
title: "Planning Step 1: Plan IIS Web Server and PHP Installation | Microsoft Docs"
author: rmcmurray
description: "The first step in planning to build a PHP website on IIS 8 is to determine how to install IIS along with the CGI module, where to download and install the ap..."
ms.author: iiscontent
manager: soshir
ms.date: 04/14/2013
ms.topic: article
ms.assetid: b484d7e9-eedf-4ea3-90be-5c14a0f5201d
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/scenario-build-a-php-website-on-iis/planning-step-1-plan-iis-web-server-and-php-installation
msc.type: authoredcontent
---
Planning Step 1: Plan IIS Web Server and PHP Installation
====================
by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

The first step in planning to build a PHP website on IIS 8 is to determine how to install IIS along with the CGI module, where to download and install the appropriate PHP version, and how to add your application files to IIS.

The following list shows the tasks required to complete this step:

- [1.1. Plan to Install IIS](#11)
- [1.2. Plan to Download and Install PHP](#12)
- [1.3. Plan to Add a PHP Application](#13)

When you are done with these tasks, record your design decisions before going on to [Step 2: Plan PHP Settings](planning-step-2-plan-php-settings.md).

<a id="11"></a>
## 1.1. Plan to Install IIS

To support PHP applications on an IIS web server, install the default configuration of IIS and the CGI module. The CGI module contains both CGI (Common Gateway Interface protocol) and FastCGI. FastCGI is a high-performance extension to CGI and is recommended for PHP applications. Once your machine has this IIS configuration installed, you can download and install PHP.

**Important**: To install IIS 8 on either Windows Server® 2012 or Windows® 8, you must sign on as a member of the Administrators group.

<a id="12"></a>
## 1.2. Plan to Download and Install PHP

The simplest way to install PHP is to use Web Platform Installer (Web PI). Web PI installs the latest version of PHP along with any dependencies that version requires. To learn more about the Web PI, see [Learn More and Install the Web PI](https://go.microsoft.com/fwlink/?LinkID=145510).

To add PHP support manually to your IIS web server, download and install the PHP runtime version that you require. You can download Windows versions of PHP from the [PHP for Windows](http://windows.php.net/) site.

There are two builds for each PHP version: one is thread-safe, and the other is non-thread-safe. The thread-safe version is designed for environments where the web server keeps the PHP engine in memory, running multiple treads of execution simultaneously. The architecture of IIS and the FastCGI extension provide an isolation model that keeps requests separate, removing the need for a thread-safe version of PHP. The non-thread-safe version of PHP gives better performance on IIS with FastCGI install than does the tread-safe version.

PHP offers several extensions that extend its base functionality. One extension is important for PHP web applications that run on IIS-the Windows Cache Extension for PHP (WinCache). WinCache is a PHP accelerator that is used to increase the speed of PHP applications that run on Windows and Windows Server. Once the WinCache is enabled and loaded by the PHP engine, PHP applications can take advantage of the functionality without any code modifications.

You can download WinCache extension from the [PHP for Windows](http://windows.php.net/) site.

<a id="13"></a>
## 1.3. Plan to Add a PHP Application

An application is a grouping of content at the root level of a website or a grouping of content in a separate folder under the website root directory. When you add an application in IIS 8, you designate a directory as the *application root*, or starting point, for the application. Then specify properties specific to that particular application, such as the application pool that the application runs in.

To configure your PHP application on an IIS website, provide the following information:

- **Alias**: The alias is used as part of the application root URL and should be short and descriptive. For example, the alias *marketing* added to the default website on the local host computer, would produce the following URL: `//localhost/marketing`.
- **Application pool**: An application pool enables an application or a group of applications to run in isolation from one or more applications in another application pool.
- **Physical path**: The local path to the application files on the server.

## See Also

- [Plan a PHP Website on IIS](plan-a-php-website-on-iis.md)
- [Step 1: Install IIS and PHP](configuring-step-1-install-iis-and-php.md)
- [Step 2: Plan PHP Settings](planning-step-2-plan-php-settings.md)
- [Step 3: Plan PHP Application Security](planning-step-3-plan-php-application-security.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)