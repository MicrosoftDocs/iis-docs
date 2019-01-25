---
title: "Translate .htaccess Content to IIS web.config"
author: rick-anderson
description: "Many PHP applications are distributed with configuration files for the Apache Web server. These configuration files (usually called .htaccess files) contain..."
ms.date: 02/23/2009
ms.assetid: ce4e6cf1-dec5-4a42-9ca6-be447dc7fa0d
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/translate-htaccess-content-to-iis-webconfig
msc.type: authoredcontent
---
Translate .htaccess Content to IIS web.config
====================
by Steve Jacobson

## Introduction

Many PHP applications are distributed with configuration files for the Apache Web server. These configuration files (usually called .htaccess files) contain a number of settings that can be used for integrating the application with the capabilities of the Web server.

IIS 7 and above uses a file called Web.config to hold settings for integration with applications. The Web.config file contains information that control module loading, security configuration, session state configuration, and application language and compilation settings. Web.config files can also contain application-specific items such as database connection strings.

This article describes the most common uses of the .htaccess file by PHP applications, and shows how to use the Web.config file for these same functions in IIS.

## Sample Application Configuration Files

The following examples are two configuration files for a sample application: an .htaccess file and a Web.config file.

### Sample Application .htaccess File


[!code-console[Main](translate-htaccess-content-to-iis-webconfig/samples/sample1.cmd)]


### Sample Application Web.config File


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample2.xml)]


## Request Filtering

This application uses the *FilesMatch* directive in the .htacess file to limit browser access to files that are components of the application.


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample3.xml)]


IIS uses the Request Filtering module to limit browser access to files that are components of the application. For the sample application in a Web.config file, the section could look like:


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample4.xml)]


Note that you can leave this section commented out for installation, because the installation scripts are blocked by this filter.

An alternative to using the request filtering is to use the URL Rewriter module to return a 403 error for any of the matching file types. The advantage of the URL Rewriter module is that it uses a regular expression for the match.


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample5.xml)]


## Default Document

In the .htaccess file for the sample application, the *DirectoryIndex* directive tells the Web server which file to load if no filename is included with the URL.


[!code-powershell[Main](translate-htaccess-content-to-iis-webconfig/samples/sample6.ps1)]


For IIS, the default document should be set up as high in the Web site hierarchy as the Module Handler. For example, with PHP, the Module Handler is usually set at the Web server level. The default document should be set at that level also, rather than locally within a Web site's context. The following code within your Web.config file can ensure this:


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample7.xml)]


## URL Rewriting

IIS includes the URL Rewrite module. You can use this extension to provide rules for IIS to rewrite incoming URL requests. The most common use of URL Rewriting is to provide shorter, easy-to-remember URLs.

Many PHP applications currently ship with rewrite rules as part of their .htaccess file. These rules tell Apache's mod\_rewrite how and when to rewrite incoming requests. The IIS URL Rewrite module can read these rules and translate them into URL Rewrite rules.

For more information about importing Apache mod\_rewrite rules, see: [Importing Apache mod\_rewrite Rules](../../extensions/url-rewrite-module/importing-apache-modrewrite-rules.md).

For the sample application, the relevant mod\_rewrite rules in the .htaccess file are:


[!code-console[Main](translate-htaccess-content-to-iis-webconfig/samples/sample8.cmd)]


The IIS URL Rewriter module can read these rules and translate them. The translated URL Rewriter rules are:


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample9.xml)]


## Error Page Redirects / Handling

Some applications handle standard errors within the scope of the application. The *ErrorDocument* directive in the .htaccess file of the sample application tells the Web server to load the home page for any 404 or "File Not Found" errors.


[!code-powershell[Main](translate-htaccess-content-to-iis-webconfig/samples/sample10.ps1)]


IIS uses the *httpErrors* directive for this functionality. However, because the capability to set this at the application level is turned off by default for IIS, this section should be commented out.


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample11.xml)]


## Directory Browsing

Another application security (or integrity) measure often implemented is disabling directory browsing from the clients. Many Web server configurations will let users see a listing of files in a directory that does not contain one of the default document files. In the .htaccess file of the sample application, this is disabled using the *Options* directive:


[!code-powershell[Main](translate-htaccess-content-to-iis-webconfig/samples/sample12.ps1)]


IIS limits this access in the Web.config file using the *directoryBrowse* directive:


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample13.xml)]


## Cache Aging

Caching directives are used to ensure that static content is cached for a period of time, and dynamic content is not cached at all. In the .htaccess file of the sample application, the *ExpiresBy* directives provided by mod\_expires module are used.


[!code-powershell[Main](translate-htaccess-content-to-iis-webconfig/samples/sample14.ps1)]


In the Web.config file, IIS uses the Output Caching module and the caching directive to control caching. For the sample application, you can enable caching for .html files for a maximum of 14 days. For .php files, ensure that no caching is performed at all with the code:


[!code-xml[Main](translate-htaccess-content-to-iis-webconfig/samples/sample15.xml)]


<a id="_Toc221427762"></a><a id="_Sample_Application_.htaccess"></a>

## Links for Further Information

- [IIS URL Rewriting and Microsoft® ASP.NET routing](../../extensions/url-rewrite-module/iis-url-rewriting-and-aspnet-routing.md).
- [IIS forum](https://forums.iis.net/).