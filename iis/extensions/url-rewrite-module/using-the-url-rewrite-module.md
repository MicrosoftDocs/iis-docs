---
title: "Using the URL Rewrite Module | Microsoft Docs"
author: ruslany
description: "The Microsoft URL Rewrite Module 2.0 for IIS 7 and above enables IIS administrators to create powerful customized rules to map request URLs to friendly URLs..."
ms.author: iiscontent
manager: soshir
ms.date: 05/30/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/url-rewrite-module/using-the-url-rewrite-module
msc.type: authoredcontent
---
Using the URL Rewrite Module
====================
by [Ruslan Yakushev](https://github.com/ruslany)

## About the URL Rewrite module

The Microsoft URL Rewrite Module 2.0 for IIS 7 and above enables IIS administrators to create powerful customized rules to map request URLs to friendly URLs that are easier for users to remember and easier for search engines to find. You can use the URL Rewrite module to perform URL manipulation tasks, some of which include:

- Define powerful rules to transform complex URLs into simple and consistent Web addresses.
- Easily replace Web application URLs to produce user and search engine friendly results.
- Rewrite URLs based on HTTP headers and IIS server variables.
- Perform redirects, send custom responses, or stop HTTP requests based on the logic expressed in the rewrite rules.
- Control access to Web site content based on URL segments or request metadata.

The URL Rewrite module is available both as a download that you can install on your own IIS server, and on Microsoft's [Azure Web Sites](https://www.windowsazure.com/en-us/documentation/services/web-sites/) cloud platform.

## URL Rewrite 2.0 features

The Microsoft URL Rewrite module 2.0 includes the following key features:

- **Rules-based URL rewriting engine**. Rewrite rules define the logic used to analyze request URLs and map them to rewite URLs when the request URL matches a defined rule. Web server and site administrators can use rewrite rule sets to define URL rewriting logic.
- **Regular expression pattern matching**. Rewrite rules can use regular expression syntax for pattern matching as defined in [ECMA-262](http://www.ecma-international.org/publications/files/ECMA-ST/Ecma-262.pdf).
- **Wildcard pattern matching.** Rewrite rules can use wildcard syntax for pattern matching.
- **Global and distributed rewrite rules**. URL Rewrite uses global rules to define server-wide URL rewriting logic. These rules are defined within the applicationHost.config file, and they supercede rules configured at lower levels in the configuration hierarchy. The module also uses distributed rules to define URL rewrite logic specific to a particular configuration scope. This type of rule can be defined on any configuration level by using Web.config files.
- **Access to server variables and HTTP headers**. Server variables and HTTP headers provide additional information about current HTTP requests. This information can be used to configure rewrite rules or to compose the output URL.
- **Various rule actions**. Instead of rewriting a URL, a rule may perform other actions, such as issue an HTTP redirect, abort the request, or send a custom status code to HTTP clients.
- **Support for IIS kernel mode and user mode output caching.** IIS output caching provides significant performance improvements for Web applications. The URL Rewrite module is fully compatible with both types of output caching. This means that it is possible to safely cache responses for rewritten URL's and thus boost the performance of Web applications that rely on URL rewriting.
- **String manipulation functions.** Built-in string manipulation functions can be used to convert URLs to lowercase and to perform URL encoding and decoding.
- **Rewrite maps**. A rewrite map is an arbitrary collection of name-value pairs. You can use a rewrite map within rewrite rules to generate the substitution URL. Rewrite maps are particularly useful when you have a large set of rewrite rules, all of which use static strings (i.e. there is no pattern matching used). In those cases, instead of defining a large set of simple rewrite rules, you can put all the mappings between into the rewrite map using the input URL as a key, and the substitution URL as value. You can then have one rewrite rule that references the rewrite map to look up substitution URL based on the input URL.
- **Failed Request Tracing support**. IIS Failed Request Tracing can be used to troubleshoot errors related to URL rewriting.
- **Rule templates**. A rule template is an extension for the URL Rewrite module user interface that simplifies creation of rewrite rules for a particular task. The module includes 3 rule templates, and also supports plugging in any number of custom templates.
- **User Interface (UI) for testing regular expression and wildcard patterns**. A UI for testing rule patterns is provided with the module. Using the UI, you can quickly check the results of a regular expression or wildcard pattern in a rewrite rule. You can also use the UI for troubleshooting and debugging problems related to pattern matching.
- **UI for managing rewrite rules and rewrite maps**. Rewrite rules and rewrite maps can be added, removed, and edited by using the URL Rewrite Module from the IIS Manager.
- **UI for importing mod\_rewrite rules**. The URL Rewrite module includes a UI for converting rewrite rules from mod\_rewrite format into an IIS format.

## Where to get the URL Rewrite module

For more information and to download the module, see [URL Rewrite](https://www.iis.net/downloads?tabid=34&g=6&i=1691).

[Download the x86 version of the URL Rewrite module](https://go.microsoft.com/?linkid=9722533)

[Download the x64 version of the URL Rewrite module](https://go.microsoft.com/?linkid=9722532)

### Upgrading from Go Live release

If you already have the Go Live release of URL rewrite module installed the installation package will upgrade it to URL Rewrite version 2.0. All rewrite rules in your ApplicationHost.config and Web.config files will be preserved.

### ASP.NET update

The URL Rewrite module installer package includes an ASP.NET update that fixes ASP.NET bugs specific to the URL Rewrite module. SPecifically, the update contains fixes for the following bugs:

1. ~ operator in ASP.NET Web server control is resolved incorrectly when using URL Rewrite.
2. ASP.NET SiteMap.CurrentNode property returns null when sitemap contains virtual URLs.

The update is applied only if the machine where URL Rewrite module is being installed has .NET Framework version 3.5 SP1 or higher. If you install the required version of the .NET Framework after you install the URL Rewrite module, you can apply the ASP.NET update by running the URL Rewrite module installer and then selecting the **Repair** option in the installer dialog.

For more details about these and other ASP.NET issues related to URL rewriting, see [URL Rewriting for ASP.NET Web Forms](url-rewriting-for-aspnet-web-forms.md).

## Using the module

These articles cover the functionality of the URL Rewrite Module and explain how to use it to implement common URL rewriting scenarios.

### Learning the basics

- [Creating Rewrite rules](creating-rewrite-rules-for-the-url-rewrite-module.md "Creating Rewrite rules")
- [Using Failed Request Tracing to trace rewrite rules](using-failed-request-tracing-to-trace-rewrite-rules.md "Using FRT to trace rewrite rules")
- [Using global and distributed rules](using-global-and-distributed-rewrite-rules.md "Using global and distributed rewrite rules")
- [Using Rewrite maps](using-rewrite-maps-in-url-rewrite-module.md "Using rewrite maps")
- [Importing Apache mod\_rewrite rules](importing-apache-modrewrite-rules.md "Importing rewrite rules")
- [Enabling Pretty Permalinks in WordPress](enabling-pretty-permalinks-in-wordpress.md "Enabling Pretty Permalinks")
- [Rule templates](rule-templates-overview.md)

    - [User Friendly URL](user-friendly-url-rule-template.md)
    - [Rule with Rewrite Map](rule-with-rewrite-map-rule-template.md)
    - [Request Blocking](request-blocking-rule-template.md)
- [Testing rule and condition patterns](testing-rewrite-rule-patterns.md)

### References and guidance

- [URL Rewrite Module Configuration reference](url-rewrite-module-configuration-reference.md "Configuration reference")
- [URL Rewrite and ASP.NET routing](iis-url-rewriting-and-aspnet-routing.md)
- [URL Rewrite and Request Filtering](iis-request-filtering-and-url-rewriting.md)
- [URL Rewrite for ASP.NET Web Forms](url-rewriting-for-aspnet-web-forms.md)
- [Developing rule templates for the URL Rewrite module](developing-rule-template-for-url-rewrite-module.md)

### Video walkthrough

- [Using the URL rewrite module - video walkthrough](url-rewrite-module-video-walkthrough.md)

## Changes since Go Live release

The following additions, changes, and important bug fixes have been made to URL rewrite module since the Go Live release:

1. Added string manipulation functions **UrlEncode** and **UrlDecode**.
2. Provided access to a raw original URL via server variable UNENCODED\_URL. This server variable now contains the raw encoded URL exactly as it was requested by Web browser.
3. Added UI for configuring rewrite rules for Application Request Routing (ARR).
4. Added support for in-place upgrade from the Go Live release of the URL rewrite module.
5. Added functionality to clean up the internal cache to avoid excessive usage of memory when caching rewrite rules.
6. Fixed a bug related to rewriting of URLs that contain non-ASCII characters.
7. Fixed a bug in processing regular expressions that caused character ranges to be evaluated incorrectly for case-insensitive patterns.
8. Included an [update for IIS FastCGI module](https://support.microsoft.com/?kbid=954946) into the installer package.
9. Included an [update for System.Web.dll](https://support.microsoft.com/?kbid=957660) into the installer package.
10. Included an update for the IIS **SetUri** function into the installer package.

## Known Issues

1. mod\_rewrite rules that use **REQUEST\_URI** server variables may not work correctly when imported by using URL Rewrite the **Import Rules** feature. To fix the imported rules use, you can use any text editor to open the Web.config file that contains those rules. Locate the **&lt;rewrite&gt;** section, and then within that section replace all instances of the string "**{SCRIPT\_NAME}**" with the string "**{URL}**".
2. Digest authentication cannot be used with URL Rewrite module.
3. ASP.NET Forms authentication uses rewritten URL for redirection. For example, if the requested URL is "**/article.htm**" and the URL Rewrite module rewrites the URL to "**/article.aspx**", which is protected by Forms authentication, then ASP.NET will redirect to "**/login.aspx?ReturnUrl=%2Farticle.aspx**".
4. Auto-detect mode in ASP.NET Forms authentication uses a rewritten URL for redirection. For example, if the requested URL is "**/article.htm**" and the URL Rewrite module rewrites the URL to "**/article.aspx**", which is protected by Forms authentication, then ASP.NET will redirect to "**/article.aspx?AspxAutoDetectCookieSupport=1**".
5. UseUri mode in ASP.NET Forms authentication uses rewritten URL for redirection. For example, if the requested URL is "**/article.htm**" and URL Rewrite module rewrites the URL to "**/article.aspx**", which is protected by Forms authentication, then ASP.NET will redirect to "**/(S(vy2ebt45imfkmjjwboow3l55 ))/article.aspx**".
6. ASP.NET rewrites back to the original URL when using URI-based authentication or cookie-less session state. For example, when a request is made to "**/(S(vy2ebt45imfkmjjwboow3l55 ))/article.htm**" and URL rewrite module rewrites "**/article.htm**" to "**/article.aspx**", then ASP.NET will rewrite the URL back to "**/article.htm**", which may result in a "404 - File Not Found" error.
7. The IIS DefaultDocument module may redirect to a rewritten URL when the URL Rewrite module rewrites to a folder. For example, if the substitution URL in a rewrite rule is "**/folder1/folder2**" and these folders exist on the file system and have a Default document configured, then the DefaultDocument module will redirect Web clients to "**/folder1/folder2/**", thus exposing the rewritten URL. To prevent this from happening, use "/" at the end of the substitution URL when rewriting to a folder, for example, "**/folder1/folder2/**"
  
  
[Discuss in IIS Forums](https://forums.iis.net/1152.aspx)