---
title: "IIS 7.0 Features and Vista Editions | Microsoft Docs"
author: rick-anderson
description: "With the release of Windows Vista and Windows Server 2008 IIS 7.0 became available on all mainstream Windows Editions for the first time. On Windows Vista Ed..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 06/24/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/install/installing-iis-7/iis-features-and-vista-editions
msc.type: authoredcontent
---
IIS 7.0 Features and Vista Editions
====================
by Henry Seiler

## Overview of IIS 7.0 differences Across Windows Vista Editions and Windows Server 2008 Editions

With the release of Windows Vista and Windows Server 2008 IIS 7.0 became available on all mainstream Windows Editions for the first time.  
  
On Windows Vista Editions, IIS 7.0 will play a dual role. First, it offers web developers the complete web platform experience for building and testing web applications on Windows, for deployment on Windows Server, just like Windows XP. Second, it enables process activation and management and the necessary HTTP infrastructure for enabling connected consumer scenarios that will be built using the Windows Communication Foundation (WinFX).

## Windows Vista Starter and Home Editions

The Windows Vista Starter and Home Editions are targeted at home and personal users who do not have the need to perform application or web development. IIS 7.0 Web Server and FTP Server features are not available on these editions. However, if you look closely you will notice specific components of IIS 7.0 that can be installed on these Editions. Please note, however, that installing these components will not provide a web server that supports static content, Classic ASP, or ASP.NET.  
  
The IIS 7.0 components available on these Editions serve as supporting infrastructure for Microsoft's Windows Communication Foundation (WCF). Collectively the IIS 7.0 components that provide this infrastructure are referred to as the Windows Process Activation Service (WAS.) Users who install WCF based applications will not need to explicitly install WAS, rather these components will be installed by WCF as needed.  
  
The IIS 7.0 simultaneous request execution limit for the Vista Starter and Home Editions is three.  
  
See the Feature Summary below for a detailed list of IIS 7.0 features available on these Editions.

## Windows Vista Home Premium Edition

The IIS 7.0 role on the Windows Vista Home Premium Edition is to support the needs of the casual or hobbyist web developers; as such the majority of the IIS 7.0 Web Server features required for web site development are available. Features not normally associated with hobbyist web development such as FTP server, advanced Web authentication and authorization, and remote administration are not available on the Vista Home Premium Edition.  
  
The IIS 7.0 simultaneous request execution limit for the Vista Home Premium Edition is three.  
  
See the Feature Summary below for a detailed list of IIS 7.0 features available on this Edition.

## Windows Vista Professional Editions

For the Windows Vista Professional Editions IIS 7.0 role is squarely targeted at the professional web developer and provides professional web developers to everything necessary to design, develop, and test web applications. (Professional Editions include Vista Business, Enterprise, and Ultimate Editions.) All of the IIS 7.0 features available on Windows Server 2008 are available on the Professional Editions with the exception of remote administration. The Professional Editions places a limit of 10 simultaneous requests that can be processed.  
  
See the Feature Summary below for a detailed list of IIS 7.0 features available on these Editions.

## Windows Server 2008 Editions

With Windows Server 2008, IIS 7.0 is ready for full deployment of web applications: All features, including remote administration are available, and of course there is no request execution limitation.  
  
See the Feature Summary below for a detailed list of IIS 7 features available on these Editions.

## IIS 7.0 Vista Edition Feature Matrix

