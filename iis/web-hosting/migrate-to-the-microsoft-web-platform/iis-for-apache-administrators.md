---
title: "IIS 7 for Apache Administrators | Microsoft Docs"
author: rick-anderson
description: "Apache Hypertext Transfer Protocol (HTTP) Server and Internet Information Services are two of the world’s most popular Web servers. This article provides tec..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 5a877ba4-8cb1-43cb-bc3a-0fe3f401b082
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/migrate-to-the-microsoft-web-platform/iis-for-apache-administrators
msc.type: authoredcontent
---
IIS 7 for Apache Administrators
====================
by Tali Smith

## Introduction

Apache Hypertext Transfer Protocol (HTTP) Server and Internet Information Services are two of the world's most popular Web servers. This article provides technical information about IIS for users who are familiar with Apache. The article compares the architecture, security model, and management features of IIS 7 (and above) with those of Apache, and it also compares common IIS and Apache management scenarios and tools.


## Compare Features

IIS, with a modular design similar to that of the Apache Web server, gives administrators control through its extensible architecture and intuitive graphical user interface. Diagnostic capabilities built into IIS help reduce the time required to troubleshoot issues, minimizing downtime.

### Modular Architecture

The functionality of IIS is divided into more than 44 separate feature modules. These modules can be installed during the setup of the Web Server (IIS) role through the Server Manager console. The existent functionality can be extended further using the included Win32® and Microsoft® .NET application programming interfaces (APIs) to build new modules. While the IIS modules replace Internet Server Application Programming Interface (ISAPI) filters and extensions, IIS maintains full support of these filters and extensions.

Apache Web Server provides limited support for Microsoft® Speech API (SAPI) extensions, but does not support ISAPI filters. It relies on a community-driven project called the Apache Portable Runtime (APR), which is used to create and maintain software libraries that provide a predictable and consistent interface to underlying platform-specific implementations. The APR provides a set of APIs that maps to the underlying operating system, and thus let developers code platform-independent programs.

### Web Server Security

Since 2003, four security vulnerabilities have been reported on IIS 6.0, compared with 23 for Apache 2.0.x during the same period of time,[1] according to the security service provider Secunia. IIS builds on the secure foundation of its predecessor, and brings an enhanced process model that isolates applications by sandboxing resources and configurations at the application level by default.

Installing a minimal environment by choosing the Server Core installation option of Windows ServerÒ 2008 further limits the area of exposure of the IIS installation. Server Core omits graphical services and most libraries, reducing the total footprint of the operating system while still retaining the ability to be administered both locally, through the IIS command-line utility Appcmd.exe, and remotely.

### Management Tools

The initial design of Apache did not take into account the possibility of implementing a graphical interface for its management tools. Apache management functions are accomplished through entries made directly into configuration files or through open-source graphical management tools such as TKApache and NetLoony.

IIS offers a range of management tools; management can be accomplished graphically, via the command line, or manually by editing the configuration file.

### Diagnostics and Troubleshooting

In Apache, faults are isolated and diagnosed through five log files, each of which must be read manually to search for patterns that point to a particular problem.

IIS include two mechanisms to help with diagnostics and troubleshooting:

- The Runtime State and Control API provides real-time state information about application pools, worker processes, sites, application domains, and even running requests. This Component Object Model (COM) API is displayed through the IIS Manager console, the new Appcmd.exe command-line tool, and WindowsÒ Management Instrumentation (WMI). These applications offer quick and easy status checks in any management environment chosen.
- Detailed event tracing functionality tracks events throughout the request and response path, allowing developers and administrators to trace a request through the IIS processing pipeline and back out to the response. These detailed tracing events collect information on the request path, errors raised by the request, and the elapsed time at all points.

IIS also provides a detailed and actionable library of error messages. This library replaces the traditional, terse error codes with detailed information about the request, the possible cause of the error, and suggested steps to fix the problem. IIS sends detailed error information to the browser and other remote clients.

### Web Application Support

IIS offers tools that enable organizations to manage all of their Web applications on a single platform, eliminating the need to maintain two or more independent platforms that create higher infrastructure costs.

FastCGI in IIS supports the high-performance version of the Common Gateway Interface (CGI). FastCGI overcomes the performance problems of standard CGIs by creating persistent processes that can be reused for multiple requests, rather than creating a new process for each request, which is then discarded when the request has been filled. FastCGI also allows applications to run remotely, improving load distribution.

