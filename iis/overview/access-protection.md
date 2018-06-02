---
title: "Access Protection"
author: shirhatti
description: "Safeguard your web server from malicious requests and unauthorized access with URL authorization rules and built-in request filtering."
ms.author: soshir
ms.date: 3/6/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---

# Access Protection

-----------------
Safeguard your web server from malicious requests and unauthorized access with URL authorization rules and built-in request filtering.

IIS provides a secure, reliable, platform for web application and services hosting. Support for URL authorization and request filtering rules give administrators fine-grained control over access of site content.

## URL Authorization

IIS stores URL authorization rules in an application's *web.config* file. The *web.config* authorization rules protecting against unauthorized access stay with the content, even if when content is moved to a different server or a new domain. IIS also supports ASP.NET URL authorization for all types of web content requests in the integrated pipeline.

## Built-in Request Filtering

IIS’s Request Filtering allows administrators to implement URL acceptance policies both globally and per URL. Filtering requests helps secure the server by ensuring that only valid requests are processed. Administrators can increase web server security by providing multiple filtering options.  Multiple filtering options can prevent malicious or incorrect URLs from being processed. For example, using Request Filtering, an administrator can set a rule that prevents the display of files with specified extensions, for example, *.ini* files.

For IIS 5.1 and IIS 6.0 users, IIS provides URL Scan 3.0 which, like IIS Request Filtering, restricts the types of HTTP requests that IIS will process. By blocking specific HTTP requests, the URL Scan 3.0 security tool helps to prevent potentially harmful requests from reaching applications on the server. URL Scan 3.0 screens all incoming requests to the server by filtering the requests based on rules. The  URL Scan 3.0 rules are set by the administrator. URL Scan 3.0 can be configured to filter HTTP query string values and other HTTP headers. Filtering can mitigate SQL injection attacks against applications while the root cause is being fixed.

## URL Rewriting

![Url Rewriter](access-protection/_static/url-rewriter-small.png)

Administrators can use URL Rewriter for IIS to protect applications on the web server. URL Rewriter enables dynamic modification of URLs based on rules defined by the site administrator. For example, rules can be created which prevent other sites from *hot-linking* to a web site’s images or video content. Disabling *hot-linking* prevents stealing content from the server and wasting bandwidth. Using:

* Rule templates
* Rewrite maps
* Other functionality integrated into IIS Manager

Administrators can set up rules to define URL rewriting behavior based on HTTP headers and server variables.

## HTTP Strict Transport Security (HSTS)

IIS adds support for [HTTP Strict Transport Security](/iis/get-started/whats-new-in-iis-10-version-1709/iis-10-version-1709-hsts) that instructs browsers that the specified web site should only be accessed using HTTPS (HTTP is not allowed).

## Cross Origin Resource Sharing (CORS)

Browsers usually apply same-origin restrictions to network requests. These restrictions would prevent a malicious page from making a cross origin request initiated from within a script. For such scenarios to work, you will need to configure your API to reply with appropriate CORS headers. [The IIS CORS module](/iis/extensions/cors-module/cors-module-configuration-reference) provides a way for web administrators and web site authors to support the CORS protocol by delegating all CORS protocol handling to the module.
