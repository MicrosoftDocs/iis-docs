---
title: "Provide URL Rewriting Functionality"
author: rick-anderson
description: "The Microsoft ® URL Rewrite Module for Internet Information Services 7 (IIS 7) and above provides flexible rules-based rewrite engine that can be used to per..."
ms.date: 11/15/2009
ms.assetid: 06fa0273-c583-4020-8743-1afadce4e625
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-applications-on-iis/provide-url-rewriting-functionality
msc.type: authoredcontent
---
# Provide URL Rewriting Functionality

by Tali Smith

## Introduction

The Microsoft® URL Rewrite Module for Internet Information Services 7 (IIS 7) and above provides flexible rules-based rewrite engine that can be used to perform broad spectrum of URL manipulation tasks, including, but not limited to:

- Enabling user-friendly and search engine-friendly URLs with dynamic Web applications.
- Rewriting URLs based on HTTP headers and server variables.
- Handling Web site content.
- Controlling access to Web site content based on URL segments or request metadata.

## Features of the URL Rewrite Module

The Microsoft URL Rewrite Module includes these key features:

- **Rules-based URL rewriting engine**. Rewrite rules are used to express the logic of what to compare/match the request URL with, and what to do if comparison was successful. Web server and site administrators can use rewrite rule sets to define URL rewriting logic.
- **Regular expression pattern matching**. Rewrite rules can use ECMA-262 compatible, regular expression syntax for pattern matching.
- **Wildcard pattern matching.** Rewrite rules can use wildcard syntax for pattern matching.
- **Global and distributed rewrite rules**. Global rules are used to define server-wide URL rewriting logic and are defined within the ApplicationHost.config file. They cannot be overridden or disabled on any lower configuration levels. Distributed rules are used to define URL rewriting logic specific to a particular configuration scope. Distributed rules can be defined on any configuration level by using Web.config files.
- **Access to server variables and http headers**. Server variables and HTTP headers provide additional information about current HTTP requests. This information can be used to make rewriting decisions or to compose the output URL.
- **Various rule actions**. Instead of rewriting a URL, a rule may perform other actions, such as issue an HTTP redirect, abort the request, or send a custom status code to HTTP client.
- **Support for IIS kernel mode and user mode output caching.** IIS output caching provides significant performance improvements for Web applications. The URL Rewrite Module is fully compatible with both types of output caching. This means that it is possible to safely cache responses for rewritten URLs, and thus boost the performance of Web applications that rely on URL rewriting.
- **String manipulation functions.** Built-in string manipulation functions can be used to convert URLs to lowercase and to perform URL encoding and decoding.
- **Rewrite maps**. A rewrite map is an arbitrary collection of name-value pairs that can be used within the rewrite rules to generate the substitution URL during rewriting. Rewrite maps are particularly useful when you have a large set of rewrite rules, all of which use static strings (for example, if there is no pattern matching used). In those cases, instead of defining a large set of simple rewrite rules, you can put all the mappings between input URL and substitution URL as keys and values into the rewrite map, and then have one rewrite rule that references this rewrite map to look up a substitution URL based on the input URL.
- **Failed Request Tracing support**. IIS Failed Request Tracing can be used to troubleshoot errors related to URL rewriting.
- **Rule templates**. A rule template is an extension for the URL Rewrite Module user interface that simplifies the creation of rewrite rules for a particular task. The module includes three built-in rule templates. It also lets you plug in any number of custom templates.
- **UI for testing of regular expression and wildcard patterns**. A GUI tool for testing rule patterns is included in the module's user interface. The tool can be used to quickly check how the regular expression or wildcard pattern works. It can also be used for troubleshooting and debugging of problems related to pattern matching.
- **UI for managing rewrite rules and rewrite maps**. Rewrite rules and rewrite maps can be added, removed and edited by using the URL Rewrite Module feature in IIS Manager.
- **GUI tool for importing of mod\_rewrite rules**. The URL Rewrite Module includes a GUI tool for converting rewrite rules from mod\_rewrite format into an IIS format.

## URL Rewrite Module Resources

