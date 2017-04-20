---
title: "IIS 7.0 Request Filtering and URL Rewriting | Microsoft Docs"
author: ruslany
description: "IIS 7.0 and above includes a request filtering module that is based on the URLScan ISAPI Filter for IIS 6.0. The module helps you tighten security of your We..."
ms.author: iiscontent
manager: soshir
ms.date: 09/04/2008
ms.topic: article
ms.assetid: 5b6e680a-85ff-4738-bdc3-52b422f176c1
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/url-rewrite-module/iis-request-filtering-and-url-rewriting
msc.type: authoredcontent
---
IIS 7.0 Request Filtering and URL Rewriting
====================
by [Ruslan Yakushev](https://github.com/ruslany)

IIS 7.0 and above includes a request filtering module that is based on the URLScan ISAPI Filter for IIS 6.0. The module helps you tighten security of your Web servers.

The IIS team has also released an add-on URL rewrite module for IIS, which provides functionality for rule-based URL manipulation. Even though the primary purpose of the URL rewrite module is to rewrite URL paths for requests, the rewrite module can also be used as a security enforcement tool that helps prevent access to Web site content.

This article explains the differences between these two modules and provides guidance on which to choose for tightening the security of your Web server.

## Request Filtering and URL Rewriting in the IIS Request Processing Pipeline

First of all, it is important to understand how the request filtering module and the rewrite module plug into the IIS pipeline. The following diagram shows the relative order of these two modules:

[![](iis-request-filtering-and-url-rewriting/_static/image2.gif)](iis-request-filtering-and-url-rewriting/_static/image1.gif)

The request filtering module runs at the beginning of the request processing pipeline by handling the BeginRequest event. The module evaluates the request metadata, such as headers, the query string, content length, etc, in order to determine whether the request metadata matches any existing filter. If there is a match, the module generates a 404 (File Not Found) response and then shortcuts the remainder of the IIS pipeline.

If the request filtering module has not filtered the request, the request is passed to the next module in the IIS pipeline, which might be the URL rewrite module. The URL rewrite module evaluates the request against rewrite rules. If a rule results in a redirection, or sends a custom response or aborts the request, the rewrite module generates an appropriate response and then shortcuts the remainder of the IIS pipeline.

Notice that the request filtering module is placed before the URL rewrite module. This is because in IIS architecture, the request filtering module is considered to be a gatekeeper component that protects the Web server from malicious requests. The URL rewrite module is considered to be a server-based URL manipulation component that works on the URLs that have already been filtered by the request filtering module. You can think of URL rewriting as server-based application logic, similar to ASP.NET applications that can also perform rewriting or redirection. Request filtering is a first line of defense, while the URL rewriter can be a second security barrier that is more application specific. For more details, see the blog post "[Interaction between URL Rewriter and Request Filtering Modules for IIS7](https://blogs.iis.net/nazim/archive/2008/06/06/interaction-between-url-rewriter-and-request-filtering-modules-for-iis7.aspx)" on the IIS Web site.

## Differences Between Request Filtering and URL Rewriting

The conceptual differences between request filtering and URL rewriting are these:

- Request filtering is designed and optimized purely for security scenarios.
- URL rewriting can be applied for a broad set of scenarios; security scenarios are just a subset of these.

With that in mind, you can compare the features of each module that can be used for security scenarios. You should consider the following categories:

1. Filtering criteria. What kind of input can be used to make a decision about blocking a request? Also, what conditions can be used to express the request-blocking logic?
2. Request-blocking actions. What actions can be performed when a request satisfies the filtering criteria?
3. Performance impact. How might request filtering and URL rewriting affect the performance of your Web server?

### Filtering Criteria

The following table lists possible filtering criteria and explains how each module supports them.

| Criterion | Supported by request filtering module? | Supported by URL rewrite module? |
| --- | --- | --- |
| Scan requested URL path | Yes, using substring search | Yes, using regex and wildcard patterns |
| Check URL length | Yes | No |
| Scan query string | No | Yes, using regex and wildcard patterns |
| Check query string length | Yes | No |
| Check HTTP verbs | Yes | Yes |
| Check request content length | Yes | No |
| Scan HTTP headers | No | Yes, using regex and wildcard patterns |
| Check HTTP headers length | Yes | No |
| Scan server variables | No | Yes |
| Check sender's IP address or host name | No\* | Yes |

\* The IP Restriction module in IIS can be used for blocking requests from specific IP addresses and host names.

### Request-Blocking Actions

The request filtering module has only one action, which it performs when a request matches a filtering criterion. The action is to return status code 404 (File Not Found).

The URL rewrite module provides a much wider set of options if a request should be blocked, including the following:

1. The requested URL can be rewritten to some other URL. For example, to prevent image hot-linking, you can rewrite a URL to a placeholder image file for any requests that come from a third-party domain.
2. The Web client can be redirected to a different URL.
3. An HTTP status code of your choice can be sent to the Web client. For example, you might send a status 401 (Unauthorized) response for requests that match specific filtering criteria.
4. The HTTP request can be aborted by dropping the socket connection. That way, the Web client gets no information about the Web server at all.

### Performance Impact

Both modules have been implemented to have as little impact as possible on the performance of the IIS Web server. However, there are the following important performance differences between these modules:

- The URL rewrite module relies heavily on regular expression patterns. Evaluating regular expressions is an expensive operation, and if you define many complex rewrite rules, you might see a noticeable impact on the throughput of your Web server.
- The request filtering module does not use regular expressions or any other pattern matching. It simply performs a substring search, which can have a significantly smaller impact on Web server throughput.

## Choosing Between Request Filtering and URL Rewriting

If you are choosing between request filtering and URL rewriting for tightening the security of your Web server, the general rule is to start with request filtering. Request filtering is optimized for security scenarios and its feature set will most likely be sufficient for implementing your security requirements. If you have a requirement that cannot be addressed by the request filtering module, use the URL rewrite module to implement that requirement, and leave the rest of the security tasks to the request filtering module. That way you reduce the performance impact of the URL rewrite module by having the minimal amount of rewrite rules for the server to process.