| Display Names / Heirarchy | Package Update Names | Server | Pro | Premium | Basic &amp; Starter |
| --- | --- | --- | --- | --- | --- |
| **Internet Information Services** | IIS-WebServerRole | Available | Available | Available | Available |
|  | **World Wide Web Services** | IIS-WebServer | Default | Default | Default | Default |
|  |  | **Common Http Features** | IIS-CommonHttpFeatures | Default | Default | Default | Default |
|  |  |  | **Static Content** | IIS-StaticContent | Default | Default | Default | N/A |
|  |  |  | **Default Document** | IIS-DefaultDocument | Default | Default | Default | N/A |
|  |  |  | **Directory Browsing** | IIS-DirectoryBrowsing | Default | Default | Default | N/A |
|  |  |  | **HTTP Errors** | IIS-HttpErrors | Default | Default | Default | Default |
|  |  |  | **HTTP Redirection** | IIS-HttpRedirect | Available | Available | Available | Available |
|  |  | **Application Development Features** | IIS-ApplicationDevelopment | Available | Available | Available | Available |
|  |  |  | **ASP.NET** | IIS-ASPNET | Available | Available | Available | N/A |
|  |  |  | **.NET Extensibility** | IIS-NetFxExtensibility | Available | Available | Available | Available |
|  |  |  | **ASP** | IIS-ASP | Available | Available | Available | N/A |
|  |  |  | **CGI** | IIS-CGI | Available | Available | Available | N/A |
|  |  |  | **ISAPI Extensions** | IIS-ISAPIExtensions | Available | Available | Available | N/A |
|  |  |  | **ISAPI Filters** | IIS-ISAPIFilter | Available | Available | Available | N/A |
|  |  |  | **Server-Side Includes** | IIS-ServerSideInclude | Available | Available | Available | N/A |
|  |  | **Health and Diagnostics** | IIS-HealthAndDiagnostics | Default | Default | Default | Default |
|  |  |  | **HTTP Logging** | IIS-HTTPLogging | Default | Default | Default | Default |
|  |  |  | **Logging Tools** | IIS-LoggingLibraries | Available | Available | Available | Available |
|  |  |  | **Request Monitor** | IIS-RequestMonitor | Default | Default | Default | Default |
|  |  |  | **Tracing** | IIS-HttpTracing | Available | Available | Available | Available |
|  |  |  | **Custom Logging** | IIS-CustomLogging | Available | Available | Available | N/A |
|  |  |  | **ODBC Logging** | IIS-ODBCLogging | Available | Available | N/A | N/A |
|  |  | **Security** | IIS-Security | Available | Available | Available | Available |
|  |  |  | **Basic Authentication** | IIS-BasicAuthentication | Available | Available | Available | N/A |
|  |  |  | **Windows Authentication** | IIS-WindowsAuthentication | Available | Available | N/A | N/A |
|  |  |  | **Digest Authentication** | IIS-DigestAuthentication | Available | Available | N/A | N/A |
|  |  |  | **Client Certificate Mapping Authentication** | IIS-ClientCertificateMappingAuthentication | Available | Available | N/A | N/A |
|  |  |  | **IIS Client Certificate Mapping Authentication** | IIS-IISCertificateMappingAuthentication | Available | Available | N/A | N/A |
|  |  |  | **URL Authorization** | IIS-URLAuthorization | Available | Available | Available | Available |
|  |  |  | **Request Filtering** | IIS-RequestFiltering | Available | Available | Available | Available |
|  |  |  | **IP Security** | IIS-IPSecurity | Available | Available | Available | Available |
|  |  | **Performance Features** | IIS-Performance | Default | Default | Default | Available |
|  |  |  | **Static Content Compression** | IIS-HttpCompressionStatic | Default | Default | Default | N/A |
|  |  |  | **Http Compression Dynamic** | IIS-HttpCompressionDynamic | Available | Available | Available | Available |
|  | **Web Management Tools** | IIS-WebServerManagementTools | Default | Default | Default | Default |
|  |  | **IIS Management Console** | IIS-ManagementConsole | Default | Default | Default | N/A |
|  |  | **IIS Management Scripts and Tools** | IIS-ManagementScriptingTools | Available | Available | Available | Available |
|  |  | **IIS Management Service** | IIS-ManagementService | Available | Available | Available | N/A |
|  |  | **IIS 6 Management Compatibility** | IIS-IIS6ManagementCompatibility | Available | Available | Available | Available |
|  |  |  | **IIS Metabase and IIS 6 compatibility** | IIS-Metabase | Available | Available | Available | Available |
|  |  |  | **IIS 6 WMI Compatibility** | IIS-WMICompatibility | Available | Available | Available | N/A |
|  |  |  | **IIS 6 Scripting Tools** | IIS-LegacyScripts | Available | Available | Available | N/A |
|  |  |  | **IIS 6 Management Console** | IIS-LegacySnapIn | Available | Available | Available | N/A |
|  | **FTP Publishing Service** | IIS-FTPPublishingService | Available | Available | N/A | N/A |
|  |  | **FTP Server** | IIS-FTPServer | Available | Available | N/A | N/A |
|  |  | **FTP Management Console** | IIS-FTPManagement | Available | Available | N/A | N/A |
| **Windows Activation Service** | WAS-WindowsActivationService | Available | Available | Available | Available |
|  | **Process Model** | WAS-ProcessModel | Default | Default | Default | Default |
|  | **.NET Environment** | WAS-NetFxEnvironment | Available | Available | Available | Available |
|  | **Configuration APIs** | WAS-ConfigurationAPI | Available | Available | Available | Available |
| **Request Execution Limit** |  | Unlimited | 10 | 3 | 3 |


## Summary

In this article we examined the differences in IIS 7.0 across the Windows Vista and Server 2008 Editions.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1041.aspx)