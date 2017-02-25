---
title: "Planning Step 1: Plan IIS Web Server and ASP.NET Modules Installation | Microsoft Docs"
author: rick-anderson
description: "The first step in planning to build an ASP.NET website on IIS 8 is to install IIS along with the ASP.NET modules and to add your application files to IIS."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/scenario-build-an-aspnet-website-on-iis/planning-step-1-plan-iis-web-server-and-asp-net-modules-installation
msc.type: authoredcontent
---
Planning Step 1: Plan IIS Web Server and ASP.NET Modules Installation
====================
by Keith Newman and Robert McMurray

The first step in planning to build an ASP.NET website on IIS 8 is to install IIS along with the ASP.NET modules and to add your application files to IIS.

The following list shows the tasks required to complete this step:

- [1.1. Plan to Install IIS and ASP.NET Modules](#11)
- [1.2. Plan to Add the ASP.NET Application](#12)

When you are done with these tasks, record your design decisions before going on to [Step 2: Plan ASP.NET Settings](planning-step-2-plan-asp-net-settings.md).

<a id="11"></a>
## 1.1. Plan to Install IIS and ASP.NET Modules

An ASP.NET Web server is an extended IIS server that has the ASP.NET runtime extensibility model integrated into the core server. The ASP.NET server configuration adds the following IIS modules to the default IIS web server installation:

- ASP.NET 4.5
- .NET Extensibility 4.5
- ISAPI Extensions
- ISAPI Filters

**Important**: To install IIS 8 on either Windows Server® 2012 or Windows® 8, you must sign on as a member of the Administrators group.

By default, Windows Server 2012 and Windows 8 installs .NET 4.5 only. If you want to run .NET 2 applications, install .NET 3.5, which supports web applications written using ASP.NET 2 to 3.5.

<a id="12"></a>
## 1.2. Plan to Add the ASP.NET Application

An application is a grouping of content at the root level of a website or a grouping of content in a separate folder under the website root directory. When you add an application in IIS 8, you designate a directory as the *application root*, or starting point, for the application. Then specify properties specific to that particular application, such as the application pool that the application runs in.

To configure your ASP.NET application on an IIS website, provide the following information:

- **Alias**: The alias is used as part of the application root URL and should be short and descriptive. For example, the alias *marketing* added to Default Web Site on the local host computer, would produce the following URL: `//localhost/marketing`.
- **Application pool**: An application pool enables an application or a group of applications to run in isolation from one or more applications in another application pool.
- **Physical path**: The local path to the application files on the server.

## See Also

- [Step 2: Plan ASP.NET Settings](planning-step-2-plan-asp-net-settings.md)
- [Plan an ASP.NET Website on IIS](plan-an-asp-net-website-on-iis.md)
- [Build an ASP.NET Website on IIS](overview-build-an-asp-net-website-on-iis.md)
- [Step 1: Install IIS and ASP.NET Modules](configuring-step-1-install-iis-and-asp-net-modules.md)