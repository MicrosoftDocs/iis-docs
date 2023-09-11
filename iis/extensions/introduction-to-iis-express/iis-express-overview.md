---
title: "IIS Express Overview"
description: "IIS Express is a lightweight, self-contained version of IIS optimized for developers. IIS Express makes it easy to use the most current version of IIS to dev..."
ms.date: 07/06/2010
ms.assetid: 715ffb5e-1dcc-4b94-939d-0f326a1a2bb3
msc.legacyurl: /learn/extensions/introduction-to-iis-express/iis-express-overview
msc.type: authoredcontent
---
# IIS Express Overview

by Vaidy Gopalakrishnan

IIS Express is a lightweight, self-contained version of IIS optimized for developers. IIS Express makes it easy to use the most current version of IIS to develop and test websites. It has all the core capabilities of IIS 7 and above as well as additional features designed to ease website development including:

- It doesn't run as a service or require administrator user rights to perform most tasks.
- IIS Express works well with ASP.NET and PHP applications.
- Multiple users of IIS Express can work independently on the same computer.

<a id="Installation"></a>

## Installing IIS Express

The most current version of the product is IIS 10.0 Express. Most of you will want to use IIS Express with a web authoring tool that provides an integrated experience.

Visual Studio 2010 SP1 and later allow IIS Express used as the web server instead of Cassini. You can also manually configure IIS Express for other web authoring tools.

You can install the IIS 10.0 Express MSI directly from the [Microsoft Download Center](https://www.microsoft.com/en-us/download/details.aspx?id=48264). Please make sure .NET Framework 4.0 or above is installed on your machine, since that is a necessary prerequisite.

## IIS Express and IIS

IIS Express is derived from IIS 7 and above and supports the core features of IIS; however, there are some key differences. An important difference is the way worker processes are managed. In IIS, the Windows Process Activation Service (WAS) silently activates and deactivates Web applications and the user has no direct control. In IIS Express, there is no WAS and the user has full control of application activation and deactivation. Sites can be launched using Visual Studio or the command line; websites that are already running can be launched and terminated using the system tray application.

Hostable Web Core (HWC) is an IIS API that can be used to write to independent Web servers that are not managed by WAS. IIS Express is designed as a wrapper over HWC.

The following chart outlines some of the major differences between IIS and IIS Express:

| **Area** | **IIS** | **IIS Express** |
| --- | --- | --- |
| Shipping mechanism | Ships with the OS. | Ships out-of-band. It is automatically included with Visual Studio but can also be installed separately. |
| Supported Windows editions | Limited number of Windows 10 and Windows 11 editions Most editions of Windows Server 2012, 2012 R2, 2016, 2019 and 2022 | All editions of Windows 10 and Windows 11 Most editions of Windows Server 2012, 2012 R2, 2016, 2019, and 2022 |
| Supported .NET Framework versions | v2.0 SP1 and above | v2.0 SP1 and above (.NET 4.0 is required). |
| Supported programming languages | Classic ASP, ASP.NET, and PHP | Classic ASP, ASP.NET, and PHP |
| Process model | Windows Process Activation Service (WAS) automatically manages configured sites. | User launches and terminates sites. |
| Hosted WebCore (aka Hostable Web Core) support | Yes | Yes. IIS Express is implemented as a layer over HWC. |
| Supported protocols | HTTP, FTP, WebDAV, HTTPS, and WCF (including over TCP, Named Pipes, and MSMQ) | HTTP, HTTPS, and WCF over HTTP |
| Non-admin support | WAS must run with administrator user rights. | A standard user is allowed to complete most tasks. |
| Multi-developer support | None | Yes. Configuration files, settings, and Web content are maintained on a per-user basis. |
| Visual Studio support | Yes | VS 2010 SP1 and later allow IIS Express to be used instead of Cassini. |
| Runtime extensions | See [https://www.iis.net/download/All](https://www.iis.net/downloads) for a complete list. | URL Rewrite and FastCGI. These extensions are built into IIS Express. |
| Management tools | IIS Manager, appcmd.exe | Appcmd.exe. Common IIS Express management tasks are also built into Visual Studio 2010 SP1 and later. |
| System tray support | None | Yes |
| Includes built-in IIS modules for authentication, authorization, compression, etc. | Yes | Yes |
