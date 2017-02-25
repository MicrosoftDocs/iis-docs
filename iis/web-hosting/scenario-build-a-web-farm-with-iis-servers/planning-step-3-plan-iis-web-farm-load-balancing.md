---
title: "Planning Step 3: Plan IIS Web Farm Load Balancing | Microsoft Docs"
author: rick-anderson
description: "In this phase of planning a web farm with IIS servers, you learn about load balancing. You also learn how to configure load balancing by using Application Re..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 04/14/2013
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/planning-step-3-plan-iis-web-farm-load-balancing
msc.type: authoredcontent
---
Planning Step 3: Plan IIS Web Farm Load Balancing
====================
by Keith Newman and Robert McMurray

In this phase of planning a web farm with IIS servers, you learn about load balancing. You also learn how to configure load balancing by using Application Request Routing (ARR). ARR is a proxy-based request routing and load balancing module for IIS.

The following list shows the tasks required to complete this step:

- [3.1. Plan Load Balancing with ARR](#31)
- [3.2. Survey Other Features of ARR](#32)

When you are done with these tasks, record your design decisions before going on to [Step 4: Plan SSL Central Certificate Store](planning-step-4-plan-ssl-central-certificate-store.md).

<a id="31"></a>
## 3.1. Plan Load Balancing with ARR

Load balancing is a way to distribute workload across multiple web servers. The purpose is to attain optimal resource utilization, maximize request throughput, minimize response time, and avoid server overload.

Load balancers use various algorithms to accomplish this task. One of the simplest algorithms is round robin, which sends each new request to a different web server in an attempt to load all servers equally. Other algorithms send specific types of requests to specific servers in an attempt to reduce response time.

Application Request Routing (ARR) is a proxy-based routing module that uses HTTP headers, server variables, and load balance algorithms to determine how to forward requests to content servers. ARR leverages the URL Rewrite module to inspect incoming requests.

A key feature of ARR is called *host name affinity*. Host name affinity creates an affinity (close connection) between requests and a given server (or set of servers). This ensures that a given site is consuming resources only on a defined number of servers.

Prepare a list of IP addresses for all servers in your farm. You will need the list to configure ARR load balancing.

<a id="32"></a>
## 3.2. Survey Other Features of ARR

In addition to load balancing, ARR provides many features that are beyond the scope of this scenario. The following table summarizes the features that are available in ARR.

| Feature | Description |
| --- | --- |
| **Browsing cached contents with the UI** | Cached contents across multiple drives, including cached directories and files, are viewable in IIS Manager. |
| **Byte-range support** | ARR segments byte-range requests into smaller pieces to help increase the cache hit/miss ratio without impacting the response time. |
| **Cache hierarchy management** | ARR lets you define and manage relationships between the cache nodes. It supports the Cache Array Routing Protocol (CARP), so that you can configure ARR as an edge cache node. |
| **Cache proxy node in CDN/ECN environment** | ARR can be used as a cache proxy in a content delivery network (CDN) or edge cache network (ECN) deployment. Because ARR is a proxy-based HTTP request-routing module with support for disk cache and CARP. |
| **Caching compressed objects** | ARR compresses and stores objects in a disk-based cache so that these objects remain uncompressed in real time for every request. |
| **Caching while serving responses** | ARR can cache large files while serving the response in real time. |
| **Client affinity** | ARR can use cookies to affinitize all requests from a client to a content server. |
| **Disk-based caching** | ARR supports cached content on user-specified primary cache drives and a secondary network-based cache drive. |
| **Failed request tracing rules** | ARR uses tracing rules to troubleshoot and diagnose failed requests. |
| **Health monitoring** | ARR provides configuration parameters to use in live traffic and specific URL tests to determine the health of content servers. |
| **Host name affinity** | Host name affinity-a feature specific to shared hosters-changes the deployment topology by providing two providers, round robin and memory, to determine which server the host affinitizes. |
| **HTTP-based routing decisions** | Application Request Routing works with the URL Rewrite module to write routing rules that are based on HTTP headers and server variables, and to make routing decisions at the application level. |
| **Live request support** | ARR supports live content requests by consolidating requests and checking the cache-miss requests before forwarding requests to the origin server. |
| **Load balance algorithms** | ARR provides six load balance algorithms that you can use to identify which content server to use to service HTTP requests. |
| **Management and monitoring using the UI** | ARR configuration settings and runtime statistics are viewable in IIS Manager. |
| **Multiple server groups** | ARR can manage multiple groups of content servers in pilot management and A/B testing scenarios. |
| **Overriding cache-control directives** | ARR lets you manually override cache-control directives that control caching behavior, such as the ability to cache and cache duration. |
| **Removing cached contents** | ARR lets you delete cached contents by matching URL patterns. |
| **Warming up cache nodes** | ARR lets you pre-cache content, anticipating demand before the content is requested. You can pre-cache the parent cache tier only or both the parent and child cache tiers. |

## See Also

- [Step 4: Plan SSL Central Certificate Store](planning-step-4-plan-ssl-central-certificate-store.md)
- [Step 2: Plan IIS Web Farm Configuration](planning-step-2-plan-iis-web-farm-configuration.md)
- [Step 3: Configure IIS Web Farm Load Balancing](configuring-step-3-configure-iis-web-farm-load-balancing.md)
- [Plan a Web Farm with IIS Servers](plan-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)