---
title: "Install Server Components | Microsoft Docs"
author: simtan
description: "Introduction This article will walk you through installing the required server components to be WebMatrix compatible and fulfill the Spotlight requirements f..."
ms.author: iiscontent
manager: soshir
ms.date: 11/03/2010
ms.topic: article
ms.assetid: cf0a1d31-1926-4e35-8b34-544c414905f8
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/joining-the-web-hosting-gallery/install-server-components
msc.type: authoredcontent
---
Install Server Components
====================
by [Simon Tan](https://github.com/simtan)

## Introduction

This article will walk you through installing the required server components to be **WebMatrix compatible** and fulfill the **Spotlight requirements** for the [Web Hosting Gallery](https://www.microsoft.com/web/hosting "Web Hosting Gallery").
## Prerequisites

We recommend having two separate machines both running Windows Server 2008 R2:

- One acting as the web server
- One acting as the database server

While it is possible to run both the web server and database server on the same machine, it is not recommended for performance and security reasons.

You will need both machines connected to the Internet to download required server components. 

To simplify the installation of the **web server** components, we highly recommend installing **Web Platform Installer**, also known as **WebPI**, on both machines. WebPI is a tool that automates the installation of a vast majority of server components and other products for Microsoft's Web Platform.

**Get WebPI 3.0 here:** [https://go.microsoft.com/fwlink/?LinkID=194638](https://go.microsoft.com/fwlink/?LinkID=194638)

If you prefer to not use WebPI, all of the required components can also be installed by hand or via your own provisioning scripts.

## Web Server Components

### Option 1 : Via Web Platform Installer 3.0 (recommended)

If you have **WebPI 3.0** installed, the following link will **automatically launch it** with all of the basic **web server** components you'll need ready to install:

> [Install Spotlight Components using Web PI](https://www.microsoft.com/web/gallery/install.aspx?appid=WHP_Recommended "Install Components using Web PI") (you will be able to review the list of products before installation begins)


(This list of components completely fulfills the **Spotlight requirements** from the [Web Hosting Gallery](https://www.microsoft.com/web/hosting/home).)

Note that many of the web applications that can be published by WebMatrix have **PHP/MySQL** components as requirements. To ensure you are able to support those applications, you can use this alternative link to install **everything above plus PHP/MySQL** related components:

> [Install Spotlight Components plus PHP/MySQL related components using Web PI](https://www.microsoft.com/web/gallery/install.aspx?appid=IIS7;Tracing;NETFramework35;NETFramework4;ASPNET;MVC;WDeploy;FTPServer;ManagementService;CGI;URLRewrite2;SMO;PHP52;WinCache52;MySQLConnector;SQLDriverPHP52IIS "Install Components including PHP/MySQL components using WebPI")


After WebPI launches from the links above, you'll just need to click the "Install" button to review the list of components and proceed with installation.

> [!NOTE]
> Even when using the links above, you'll still have to install the [Extensionless URL Hotfix](https://support.microsoft.com/kb/980368) separately, discussed below.

### Option 2 : Manually install Web Server components

Here is the full list of which components are installed by those links, so you can confirm against the list of products listed in WebPI. Note that many of them bring in dependencies – that is expected behavior – but the total download should not exceed 50 MB or so.

#### Server

- [Required] [IIS 7 Web Server](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=IIS7;Tracing "IIS 7 basic components") basic components

    - Required for basic web server functionality

#### Frameworks

- [Required] [.NET Framework 3.5 SP1](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=NETFramework35)

    - [Some applications](https://www.microsoft.com/web/gallery/) depend on this framework
- [Required] [.NET Framework 4.0](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=NETFramework40)

    - [Some applications](https://www.microsoft.com/web/gallery/) depend on this framework
- [Optional] [PHP](http://windows.php.net/download/ "PHP for Windows") (5.3.2 or higher) 

    - This is not required for Spotlight, but many applications that can be published by WebMatrix depend on this framework

#### ASP.NET

- [Required] [ASP.NET](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=ASPNET)

    - This framework is the backend of many of the most popular web applications
- [Required] [ASP.NET MVC](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=MVC) 1.0

    - A handful of applications in the App Gallery depend on this installed centrally
- [Optional]  
  
 Note that you can also optionally install [ASP.NET MVC3](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=MVC3) and [ASP.NET Web Pages](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=Plan9), which gives you the ability to host applications written in the new "Razor" syntax of ASP.NET. However, note that the binaries required for these kinds of applications are **automatically published** by WebMatrix. That is, each end user who publishes applications of this type will automatically end up with the required binaries in a */bin/* folder within their site root directory, so it is not really necessary to install them centrally.  
  
 In fact, we actually recommend that you do **not** install anything except **MVC 1**.  
  
 Also, note that this ASP.NET Web Pages is not a final release of the product. If you choose to install ASP.NET Web Pages, you will need to re-install it when future versions are released.


#### IIS Modules

- [Required] [Microsoft Web Deploy](https://www.iis.net/downloads/microsoft/web-deploy "Web Deploy") 2.0

    - Web Deploy is a client-server tool that simplifies the deployment of sites and applications to IIS servers. While WebMatrix supports web application publishing using both FTP and Web Deploy protocols, the latter providers a faster, more secure, and richer experience. It also lets the user deploy whole apps, including databases, ensuring they work both locally and remotely. It is the highlight of the WebMatrix publishing story.
- [Required] [FTP Publishing Service](https://www.iis.net/downloads/microsoft/ftp "FTP Publishing Service")

    - To ensure the option of FTP exists for maximum compatibility
- [Optional] [Media Services](https://www.iis.net/overview/choice/integratedmediaplatform "Media Services") 4.0

    - For IIS Smooth Streaming support
- [Required] [IIS Remote Management](https://www.iis.net/downloads/microsoft/iis-manager "IIS Manager for Remote Administration") Service

    - To allow your users to manage aspects of their accounts using the IIS console
    - Also a dependency for Web Deploy to function properly
- [Required] [FastCGI for IIS](https://www.iis.net/downloads/microsoft/fastcgi-for-iis "FastCGI for IIS")

    - Provides a much faster CGI implementation than the default
- [Required] [URL Rewrite 2.0](https://www.iis.net/downloads/microsoft/url-rewrite "URL Rewrite")

    - A dependency for many applications to function correctly
- [Required] [SQL Server 2008 Management Objects](https://www.microsoft.com/downloads/en/details.aspx?FamilyID=ceb4346f-657f-4d28-83f5-aae0c5c83d52 "SQL Server 2008 R2 feature pack")

    - A dependency for many applications to function correctly
- [Optional] [Windows Cache Extension 1.1 for PHP](https://www.iis.net/downloads/microsoft/wincache-extension "Windows Cache Extension for PHP")

    - Highly recommended when running PHP on Windows
- [Optional] [MySQL Connector/Net](http://dev.mysql.com/downloads/connector/net/ "MySQL Connector/NET") 6.2.3 or higher

    - Necessary for .NET applications using MySQL databases
- [Optional] [Microsoft Drivers for PHP for SQL Server](https://www.microsoft.com/downloads/en/details.aspx?FamilyID=80e44913-24b4-4113-8807-caae6cf2ca05 "Microsoft Drivers for PHP for SQL") 2.0 in IIS

    - Necessary for PHP applications using SQL Server

### Install Web Server Patches

- [Extensionless URL Hotfix](https://archive.msdn.microsoft.com/KB2522807)

    - Required for ASP.NET Web Pages to function correctly. It is discussed further in [this blog post](https://blogs.msdn.com/b/tmarq/archive/2010/04/01/asp-net-4-0-enables-routing-of-extensionless-urls-without-impacting-static-requests.aspx).

## Database Server Components

### SQL Server

- [Required] Microsoft SQL Server 2008  
  
 WebPI supports installing [Microsoft SQL Server 2008 Express edition](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=SqlExpress), but we do not recommend this product in shared hosting environments. (You should use the full version instead.)
- [Optional] [PHP Driver for SQL Server](https://www.microsoft.com/web/gallery/install.aspx?appsxml=&amp;appid=SQLDriverPHP)  
 We highly recommended installing this component on your **database server** if you are supporting PHP.

### MySQL

For more information on configuring a MySQL installation for WebMatrix support, please see [this article](setup-mysql-with-webmatrix-support.md "Set up MySQL with WebMatrix support").

## Next Steps

You should ensure that the Web Deploy 2.0 component is [configured to allow delegated deployments](configure-site-for-web-deploy-publishing.md "Configure Web Deploy for delegated deployments"). This is critical, as it is the primary method that allows your customers to publish to your servers with WebMatrix.