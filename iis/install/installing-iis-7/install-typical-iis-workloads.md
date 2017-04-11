---
title: "Install Typical IIS Workloads | Microsoft Docs"
author: rick-anderson
description: "The IIS 7.0 and above modular architecture is designed to enable the IT professional to customize exactly which features are installed and running on the Web..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-install
ms.prod: iis
msc.legacyurl: /learn/install/installing-iis-7/install-typical-iis-workloads
msc.type: authoredcontent
---
Install Typical IIS Workloads
====================
by [Saad Ladki](https://twitter.com/saadladki)

## Introduction

The IIS 7.0 and above modular architecture is designed to enable the IT professional to customize exactly which features are installed and running on the Web server. IIS is now factored into more than 40 feature modules that can be independently installed on the box, dramatically reducing the potential attack surface, while lowering the footprint requirements, and minimizing patching and security risks.

To take full advantage of this modular architecture, you should plan your IIS installation to match the requirements of the applications you will be deploying. Doing so will minimize the IIS features you install, allowing you to take advantage of the benefits of the IIS modular architecture. We will start by considering several common workload configurations and then look at ways they can be combined and modified.

<a id="Prerequisites"></a>

## Prerequisites

This article discusses installing IIS 7.0 and above on Vista and Windows Server® 2008. This article will not instruct you on how to use the Vista / Windows Server 2008 install technologies; specific details on using setup user interfaces or command line tools to install IIS can be found at:

- [Installing IIS 7.0 on Windows Server 2008](installing-iis-7-and-above-on-windows-server-2008-or-windows-server-2008-r2.md)
- [Installing IIS 7.0 on Windows Vista](installing-iis-on-windows-vista-and-windows-7.md)
- [Installing IIS 7.0 from the Command Line](installing-iis-from-the-command-line.md)
- [Using Unattended Setup to Install IIS](using-unattended-setup-to-install-iis.md)

<a id="Principle"></a>

## Principle IIS Workloads

In this section we will consider several common workloads that typify task specific installations of IIS. These workloads can serve as starting points for customizing an IIS install to meet your specific needs.

The common IIS workloads we will consider are:

- Default Install - Static Content web Server
- ASP.NET
- Classic ASP
- Fast CGI for PHP
- IIS Full Install

### Combining and Modifying Workloads

In IIS, you are free to choose the exact features to install to match your workload. In the section above we examined several typical workloads that an IIS web server may be configured with. Combining workloads is a simple process of adding the features of one or more workloads together into your install.

It is also possible to modify these workloads by removing features that you do not want to allow, for example Directory Browsing, or by adding additional features such as authentication or authorization.

Additional sections will provide guidance on adding support for local and remote management, security, diagnostic, and IIS 6.0 compatibility to the common workloads.

### Default Install - Static Content Web Server

The Static content web server is the most basic and commonly used installation profile and is commonly used in conjunction with other workloads. The pre-selected setup defaults of IIS provide all the IIS modules required to support this workload. This includes the ability to serve static html files, documents, and images. Additionally support for default document, directory browsing, logging and anonymous authentication is provided. The IIS Management Console is also installed.

To install IIS features for Static Content Web Server from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name:


| UI Name | Update Name |
| --- | --- |
| Static Content | IIS-StaticContent |
| Default Document | IIS-DefaultDocument |
| Directory Browsing | IIS-DirectoryBrowsing |
| HTTP Errors | IIS-HttpErrors |
| HTTP Logging | IIS-HttpLogging |
| Logging Tools | IIS-LoggingLibraries |
| Request Monitor | IIS-HttpTracing |
| Request Filtering | IIS-RequestFiltering |
| Static Content Compression | IIS-HttpCompressionStatic |
| IIS Management Console | IIS-ManagementConsole |


To install IIS features for Static Content Web Server via pkgmgr.exe use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample1.cmd)]


To install IIS features for Static Content Web Server via ServerManagerCmd.exe use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample2.cmd)]

<a id="ASP.NET"></a>

## ASP.NET Workload

Since its first release ASP.NET has been the platform of choice for developing web applications on the Windows / IIS platform. IIS takes ASP.NET to the next level, by integrating the ASP.NET runtime extensibility model with the core server. This allows developers to fully extend the IIS server with the richness of ASP.NET 2.0 and the .NET Framework. For a full overview of how ASP.NET functionality can now be used with all IIS features see the article: [ASP.NET Integration with IIS7 and Above](../../application-frameworks/building-and-running-aspnet-applications/aspnet-integration-with-iis.md).

