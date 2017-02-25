---
title: "Enable FastCGI Support in IIS 7 on Windows Server 2008, Windows Server 2008 R2, Windows Vista, or Windows 7 | Microsoft Docs"
author: rick-anderson
description: "Introduction Internet Information Services 7 (IIS 7) and above comes with extended support for application frameworks through FastCGI, an open protocol suppo..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/enable-fastcgi-support-in-iis-7-on-windows-server-2008-windows-server-2008-r2-windows-vista-or-windows-7
msc.type: authoredcontent
---
Enable FastCGI Support in IIS 7 on Windows Server 2008, Windows Server 2008 R2, Windows Vista, or Windows 7
====================
by Tali Smith

## Introduction

Internet Information Services 7 (IIS 7) and above comes with extended support for application frameworks through FastCGI, an open protocol supported by many open-source application frameworks that otherwise may not support stable and high-performance native integration with IIS.FastCGI provides a high-performance alternative to the Common Gateway Interface (CGI), a standard way for external applications to interface with Web servers that has been supported as part of the IIS feature set since the first release.

For example, PHP traditionally runs on IIS either as an ISAPI extension or as a CGI program. CGI programs are executables launched by the Web server to output dynamic information; CGI applications run in a separate process that is created at the start of each request and terminated at the end. The "one process per request" model makes CGI programs simple to implement but can limit efficiency and scalability. ISAPI extensions execute inside the IIS worker process on multiple threads.

FastCGI lets a single, long-running process handle multiple user requests; it retains the simplicity of the CGI programming model while eliminating much of the overhead. FastCGI addresses the performance issues inherent in CGI by providing a mechanism to reuse a single process over and over again for many requests. Additionally, FastCGI maintains compatibility with non-thread-safe libraries by providing a pool of reusable processes and ensuring that each process handles only one request at a time.

The FastCGI module lets PHP developers get dramatically better performance, scalability, and reliability when running on Windows® operating systems. The FastCGI module also enables easy integration with the new features of IIS (such as the new output caching features) and with Microsoft® ASP.NET.

## Before You Begin

Windows Server® 2008 R2, Windows Server® 2008, Windows Vista®, or Windows® 7, and IIS 7 or above must be installed.

## Enable FastCGI Support

1. Add the CGI role service by going to **Server Manager** &gt; **Roles** &gt; **Add Role Services**.

2. Under **Application Development**, select the **CGI** check box. This enables both the CGI and FastCGI services (selecting CGI enables both CGI and FastCGI).

![](enable-fastcgi-support-in-iis-7-on-windows-server-2008-windows-server-2008-r2-windows-vista-or-windows-7/_static/image3.jpg)


###### Figure 1: Select Role Services page

3. Confirm the selections on the **Confirm Installation Selection** page, and then click **Install**.

4. The **Installation Results** page shows that the installation succeeded. Click **Close**.

5. The CGI role service appears under the IIS panel.

## Enable FastCGI Support in Windows 7 and Windows Vista SP1

IIS 7.0 for Windows Vista® Service Pack 1 (SP1) includes a built-in FastCGI component. (Note that IIS 7.0 included in Windows Vista without SP1 does *not*include FastCGI component.) To get FastCGI support on IIS 7.0 in Windows Vista, you must upgrade to Windows Vista SP1.

The steps to enable FastCGI in Windows 7 are similar.

1. Add the CGI role service by going to **Control Panel** &gt; **Programs and Features** &gt; **Turn Windows features on or off.**

[![](enable-fastcgi-support-in-iis-7-on-windows-server-2008-windows-server-2008-r2-windows-vista-or-windows-7/_static/image5.jpg)](enable-fastcgi-support-in-iis-7-on-windows-server-2008-windows-server-2008-r2-windows-vista-or-windows-7/_static/image4.jpg)


###### Figure 2: Windows Features page

## Install the Update for FastCGI Module

The update for the IIS FastCGI module fixes several known compatibility issues with popular PHP applications. Install the update from one of the following locations:

- [Update for Windows Server 2008](https://www.microsoft.com/downloads/details.aspx?FamilyID=d0343911-1775-4aef-8c99-5f13862ac386&amp;DisplayLang=en)
- [Update for Windows Server 2008 x64 Edition](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=3&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3d70278393-3291-4aa1-870b-0e9b0907bddf%26DisplayLang%3den)
- [Update for Windows Server 2008 for Itanium-based Systems](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=5&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3d98e06637-0f00-45d5-83c5-ed1b41fd6a7b%26DisplayLang%3den)
- [Update for Windows Vista SP1](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=2&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3d19600729-8470-4956-a276-200450d814bd%26DisplayLang%3den)
- [Update for Windows Vista SP1 for x64 based Systems](https://www.microsoft.com/downloads/info.aspx?na=22&amp;p=4&amp;SrcDisplayLang=en&amp;SrcCategoryId=&amp;SrcFamilyId=&amp;u=%2fdownloads%2fdetails.aspx%3fFamilyID%3dc7066c3b-dcf7-4441-87bc-f7dcb51067d0%26DisplayLang%3den)

## Install the Administration Pack for IIS 7.0 and Above

> [!NOTE]
> This step is optional.

The [IIS 7.0 Administration Pack](../../../downloads/microsoft/administration-pack.md) adds to the set of management features that ship with IIS to include Administration UI support for ASP.NET authorization, custom errors, FastCGI configuration, request filtering, and much more. The Administration Pack also provides a generic configuration editor that is capable of setting any IIS configuration setting and automatically generating scripts to make the task easily repeatable.


> [!NOTE]
> *This article uses information from: "[Using FasCGI to Host PHP Applications on IIS 7.0 and Above](../install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis.md#InstallPHP)" by Ruslan Yakushev, published on December 5, 2007**.*


## Links for Further Information

[Enabling FastCGI on IIS 7](https://technet.microsoft.com/en-us/library/cc753077(WS.10).aspx).

[Setting up FastCGI for PHP](../running-php-applications-on-iis/set-up-fastcgi-for-php.md).

[Installing FastCGI Support On Server Core](install-php-and-fastcgi-support-on-server-core.md).
  
  
[Discuss in IIS Forums](https://forums.iis.net/1102.aspx)