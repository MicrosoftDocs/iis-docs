---
title: "Use Request Filtering | Microsoft Docs"
author: rick-anderson
description: "UrlScan, a security tool, was provided as an add-on to earlier versions of Internet Information Services (IIS) so administrators could enforce tighter securi..."
ms.author: iiscontent
manager: soshir
ms.date: 11/22/2007
ms.topic: article
ms.assetid: 240d711d-011b-4419-8560-6af44b339ba2
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/configuring-security/use-request-filtering
msc.type: authoredcontent
---
Use Request Filtering
====================
by IIS Team

## Introduction

UrlScan, a security tool, was provided as an add-on to earlier versions of Internet Information Services (IIS) so administrators could enforce tighter security policies on their Web servers. Within IIS 7 and above, all the core features of URLScan have been incorporated into a module called Request Filtering, and a Hidden Segments feature has been added. This article describes each feature of Request Filtering and gives examples of how the features can be applied in your environment.

Note that IIS also includes a module for URL rewriting. There are differences between these two modules: Request filtering is designed and optimized for security scenarios, while URL rewriting can be applied for a broad set of scenarios (security scenarios are just a subset of these). For more information about the differences, see [IIS 7.0 and Above Request Filtering and URL Rewriting](../../extensions/url-rewrite-module/iis-request-filtering-and-url-rewriting.md).

## Filter Double-Encoded Requests

This feature prevents attacks that rely on double-encoded requests and applies if an attacker submits a carefully crafted double-encoded request to IIS. When the double-encoded requests filter is enabled, IIS normalizes the URL twice; if the first normalization is different from the second, the request is rejected and the error code logged is 404.11. The double-encoded requests filter was the VerifyNormalization option in UrlScan.

If you do not want IIS to allow doubled-encoded requests to be served, use the following:


[!code-xml[Main](use-request-filtering/samples/sample1.xml)]


## Filter High Bit Characters

This feature either allows or rejects all requests to IIS that contain non-ASCII characters and logs the error code 404.12. The UrlScan equivalent is AllowHighBitCharacters.

For example, suppose you want to allow high bit characters for one application but not for the entire server. Set the allowHighBitCharacters="false" in the ApplicationHost.config file; but within the application root, create a Web.config file that allows that single application to accept non-ASCII characters. In the Web.config file, use:


[!code-xml[Main](use-request-filtering/samples/sample2.xml)]


## Filter Based on File Extensions

This feature defines a set of allowed file extensions that IIS serves. When IIS rejects a request based on file extensions, the error code logged is 404.7. The AllowExtensions and DenyExtensions options are the UrlScan equivalents.

For example, suppose you want to allow every type of file except ASP files. Set the allowUnlisted option for fileExtensions to "true", and then define a file extension entry to explicitly deny ASP:


[!code-xml[Main](use-request-filtering/samples/sample3.xml)]


## Filter Based on Request Limits

This filter combines three features (which had the same names in UrlScan):

- maxAllowedContentLength–upper limit on the content size
- maxUrl–upper bound on a URL length
- maxQueryString–upper bound on the length of a query string

When IIS rejects a request based on request limits, the error code logged is:

- 404.13 if the content is too long.
- 404.14 if the URL is too large.
- 404.15 if the query string is too long.

For example, it is very common for companies to purchase software to which they do not have source code access. Over time, they may find vulnerabilities in that code. Getting updates for the affected code is often not easy. The problems are frequently caused by a URL or query string that is too long or by an excess of content sent to an application. Once you determine a safe upper bound, you can apply limits using the configuration below, without having to patch the application binaries:


[!code-xml[Main](use-request-filtering/samples/sample4.xml)]


## Filter by Verbs

This feature defines a list of verbs that IIS accept as part of a request. When IIS reject a request based on this feature, the error code logged is 404.6. This corresponds to the UseAllowVerbs, AllowVerbs, and DenyVerbs options in UrlScan.

For example, suppose you only want to allow only the verb GET. To set this, you must first lock down the configuration so that no verbs are allowed by setting the allowUnlisted="false" option. Next, list the verbs you want to explicitly allow, in this case, GET.


[!code-xml[Main](use-request-filtering/samples/sample5.xml)]
  

## Filter Based on URL Sequences

This feature defines a list of sequences that IIS reject when it is part of a request. When IIS reject a request for this feature, the error code logged is 404.5.This corresponds to the DenyUrlSequences feature in UrlScan.

This is a very powerful feature. Using the following code, you can prevent a given character sequence from ever being served by IIS:


[!code-xml[Main](use-request-filtering/samples/sample6.xml)]


In the previous example, the '..' sequence is rejected. Suppose you purchased an application from a vendor who went out of business and you discovered that the application was vulnerable when a given character sequence was sent to it. Using this feature, you can protect that application by simply adding that URL sequence to the denied list without having to patch the application's code.

<a id="FilterHidden"></a>

## Filter Out Hidden Segments

This feature allows you to define which segments are "servable." When IIS rejects a request based on this feature, the error code logged is 404.8. This feature is new to IIS 7 and above; it was not part of UrlScan.

Consider the following example where there are two URLs on a server:

**`http://site.com/bin`**

**`http://site.com/binary`**

Suppose you want to allow content in the binary directory, but not the content in the bin directory. If you use URL sequences and reject the sequence "bin", you deny access to both URLs. By using the configuration shown below, you can deny access to bin, but still have the content in binary served:


[!code-xml[Main](use-request-filtering/samples/sample7.xml)]

<a id="Summary"></a>

## IIS 7 and Above Error Codes

In previous versions, you could use UrlScan at a global level to define security policies you wanted to enforce on your systems. With IIS 7 and above, you can still implement those polices at a global level, but also per URL. You can therefore leverage all the benefits that the new rich delegation model provides.

The following table is a summary of the error codes IIS logs:

| Error | Status Codes |
| --- | --- |
| **Site not found** | 404.1 |
| **Denied by policy** | 404.2 |
| **Denied by mime map** | 404.3 |
| **No handler** | 404.4 |
| **Request Filtering: URL Sequence denied** | 404.5 |
| **Request Filtering: Verb denied** | 404.6 |
| **Request Filtering: File extension denied** | 404.7 |
| **Request Filtering: Denied by hidden segment** | 404.8 |
| **Denied since hidden file attribute has been set** | 404.9 |
| **Request Filtering: Denied because request header is too long** | 404.10 |
| **Request Filtering: Denied because URL doubled escaping** | 404.11 |
| **Request Filtering: Denied because of high bit characters** | 404.12 |
| **Request Filtering: Denied because content length too large** | 404.13 |
| **Request Filtering: Denied because URL too long** | 404.14 |
| **Request Filtering: Denied because query string too long** | 404.15 |