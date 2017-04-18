---
title: "Application Request Routing Version 2 Overview | Microsoft Docs"
author: rick-anderson
description: "This section of the documentation applies to Microsoft Application Request Routing Version 2 for IIS 7 and Above . Microsoft Application Request Routing (ARR..."
ms.author: iiscontent
manager: soshir
ms.date: 03/18/2009
ms.topic: article
ms.assetid: e3c34cfb-604c-4ef2-bf05-0ac975f9eeab
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/planning-for-arr/application-request-routing-version-2-overview
msc.type: authoredcontent
---
Application Request Routing Version 2 Overview
====================
by IIS Team

## Introduction

This section of the documentation applies to **Microsoft Application Request Routing Version 2 for IIS 7 and Above**.

Microsoft Application Request Routing (ARR) for IIS 7 and above is a proxy-based routing module that forwards HTTP requests to application servers based on HTTP headers, server variables, and load balance algorithms.

ARR Version 2 is an incremental release that includes all of the features from Version 1, and adds support for disk-based cache. More specifically, ARR Version 2 can be used to:

- Enhance ARR Version 1 [scenarios](using-the-application-request-routing-module.md) with disk cache.
- Use ARR as a cache proxy as a [cache node](../configuring-application-request-routing-arr/cache-hierarchy-management-using-application-request-routing.md) in a [CDN/ECN environment](../installing-application-request-routing-arr/deploying-application-request-routing-in-cdn.md).

    - Use ARR as an edge/child cache node.
    - Use ARR as a parent cache node.

> [!NOTE]
>  
> 
> - ARR Version 1 and ARR Version 2 cannot be installed side-by-side.
> - Previous releases of ARR Version 2 (Beta1, Beta2 and RC) and the ARR Version 2 RTW cannot be installed side-by-side.
> - ARR Version 2 RTW supports upgrading from ARR Version 1 RTW and from ARR Version 2 RC. If any other version of ARR is already installed, uninstall it before proceeding with the ARR Version 2 installation.
> - The minimum supported resolution for IIS Manager is 1024x768.


## Features

ARR Version 2 includes the following key features:

- **Disk-based caching** &mdash; In addition to the kernel memory cache in ARR Version 1, Version 2 adds support for [disk-based cache](../configuring-application-request-routing-arr/configure-and-enable-disk-cache-in-application-request-routing.md), including support for a secondary network-based drive.
- **Cache hierarchy management** &mdash; Define and [manage relationships](../configuring-application-request-routing-arr/cache-hierarchy-management-using-application-request-routing.md) between cache nodes, including support for the Cache Array Routing Protocol (CARP).
- **Cache proxy node in CDN/ECN environment** &mdash; Because ARR is a proxy-based HTTP request routing module with support for disk cache and CARP, ARR can be used as [a cache proxy in a CDN/ECN environment](../installing-application-request-routing-arr/deploying-application-request-routing-in-cdn.md).
- **Caching compressed objects** &mdash; Disk-based cache stores compressed objects so that the objects do not have to be compressed in real time for every request. In addition, ARR [gzip compresses objects](../configuring-application-request-routing-arr/using-compression-in-application-request-routing.md) even if the content server does not respond with gzip content-encoding.
- [**Configure Caching with Query String Support**](../configuring-application-request-routing-arr/configure-caching-with-query-string-support-in-application-request-routing.md) in Application Request Routing
- **Browsing cached contents using IIS Manager** &mdash; [Browse through cached contents](../configuring-application-request-routing-arr/browse-cached-contents-on-disk-on-application-request-routing.md) across multiple drives in one consolidated graphical view in IIS Manager.
- **Removing cached contents** &mdash; [Delete cached contents](../configuring-application-request-routing-arr/delete-cached-objects.md) by matching URL patterns.
- Running Scavenger.exe to delete cached content in the secondary drive as a [standalone](../configuring-application-request-routing-arr/use-scavengeexe-tool-to-delete-cached-content-from-secondary-cache-drive.md) utility.
- **Overriding cache-control directives** &mdash; Manually [override the cache-control directives](../configuring-application-request-routing-arr/manually-override-cache-control-directives-using-application-request-routing.md) in the response header to change the cache behavior.
- **Warming up cache node** &mdash; [Proactively warm up your cache node](../configuring-application-request-routing-arr/warm-up-cache-nodes-on-application-request-routing.md) with contents that **will** be in demand before they are requested. In addition, the contents can be pre-cached selectively only at the parent cache tier.
- **Intelligent byte-range support** &mdash; ARR converts the [byte-range request into manageable segments](../configuring-application-request-routing-arr/configure-byte-range-request-segment-size-in-application-request-routing.md) to increase cache hit/miss ratio without sacrificing response time.
- **Intelligent live request support** &mdash; ARR is designed to work with Live Smooth Streaming to [support live content requests](../configuring-application-request-routing-arr/configure-request-consolidation-feature-in-application-request-routing.md) without overloading the live streaming server.
- **Caching while serving response** &mdash; Caching large content, such as a movie clip, may take some time. ARR Version 2 is capable of caching the content while serving the response immediately.
- **Support for performance counters** &mdash; The runtime statistics shown in the Monitoring and Management view are accessible as [performance counters](../configuring-application-request-routing-arr/using-performance-counters.md).

