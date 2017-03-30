---
title: "Feature to Configuration Reference | Microsoft Docs"
author: rick-anderson
description: "IIS Manager Feature to Configuration Mapping This is a quick reference for mapping IIS 7.0 and above Manager features in the feature list to configuration se..."
ms.author: iiscontent
manager: soshir
ms.date: 11/23/2007
ms.topic: article
ms.assetid: 
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/feature-to-configuration-reference
msc.type: authoredcontent
---
Feature to Configuration Reference
====================
by [Saad Ladki](https://twitter.com/saadladki)

## IIS Manager Feature to Configuration Mapping

This is a quick reference for mapping IIS 7.0 and above Manager features in the **feature list** to configuration sections and the modules that consume those configuration sections.

The table below shows the IIS Manager feature name, followed by the configuration section(s) that feature reads and writes, followed by the module(s) that consume the configuration section(s). In some cases, the configuration section is consumed by the IIS core server, IIS Manager, .NET Framework 2.0 or ASP.NET 2.0, and these are marked specially in square braces, e.g. [IIS Server Core]. For more information on IIS modules, please see the [IIS Module Overview](../introduction-to-iis/iis-modules-overview.md)


| IIS Manager Feature Name | Configuration Section | What consumes this? Module (Type/Dll) |
| --- | --- | --- |
| .NET Compilation | system.web/compilation |  |
| .NET Globalization | system.web/globalization |  |
| .NET Trust Levels | system.web/trust |  |
| [Authentication] Anonymous | system.webServer/security/anonymousAuthentication | AnonymousAuthenticationModule (authanon.dll) |
| [Authentication] Basic | system.webServer/security/basicAuthentication | BasicAuthenticationModule (authbas.dll) |
| [Authentication] Digest | system.webServer/security/digestAuthentication | DigestAuthenticationModule (authmd5.dll) |
| [Authentication] Forms | system.web/authentication | FormsAuthentication (System.Web.Security.FormsAuthenticationModule) |
| [Authentication] Windows | system.webServer/security/windowsAuthentication | WindowsAuthenticationModule (authsspi.dll) |
| Administrators | administration.config: administrators | [IIS Manager, Web Management Service (WMSVC)] |
| Application Settings | appSettings |  |
| ASP | system.webServer/asp (indirect) | IsapiModule (isapi.dll) |
| Authorization Rules | system.webServer/security/authorization | UrlAuthorizationModule (urlauthz.dll) |
| Certificates | [Local Machine Certificate Store] |  |
| CGI | system.webServer/cgi | CgiModule (cgi.dll) |
| **Compression** | system.webServer/httpCompression | DynamicCompressionModule (compdyn.dll) StaticCompressionModule (compstat.dll) |
| system.webServer/urlCompression |
| Connection Strings | connectionStrings |  |
| Custom Error Pages | system.webServer/httpErrors | CustomErrorModule (custerr.dll) |
| Default Document | system.webServer/defaultDocument | DefaultDocumentModule (defdoc.dll) |
| Directory Browsing | system.webServer/directoryBrowse | DirectoryListingModule (dirlist.dll) |
| Failed Request Tracing Rules | system.webServer/tracing/traceFailedRequests | FailedRequestsTracingModule (iisfreb.dll) |
| system.webServer/tracing/traceProviderDefinitions |
| Handler Mappings | system.webServer/handlers | [IIS Server Core] |
| HTTP Headers | system.webServer/httpProtocol | ProtocolSupportModule (protsup.dll) |
| IP and Domain Restrictions | system.webServer/ipSecurity | IpRestrictionModule (iprestr.dll) |
| ISAPI and CGI Restrictions | system.webServer/security/isapiCgiRestriction | CgiModule (cgi.dll) |
| IsapiModule (isapi.dll) |
| ISAPI Filters | system.webServer/isapiFilters | IsapiFilterModule (filter.dll) |
| Logging | system.applicationHost/log | [IIS Server Core] |
| system.webServer/httpLogging | HttpLoggingModule (loghttp.dll) |
| Machine Key | system.web/machineKey |  |
| Management Service | Registry: HKLM\SOFTWARE\Microsoft\WebManagement\Server | [Web Management Service (WMSVC)] |
| Membership Roles | system.web/roleManager | RoleManager (System.Web.Security.RoleManagerModule) |
| Membership Users | system.web/membership |  |
| MIME Types | system.webServer/staticContent | StaticFileModule (static.dll) |
| Modules | system.webServer/globalModules | [IIS Server Core] |
| system.webServer/modules |
| Output Caching Rules | system.webServer/caching | HttpCacheModule (cachhttp.dll) |
| Pages and Controls | system.web/pages | [ASP.NET 2.0] |
| Profile | system.web/profile | Profile (System.Web.Profile.ProfileModule) |
| Providers | system.web/membership system.web/roleManager system.web/profile |  |
| Redirect Rules | system.webServer/httpRedirect | HttpRedirectionModule (redirect.dll) |
| Rights and Permissions | system.webServer/access | [IIS Server Core] |
| Server Side Includes | system.webServer/serverSideInclude | ServerSideIncludeModule (iis\_ssi.dll) |
| Session State | system.web/sessionState | Session (System.Web.SessionState.SessionStateModule) |
| system.web/sessionPageState |
| SMTP E-mail | system.net/mailSettings/smtp | [.NET Framework 2.0] |
| SSL Settings | system.webServer/access | [IIS Server Core] |
| Worker Processes |  |  |


[Discuss in IIS Forums](https://forums.iis.net/1111.aspx)