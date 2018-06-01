---
title: "Powerful Admin Tools"
author: shirhatti
description: "IIS includes a comprehensive set of administration tools, including administration and command-line tools, managed code and scripting APIs, and Windows PowerShell support to simplify day-to-day tasks for developers and administrators."
ms.author: soshir
ms.date: 3/6/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
Powerful Admin Tools
--------------------

IIS includes a comprehensive set of administration tools, including administration and command-line tools, managed code and scripting APIs, and Windows PowerShell support to simplify day-to-day tasks for developers and administrators.

## IIS Manager

![Enable Remote Connections](powerful-admin-tools/_static/enableremoteconnections-small.png) IIS Manager offers an efficient tool for managing the web server. The administration tool provides streamlined access to IIS and ASP.NET configuration settings, membership and user data, and runtime diagnostic information. The admin tool also enables those who host or administer Web sites to delegate administrative control to developers or content owners, thus reducing cost of ownership and administrative burden for the administrator. Other key features include:

*   [Remote administration](https://www.iis.net/downloads/microsoft/iis-manager) over HTTP/SSL
*   Support for both Windows and non-Windows credentials for delegated administration
*   A rich [extensibility framework](../develop/extending-the-management-ui.md) for plugging in new UI features using the .NET Framework
*   Automatic download and install of new UI modules to the client

## .NET Microsoft.Web.Administration

IIS includes the Microsoft.Web.Administration API for [programmatically administering](../manage/scripting/how-to-use-microsoftwebadministration.md) the web server. These managed code API makes it easy to programmatically provision, access important state and diagnostic information, or configure the server.

## Windows PowerShell

The [IIS Administration PowerShell cmdlets](https://docs.microsoft.com/powershell/module/iisadministration/?view=win10-ps) allow Web administrators and hosting providers to easily automate routine and complex IIS administration tasks such as creating Web sites, and managing configuration and run-time data using Windows PowerShell. Administrators can further increase productivity by leveraging the many cmdlets included with the Windows PowerShell Provider for IIS. The IIS Adminstration PowerShell cmdlets are available on Windows 10/Windows Server 2016 and higher. On older OSes, these cmdlets are available for download via the [PowerShell Gallery](https://www.powershellgallery.com/packages/IISAdministration/1.1.0.0).

## Command-line - AppCmd.exe

IIS supports a command line tool [AppCmd.exe](../get-started/getting-started-with-iis/getting-started-with-appcmdexe.md) \- for administering the server. This powerful utility makes it easy to read and write configuration values, and access site and application pool state information, all from the command prompt.

## Microsoft IIS Administration API

The [Microsoft IIS Administration API](https://docs.microsoft.com/iis-administration/) is REST API that enables customers to configures and monitor their IIS web server. With the API installed on a machine with IIS, one can configure an IIS instance with any HTTP client including the web management tool at [manage.iis.net](https://manage.iis.net/).