The ASP.NET workload extends the static content workload by adding modules for ASP.NET, .NET Extensibility, Request Filtering, ISAPI Filters, and ISAPI Extensions.

To install IIS features for ASP.NET from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| ASP.NET | IIS-ASPNET |
| .NET Extensibility | IIS-NetFxExtensibility |
| Request Filtering | IIS-RequestFiltering |
| ISAPI | IIS-ISAPIFilter |
| ISAPI Extensions | IIS-ISAPIExtensions |


To install IIS features for ASP.NET along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample3.cmd)]


To install IIS features for ASP.NET via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample4.ps1)]


It is possible to install support for .NET Extensibility and managed modules without installing support for ASP.NET. Using the IIS .NET Extensibility feature, developers can build solutions that add value for all application components, such as custom authentication schemes, monitoring and logging, security filtering, load balancing, content redirection, and state management. Learn more in article [Developing a Module using .NET.](../../develop/runtime-extensibility/developing-a-module-using-net.md)

To install IIS features for Managed Modules from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| .NET Extensibility | IIS-NetFxExtensibility |


To install IIS features for Managed Modules along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample5.cmd)]


To install IIS features for Managed Modules via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample6.ps1)]

<a id="InstallClassic"></a>

## Install Classic ASP Workload

The widely used classic ASP workload for serving server side scripted .asp pages builds on the static content workload by adding modules for ASP, Request Filtering, and ISAPI Extensions.

To install IIS features for Classic ASP from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| ASP | IIS-ASP |
| Request Filtering | IIS-RequestFiltering |
| ISAPI Extensions | IIS-ISAPIExtensions |


To install IIS features for Classic ASP along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample7.cmd)]


To install IIS features for Classic ASP via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample8.ps1)]

<a id="InstallFastCGI"></a>

## Install FastCGI for PHP

FastCGI provides a high-performance alternative to the Common Gateway Interface (CGI), a standard way of interfacing external applications with Web servers that has been supported as part of the IIS feature-set since the very first release.

FastCGI overcomes the performance penalty of traditional CGI by re-using CGI processes to service subsequent requests, while continuing to ensure single request concurrency. For more information on how FastCGI works, see article [Using FastCGI to Host PHP Applications on IIS 7.0 and Above.](../../application-frameworks/install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis.md)

To install IIS features for CGI and Fast CGI from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| CGI | IIS-CGI |


To install IIS features for CGI and FastCGI along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample9.cmd)]


To install IIS features for CGI and FastCGI via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample10.ps1)]

<a id="FullInstall"></a>

## IIS 7.0 and Above Full Install

As a developer or one who is just evaluating IIS you may simply just want to install all 40 of the IIS features: This will certainly assure that you're not missing anything; but realistically, even in a development environment there are advantages to limiting your install to just the features needed for your intended application. Doing your development on a partial install of IIS will assure that you have an understanding of your application's IIS module dependencies. It may also be true that the target servers that your IIS applications will be deployed on will not be configured with a full install. Matching the IIS install on your development machine to that of your target hosting machine will assure your application can run as expected when deployed.

To install all IIS features from the Vista/Windows Server 2008 setup user interface, select the all IIS features displayed in the setup UI. To install all IIS features via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample11.cmd)]


To install all IIS features via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample12.ps1)]

<a id="Adding"></a>

## Adding Diagnostics

The default static content workload includes HTTP logging and Request Monitor features for logging requests and monitoring request execution, but there are additional IIS 7.0 features you can use to enhance IIS logging and tracing capabilities:

- Tracing
- Custom Logging
- ODBC Logging

Of these features, Tracing provides a powerful way new to debug and diagnose IIS application issues in production environments as well as in development environment. (See article [Troubleshooting Failed Requests using Tracing in IIS7 and Above](../../troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis.md) ) The Custom Logging and ODBC Logging features exist for IIS 6.0 compatibility and you should only need to install them if you have existing IIS 6.0 that take advantage of these features.

To install the IIS Tracing feature from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| Tracing | IIS-HttpTracing |


To install IIS features for Tracing along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample13.cmd)]


To install IIS features for Tracing via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample14.ps1)]

<a id="AddingSecurity"></a>

## Adding Security Features

IIS always includes support for anonymous authentication, no special setup actions need be specified to get this support. If you do not want to allow anonymous authentication it can be disabled from the Management Console. In addition to anonymous authentication, IIS supports many optional authentication and authorization mechanisms to allow you to best secure your web sites.

### IIS Authentication Features

