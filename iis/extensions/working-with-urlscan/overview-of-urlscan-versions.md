---
title: "Overview of UrlScan Versions | Microsoft Docs"
author: rmcmurray
description: "UrlScan primarily consists of two parts: the UrlScan ISAPI filter named UrlScan.dll, and a configuration file named UrlScan.ini. ( Note : Some of the earlier..."
ms.author: iiscontent
manager: soshir
ms.date: 07/15/2010
ms.topic: article
ms.assetid: 09301b0d-9312-4ee2-b07b-1e01fa5dd8b5
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/working-with-urlscan/overview-of-urlscan-versions
msc.type: authoredcontent
---
Overview of UrlScan Versions
====================
by [Robert McMurray](https://github.com/rmcmurray)

UrlScan primarily consists of two parts: the UrlScan ISAPI filter named UrlScan.dll, and a configuration file named UrlScan.ini. (> [!NOTE]
> Some of the earlier versions of UrlScan contained an additional resource file named UrlScanr.dll.)

Each version of UrlScan added additional features, and each new version of the configuration file contained settings that controlled the functionality of those features. The configuration files are generally compatible across all versions of UrlScan, because older versions of UrlScan scan will ignore newer settings, and newer versions of UrlScan will use the default values if a setting is missing.

### UrlScan Version 1

UrlScan 1.0 was the first version of UrlScan that Microsoft released as an ISAPI filter sample that helped reduce the attack surface for IIS versions 4.0 and 5.0. The design concept was to allow Web server administrations to define the list of HTTP verbs, headers, file name extensions, and character sequences that are allowed on their servers.

> [!NOTE]
> UrlScan 1.0 has been replaced by the UrlScan Version 3.1 and should not be used.

For more information about UrlScan Version 1, see the [UrlScan 1 Reference](urlscan-1-reference.md) topic.

### UrlScan Version 2

Microsoft released UrlScan 2.1 and UrlScan 2.0 as part of the IIS Lockdown Tool, which was a more comprehensive approach to reducing the surface attack area for Web servers that used IIS versions 4.0, 5.0, and 5.1. The IIS Lockdown Tool was a wizard that server administrators would use to customize the content types, script mapping, system permissions, and virtual directories that their Web servers will use. The IIS Lockdown included the option to install UrlScan as an additional security measure, and included several configuration templates for UrlScan that addressed several installation environments for IIS, such as installing IIS with Exchange Server, BizTalk Server, SharePoint, etc.

Microsoft later released UrlScan 2.5 as a separate download, which added request limits to the list of features. Request limits allow administrators to configure the maximum size for request elements, such as content length, URLs, and query strings.

For more information about UrlScan Version 2, see the [UrlScan 2 Reference](urlscan-2-reference.md) topic.

### UrlScan Version 3

Microsoft released UrlScan 3.1 and 3.0 as separate downloads, although administrators should make sure that they upgrade to UrlScan 3.1.

The UrlScan Version 3 family added enhanced parsing of escape sequences in URLs and query strings, which added features to create filtering rules, to always allow specific URLs to bypass UrlScan filtering, and to allow or deny requests that contained user-defined query string elements. This feature helps prevent server attacks that use query strings, such as SQL injection attacks.

For more information about UrlScan Version 3, see the [UrlScan 3 Reference](urlscan-3-reference.md) topic.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1043.aspx)