The following articles cover the functionality of the URL Rewrite Module, and explain how to use it to accomplish common URL rewriting scenarios.

**Learning the basics**

- [Creating rewrite rules](../../extensions/url-rewrite-module/creating-rewrite-rules-for-the-url-rewrite-module.md "Creating rewrite rules")
- [Using Failed Request Tracing to trace rewrite rules](../../extensions/url-rewrite-module/using-failed-request-tracing-to-trace-rewrite-rules.md "Using FRT to trace rewrite rules")
- [Using global and distributed rules](../../extensions/url-rewrite-module/using-global-and-distributed-rewrite-rules.md "Using global and distributed rewrite rules")
- [Using rewrite maps](../../extensions/url-rewrite-module/using-rewrite-maps-in-url-rewrite-module.md "Using rewrite maps")
- [Importing rewrite rules](../../extensions/url-rewrite-module/importing-apache-modrewrite-rules.md "Importing rewrite rules")
- [Enabling "pretty permalinks" in WordPress](../../extensions/url-rewrite-module/enabling-pretty-permalinks-in-wordpress.md "Enabling Pretty Permalinks")
- [Rule templates](../../extensions/url-rewrite-module/rule-templates-overview.md) 

    - [User-friendly URL](../../extensions/url-rewrite-module/user-friendly-url-rule-template.md)
    - [Rule with Rewrite Map](../../extensions/url-rewrite-module/rule-with-rewrite-map-rule-template.md)
    - [Request blocking](../../extensions/url-rewrite-module/request-blocking-rule-template.md)
- [Testing rule and condition patterns](../../extensions/url-rewrite-module/testing-rewrite-rule-patterns.md)

**References and guidance**

- [URL Rewrite Module configuration reference](../../extensions/url-rewrite-module/url-rewrite-module-configuration-reference.md "Configuration reference")
- [URL Rewriting and Microsoft® ASP.NET routing](../../extensions/url-rewrite-module/iis-url-rewriting-and-aspnet-routing.md)
- [URL rewriting and request filtering](../../extensions/url-rewrite-module/iis-request-filtering-and-url-rewriting.md)
- [URL rewriting for ASP.NET Web forms](../../extensions/url-rewrite-module/url-rewriting-for-aspnet-web-forms.md)
- [Developing rule templates for the URL Rewrite Module](../../extensions/url-rewrite-module/developing-rule-template-for-url-rewrite-module.md)

**Video walkthrough**

- [Using the URL Rewrite Module - video walkthrough](../../extensions/url-rewrite-module/url-rewrite-module-video-walkthrough.md)

### Known Issues and Changes

There are a few known issues and changes to consider:

- The mod\_rewrite rules that use **REQUEST\_URI** server variables may not work correctly when imported by using the URL rewrite "**Import Rules…**" feature. To fix the imported rules, use any text editor to open the web.config file that contains those rules. Locate the `<rewrite>` section, and then within that section replace all instances of string "**{SCRIPT\_NAME}**" with the string "**{URL}**".
- Digest authentication cannot be used with the URL Rewrite Module.
- ASP.NET Forms Authentication uses rewritten URLs for redirection. For example, if the requested URL is "**/article.htm**" and the URL Rewrite Module rewrites the URL to "**/article.aspx**", which is protected by Forms Authentication, then ASP.NET redirects to "**/login.aspx?ReturnUrl=%2Farticle.aspx**".
- The auto-detect mode in ASP.NET Forms Authentication uses rewritten URLs for redirection. For example, if the requested URL is "**/article.htm**" and the URL Rewrite Module rewrites the URL to "**/article.aspx**", which is protected by Forms Authentication, then ASP.NET redirects to "**/article.aspx?AspxAutoDetectCookieSupport=1**".
- UseUri mode in ASP.NET Forms Authentication uses rewritten URLs for redirection. For example, if the requested URL is "**/article.htm**" and URL rewrite module rewrites the URL to "**/article.aspx**", which is protected by Forms Authentication, then ASP.NET redirects to "**/(S(vy2ebt45imfkmjjwboow3l55))/article.aspx**".
- ASP.NET rewrites back to the original URL when using URI-based authentication or a cookieless session state. For example, when a request is made to "**/(S(vy2ebt45imfkmjjwboow3l55))/article.htm**" and the URL Rewrite Module rewrites "**/article.htm**" to "**/article.aspx**", then ASP.NET rewrites the URL back to "**/article.htm**", which may result in a "404 - File Not Found" error.
- The IIS DefaultDocument module may redirect to a rewritten URL when the URL Rewrite Module rewrites to a folder. For example, if a substitution URL in a rewrite rule is "**/folder1/folder2**", and these folders exist on file system and have default document configured, then DefaultDocument module redirects a Web client to "**/folder1/folder2/**", thus exposing the rewritten URL. To prevent this from happening, use "/" at the end of the substitution URL when rewriting to a folder (for example, "**/folder1/folder2/**").

