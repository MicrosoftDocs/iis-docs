---
title: "IIS Express Overview | Microsoft Docs"
author: vaidy4github
description: "IIS Express is a lightweight, self-contained version of IIS optimized for developers. IIS Express makes it easy to use the most current version of IIS to dev..."
ms.author: iiscontent
manager: soshir
ms.date: 07/06/2010
ms.topic: article
ms.assetid: 715ffb5e-1dcc-4b94-939d-0f326a1a2bb3
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/introduction-to-iis-express/iis-express-overview
msc.type: authoredcontent
---
IIS Express Overview
====================
by [Vaidy Gopalakrishnan](https://github.com/vaidy4github)

IIS Express is a lightweight, self-contained version of IIS optimized for developers. IIS Express makes it easy to use the most current version of IIS to develop and test websites. It has all the core capabilities of IIS 7 and above as well as additional features designed to ease website development including:

- It doesn't run as a service or require administrator user rights to perform most tasks.
- IIS Express works well with ASP.NET and PHP applications.
- Multiple users of IIS Express can work independently on the same computer.

<a id="Installation"></a>

## Installing IIS Express

The most current version of the product is IIS 7.5 Express. Most of you will want to use IIS Express with a web authoring tool that provides an integrated experience.

IIS Express is automatically included with [WebMatrix](https://www.microsoft.com/web/webmatrix "Microsoft WebMatrix"), a new and complete tool that greatly simplifies web development. Visual Studio 2010 SP1 allows IIS Express used as the web server instead of Cassini. You can also manually configure Visual Studio 2008.

Use one of the following links to install IIS 7.5 Express using Web Platform Installer. Either of them will allow you to use IIS Express with Visual Studio.

- [Install Microsoft WebMatrix](https://www.microsoft.com/web/gallery/install.aspx?appid=WebMatrix "Install Microsoft WebMatrix"). This will install IIS 7.5 Express as well.
- [Install IIS 7.5 Express only](https://www.microsoft.com/web/gallery/install.aspx?appid=IISExpress "Install IIS 7.5 Express"). After clicking the link, save the executable to your hard drive and run it. Doing so will install IIS Express using the [Web Platform Installer](../../install/web-platform-installer/using-the-microsoft-web-platform-installer.md "Web Platform Installer").

You an also install the IIS 7.5 Express MSI directly from the [Microsoft Download Center](https://www.microsoft.com/downloads/en/details.aspx?FamilyID=abc59783-89de-4adc-b770-0a720bb21deb). If you choose this route, please make sure .NET 4.0 is installed on your machine, since that is a necessary prerequisite.

## IIS Express and IIS

IIS Express is derived from IIS 7 and above and supports the core features of IIS; however, there are some key differences. An important difference is the way worker processes are managed. In IIS, the Windows Process Activation Service (WAS) silently activates and deactivates Web applications and the user has no direct control. In IIS Express, there is no WAS and the user has full control of application activation and deactivation. Sites can be launched using WebMatrix, Visual Studio 2010 SP1 or the command line; websites that are already running can be launched and terminated using the system tray application.

Hostable Web Core (HWC) is an IIS API that can be used to write to independent Web servers that are not managed by WAS. IIS Express is designed as a wrapper over HWC.

The following chart outlines some of the major differences between IIS and IIS Express:

| **Area** | **IIS** | **IIS Express** |
| --- | --- | --- |
| Shipping mechanism | Ships with the OS. | Ships out-of-band. It is automatically included with WebMatrix but can also be installed separately. |
| Supported Windows editions | Limited number of Windows Vista and Windows 7 editions Most editions of Windows Server 2003, 2008 and 2008 R2 | All editions of Windows XP, Vista, Windows 7 All editions of Windows Server 2008 and 2008 R2 |
| Supported .NET Framework versions | v2.0 SP1 and above | v2.0 SP1 and above (.NET 4.0 is required). |
| Supported programming languages | Classic ASP, ASP.NET, and PHP | Classic ASP, ASP.NET, and PHP |
| Process model | Windows Process Activation Service (WAS) automatically manages configured sites. | User launches and terminates sites. |
| Hosted WebCore (aka Hostable Web Core) support | Yes | Yes. IIS Express is implemented as a layer over HWC. |
| Supported protocols | HTTP, FTP, WebDAV, HTTPS, and WCF (including over TCP, Named Pipes, and MSMQ) | HTTP, HTTPS, and WCF over HTTP |
| Non-admin support | WAS must run with administrator user rights. | A standard user is allowed to complete most tasks. |
| Multi-developer support | None | Yes. Configuration files, settings, and Web content are maintained on a per-user basis. |
| Visual Studio support | Yes | VS 2010 SP1 Beta allows IIS Express to be used instead of Cassini. VS 2008 can also be manually configured to use IIS Express. |
| Runtime extensions | See [https://www.iis.net/download/All](https://www.iis.net/downloads) for a complete list. | URL Rewrite and FastCGI. These extensions are built into IIS Express. |
| Management tools | IIS Manager, appcmd.exe | Appcmd.exe. Common IIS Express management tasks are also built into WebMatrix and Visual Studio 2010 SP1 and later. |
| System tray support | None | Yes |
| Includes built-in IIS modules for authentication, authorization, compression, etc. | Yes | Yes |
  
  
[Discuss in IIS Forums](https://forums.iis.net/1166.aspx)