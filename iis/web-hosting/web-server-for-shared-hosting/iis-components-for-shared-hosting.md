---
title: "IIS 7 Components for Shared Hosting"
author: walterov
description: "IIS 7 and above makes it easier for system administrators to help secure and manage shared hosting environments. To deploy a Web server and host thousands of..."
ms.date: 12/01/2007
ms.assetid: 3be64664-b253-4deb-be3b-e30d678f5797
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/iis-components-for-shared-hosting
msc.type: authoredcontent
---
# IIS 7 Components for Shared Hosting

by [Walter Oliver](https://github.com/walterov)

## Introduction

IIS 7 and above makes it easier for system administrators to help secure and manage shared hosting environments. To deploy a Web server and host thousands of Web sites on it, server administrators need to configure and isolate sites from each other. This article provides recommendations for server administrators running in such environments.

IIS provides a modular architecture that lets you customize the components that you want to install on the Web server. IIS contains more than 40 components that you can independently install on the server. Installing only the modules that you need dramatically reduces the potential attack surface, and lowers the footprint requirements on the server.

For more information about the new modular architecture, see [IIS Modules Overview](../../get-started/introduction-to-iis/iis-modules-overview.md).

## Table

The following table lists the components that were installed on the Web server as part of the shared hosting architecture mentioned in the [Shared Hosting Setup](../planning-the-web-hosting-architecture/shared-hosting-configuration.md) article in "Planning the Web Hosting Architecture". Based on the shared hosting environment that you use, define your own set of components to install that meet your business needs.

| **Component** | **Installed?** | **Reason** |
| --- | --- | --- |
| **Web Server** | Yes | This is the core Web server. |
| **Common HTTP Features** |  | Includes commonly used features such as enabling static content (HTML, jpeg, etc.) or default documents. |
| Static Content | Yes | The Web server can serve static content, such as .html, .css, and .jpeg files, if you enable this option. |
| Default Document | Yes | When a visitor enters `www.site.com` but does not provide a specific document name, such as default.aspx, this feature allows the visitor to be seamlessly directed to the default document defined for the Web site. |
| Directory Browsing | Yes | Allows users browse the contents of a directory. |
| HTTP Errors | Yes | Allows error messages sent to a visitor's browser to be customized and for the server administrator to see the new detailed errors on the local Web server. |
| HTTP Redirection | Yes | Allows hosted customers to redirect requests for one URL to be redirected to another. |
| **Application Development** |  | Allows applications to be developed and run on the server, such as ASP.NET. |
| ASP.NET | Yes | ASP.NET ISAPI and modules for managed code applications (.aspx pages). |
| .NET Extensibility | Yes | Infrastructure required for ASP.NET. Allows developers to change and extend Web server functionality in the new request pipeline. |
| ASP | Yes | Required if customers use classic ASP applications. |
| CGI | Yes | Required for CGI applications, such as for PHP so that it can use the new FastCGI component. |
| ISAPI Extensions | Yes | Required for ASP.NET and other ISAPI extensions. |
| ISAPI Filters | Yes | Required for ASP.NET 1.1 ISAPI filter. |
| Server Side Includes | No | Not recommended unless customers are using Service Side Include files. |
| **Health and Diagnostics** |  | Provides infrastructure to monitor and troubleshoot the health of the Web server and sites. |
| HTTP Logging | Yes | Allows logging of Web site activity or traffic. |
| Logging Tools | No | Infrastructure for managing Web server logs. |
| Request Monitor | Yes | Allows requests to be monitored in-flight. Can be used to determine why a worker process is unresponsive or slow. |
| Tracing | Yes | Infrastructure to diagnose problems using Event Tracing in Windows and Failed Request Tracing. |
| Custom Logging | No | Support for logging activity in a different format from IIS generated log files. Not needed unless a custom format is used. |
| ODBC Logging | No | Infrastructure for logging activity to an ODBC compliant database. Not needed unless ODBC logging is used. |
| **Security** |  | Infrastructure for securing requests and filtering incoming requests based on security rules. |
| Basic Authentication | No | Clear-text authentication method that can be secured with SSL. Not needed if only anonymous authentication is used. |
| Windows Authentication | No | Hash-based authentication method. Not needed if only anonymous authentication is used. |
| Digest Authentication | No | Hash-based authentication method. Not needed if only anonymous authentication is used. |
| Client Certificate Mapping Authentication | No | Allows client certificates to be used to authenticate users. This type of client certificate mapping uses Active Directory. |
| IIS Client Cert Mapping Authentication | No | Allows client certificates to be used to authenticate users. This type of client certificate mapping uses IIS natively. |
| URL Authorization | Yes | Allows users to create rules that restrict access to content. |
| Request Filtering | Yes | Recommended security feature. Screens incoming requests based on rules sets. |
| IP and Domain Restrictions | No | Content can be allowed or denied to users based on the originating IP address or domain name of the request. |
| **Performance** |  |  |
| Static Content Compression | Yes | Allows static content to be compressed and unlike dynamic responses, compressed static responses can be cached without degrading CPU resources. |
| Dynamic Content Compression | Yes | Allows dynamic compression, utilizing bandwidth more efficiently, but may add a CPU load. |
| **Management Tools** |  |  |
| IIS Management Console | Yes | Needed to manage IIS locally, provides a user interface (UI) for server management. |
| IIS Management Scripts and Tools | Yes | Needed to script tasks, allows programmatic management of the server using scripts. |
| Management Service | Yes | Needed to allow remote management of IIS and to allow delegated users to administer their sites using a remote manager tool. |
| IIS 6 Management Compatibility | Yes (if needed) | Do not install unless compatibility with features, services, scripts and management tools for IIS 6.0 is required. |
| IIS Metabase Compatibility | Yes (if needed) | Required for SharePoint v3, ASP.NET 1.1, SMTP service and other features requiring backwards compatibility with the metabase. Provides compatibility for scripts based on IIS 6.0 interfaces for ADSI (Active Directory Service Interface) and ABO (Admin Base Object). |
| IIS 6 WMI Compatibility | No | Provides compatibility for scripts based on the IIS 6.0 WMI (Windows Management Instrumentation) provider. |
| IIS 6 Scripting Tools | No | Provides compatibility for scripts based on IIS 6.0 interfaces for ADO (ActiveX Data Objects) or ADSI APIs. |
| IIS 6 Management Console | No | Provides the IIS 6.0 based management tool. |
| **FTP Publishing Service** | No |  |
| FTP Server | No | Only needed if users upload using FTP. **Note:** This table refers to the built-in, legacy FTP server. It is highly recommended that you download and install the new FTP7 server if you need to offer FTP publishing to your users. It is available at [Installing and Troubleshooting FTP7](../../install/installing-publishing-technologies/installing-and-configuring-ftp-7-on-iis-7.md). |
| FTP Management Console | No | Only needed if users upload using FTP. |

> [!NOTE]
> Install only the components required for the shared hosting environment. For example, if Digest Authentication is not needed, do not enable it.