---
title: "UrlScan Overview"
author: naziml
description: "UrlScan is a security tool that restricts the types of HTTP requests that Microsoft Internet Information Services (IIS) will process. By blocking specific HT..."
ms.date: 11/04/2009
ms.assetid: 87825b78-26cc-4b36-8297-a3ac0b4e8c5d
msc.legacyurl: /learn/extensions/working-with-urlscan/urlscan-overview
msc.type: authoredcontent
---
UrlScan Overview
====================
by [Nazim Lala](https://github.com/naziml)

## Introduction

UrlScan is a security tool that restricts the types of HTTP requests that Microsoft Internet Information Services (IIS) will process. By blocking specific HTTP requests, the UrlScan security tool helps prevent potentially harmful requests from reaching the server. UrlScan is implemented as an ISAPI filter that screens and analyzes HTTP requests as IIS receives them. When properly configured, UrlScan is effective at reducing the exposure of IIS to potential Internet attacks.

> [!NOTE]
> Microsoft has now released [UrlScan 3.1](urlscan-3-reference.md). This version updates earlier versions of UrlScan with additional features, including the ability to filter requests based on query strings - which can help mitigate SQL injection and other attacks that use a query string payload, and the ability to created custom rules that scan parts of your HTTP requests.

Administrators may configure UrlScan to reject HTTP requests based on the following criteria:

- The HTTP request method or verb
- The file name extension of the requested resource
- Suspicious URL encoding
- Presence of non-ASCII characters in the URL
- Presence of specified character sequences in the URL
- Presence of specified headers in the request

When UrlScan denies a request it will log the action and the reason for the denial, along with additional information about the request – typically, the complete URL and IP address of the source of the request. When a denial occurs, IIS sends a "404 Object not found" response to the client. This simple response reduces the possibility of inadvertently disclosing information about the server to a possible attacker.

## Getting UrlScan

To download and install UrlScan 3.1, click on the appropriate download link for your environment:

- Download the x86 version from [Microsoft Download Center](https://www.iis.net/downloads/microsoft/urlscan).
- Download the x64 version from [Microsoft Download Center](https://www.iis.net/downloads/microsoft/urlscan).

UrlScan 3.1 works with the following IIS versions:

- IIS 5.1 on Windows XP
- IIS 6.0 on Windows Server 2003
- IIS 7.0 and above on Windows Server 2008 and Windows Vista

> [!NOTE]
> While UrlScan 3.1 might work with IIS 4.0 on Windows NT 4.0 and IIS 5.0 on Windows 2000, these products are no longer supported by Microsoft. For more information about Microsoft's list of supported products, see Microsoft's [Support Lifecycle Policy](https://support.microsoft.com/lifecycle/).

## UrlScan 3.1 Overview

This section provides a quick look at how to use UrlScan Version 3.1. If you have used UrlScan Version 2.5, be sure to check out the **New Features** section. Please refer to the [Frequently Asked Questions](index.md) if you have any questions or concerns. If you do not find the information you are looking for, please post to the [IIS 7 security forums](https://forums.iis.net/1043.aspx) on IIS.net.

UrlScan Version 3.1 is an upgrade to UrlScan Version 2.5 which was originally released as part of the IIS Lockdown Tool. UrlScan Version 3.1 maintains compatibility with its predecessor, so if you have a configuration file for the older version, you can use your existing configuration file with UrlScan Version 3.1 and the behavior will be identical. Like its predecessor, UrlScan Version 3.1 is an ISAPI filter that reads configuration from a UrlScan.ini file and restricts certain types of requests (enumerated in UrlScan.ini) from being executed by IIS. An IIS web server administrator can add, modify and extend UrlScan configuration to further restrict the types of HTTP requests that will be served by IIS. By filtering unusual requests, UrlScan will help prevent such requests from reaching application code, where they may potentially cause damage to the application or server. UrlScan Version 3.1 will install for IIS 5.1 and later, including IIS 7.0 and above for Windows Server 2008.

### UrlScan Version 3.1 Features

UrlScan Version 3.1 maintains feature and functionality parity with its predecessor (UrlScan Version 2.5). The configuration format is the same, but includes a few additional sections that can be used for the new features. If you are currently using UrlScan Version 2.5, you can use the same UrlScan.ini configuration file with UrlScan Version 3.1.

#### New Features

- Deny rules can now be independently applied to query string, all headers, a particular header, URL or a combination of these.
- A global DenyQueryString section in configuration lest you add deny rules for query strings with the option of checking the un-escaped version of the query string as well.
- A global AlwaysAllowedUrls section in configuration lets you specify safe URLs that will bypass all URL based checks. This feature has been added post UrlScan Version 3.0 Beta.
- A global AlwaysAllowedQueryStrings section in configuration lets you specify safe query strings that will bypass all query string checks. This feature has been added post UrlScan Version 3.0 Beta.
- Using escape sequences (like %0A%0D) can now be used in deny rules so it is possible to deny CRLF and other sequences involving non-printable characters.
- Multiple UrlScan instances can now be installed as site filters, each with its own configuration and rules (UrlScan.ini).
- Configuration (UrlScan.ini) change notifications will be propagated to IIS worker processes so you won't have to recycle your worker processes after making a configuration change. Logging settings are the only exception to this.
- Enhanced W3C formatted logging that will give descriptive configuration errors in the Remarks header. This feature has been added post UrlScan Version 3.0 Beta, which did not have W3C formatted logs.

#### Features Ported from UrlScan Version 2.5

Here is a quick summary of the features in UrlScan Version 2.5.

- Block requests from being executed by IIS based on HTTP Verbs, HTML Encoding, URI Extension, URL sequences and size of request.
- Ability to change log file directory.
- Ability to log long URLs (&gt;1024 bytes) up to 128 Kb.

Please check the [UrlScan Version 2 Reference](urlscan-2-reference.md) for more information.

## More Information

For additional information about using UrlScan:

- Post queries about the tool on the IIS security forums: 

    - [IIS 5.x and IIS 6.0](https://forums.iis.net/1031.aspx)
    - [IIS 7.0 and IIS 7.5](https://forums.iis.net/1043.aspx)
- See blogs about UrlScan Version 3.1 from [Wade Hilmo](https://blogs.iis.net/wadeh/archive/2008/10/31/UrlScan-3-1.aspx).
