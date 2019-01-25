---
title: "Feature to Configuration Reference"
author: rick-anderson
description: "IIS Manager Feature to Configuration Mapping This is a quick reference for mapping IIS 7.0 and above Manager features in the feature list to configuration se..."
ms.date: 11/23/2007
ms.assetid: 10755442-bb08-461e-b3c6-95cbdd0565d8
msc.legacyurl: /learn/get-started/planning-your-iis-architecture/feature-to-configuration-reference
msc.type: authoredcontent
---
Feature to Configuration Reference
====================
by [Saad Ladki](https://twitter.com/saadladki)

## IIS Manager Feature to Configuration Mapping

This is a quick reference for mapping IIS 7.0 and above Manager features in the **feature list** to configuration sections and the modules that consume those configuration sections.

The table below shows the IIS Manager feature name, followed by the configuration section(s) that feature reads and writes, followed by the module(s) that consume the configuration section(s). In some cases, the configuration section is consumed by the IIS core server, IIS Manager, .NET Framework 2.0 or ASP.NET 2.0, and these are marked specially in square braces, e.g. [IIS Server Core]. For more information on IIS modules, please see the [IIS Module Overview](../introduction-to-iis/iis-modules-overview.md)

<table border="0">
<colgroup>
<col>
<col>
<col></colgroup>
<tbody valign="top">
<tr>
<th>
<p>IIS Manager Feature Name</p></th>
<th>
<p>Configuration Section </p></th>
<th>
<p>What consumes this?  Module (Type/Dll)</p></th></tr>
<tr>
<th>.NET Compilation</th>
<td>
<p>system.web/compilation</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>.NET Globalization</th>
<td>
<p>system.web/globalization</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>.NET Trust Levels</th>
<td>
<p>system.web/trust</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>[Authentication] Anonymous </th>
<td>
<p>system.webServer/security/anonymousAuthentication</p></td>
<td>
<p>AnonymousAuthenticationModule (authanon.dll)</p></td></tr>
<tr>
<th>[Authentication] Basic </th>
<td>
<p>system.webServer/security/basicAuthentication</p></td>
<td>
<p>BasicAuthenticationModule (authbas.dll)</p></td></tr>
<tr>
<th>[Authentication] Digest </th>
<td>
<p>system.webServer/security/digestAuthentication</p></td>
<td>
<p>DigestAuthenticationModule (authmd5.dll)</p></td></tr>
<tr>
<th>[Authentication] Forms </th>
<td>
<p>system.web/authentication</p></td>
<td>
<p>FormsAuthentication (System.Web.Security.FormsAuthenticationModule)</p></td></tr>
<tr>
<th>[Authentication] Windows </th>
<td>
<p>system.webServer/security/windowsAuthentication</p></td>
<td>
<p>WindowsAuthenticationModule (authsspi.dll)</p></td></tr>
<tr>
<th>Administrators</th>
<td>
<p>administration.config: administrators</p></td>
<td>
<p>[IIS Manager, Web Management Service (WMSVC)]</p></td></tr>
<tr>
<th>Application Settings</th>
<td>
<p>appSettings</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>ASP</th>
<td>
<p>system.webServer/asp (indirect)</p></td>
<td>
<p>IsapiModule (isapi.dll)</p></td></tr>
<tr>
<th>Authorization Rules</th>
<td>
<p>system.webServer/security/authorization</p></td>
<td>
<p>UrlAuthorizationModule (urlauthz.dll)</p></td></tr>
<tr>
<th>Certificates</th>
<td>
<p> [Local Machine Certificate Store]</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>CGI</th>
<td>
<p>system.webServer/cgi</p></td>
<td>
<p>CgiModule (cgi.dll)</p></td></tr>
<tr>
<th rowspan="2">
<p><strong>Compression </strong></p>
<p>  </p>
<p>  </p>
<p><strong> </strong> </p></th>
<td>
<p>system.webServer/httpCompression </p>
<p>  </p></td>
<td rowspan="2">
<p>DynamicCompressionModule (compdyn.dll) </p>
<p>StaticCompressionModule (compstat.dll)</p></td></tr>
<tr>
<td>
<p>system.webServer/urlCompression </p>
<p>  </p></td></tr>
<tr>
<th>Connection Strings</th>
<td>
<p>connectionStrings</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>Custom Error Pages</th>
<td>
<p>system.webServer/httpErrors</p></td>
<td>
<p>CustomErrorModule (custerr.dll)</p></td></tr>
<tr>
<th>Default Document</th>
<td>
<p>system.webServer/defaultDocument</p></td>
<td>
<p>DefaultDocumentModule (defdoc.dll)</p></td></tr>
<tr>
<th>Directory Browsing</th>
<td>
<p>system.webServer/directoryBrowse</p></td>
<td>
<p>DirectoryListingModule (dirlist.dll)</p></td></tr>
<tr>
<th rowspan="2">
<p>Failed Request Tracing Rules</p>
<p><strong> </strong> </p></th>
<td>
<p>system.webServer/tracing/traceFailedRequests</p></td>
<td rowspan="2">
<p>FailedRequestsTracingModule (iisfreb.dll) </p>
<p>  </p></td></tr>
<tr>
<td>
<p>system.webServer/tracing/traceProviderDefinitions</p></td></tr>
<tr>
<th>Handler Mappings</th>
<td>
<p>system.webServer/handlers</p></td>
<td>
<p>[IIS Server Core]</p></td></tr>
<tr>
<th>HTTP Headers</th>
<td>
<p>system.webServer/httpProtocol</p></td>
<td>
<p>ProtocolSupportModule (protsup.dll)</p></td></tr>
<tr>
<th>IP and Domain Restrictions</th>
<td>
<p>system.webServer/ipSecurity</p></td>
<td>
<p>IpRestrictionModule (iprestr.dll)</p></td></tr>
<tr>
<th rowspan="2">
<p>ISAPI and CGI Restrictions</p>
<p><strong> </strong> </p></th>
<td rowspan="2">
<p>system.webServer/security/isapiCgiRestriction </p>
<p>  </p></td>
<td>
<p>CgiModule (cgi.dll)</p></td></tr>
<tr>
<td>
<p>IsapiModule (isapi.dll)</p></td></tr>
<tr>
<th>ISAPI Filters</th>
<td>
<p>system.webServer/isapiFilters</p></td>
<td>
<p>IsapiFilterModule (filter.dll)</p></td></tr>
<tr>
<th rowspan="2">
<p>Logging</p>
<p><strong> </strong> </p></th>
<td>
<p>system.applicationHost/log</p></td>
<td>
<p>[IIS Server Core]</p></td></tr>
<tr>
<td>
<p>system.webServer/httpLogging</p></td>
<td>
<p>HttpLoggingModule (loghttp.dll)</p></td></tr>
<tr>
<th>Machine Key</th>
<td>
<p>system.web/machineKey</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>Management Service</th>
<td>
<p>Registry: </p>
<p>HKLM\SOFTWARE\Microsoft\WebManagement\Server</p></td>
<td>
<p>[Web Management Service (WMSVC)]</p></td></tr>
<tr>
<th>Membership Roles</th>
<td>
<p>system.web/roleManager</p></td>
<td>
<p>RoleManager (System.Web.Security.RoleManagerModule)</p></td></tr>
<tr>
<th>Membership Users</th>
<td>
<p>system.web/membership</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>MIME Types</th>
<td>
<p>system.webServer/staticContent</p></td>
<td>
<p>StaticFileModule (static.dll)</p></td></tr>
<tr>
<th rowspan="2">
<p>Modules</p>
<p><strong> </strong> </p></th>
<td>
<p>system.webServer/globalModules</p></td>
<td rowspan="2">
<p>[IIS Server Core] </p>
<p>  </p></td></tr>
<tr>
<td>
<p>system.webServer/modules</p></td></tr>
<tr>
<th>Output Caching Rules</th>
<td>
<p>system.webServer/caching</p></td>
<td>
<p>HttpCacheModule (cachhttp.dll)</p></td></tr>
<tr>
<th>Pages and Controls</th>
<td>
<p>system.web/pages</p></td>
<td>
<p>[ASP.NET 2.0]</p></td></tr>
<tr>
<th>Profile</th>
<td>
<p>system.web/profile</p></td>
<td>
<p>Profile (System.Web.Profile.ProfileModule)</p></td></tr>
<tr>
<th>Providers</th>
<td>
<p>system.web/membership<br>system.web/roleManager<br>system.web/profile</p></td>
<td>
<p>  </p></td></tr>
<tr>
<th>Redirect Rules</th>
<td>
<p>system.webServer/httpRedirect</p></td>
<td>
<p>HttpRedirectionModule (redirect.dll)</p></td></tr>
<tr>
<th>Rights and Permissions</th>
<td>
<p>system.webServer/access</p></td>
<td>
<p>[IIS Server Core]</p></td></tr>
<tr>
<th>Server Side Includes</th>
<td>
<p>system.webServer/serverSideInclude</p></td>
<td>
<p>ServerSideIncludeModule (iis_ssi.dll)</p></td></tr>
<tr>
<th rowspan="2">
<p>Session State</p>
<p><strong> </strong> </p></th>
<td>
<p>system.web/sessionState</p></td>
<td rowspan="2">
<p>Session (System.Web.SessionState.SessionStateModule) </p>
<p>  </p></td></tr>
<tr>
<td>
<p>system.web/sessionPageState</p></td></tr>
<tr>
<th>SMTP E-mail</th>
<td>
<p>system.net/mailSettings/smtp</p></td>
<td>
<p>[.NET Framework 2.0]</p></td></tr>
<tr>
<th>SSL Settings</th>
<td>
<p>system.webServer/access</p></td>
<td>
<p>[IIS Server Core]</p></td></tr>
<tr>
<th>Worker Processes</th>
<td>
<p>  </p></td>
<td>
<p>  </p></td></tr></tbody></table>
