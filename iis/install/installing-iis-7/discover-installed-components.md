---
title: "Discover Installed Components | Microsoft Docs"
author: rick-anderson
description: "The modular architecture in IIS 7.0 and above allows you to limit the potential attack surface on your IIS installation, or to replace built-in features with..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: 834203a5-cbeb-49af-a536-7d5ab91e5bfa
ms.technology: iis-install
ms.prod: iis
msc.legacyurl: /learn/install/installing-iis-7/discover-installed-components
msc.type: authoredcontent
---
Discover Installed Components
====================
by [IIS Team](https://twitter.com/inetsrv)

## Introduction

The modular architecture in IIS 7.0 and above allows you to limit the potential attack surface on your IIS installation, or to replace built-in features with third-party or custom implementations. In general, this architecture offers you an the ability to control how you deploy IIS on your network.

But if there is a downside to this modular architecture, it is that you can no longer be certain every IIS component you need is available, just because IIS has been installed. You might also discover that making sure multiple servers all have the same IIS components can be a chore.

To work around these issues, we are publishing a list of registry keys that show whether any given IIS module has been installed. Use these registry keys to programmatically check on IIS components. If a component has been installed, the registry key has a DWORD value of 00000001. If a component has never been installed or has been uninstalled, the registry key does not exist. Use the table below to match IIS component names with their registry keys.

## Registry Keys

These keys appear in the following registry hive:

[!code-console[Main](discover-installed-components/samples/sample1.cmd)]


| Display Name | Registry Key |
| --- | --- |
| Web Server | W3SVC |
| Common HTTP Features |
| Static Content | StaticContent |
| Default Document | DefaultDocument |
| Directory Browsing | DirectoryBrowse |
| HTTP Errors | HttpErrors |
| HTTP Redirection | HttpRedirect |
| Application Development Features |
| ASP.NET | ASPNET |
| .NET Extensibility | NetFxExtensibility |
| ASP | ASP |
| CGI | CGI |
| ISAPI Extensions | ISAPIExtensions |
| ISAPI Filters | ISAPIFilter |
| Server-Side Includes | ServerSideInclude |
| Health and Diagnostics |
| HTTP Logging | HttpLogging |
| Logging Tools | LoggingLibraries |
| Request Monitor | RequestMonitor |
| Tracing | HttpTracing |
| Custom Logging | CustomLogging |
| ODBC Logging | ODBCLogging |
| Security |
| Basic Authentication | BasicAuthentication |
| Windows Authentication | WindowsAuthentication |
| Digest Authentication | DigestAuthentication |
| Client Certificate Mapping Authentication | ClientCertificateMappingAuthentication |
| IIS Client Certificate Mapping Authentication | IISClientCertificateMappingAuthentication |
| URL Authorization | Authorization |
| Request Filtering | RequestFiltering |
| IP and Domain Restrictions | IPSecurity |
| Performance Features |
| Static Content Compression | HttpCompressionStatic |
| Dynamic Content Compression | HttpCompressionDynamic |
| Management Tools |
| IIS Management Console | ManagementConsole |
| IIS Management Scripts and Tools | ManagementScriptingTools |
| Management Service | AdminService |
| IIS 6 Management Compatibility |
| IIS Metabase Compatibility | Metabase |
| IIS 6 WMI Compatibility | WMICompatibility |
| IIS 6 Scripting Tools | LegacyScripts |
| IIS 6 Management Console | LegacySnapin |
| FTP Publishing Service |
| FTP Server | FTPServer |
| FTP Management snap-in | LegacySnapin |
| Windows Process Activation Service |
| Process Model | ProcessModel |
| .NET Environment | NetFxEnvironment |
| Configuration APIs | WASConfigurationAPI |


[Discuss in IIS Forums](https://forums.iis.net/1041.aspx)