IIS also operates with the MicrosoftÒ .NET Framework version 1.1 and later. Through its support of classic ASP, Microsoft® ASP.NET, and PHP, IIS provides organizations with the flexibility to write applications in the language of their choice and to host applications on the platform of their choice.

### Extensibility Model for Customization

Developers can extend IIS through the core server API set, which lets them build modules in both native code (such as C/C++) and managed code using languages (such as C# and Microsoft® Visual Basic®) that use the .NET Framework. IIS also enables extensibility for configuration, scripting, event logging, and administration tool feature sets.

Extensions are available for download at no charge for x86 and x64 platforms. The extensions cover a range of tasks in deployment, administration, request handling, security, content publishing, and media service. For the available IIS extensions, see: [IIS Extensions](https://www.iis.net/downloads).

### FTP Publishing Service for IIS 7 and Above

FTP Publishing Service for IIS (FTP 7) offers many enhanced capabilities over previous releases of the IIS FTP server:

- Tighter integration with IIS through a new administration user interface (UI) and configuration store based on the .NET XML-based \*.CONFIG format.
- Support for File Transfer Protocol (FTP) over Secure Sockets Layer (SSL) and for the use of non-WindowsÒ accounts for authentication. The new FTP service also supports other Internet improvements, such as UTF8 and IPv6.
- Shared hosting improvements through full integration into IIS. This allows FTP 7 to host FTP and Web content from the same site by simply adding an FTP binding to an existing Web site. In addition, the FTP service now has virtual host name support, making it possible to host multiple FTP sites on the same IP address.
- Improved logging and supportability features, including enhanced logging for all FTP-related traffic, unique tracking for FTP sessions, FTP sub-statuses, and additional detail fields in FTP logs.

### Integrated Request Pipeline

In previous versions of IIS, ASP.NET was implemented as an IIS ISAPI extension, and requests to non-ASP.NET content, such as ASP pages or static files, were not visible to ASP.NET.

In IIS, the layout of the request pipeline provides more opportunities to influence the way in which a request is handled. IIS processes a request to any content type, which enables services provided by ASP.NET modules such as forms authentication or output cache to be used for requests to ASP pages, PHP pages, or static files.

## IIS 7 and Above Configuration and Management

In Apache, configuration starts with a directive entry in the Httpd.config file.

This method is similar for IIS configuration, in which most settings can be configured either locally in the Web.config file or globally in the ApplicationHost.config file. IIS provides a few methods for editing the .config files. These methods include:

- Graphically editing through the IIS Manager console.
- Editing from the command prompt by using Appcmd.exe along with the *set config / commit* argument/.
- Editing within a Windows Management Instrumentation script, using *Application class*.
- Manually editing the configuration files, which are based on a strongly typed schema written in clear-text XML. Microsoft® Visual Web Developer 2005 Express Edition can be used to edit the IIS configuration files in a neat-looking code editor environment.

The complete usage options of Appcmd.exe can be found [here](../../get-started/getting-started-with-iis/getting-started-with-appcmdexe.md).

## Using Modules to Control and Customize IIS

Modules in IIS control and customize its functionality, resulting in greater flexibility and efficiency of the server platform. By default, these modules are dynamic link library (DLL) files stored in the `%WINDIR%\System32\inetsrv\` folder. They can be classified into two types, as follows.

- **Native.** A native module has unrestricted access to any resource available to the server worker process, just like an ISAPI filter or extension in previous versions.
- **Managed.** Managed modules can be configured separately for each site or application. They are loaded for processing only when required by the particular site or application.

#### HTTP Modules

Several IIS modules perform tasks specific to HTTP in the request-processing pipeline. These include modules to respond to information and inquiries sent in client headers, to return HTTP errors, and to redirect requests.

| Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| Core feature: ErrorDocument Directive | CustomErrorModule | Sends default and configured HTTP error messages when an error status code is set on a response. | Inetsrv\Custerr.dll |
| mod\_alias | HttpRedirectionModule | Supports configurable redirection for HTTP requests. | Inetsrv\Redirect.dll |
| mod\_headers | ProtocolSupportModule | Performs protocol-related actions, such as setting response and redirecting headers based on the configuration. | Inetsrv\Protsup.dll |

#### Security Modules

Several IIS modules perform security tasks in the request-processing pipeline. In addition, separate modules exist for each of the authentication schemes, enabling the selection of modules for the types of authentication desired on the server. Other modules perform URL authorization and filter requests.

| <a id="_Toc208241295"></a>Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| mod\_auth\_anon | AnonymousAuthentica- tionModule | Performs Anonymous authentication when no other authentication method succeeds. | Inetsrv\Authanon.dll |
| mod\_auth | BasicAuthentication- Module | Performs Basic authentication. | Inetsrv\Authbas.dll |
|  | CertificateMapping- AuthenticationModule | Performs Certificate Mapping authentication using Active Directory®. | Inetsrv\Authcert.dll |
| mod\_auth\_digest | DigestAuthentication-Module | Performs Digest authentication. | Inetsrv\Authmd5.dll |
| No equivalent | IISCertificateMapping- AuthenticationModule | Performs Certificate Mapping authentication using IIS certificate configuration. | Inetsrv\Authmap.dll |
| Partially available as a core function of Apache | RequestFilteringModule | Performs URLScan tasks such as configuring allowed verbs and file extensions, setting limits, and scanning for bad character sequences. | Inetsrv\Modrqflt.dll |
| mod\_auth | UrlAuthorizationModule | Performs URL authorization. | Inetsrv\Urlauthz.dll |
| Not supported | WindowsAuthentication- Module | Performs NTLM integrated authentication. | Inetsrv\Authsspi.dll |
| mod\_access | IpRestrictionModule | Restricts IPv4 addresses listed in the ipSecurity list in configuration. | Inetsrv\iprestr.dll |

#### Content Modules

Several IIS modules perform tasks related to content in the request-processing pipeline. Content modules process requests for static files, return a default page when a client fails to specify a resource in a request, list the contents of a directory, and more.

| <a id="_Toc208241296"></a>Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| mod\_cgi | CgiModule | Executes Common Gateway Interface (CGI) processes to build response output. | Inetsrv\Cgi.dll |
| mod\_dir | DefaultDocumentModule | Attempts to return a default document for requests made to the parent directory. | Inetsrv\Defdoc.dll |
| mod\_autoindex | DirectoryListingModule | Lists the contents of a directory. | Inetsrv\dirlist.dll |
| Third party | IsapiModule | Hosts ISAPI extension DLLs. | Inetsrv\Isapi.dll |
| Not supported | IsapiFilterModule | Supports ISAPI filter DLLs. | Inetsrv\Filter.dll |
| Core feature: Options directive | ServerSideIncludeModule | Processes server-side includes code. | Inetsrv\Iis\_ssi.dll |
| Core feature: EnableSendfile directove | StaticFileModule | Serves static files. | Inetsrv\Static.dll |
| mod\_fcgid | FastCgiModule | Supports FastCGI, a high-performance alternative to CGI. | Inetsrv\iisfcgi.dll |

#### Compression Modules

Two IIS modules perform compression in the request-processing pipeline.

| <a id="_Toc208241297"></a>Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| mod\_gzip | DynamicCompression- Module | Compresses responses and applies GZIP compression transfer coding to responses. | Inetsrv\Compdyn.dll |
| mod\_gzip | StaticCompression- Module | Performs precompression of static content. | Inetsrv\Compstat.dll |

#### Caching Modules

Several IIS modules perform tasks related to caching in the request-processing pipeline. Caching improves the performance of Web sites and Web applications by storing processed information, such as Web pages, in memory on the server and then reusing that information in subsequent requests for the same resource.

| <a id="_Toc208241298"></a>Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| mod\_cache and supporting modules | FileCacheModule | Provides user-mode caching for files and file handles. | Inetsrv\Cachfile.dll |
| mod\_cache and supporting modules | HTTPCacheModule | Provides kernel-mode and user-mode caching in HTTP.sys. | Inetsrv\Cachhttp.dll |
| mod\_cache and supporting modules | TokenCacheModule | Provides user-mode caching of user name and token pairs for modules that produce Windows user principals. | Inetsrv\Cachtokn.dll |
| mod\_cache and supporting modules | UriCacheModule | Provides user-mode caching of URL info. | Inetsrv\Cachuri.dll |

#### Logging and Diagnostics Modules

Several IIS modules perform tasks related to logging and diagnostics in the request-processing pipeline. The logging modules support loading custom modules and passing information to HTTP.sys. The diagnostics modules track and report events during request processing.

| Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| mod\_log\_config | CustomLoggingModule | Loads custom logging modules. | Inetsrv\Logcust.dll |
| Not supported | FailedRequests- TracingModule | Supports the Failed Request Tracing feature. | Inetsrv\Iisfreb.dll |
| mod\_log\_config | HttpLoggingModule | Passes information and processing status to HTTP.sys for logging. | Inetsrv\Loghttp.dll |
| mod\_dtrace | RequestMonitorModule | Tracks requests currently executing in worker processes, and reports information with the Runtime Status and Control Application Programming Interface. | Inetsrv\Iisreqs.dll |
| mod\_log\_config | TracingModule | Reports events to Event Tracing for WindowsÒ (ETW). | Inetsrv\Iisetw.dll |

#### Managed Support Modules

Two IIS modules support managed integration in the IIS request-processing pipeline.

| Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| Not supported | ManagedEngine | Provides integration of managed code modules in the IIS request-processing pipeline. | Microsoft.NET\Framework\v2.0.50727\webengine.dll |
| Third party | ConfigurationValidationModule | Validates configuration issues (for example, when an application is running in Integrated mode, but has handlers or modules declared in the system.web section). | Inetsrv\validcfg.dll |

#### Managed Modules

In addition to native modules, IIS enables the use of managed code modules to extend IIS functionality. Some of the managed modules, such as UrlAuthorization, have a native module counterpart that provides a native alternative to the managed module.

| <a id="_Toc185320536"></a><a id="_Toc208241301"></a><a id="_Toc148380263"></a>Apache module | IIS equivalent | Description | Resource |
| --- | --- | --- | --- |
| mod\_auth\_anon | AnonymousIdentification | Manages anonymous identifiers used by features supporting anonymous identification, such as ASP.NET profile. | System.Web.Security.AnonymousIdentificationModule |
| mod\_auth | DefaultAuthentication | Ensures that an authentication object is present in the context. | System.Web.Security.DefaultAuthenticationModule |
| mod\_auth | FileAuthorization | Verifies that a user has permission to access the requested file. | System.Web.Security.FileAuthorizationModule |
| mod\_auth | FormsAuthentication | Supports forms authentication. | System.Web.Security.FormsAuthenticationModule |
| mod\_auth | OutputCache | Supports output caching. | System.Web.Caching.OutputCacheModule |
| mod\_auth | Profile | Manages user profiles using ASP.NET profile, which stores and retrieves user settings in a data source such as a database. | System.Web.Profile.ProfileModule |
| Third party | RoleManager | Manages a RolePrincipal instance for the current user. | System.Web.Security.RoleManagerModule |
| mod\_perl | Session | Supports maintaining session state, which enables storage of data specific to a single client within an application on the server. | System.Web.SessionState.SessionStateModule |
| Third party | UrlAuthorization | Determines whether the current user has access to the requested URL based on the user name or the list of roles of which the user is a member. | System.Web.Security.UrlAuthorizationModule |
| mod\_rewrite | UrlMappingsModule | Supports mapping a real URL to a more user-friendly URL. | System.Web.UrlMappingsModule |
| Not supported | WindowsAuthentication | Sets the identity of the user for an ASP.NET application when Windows authentication is enabled. | System.Web.Security.WindowsAuthenticationModule |

### Distributed Configuration Model

The new configuration system in IIS caches configuration files like .htaccess files in Apache, but consumes significantly less memory. In addition, there are various ways to configure IIS to take advantage of either global or more granular configuration changes.

IIS uses a configuration scheme that provides ASP.NET integration, including shared configuration and HTTP runtime support. The XML-based configuration model uses configuration text files that hold configuration settings and that can be stored in separate XML files in a folder.

IIS uses three main XML files that maintain server deployments:

- Machine.config holds .NET Framework settings for the server. These settings are inherited by all other .NET Framework configuration files and can be located by default at `%windir%\Microsoft.net\Framework\ &lt;*framework\_version*&gt;\Config\Machine.config`.
- The ApplicationHost.config file contains settings for IIS and its services. By default, it is located at `%windir%\System32\inetsrv\config\applicationHost.config`.
- The Root Web.config file holds the global settings for ASP.NET Web applications, and it is located at `%windir%\Microsoft.NET\Framework\&lt;*framework\_version*&gt;\Config\Root Web.config`. This file gives each application a Web.config file that overrides global settings and also allows the IIS configuration settings to be stored in these Web.config files, making copying applications across multiple Web servers much easier, and avoids costly and error-prone replication, manual synchronization, and additional configuration tasks.

## Administration Using IIS 7 and Above

IIS can be used to execute the same management tasks that are performed on Apache.

### Customizing Error Messages

For every standard HTTP error 403, 404, and 504, a message is returned to the browser. Different Web servers allow administrators to return a default error message, a specific Web page, or a file as a Web page for each error.

- In Apache, customizing error messages is done using the .htaccess file, which administrators can use to manipulate server behavior and create custom server error messages. Examples of such errors are the "404 Not Found" error that appears when a link is broken and the "500 Internal Server Error" that appears when a script fails. The .htaccess file tells the server to display a special page in case of an error.
- IIS also lets administrators return special pages in place of default pages for Web site errors. For example, instead of displaying the message "404 File Not Found," a message listing optional links along with the company header and an apologetic note may be displayed.

By default, IIS returns two types of errors when a problem occurs. The first type is the standard custom error, including a terse error description and an error code. The second type of error is a detailed error, which by default only returns requests from localhost. IIS can be configured to return detailed errors all the time, specifically when the application needs to be run in debug mode, or to never return detailed errors and instead always return custom errors.

### URL Rewriting

URL rewriting is a way to modify the appearance of a Web URL. Web application users prefer short, neat URLs instead of raw query string parameters. A concise URL is easy to remember and less time-consuming to type in. If the URL can be made to relate clearly to the content of the page, then errors are less likely to happen.

- For URL rewriting, Apache comes with a well-known module called mod\_rewrite. This module provides a rule-based rewriting engine to rewrite requested URLs on the fly. The mod\_rewrite module is enabled in the Apache.conf file by removing the # and restarting Apache. Rewrite rules can then be defined in the .htaccess file within any particular directory.
- IIS now offers a URL Rewriting module (see: [URL Rewrite Module](https://www.iis.net/downloads/microsoft/url-rewrite)).

### Web Caching

Web caching is the temporary storage of Web objects, such as HTML documents, for later retrieval. There are three significant advantages to Web caching: reduced bandwidth consumption as fewer requests and responses need to go over the network, reduced server load as a server has fewer requests to handle, and reduced latency since responses for cached requests are available immediately and are closer to the client being served. Together, these advantages make the Web less expensive and improve performance.

Caching can be performed by the client application and is built into most Web browsers. A number of products extend or replace built-in caches with systems containing larger storage, more features, or better performance. Caching can also be implemented between the client and the server as part of a proxy. Proxy caches are often located near network gateways to reduce the bandwidth required over expensive dedicated Internet connections. Finally, caches can be placed directly in front of a particular server to reduce the number of requests that the server must handle.

- In Apache 2.0 and 2.2, caching normally relies on three modules: mod\_cache, mod\_disk\_cache, and mod\_mem\_cache. The commands to configure caching must be defined in the main server configuration file(s), not in .htaccess files. Caching techniques do not work without server administrator access and are most appropriate for dynamic content that should be cached and served as static content. This is how Apache forces the caching of dynamic content for a certain period of time that would otherwise be served dynamically each time before hitting the database again.
- The IIS output cache is a new feature that makes it possible to cache entire responses in memory, even from dynamic content, and lets site owners and developers configure the output cache to allow caching of separate copies of responses based on query string values.

The output cache is also integrated with the HTTP.sys kernel cache that helps with fast performance. Kernel caching is unlocked by default. Developers can take advantage of this feature by configuring caching profiles within their applications. A command-line tool can be executed to show the content in the HTTP.sys cache. A rule based on response headers may be configured to cache different versions of content in a site or application.

### Web Output Compression

Although Web page compression is not a new technology, it has recently become popular among IT administrators and managers because of the almost-immediate return on investment (ROI) that it generates.

- The Web output compression solution available in Apache is mod\_gzip, with which configured file types are compressed using GZIP encoding after processing by Apache's other modules and before being sent to the client. When a request is received from a client, Apache determines if mod\_gzip should be invoked by noting whether the "Accept-Encoding" HTTP request header was sent. If the client sends the header, mod\_gzip compresses the output of all configured file types when they are sent to the client.
- IIS has improved and simplified support for GZIP encoding enabled out-of-the-box execution of Web compression. Compression is configured in the ApplicationHost.config file at C:\Windows\System32\inetsrv\config\applicationhost.config. The compression module gives IIS the ability to serve compressed responses to compression-enabled clients. Clients that can accept compressed responses send an Accept-Encoding header indicating the compression schemes that they can handle. If IIS can compress the response using one of these compression schemes, it then sends a compressed response with a Content-Encoding response header indicating the scheme used to compress the response.

## Diagnostics and Troubleshooting

To effectively manage a Web server, it is necessary to get feedback on the activity and performance of the server and on any problems that may be occurring.

### Apache

The Apache HTTP Server provides comprehensive and flexible logging capabilities:

- **Error logs.** The server error log, whose name and location is set by the ErrorLog directive, is the most important log file. This is where Apache Httpd sends diagnostic information and records any errors that it encounters in processing requests. It is the first place to look when a problem occurs with starting or operating the server, since it often contains details of what went wrong and how to fix it.   
  
 A wide variety of different messages can appear in the error log. The error log also contains debugging output from CGI scripts. Any information written to stderr by a CGI script is copied directly to the error log.  
  
 Customizing the error log by adding or removing information is not possible. However, error log entries dealing with particular requests have corresponding entries in the access log. Customizing the access log to provide more information is also possible.

- **Access logs.** In Apache, the server access log records all requests processed by the server. The CustomLog directive controls the location and content of the access log. The LogFormat directive can be used to simplify the selection of the contents of the logs. Various versions of Apache Httpd use different modules and directives to control access logging, including mod\_log\_config, mod\_log\_referer, mod\_log\_agent, and the `TransferLog` directive.
- **Script logs.** To aid in debugging, the ScriptLog directive allows you to record the input to and output from CGI scripts. This should only be used during testing and not for live servers.
- **Rewrite log****s.** When using the powerful and complex features of mod\_rewrite, it is almost always necessary to use the RewriteLog to help in debugging. This log file produces a detailed analysis of how the rewriting engine transforms requests. The RewriteLogLevel directive controls the level of detail.

### IIS 7 and Above

IIS includes major improvements that aid in diagnostics and troubleshooting to help developers and administrators more easily work with errant Web sites and applications. The following are improvements in diagnostic and troubleshooting tools in IIS:

- Lets the administrator see all requests currently running on the server.
- Provides detailed local server error logs.
- Provides detailed trace log that make it possible to track problem issues and obtain detailed information about trace events.
- Includes new Runtime State and Control API (RSCA) for real-time state information about application pools, worker processes, sites, application domains, and running requests (providing real-time state information through a native Component Object Model [COM] API and Appcmd.exe).
- Can be configured to automatically capture full trace logs.
- Contains tools that let IT staff find problems and troubleshoot in IIS Manager.

## Securing the Web Server

### Apache

Apache administrators often use the following to secure their configurations:

- Apply security patches.
- Hide the Apache version number and other sensitive information.
- Make sure Apache is running under its own user account and group.
- Ensure that files outside the Web root are not served.
- Turn off directory browsing.
- Turn off CGI execution.
- Run mod\_security, a module written to apply several different security configurations:

    - Filtering (Simple and Regular Expression based)
    - Encoding Validation (URL and Unicode)
    - Auditing
    - Upload memory limits
    - Server identity masking, etc.

### IIS 7 and Above

Request Filtering is integrated into IIS. Details and a complete options set for the module can be found [here](../../manage/configuring-security/use-request-filtering.md).

Dynamic IP Restrictions for IIS is a module that provides protection against denial-of-service and brute-force attacks on Web servers and Web sites. Such protection is provided by temporarily blocking IP addresses of the HTTP clients that make unusually high number of concurrent requests or that make large number of requests over a short period of time. Detailed instructions on the installation and use of this module can be found [here](../../manage/configuring-security/using-dynamic-ip-restrictions.md).


> [!NOTE]
> *This article is based on the white paper*[IIS 7.0 for Apache Administrators](https://download.microsoft.com/download/2/D/8/2D863347-3AFF-48A6-9FCF-EC6554C18DCF/IIS_7_for_Apache.doc)*.*


## Links for Further Information

[My Take: IIS vs. Apache](https://blogs.iis.net/bills/archive/2007/05/07/iis-vs-apache.aspx).

[Benefits of Running IIS7 Over IIS6 Or Apache](http://ezinearticles.com/?Benefits-of-Running-IIS7-Over-IIS6-Or-Apache&amp;id=2131887).

See: http://secunia.com/advisories/product/1438/?task=statistics.