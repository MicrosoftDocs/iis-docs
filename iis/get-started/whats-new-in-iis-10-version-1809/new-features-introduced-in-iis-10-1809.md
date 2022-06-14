---
title: New Features Introduced  in IIS 10.0, version 1809
author: shirhatti
description: Describes the new features introduced in IIS 10.0 version 1809 and outlines the new binding flags and new compression API.
ms.author: soshir
ms.date: 10/03/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
New Features Introduced  in IIS 10.0, version 1809
=================================================

IIS 10.0 version 1809 is the latest version of Internet Information Services (IIS) which shipped with the Windows 10 October 2018 Update and Windows Server 2019. This article describes the new functionality of IIS and provides links to resources to learn more about these features.

IIS 10.0 version 1809 is a cumulative update if you are upgrading from Windows Server 2016 and includes all the features introduced in version 1709 and version 1803.

## New binding flags

We introduced support for OCSP stapling in IIS 7.0 and support for HTTP/2 in IIS 10.0, but they were only controlled on a system-wide level. In IIS 10.0 version 1809 and later you can control both OCSP Stapling and HTTP/2 on a per-binding basis.

## New compression API

The static and dynamic compression modules in IIS provide support for pluggable compression scheme providers. As part of IIS 10.0 version 1809, we've introduced a [new compression API](https://msdn.microsoft.com/library/mt846747(v=vs.90).aspx) that compression schemes can optionally implement to better support compressing of streaming data. The new [IIS Compression module](/iis/extensions/iis-compression/iis-compression-overview) that adds a new gzip compression scheme (with better for streaming data) and a Brotli compression scheme both make use of this API.

## UI for HTTPS Strict Transport Security

HTTPS Strict Transport Security (HSTS) support that was introduced in IIS 10.0, version 1709 now has new UI in IIS Manager to manage this feature. The new UI is accessible through the **Configure** section under the **Actions** bar for each site.

![UI for HSTS](hsts.png)
