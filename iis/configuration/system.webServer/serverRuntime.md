---
title: "Server Runtime &lt;serverRuntime&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;serverRuntime&gt; element configures the following settings that are related to the Internet Information Services (IIS) 7 server runtime: Se..."
ms.author: iiscontent
manager: soshir
ms.date: 06/26/2017
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/serverruntime
msc.type: config
---
Server Runtime &lt;serverRuntime&gt;
====================
<a id="001"></a>
## Overview

The `<serverRuntime>` element configures the following settings that are related to the Internet Information Services (IIS) 7 server runtime:

- Setting the **enabled** attribute to **true** will configure IIS 7 to serve content on the URL where the `<serverRuntime>` element is configured; setting the **enabled** attribute to **false** will configure IIS 7 to not serve content for that URL.
- The **alternateHostName** attribute specifies a host name that is different from the computer name in the HTTP Content-location header.
- The **appConcurrentRequestLimit** attribute specifies the maximum number of concurrent requests that can be queued for an application.
- The **enableNagling** attribute enables or disables nagling, which is an optimization for HTTP over TCP that increases efficiency by trying to minimize the number of packets that are required before data is sent . It works by waiting to send a packet until its data area is full, until a 200-millisecond time-out period expires, or until the sender indicates that it is finished sending data. IIS versions 5.1 and earlier use nagling for all data sent to the client. 

    > [!NOTE]
    > Nagling has a possible disadvantage; if an extension does not fill up the packet, there is still a delay of 200 milliseconds before the response is sent. This behavior is seen most often when you use ISAPI extensions that support an HTTP keep-alive header in the response to the client. In this case, IIS does not close the connection after the response, so the final packet ends up waiting for 200 milliseconds.
- IIS 7 checks the status of two attributes to determine the traffic level for a particular URL. The **frequentHitThreshold** attribute configures the number of requests and the **frequentHitTimePeriod** attribute configures the amount of time allowed before that URL is judged to be frequently hit. This information is used when writing HTTP modules that use this information for processing. For more information, see the [IHttpUrlInfo::IsFrequentlyHit Method](https://msdn.microsoft.com/en-us/library/ms692441.aspx) topic on MSDN.
- The **maxRequestEntityAllowed** and **uploadReadAheadSize** attributes respectively configure limits for the maximum number of bytes allowed in the entity body of a request and the number of bytes a Web server will read into a buffer and pass to an ISAPI extension.

### New in IIS 7.5

IIS 7.5 added the **authenticatedUserOverride** attribute to the `<serverRuntime>` element, which configures whether the IIS 7 server runtime will provide the authenticated user's identity or the worker process identity in the [IHttpUser::GetPrimaryToken](https://msdn.microsoft.com/en-us/library/ms692659.aspx) and [IHttpUser::GetImpersonationToken](https://msdn.microsoft.com/en-us/library/ms689403.aspx) methods. This attribute can be set to *UseAuthenticatedUser* or *UseWorkerProcessUser*, and these values respectively specify whether the IIS 7 server runtime will provide the authenticated user's identity or the worker process identity for any module that is using impersonation.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<serverRuntime>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<serverRuntime>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<serverRuntime>` element was not modified in IIS 8.0. |
| IIS 7.5 | The **authenticatedUserOverride** attribute was added in IIS 7.5. |
| IIS 7.0 | The `<serverRuntime>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<serverRuntime>` element replaces the following IIS 6.0 metabase properties: - **SetHostName** - **MaxRequestEntityAllowed** - **UploadReadAheadSize** |

<a id="003"></a>
## Setup

The `<serverRuntime>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface that lets you configure the `<serverRuntime>` element for IIS 7. For examples of how to configure the `<serverRuntime>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `alternateHostName` | Optional string attribute. Specifies the host name to use for redirection. |
| `appConcurrentRequestLimit` | Optional uint attribute. Specifies the maximum number of requests that can be queued for an application. The default value is `5000`. |
| `authenticatedUserOverride` | Optional enum attribute. Specifies whether the IIS 7 server runtime will provide the authenticated user's identity or the worker process identity for modules that are using impersonation. <br><br>**Note:** This attribute was added in IIS 7.5. | Value | Description | | --- | --- | | `UseAuthenticatedUser` | Specifies that IIS will provide the authenticated user's token; applications that run in this context will be limited to any access restrictions for the authenticated user's identity. The numeric value is `1`. | | `UseWorkerProcessUser` | Specifies that IIS will provide the token for the worker process identity instead of using the authenticated user's identity; applications that run in this context will be limited to any access restrictions for the worker process identity. The numeric value is `2`. | The default value is `UseAuthenticatedUser`. |
| `enabled` | Optional **Boolean** attribute. Specifies whether applications on the Web server are able to serve content (**true**) or not are not able to serve content (**false**). The default value is `true`. |
| `enableNagling` | Optional **Boolean** attribute. Specifies whether nagling is enabled (**true**) or disabled (**false**). The default value is `false`. |
| `frequentHitThreshold` | Optional uint attribute. Specifies the number of times a URL must be requested, within the time span specified in the **frequentHitTimePeriod** attribute, to be considered frequently hit. The value must be between 1 and 2147483647. The default value is `2`. |
| `frequentHitTimePeriod` | Optional timeSpan attribute. Specifies the time interval in which a URL must be requested the number of times specified in the **frequentHitThreshold** attribute before it is considered to be frequently hit. The default value is `00:00:10` (10 seconds). |
| `maxRequestEntityAllowed` | Optional uint attribute. Specifies the maximum number of bytes that can be in an entity body of a request. If the Content-Length header specifies a larger number, IIS sends an HTTP 403 error response. The default value is `4294967295` (unlimited). |
| `uploadReadAheadSize` | Optional uint attribute. Specifies the number of bytes that a Web server will read into a buffer and pass to an ISAPI extension or module. This occurs once per client request. The ISAPI extension or module receives any additional data directly from the client. The value must be between 0 and 2147483647. The default value is `49152`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample sets the `<serverRuntime>` element's **enable** attribute to **true**, then configures the number of requests for a URL to be considered "frequently hit" by setting the **frequentHitThreshold** attribute to 5 requests and the **frequentHitTimePeriod** attribute to 20 seconds.

[!code-xml[Main](serverRuntime/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples set the `<serverRuntime>` element's **enable** attribute to **true**, then configure the number of requests for a URL to be considered "frequently hit" by setting the **frequentHitThreshold** attribute to 5 requests and the **frequentHitTimePeriod** attribute to 20 seconds.

### AppCmd.exe

[!code-console[Main](serverRuntime/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](serverRuntime/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](serverRuntime/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](serverRuntime/samples/sample5.js)]

### VBScript

[!code-vb[Main](serverRuntime/samples/sample6.vb)]