To install IIS features for authentication from the Vista/Windows Server 2008 setup user interface, select among following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| Basic Authentication | IIS-BasicAuthentication |
| Windows Authentication | IIS-WindowsAuthentication |
| Digest Authentication | IIS-DigestAuthentication |
| Client Certificate Mapping Authentication | IIS-ClientCertificateMappingAuthentication |
| IIS Client Certificate Mapping Authentication | IIS-IISCertificateMappingAuthentication |


To install IIS features for authentication along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample15.cmd)]


To install IIS features for authentication via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample16.ps1)]


### IIS 7.0 and Above Authorization Features

To install IIS features for authorization from the Vista/Windows Server 2008 setup user interface, select among following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| URL Authorization | IIS-URLAuthorization |
| Request Filtering | IIS-RequestFiltering |
| IP Security | IIS-IPSecurity |


> [!NOTE]
> The Request Filtering feature is part of the default install, and should only be excluded from your installations after you consider all security issues related to this feature.

To install IIS features for authorization along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample17.cmd)]


To install IIS features for authorization via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample18.ps1)]

<a id="Management"></a>

## Management Features for Local and Remote Administration

The default static content workload includes the IIS Management Console, which can be used to manage IIS on your local machine. The Management Console can also be used to manage IIS servers remotely if those servers are configured to accept connections from remote IIS Management Consoles.

### Management Client

Installing only the IIS Management Console will give you the ability to manage IIS on other servers that have the Remote Management Service installed.

To install the Management Client only without any IIS web Server or FTP Server features from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| IIS Management Console | IIS- ManagementConsole |


To install IIS features for Management Console along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample19.cmd)]


To install IIS features for Management Console via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample20.ps1)]


### Remote Management Service

Installing the IIS Remote Management Service will allow an IIS server to be managed remotely by IIS Management Consoles on other computers.

To install the IIS Management Service from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| Management Service | IIS-ManagementService |


To install IIS Management Service along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample21.cmd)]


To install IIS Management Service via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample22.ps1)]


### IIS 6.0 Metabase Compatibility

IIS provides a configuration store called ApplicationHost.config with a set of management APIs. In order to maintain compatibility with existing applications and scripts that use ABO or ADSI to configure IIS, IIS provides a complete metabase compatibility layer that implements the ABO and ADSI APIs and maps these APIs to the new ApplicationHost.config data store. In addition to the Metabase compatibility feature for ABO, you can also install IIS 6.0 Metabase compatibility for WMI scripting and, the IIS 6.0 scripting tools. To learn more about metabase compatibility, see the article [Metabase Compatibility with IIS7 and Above](../../manage/managing-your-configuration-settings/metabase-compatibility-with-iis-7-and-above.md)

To install the Metabase Compatibility from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| IIS 6 Metabase Compatibility | IIS-Metabase |
| IIS 6 WMI Compatibility | IIS-WMICompatibility |
| IIS 6 Scripting Tools | IIS-LegacyScripts |


To install IIS Metabase Compatibility along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample23.cmd)]


To install IIS features for Metabase via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample24.ps1)]


### Managing IIS 6.0 and FTP Server

IIS 7.0 and above provides the IIS 6.0 MMC snap-in to allow you to use your Vista/Windows Server 2008 machines to remotely administer existing IIS 6.0 server on Windows Server 2003 as well as FTP servers on Windows Server 2008. The IIS 6 Management Console cannot be used to manage IIS 7.0 and above Servers.

To install the IIS 6.0 Management Console from the Vista/Windows Server 2008 setup user interface, select the following IIS features by UI name (in addition to features for static content):


| UI Name | Update Name |
| --- | --- |
| IIS 6 Management Console | IIS-LegacySnapIn |


To install IIS 7.0 and above features for IIS 6.0 Management Console along with features for Static Content Web Server via pkgmgr.exe, use the following command line:


[!code-console[Main](install-typical-iis-workloads/samples/sample25.cmd)]


To install IIS 7.0 and above features for IIS 6.0 management via ServerManagerCmd.exe, use the following command line:


[!code-powershell[Main](install-typical-iis-workloads/samples/sample26.ps1)]

<a id="Summary"></a>

## Summary

In this article we saw how to install IIS 7.0 and above to support specific workloads, and how these workloads can be combined and modified. We also looked at adding IIS 7.0 and above features for tracing, security, IIS 6.0 compatibility, local and remote management, and IIS 6.0 management. After installing IIS 7.0 and above with the Server Manager Tool you can then use the Web Server Role Page for quick view of IIS 7.0 and above status, and use the IIS 7.0 and above management Console to configure the IIS features you installed.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1041.aspx)