---
title: "IIS 7.0 Features and Vista Editions | Microsoft Docs"
author: rick-anderson
description: "With the release of Windows Vista and Windows Server 2008 IIS 7.0 became available on all mainstream Windows Editions for the first time. On Windows Vista Ed..."
ms.author: iiscontent
manager: soshir
ms.date: 06/24/2008
ms.topic: article
ms.assetid: b4fdece1-389e-4093-bf6d-29e3b1ae3d6b
ms.technology: iis-install
ms.prod: iis
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
<table>
<tbody>
<tr>
  <th colSpan=6>Display Names / Hierarchy</th>
  <th colSpan=5>Package Update Names</th>
  <th>Server</th>
  <th>Pro</th>
  <th>Premium</th>
  <th>Basic &amp; Starter</th></tr>
<tr>
<td colSpan=6>
<p><b>Internet Information Services</b></p></td>
<td colSpan=5>
<p>IIS-WebServerRole</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=5>
<p><b>World Wide Web Services</b></p></td>
<td colSpan=5>
<p>IIS-WebServer</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>Common Http Features</b></p></td>
<td colSpan=5>
<p>IIS-CommonHttpFeatures</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Static Content</b></p></td>
<td colSpan=5>
<p>IIS-StaticContent</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Default Document</b></p></td>
<td colSpan=5>
<p>IIS-DefaultDocument</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Directory Browsing</b></p></td>
<td colSpan=5>
<p>IIS-DirectoryBrowsing</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>HTTP Errors</b></p></td>
<td colSpan=5>
<p>IIS-HttpErrors</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>HTTP Redirection</b></p></td>
<td colSpan=5>
<p>IIS-HttpRedirect</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>Application Development Features</b></p></td>
<td colSpan=5>
<p>IIS-ApplicationDevelopment</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>ASP.NET</b></p></td>
<td colSpan=5>
<p>IIS-ASPNET</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>.NET Extensibility</b></p></td>
<td colSpan=5>
<p>IIS-NetFxExtensibility</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>ASP</b></p></td>
<td colSpan=5>
<p>IIS-ASP</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>CGI</b></p></td>
<td colSpan=5>
<p>IIS-CGI</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>ISAPI Extensions</b></p></td>
<td colSpan=5>
<p>IIS-ISAPIExtensions</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>ISAPI Filters</b></p></td>
<td colSpan=5>
<p>IIS-ISAPIFilter</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Server-Side Includes</b></p></td>
<td colSpan=5>
<p>IIS-ServerSideInclude</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>Health and Diagnostics</b></p></td>
<td colSpan=5>
<p>IIS-HealthAndDiagnostics</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>HTTP Logging</b></p></td>
<td colSpan=5>
<p>IIS-HTTPLogging</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Logging Tools</b></p></td>
<td colSpan=5>
<p>IIS-LoggingLibraries</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Request Monitor</b></p></td>
<td colSpan=5>
<p>IIS-RequestMonitor</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Tracing</b></p></td>
<td colSpan=5>
<p>IIS-HttpTracing</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Custom Logging</b></p></td>
<td colSpan=5>
<p>IIS-CustomLogging</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>ODBC Logging</b></p></td>
<td colSpan=5>
<p>IIS-ODBCLogging</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>Security</b></p></td>
<td colSpan=5>
<p>IIS-Security</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Basic Authentication</b></p></td>
<td colSpan=5>
<p>IIS-BasicAuthentication</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Windows Authentication</b></p></td>
<td colSpan=5>
<p>IIS-WindowsAuthentication</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Digest Authentication</b></p></td>
<td colSpan=5>
<p>IIS-DigestAuthentication</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Client Certificate Mapping Authentication</b></p></td>
<td colSpan=5>
<p>IIS-ClientCertificateMappingAuthentication</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>IIS Client Certificate Mapping Authentication</b></p></td>
<td colSpan=5>
<p>IIS-IISCertificateMappingAuthentication</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>URL Authorization</b></p></td>
<td colSpan=5>
<p>IIS-URLAuthorization</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Request Filtering</b></p></td>
<td colSpan=5>
<p>IIS-RequestFiltering</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>IP Security</b></p></td>
<td colSpan=5>
<p>IIS-IPSecurity</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>Performance Features</b></p></td>
<td colSpan=5>
<p>IIS-Performance</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Static Content Compression</b></p></td>
<td colSpan=5>
<p>IIS-HttpCompressionStatic</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>Http Compression Dynamic</b></p></td>
<td colSpan=5>
<p>IIS-HttpCompressionDynamic</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=5>
<p><b>Web Management Tools</b></p></td>
<td colSpan=5>
<p>IIS-WebServerManagementTools</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>IIS Management Console</b></p></td>
<td colSpan=5>
<p>IIS-ManagementConsole</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>IIS Management Scripts and Tools</b></p></td>
<td colSpan=5>
<p>IIS-ManagementScriptingTools</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>IIS Management Service</b></p></td>
<td colSpan=5>
<p>IIS-ManagementService</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=3>
<p><b>IIS 6 Management Compatibility</b></p></td>
<td colSpan=5>
<p>IIS-IIS6ManagementCompatibility</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>IIS Metabase and IIS 6 compatibility</b></p></td>
<td colSpan=5>
<p>IIS-Metabase</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>IIS 6 WMI Compatibility</b></p></td>
<td colSpan=5>
<p>IIS-WMICompatibility</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>IIS 6 Scripting Tools</b></p></td>
<td colSpan=5>
<p>IIS-LegacyScripts</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>IIS 6 Management Console</b></p></td>
<td colSpan=5>
<p>IIS-LegacySnapIn</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=5>
<p><b>FTP Publishing Service</b></p></td>
<td colSpan=5>
<p>IIS-FTPPublishingService</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>FTP Server</b></p></td>
<td colSpan=5>
<p>IIS-FTPServer</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td>
<p><b>&nbsp;</b> </p></td>
<td colSpan=4>
<p><b>&nbsp;</b> </p></td>
<td>
<p><b>FTP Management Console</b></p></td>
<td colSpan=5>
<p>IIS-FTPManagement</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>N/A</p></td>
<td>
<p>N/A</p></td></TR>
<tr>
<td colSpan=6>
<p><b>Windows Activation Service</b></p></td>
<td colSpan=5>
<p>WAS-WindowsActivationService</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td colSpan=4>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>Process Model</b></p></td>
<td colSpan=5>
<p>WAS-ProcessModel</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td>
<td>
<p>Default</p></td></TR>
<tr>
<td colSpan=4>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>.NET Environment</b></p></td>
<td colSpan=5>
<p>WAS-NetFxEnvironment</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td colSpan=4>
<p><b>&nbsp;</b> </p></td>
<td colSpan=2>
<p><b>Configuration APIs</b></p></td>
<td colSpan=5>
<p>WAS-ConfigurationAPI</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td>
<td>
<p>Available</p></td></TR>
<tr>
<td colSpan=6>
<p><b>&nbsp;</b> </p>
<p><b>Request Execution Limit</b></p></td>
<td colSpan=5>
<p>&nbsp;  </p></td>
<td>
<p>Unlimited</p></td>
<td>
<P align=right>10</p></td>
<td>
<P align=right>3</p></td>
<td>
<P align=right>3</p></td></TR>
</tbody></table>

## Summary

In this article we examined the differences in IIS 7.0 across the Windows Vista and Server 2008 Editions.
