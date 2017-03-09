---
title: "Using the Application Request Routing Module | Microsoft Docs"
author: rick-anderson
description: "Microsoft Application Request Routing (ARR) for IIS 7 and above is a proxy-based routing module that forwards HTTP requests to content servers based on HTTP..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 07/02/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/extensions/planning-for-arr/using-the-application-request-routing-module
msc.type: authoredcontent
---
Using the Application Request Routing Module
====================
by [IIS Team](https://twitter.com/inetsrv)

## Introduction

Microsoft Application Request Routing (ARR) for IIS 7 and above is a proxy-based routing module that forwards HTTP requests to content servers based on HTTP headers, server variables, and load balance algorithms. ARR can be used to:

- Increase application availability and scalability.
- Better utilize content server resources.
- Facilitate application deployment including pilot management and A/B testing.
- Lower management costs and create opportunities for shared hosters.

ARR relies on the [URL rewrite module](../url-rewrite-module/using-the-url-rewrite-module.md) to inspect incoming HTTP requests to make the routing decisions. Therefore, the URL rewrite module is required to enable ARR features.

ARR support is provided by [Microsoft Help and Support](https://support.microsoft.com/). The [forum](https://forums.iis.net/1154.aspx) will remain active.

## Features

Microsoft Application Request Routing for IIS includes the following key features:

- **HTTP-based routing decisions** Unlike hardware load balancers that make routing decisions at the IP level, ARR makes routing decisions at the application level. By using ARR with the URL rewrite module, you can write powerful routing rules that are based on HTTP headers and server variables.
- **Load balance algorithms** You can apply a user-selected load balance algorithm to determine which content server is most appropriate to service HTTP requests. Six algorithms are provided.
- **Health monitoring** You can use both live traffic and specific URL tests to determine the health of content servers. A set of configuration parameters are provided to define the meaning of server health. You can also disable both live traffic and URL tests and use a custom health monitoring provider. To do this, set the health of the servers by calling RSCA APIs.
- **Client affinity** By using a cookie, ARR can affinitize all requests from a client to a content server. ARR differentiates the clients behind NAT, so each client is treated independently. This feature requires that the clients are able to accept cookies.
- **Host name affinity**"Host name affinity" is a specific feature for shared hosters. This feature changes the deployment topology to minimize and streamline administration and to create additional business opportunities. For more information about this scenario, see [Shared Hosting Deployment using Application Request Routing](overview-of-shared-hosting-deployment-using-application-request-routing-20.md). Two providers, round robin and memory, are used to determine to which server the host should be affinitized.
- **Multiple server groups** ARR can manage multiple server groups, which are logical groupings of content servers in an environment. This feature allows ARR to be used in pilot management and A/B testing scenarios.
- **Management and monitoring by using the UI** You can use IIS Manager to manage and view all configuration settings and aggregated runtime statistics for ARR.
- **Failed request tracing rules** Specific traces have been added to quickly troubleshoot and diagnose ARR.

## Getting the Module

Download Microsoft Application Request Routing Version 2 for IIS 7 (x86) [here](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1709).  
Download Microsoft Application Request Routing Version 2 for IIS 7 (x64) [here](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1712).

## Using the Module

These articles explain how to configure and achieve the core scenarios by using ARR. It is recommended that you read the articles in the following order because the scenarios get richer with each article:

- [Install Application Request Routing](../installing-application-request-routing-arr/install-application-request-routing.md)
- [Define and Configure an Application Request Routing Server Group](../configuring-application-request-routing-arr/define-and-configure-an-application-request-routing-server-farm.md)
- [HTTP Load Balancing using Application Request Routing](../configuring-application-request-routing-arr/http-load-balancing-using-application-request-routing.md) 

    - Includes using health monitoring and client affinity
- [Configure 3-tier deployment architecture using Application Request Routing](../configuring-application-request-routing-arr/configure-3-tier-deployment-architecture-using-application-request-routing.md)
- [Pilot Program Management using Application Request Routing](../configuring-application-request-routing-arr/pilot-program-management-using-application-request-routing.md)
- [Shared Hosting using Application Request Routing](../configuring-application-request-routing-arr/shared-hosting-using-application-request-routing-arr.md)

    - [Using Microsoft External Cache for IIS7 and Above](../configuring-application-request-routing-arr/using-multiple-instances-of-application-request-routing-arr-servers.md)
    - [How to configure WMI service on application servers for HostNameMemory affinity provider](../configuring-application-request-routing-arr/how-to-configure-wmi-service-on-application-servers-for-hostnamememory-affinity-provider.md)
- [Using Failed Request Tracing Rules to Troubleshoot Application Request Routing](../../troubleshoot/using-failed-request-tracing/using-failed-request-tracing-rules-to-troubleshoot-application-request-routing-arr.md)
- High availability at ARR tier

    - [ARR and NLB](../configuring-application-request-routing-arr/achieving-high-availability-and-scalability-arr-and-nlb.md)
    - [ARR and Hardware Load Balancer](../configuring-application-request-routing-arr/achieving-high-availability-and-scalability-arr-and-hardware-load-balancer.md)
  
  
[Discuss in IIS Forums](https://forums.iis.net/1154.aspx)