## Support

ARR Version 2 is a Released to Web (RTW) product and support is provided by [Microsoft Help and Support](https://support.microsoft.com/). The [forum](https://forums.iis.net/1154.aspx) will remain active.

## Get the module

- Microsoft Application Request Routing Version 2 for IIS 7 (x86) [here](https://download.microsoft.com/download/4/D/F/4DFDA851-515F-474E-BA7A-5802B3C95101/ARRv2_setup_x86.EXE).
- Microsoft Application Request Routing Version 2 for IIS 7 (x64) [here](https://download.microsoft.com/download/3/4/1/3415F3F9-5698-44FE-A072-D4AF09728390/ARRv2_setup_x64.EXE).

## Using the module

The following articles explain how to install and configure ARR Version 2. **It is strongly recommended that these articles are read in the order listed below as they get progressively more advanced.**

- [**Install**](../installing-application-request-routing-arr/install-application-request-routing-version-2.md) **Application Request Routing (ARR) Version 2 for IIS.** &mdash; Includes IIS configuration recommendations when deploying in a production environment.
- **Configure and** [**enable disk cache**](../configuring-application-request-routing-arr/configure-and-enable-disk-cache-in-application-request-routing.md) **for ARR.** &mdash; How to configure primary cache drives and a secondary cache drive that can be shared across multiple cache nodes.
- **[Configure Caching with Query String Support](../configuring-application-request-routing-arr/configure-caching-with-query-string-support-in-application-request-routing.md) in Application Request Routing**
- **How to define** [cache hierarchy](../configuring-application-request-routing-arr/cache-hierarchy-management-using-application-request-routing.md) for ARR. &mdash; Explains how the cache relationship is managed in ARR.
- **Configure [ARR as cache nodes in CDN/ECN](../installing-application-request-routing-arr/deploying-application-request-routing-in-cdn.md)** &mdash; Steps through how ARR can be deployed as an edge/child cache node as well as a parent cache node.
- **[Browse cached contents](../configuring-application-request-routing-arr/browse-cached-contents-on-disk-on-application-request-routing.md) on disk.** &mdash; View cached contents using IIS Manager across multiple primary cache drives.
- [**Remove cached contents**](../configuring-application-request-routing-arr/delete-cached-objects.md) **from ARR.** &mdash; Delete one or more cached contents while browsing or by matching URL patterns.
- Running Scavenger.exe to delete cached content in the secondary drive as a [standalone](../configuring-application-request-routing-arr/use-scavengeexe-tool-to-delete-cached-content-from-secondary-cache-drive.md) utility.
- [**Override cache-control directives**](../configuring-application-request-routing-arr/manually-override-cache-control-directives-using-application-request-routing.md) **in an HTTP response.** &mdash; Control what to cache or for how long to cache, irrespective of cache-control directives.
- [**Warm up cache nodes**](../configuring-application-request-routing-arr/warm-up-cache-nodes-on-application-request-routing.md) **on ARR with anticipated contents.** &mdash; Proactively cache contents on ARR before they are in demand.
- [**Configure byte-range request**](../configuring-application-request-routing-arr/configure-byte-range-request-segment-size-in-application-request-routing.md) **segment size in ARR.** &mdash; Explore how ARR handles byte-range requests.
- [**Configure request consolidation**](../configuring-application-request-routing-arr/configure-request-consolidation-feature-in-application-request-routing.md) **feature in ARR.** &mdash; Understand how ARR can help with serving live streaming media.
- **[Using compression](../configuring-application-request-routing-arr/using-compression-in-application-request-routing.md) in ARR.** &mdash; ARR compresses and caches compressed objects even if the content server does not support compression.
- **[Using performance counters](../configuring-application-request-routing-arr/using-performance-counters.md)**. &mdash; Use performance counters to gather real-time runtime statistics.
- **[Deployment recommendations](../installing-application-request-routing-arr/deployment-recommendations-for-application-request-routing.md) for ARR.** &mdash; Best practices and recommendations for ARR deployment.

## Changes in URL Rewrite Module

ARR Version 2 includes the updated version of URL Rewrite Module 2.0, which has several breaking changes that were introduced since the release of the URL Rewrite 2.0 Beta. The breaking changes are listed below:

- If a distributed rewrite rule sets a server variable, then that server variable has to be added to a &lt;allowedServerVariables&gt; collection. This can be done by either using the URL Rewrite user interface in IIS Manager or by modifying the applicationHost.config file as shown below. Note that it is not necessary to do this if the server variable is set by using a global rule.  

    [!code-xml[Main](application-request-routing-version-2-overview/samples/sample1.xml)]
- The HTTP\_CONTENT\_TYPE server variable has been replaced with RESPONSE\_CONTENT\_TYPE. If an outbound rewrite rule uses a pre-condition that checks the HTTP\_CONTENT\_TYPE, then that rule will stop working. Change the pre-condition to use RESPONSE\_CONTENT\_TYPE instead.