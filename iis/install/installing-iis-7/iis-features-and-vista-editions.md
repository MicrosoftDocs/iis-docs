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

<TABLE border=0 cellSpacing=0 cellPadding=0 style="display:block;overflow:auto;">
<TBODY>
<TR>
<th vAlign=bottom width=339 colSpan=6 noWrap>
Display Names / Heirarchy</th>
<th vAlign=bottom width=233 colSpan=5 noWrap>
Package Update Names</th>
<th vAlign=bottom width=63 noWrap>
Server</th>
<th vAlign=bottom width=61 noWrap>
Pro</th>
<th vAlign=bottom width=61 noWrap>
Premium</th>
<th vAlign=bottom width=63 noWrap>
Basic &amp; Starter</th></TR>
<TR>
<TD vAlign=bottom width=339 colSpan=6 noWrap>
<P><B>Internet Information Services</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-WebServerRole</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=310 colSpan=5 noWrap>
<P><B>World Wide Web Services</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-WebServer</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=279 colSpan=4 noWrap>
<P><B>Common Http Features</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-CommonHttpFeatures</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Static Content</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-StaticContent</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Default Document</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-DefaultDocument</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Directory Browsing</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-DirectoryBrowsing</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>HTTP Errors</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HttpErrors</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>HTTP Redirection</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HttpRedirect</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available<?xml namespace="" prefix="O" ?></P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=279 colSpan=4 noWrap>
<P><B>Application Development Features</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ApplicationDevelopment</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>ASP.NET</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ASPNET</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>.NET Extensibility</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-NetFxExtensibility</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>ASP</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ASP</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>CGI</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-CGI</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>ISAPI Extensions</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ISAPIExtensions</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>ISAPI Filters</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ISAPIFilter</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Server-Side Includes</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ServerSideInclude</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=279 colSpan=4 noWrap>
<P><B>Health and Diagnostics</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HealthAndDiagnostics</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>HTTP Logging</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HTTPLogging</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Logging Tools</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-LoggingLibraries</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Request Monitor</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-RequestMonitor</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Tracing</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HttpTracing</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Custom Logging</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-CustomLogging</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>ODBC Logging</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ODBCLogging</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=279 colSpan=4 noWrap>
<P><B>Security</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-Security</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Basic Authentication</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-BasicAuthentication</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Windows Authentication</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-WindowsAuthentication</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Digest Authentication</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-DigestAuthentication</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Client Certificate Mapping Authentication</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ClientCertificateMappingAuthentication</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>IIS Client Certificate Mapping Authentication</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-IISCertificateMappingAuthentication</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>URL Authorization</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-URLAuthorization</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Request Filtering</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-RequestFiltering</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>IP Security</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-IPSecurity</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=279 colSpan=4 noWrap>
<P><B>Performance Features</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-Performance</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Static Content Compression</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HttpCompressionStatic</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=31 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>Http Compression Dynamic</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-HttpCompressionDynamic</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=310 colSpan=5 noWrap>
<P><B>Web Management Tools</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-WebServerManagementTools</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>IIS Management Console</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ManagementConsole</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>IIS Management Scripts and Tools</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ManagementScriptingTools</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>IIS Management Service</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-ManagementService</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=247 colSpan=3 noWrap>
<P><B>IIS 6 Management Compatibility</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-IIS6ManagementCompatibility</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=28 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=220 noWrap>
<P><B>IIS Metabase and IIS 6 compatibility</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-Metabase</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=28 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=220 noWrap>
<P><B>IIS 6 WMI Compatibility</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-WMICompatibility</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=28 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=220 noWrap>
<P><B>IIS 6 Scripting Tools</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-LegacyScripts</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=63 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=28 colSpan=2 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=220 noWrap>
<P><B>IIS 6 Management Console</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-LegacySnapIn</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=310 colSpan=5 noWrap>
<P><B>FTP Publishing Service</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-FTPPublishingService</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=90 colSpan=4 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=220 noWrap>
<P><B>FTP Server</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-FTPServer</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=29 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=90 colSpan=4 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=220 noWrap>
<P><B>FTP Management Console</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>IIS-FTPManagement</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>N/A</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>N/A</P></TD></TR>
<TR>
<TD vAlign=bottom width=339 colSpan=6 noWrap>
<P><B>Windows Activation Service</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>WAS-WindowsActivationService</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=101 colSpan=4 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=238 colSpan=2 noWrap>
<P><B>Process Model</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>WAS-ProcessModel</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Default</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Default</P></TD></TR>
<TR>
<TD vAlign=bottom width=101 colSpan=4 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=238 colSpan=2 noWrap>
<P><B>.NET Environment</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>WAS-NetFxEnvironment</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=101 colSpan=4 noWrap>
<P><B>&nbsp;</B> </P></TD>
<TD vAlign=bottom width=238 colSpan=2 noWrap>
<P><B>Configuration APIs</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>WAS-ConfigurationAPI</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P>Available</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Available</P></TD></TR>
<TR>
<TD vAlign=bottom width=339 colSpan=6 noWrap>
<P><B>&nbsp;</B> </P>
<P><B>Request Execution Limit</B></P></TD>
<TD vAlign=bottom width=233 colSpan=5 noWrap>
<P>&nbsp;  </P></TD>
<TD vAlign=bottom width=63 noWrap>
<P>Unlimited</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P align=right>10</P></TD>
<TD vAlign=bottom width=61 noWrap>
<P align=right>3</P></TD>
<TD vAlign=bottom width=63 noWrap>
<P align=right>3</P></TD></TR>
</TBODY></TABLE>

## Summary

In this article we examined the differences in IIS 7.0 across the Windows Vista and Server 2008 Editions.
