---
title: "Troubleshooting Cache Items ARR V2 | Microsoft Docs"
author: apurvajo
description: "Tools Used in this Troubleshooter: ARR Helper Failed Request Tracing (FREB) IIS Advanced Logging Network Monitor This material is provided for informational..."
ms.author: iiscontent
manager: soshir
ms.date: 04/09/2012
ms.topic: article
ms.assetid: b0d9230c-a4dd-478b-97d6-dea3f2e6bcdd
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/troubleshooting-application-request-routing/troubleshooting-cache-items-arr-v2
msc.type: authoredcontent
---
Troubleshooting Cache Items ARR V2
====================
by [Apurva Joshi](https://github.com/apurvajo)

#### Tools Used in this Troubleshooter:

- ARR Helper
- Failed Request Tracing (FREB)
- IIS Advanced Logging
- Network Monitor

This material is provided for informational purposes only. Microsoft makes no warranties, express or implied.

## Overview

In this walkthrough we will trace a request as it passes through ARR and is sent to next tier server and examine the data that can be gathered to identify the request where it was sent and ultimately where it was served from.

## Understand the Architecture of the Farm

The first step is to understand the architecture of the environment including the following. Without knowledge of this it would be impossible to devise any sort of logical action plan when troubleshooting.

- ARR Farm topology (how many servers, how routing is configured, other devices)
- URL Rewrite rules in place

For the purposes of this walkthrough we are going to use the following configuration.

![](troubleshooting-cache-items-arr-v2/_static/troubleshooting-cache-items-arr-v2-1108-image11.jpeg)

**Disk Cache Configuration:** 

One local drive with 100GB maximum size configured.

[!code-xml[Main](troubleshooting-cache-items-arr-v2/samples/sample1.xml)]

**Global Cache Control Rules:** 

This rule is defined as Cache for 60 minutes when no cache control directive exists.

[!code-xml[Main](troubleshooting-cache-items-arr-v2/samples/sample2.xml)]

## Build a Data Gathering Plan

In this section we will step though the flow of cache hits and misses as this passes through ARR and identify tools or logs we might use to inspect the requests. The following steps outline the request flow for content not previously cached using the configuration above as our reference and the tools we would use at each step.

- The requested content is not found locally (neither in memory nor on disk on child node).

    - Freb Logs
    - IIS built in logging
    - Network Monitor
- The request is forwarded to the next tier cache node (parent node).

    - Freb Logs
    - IIS Advanced Logging module
    - IIS built in logging
    - Network Monitor
- The requested content is not found at the next tier cache node (neither in memory nor on disk): Repeat steps 2 as many times as appropriate based on cache hierarchy.
- The request is forwarded to the origin server.

    - Freb Logs
    - IIS built in logging
    - Network Monitor

## Gather the Data

**The requested content is not found locally (neither in memory nor on disk).**

Here we can identify a cache hit/miss in either the IIS Logs or Freb logs. The Freb logs provide additional details such as where the request was routed which will be important if there are multiple down level servers.

**IIS Log Entry:** You will find the following entries in the **CS—uri-Query** field identifying the cache hit or miss and the guid for the request you which can be used to identify the request on down level servers.

[!code-console[Main](troubleshooting-cache-items-arr-v2/samples/sample3.cmd)]

[!code-console[Main](troubleshooting-cache-items-arr-v2/samples/sample4.cmd)]

[!code-console[Main](troubleshooting-cache-items-arr-v2/samples/sample5.cmd)]

[!code-console[Main](troubleshooting-cache-items-arr-v2/samples/sample6.cmd)]

**FREB Log:** The cache miss is found by the entry **ARR\_DISK\_CACHE\_GET\_FAILED.**

| r | ARR\_DISK\_CACHE\_GET\_FAILED Warning | FilePath="\\?\C:\ARRCache\localhost\iisstart.htm.full", ErrorCode="The system cannot find the file specified. (0x80070002)", IsRangeEntry="false", RangeOffset="0", RangeSegmentSize="0" |
| --- | --- | --- |

Identify the Server that the request is being routed to. Here we can see the request being sent to server W2K8WEBSERVER2 so we know that will be our next level server for data review.

| i | ARR\_SERVER\_ROUTED | RoutingReason="LoadBalancing", Server="W2K8WEBSERVER2", State="Active", TotalRequests="8", FailedRequests="0", CurrentRequests="1", BytesSent="1127", BytesReceived="6441379", ResponseTime="31351" |
| --- | --- | --- |

The following headers are added to the request for forwarding. If some names are different than the defaults X-Forwarded-For, X-ARR-ClientCert and X-ARR-LOG-ID they may have been customized in Server Farm proxy settings.

| GENERAL\_SET\_REQUEST\_HEADER | HeaderName="Max-Forwards", HeaderValue="10", Replace="true" |
| --- | --- |
| GENERAL\_SET\_REQUEST\_HEADER | HeaderName="X-Forwarded-For", HeaderValue="127.0.0.1:62489", Replace="true" |
| GENERAL\_SET\_REQUEST\_HEADER | HeaderName="X-ARR-SSL", HeaderValue="", Replace="true" |
| GENERAL\_SET\_REQUEST\_HEADER | HeaderName="X-ARR-ClientCert", HeaderValue="", Replace="true" |
| GENERAL\_SET\_REQUEST\_HEADER | HeaderName="X-ARR-LOG-ID", HeaderValue="fe9d20da-a571-4451-8ef3-0e7faf1a463a", Replace="true" |

**The request is forwarded to the next tier cache node (parent node)**

In the previous step we identified this server as **W2K8WEBSERVER2** so we will examine the following data on this server. As in the previous steps there are multiple data points that can be used. Using **X-ARR-LOG-ID** we can identify the request reached this server.

**FREB Logs:** The request can be identified by the **X-ARR-LOG-ID** sent from the child node. We identified this as **"fe9d20da-a571-4451-8ef3-0e7faf1a463a"** in the last step.

| i | GENERAL\_REQUEST\_HEADERS | Headers="Connection: Keep-Alive Accept: \*/\* Host: localhost Max-Forwards: 10 X-Original-URL: /iisstart.htm X-Forwarded-For: 127.0.0.1:62489 X-ARR-LOG-ID: fe9d20da-a571-4451-8ef3-0e7faf1a463a |
| --- | --- | --- |

**IIS Advanced Logging Module:** Using Advanced logging we can add custom logging fields based on the headers X-Forwarded-For and X-ARR-LOG-ID and then used filtering to only log when these headers are present.

[!code-console[Main](troubleshooting-cache-items-arr-v2/samples/sample7.cmd)]

[!code-console[Main](troubleshooting-cache-items-arr-v2/samples/sample8.cmd)]

**Network Monitor:** Again we could use the trace to identify the X-ARR-LOG-ID and X-Forwarded-For if we are tracing a particular request.

[ARR Helper](https://blogs.iis.net/anilr/archive/2009/03/03/client-ip-not-logged-on-content-server-when-using-arr.aspx): This module adds the X-Forwarded-For to the C-IP field and the X-ARR-LOG-ID to the cs-uri-query field of the default IIS logs.

**NOTE**: The ArrHelper is not currently supported by Microsoft

**Repeat Steps 1 and 2 for Multiple Levels of Cache**.

If the server Parent Node W2K8WEBSERVER2 is also configured with ARR and caching features then we would again look at the IISLOGS/FREB to see if there was cache Hit/Miss and where to go based on that finding.

**Request is forwarded to the Origin Server**

This step can be treated as a normal http/s request and can be tracked with the following tools.

- Network Monitor: Capture traces on the Origin server to verify receipt of the request
- IIS Logs: Check IIS logs for Http Response codes for the content you are tracing
- IIS FREB Logs: If the request was found in the Network trace and the Http response code was not a 200 you may want to use [FREBagain](../../troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis.md) to troubleshoot the issue.

## Troubleshooting Cache Failures

**Check Cache-Control Headers**

Verify Cache-Control headers received from client. This can be done in conjunction with checking the Cache control Rules since they can be configured to override headers.

**Review Cache-Control Rules in ARR**

Check the Cache Control Rules in ARR to verify ARR caching is enabled.

**Verify HTTP.SYS settings**

Check reasons content is not cached by HTTP.sys in kernel [HERE](https://support.microsoft.com/kb/817445)

**Disk Cache Failures**

Arr will log events to the Application event log when disk failures occur and mark the disk as unhealthy.

| Log Name: Application |
| --- |
| Source: Application Request Routing |
| Date: 11/2/2009 5:26:59 PM |
| Event ID: 1006 |
| Task Category: None |
| Level: Warning |
| Keywords: Classic |
| User: N/A |
| Computer: |
| Description: Drive with path '\\?\E:\temp$\arrcache\' is being marked unhealthy. The data contains the error code. |
| Event Xml: |

### Other Resources

- [ARR Helper](https://blogs.iis.net/anilr/archive/2009/03/03/client-ip-not-logged-on-content-server-when-using-arr.aspx)
- [Reasons content is not cached by HTTP.sys in kernel](https://support.microsoft.com/kb/817445)
- [Network Monitor](https://support.microsoft.com/kb/933741)
- [IIS Advance Logging](https://www.iis.net/downloads/microsoft/advanced-logging)