## Example: Enable "Pretty Permalinks"

Typically, WordPress users must use "almost pretty" URLs (for example, `http://contoso.com/index.php/yyyy/mm/dd/post-name/`). With the URL Rewrite module, you can create "Pretty Permalinks" (for example, `http://example.com/year/month/day/post-name/`) for WordPress blogs hosted on IIS.

The steps that follow assume that WordPress is installed in a Web site root directory. If WordPress is installed in a subdirectory, then the rewrite rules must be included in the Web.config file located within the same subdirectory as the WordPress files.

1. Install **URL Rewrite Go Live** release.
2. Log on to **WordPress** as an administrator.
3. Click the **Settings** button.
4. Click the **Permalinks** tab for the **Customize Permalink Structure** page.  

    [![Screenshot shows Permalink Settings page with Default selected.](provide-url-rewriting-functionality/_static/image2.jpg)](provide-url-rewriting-functionality/_static/image1.jpg)

    *Figure 1: Customize permalink structure page*
5. Select **Custom Structure**, and then type  
    **/%year%/%monthnum%/%day%/%postname%/** in the **Custom Structure** text box.
6. Click **Save Changes**. You will see that all the blog post links have URLs that follow the format you have specified; however, if you click any link, the Web server returns a 404 - File Not Found error, because WordPress relies on a URL rewriting capability within a server to rewrite requests that have "pretty permalinks" to an Index.php file.

## Create Rewrite Rule

1. Open the **Web.config** file (located in the same directory as the WordPress files). If you do not have a Web.config file in the WordPress directory, create it.
2. Copy and paste the following XML section into the system.webServer element:  

    [!code-xml[Main](provide-url-rewriting-functionality/samples/sample1.xml)]

This rule matches any requested URL; if the URL does not correspond to a file or a folder on a file system, then the rule rewrites the URL to Index.php and determines which content to serve based on the REQUEST\_URI server variable that contains the original URL before it was modified by the rule.

## Test the Rewrite Rule

After the rewrite rule is saved to the Web.config file, open a Web browser, and click any one of the permalinks in WordPress blog. You should see the correct content returned by the Web server for every permalink.

[![Screenshot shows a test page in a block with the U R L highlighted.](provide-url-rewriting-functionality/_static/image4.jpg)](provide-url-rewriting-functionality/_static/image3.jpg)

*Figure 2: Blog welcome page*

*This article updates the*[*Enabling Pretty Permalinks in WordPress*](../../extensions/url-rewrite-module/enabling-pretty-permalinks-in-wordpress.md)*and*[*IIS 7 URL Rewrite Module support in WordPress 2.8*](https://blogs.iis.net/ruslany/archive/2009/05/16/iis-7-url-rewrite-module-support-in-wordpress-2-8.aspx)*articles written by Ruslan Yakushev.*

## Links for Further Information

- [URL Rewrite Module](https://www.iis.net/downloads?tabid=34&g=6&i=1691).
- [Creating rewrite rules for the URL Rewrite Module](../../extensions/url-rewrite-module/creating-rewrite-rules-for-the-url-rewrite-module.md).
- [Videocast about URL rewriting functionality](https://www.iis.net/downloads/microsoft/url-rewrite).
- [URL Rewrite Module 1.1 configuration](../../extensions/url-rewrite-module/url-rewrite-module-configuration-reference.md).
