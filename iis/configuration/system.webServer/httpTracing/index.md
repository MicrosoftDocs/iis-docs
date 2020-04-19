---
title: "HTTP Tracing &lt;httpTracing&gt;"
author: rick-anderson
description: "Overview The &lt;httpTracing&gt; element allows you to configure request-based event tracing for incoming IIS requests, and contains a &lt;traceUrls&gt; elem..."
ms.date: 09/26/2016
ms.assetid: 5f338c6e-97f9-40cd-beb8-d6ac9528a185
msc.legacyurl: /configreference/system.webserver/httptracing
msc.type: config
---
HTTP Tracing &lt;httpTracing&gt;
====================
<a id="001"></a>
## Overview

The `<httpTracing>` element allows you to configure selective request-based event tracing for incoming IIS requests.
`<httpTracing>` contains a `<traceUrls>` element, which contains a collection of `<add>` elements.
Each `<add>` element defines a unique URL to enable tracing.

> [!NOTE]
> Event Tracing for Windows (ETW) is a general-purpose, high-speed tracing facility provided by the operating system. Using a buffering and logging mechanism implemented in the kernel, ETW provides a tracing mechanism for events raised by both user-mode applications and kernel-mode device drivers. Additionally, ETW gives you the ability to enable and disable logging dynamically, making it easy to perform detailed tracing in production environments without requiring reboots or application restarts. The logging mechanism uses per-processor buffers that are written to disk by an asynchronous writer thread. This allows large-scale server applications to write events with minimum disturbance.

> [!NOTE]
> To enable IIS request-based ETW, install the [TracingModule](/iis/get-started/introduction-to-iis/iis-modules-overview#module-reference).

By default, IIS emits request-based ETW events for all URLs through the provider **IIS: WWW Server** with GUID **{3A2A4E84-4C21-4981-AE10-3FDA0D9B0F83}** (the detailed information can be found in the [`<traceProviderDefinitions>`](/iis/configuration/system.webserver/tracing/traceproviderdefinitions) element).
To enable the URL filter for ETW specified by the `<traceUrls>` collection under the `<httpTracing>` element, the first (least significant) bit of the [trace flags](https://docs.microsoft.com/windows-hardware/drivers/devtest/trace-flags) must be set as 1 when running an ETW session.
For example, to enable IIS request-based ETW events ONLY for the URLs configured in the `<traceUrls>` collection, set the trace flags to **0xFFFFFFFF** for an ETW session with the provider **IIS: WWW Server**.
Such trace flags enable the URL filter as well as all [trace areas](/iis/configuration/system.webserver/tracing/traceproviderdefinitions/add/areas).
To enable the same events for all URLs, set the trace flags to **0xFFFFFFE** instead.

> [!NOTE]
> The URL filter defined in the `<traceUrls>` collection under the `<httpTracing>` element only affects IIS request-based ETW and has no impact on failed request tracing.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<httpTracing>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<httpTracing>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<httpTracing>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<httpTracing>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<httpTracing>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<httpTracing>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for the `<httpTracing>` element for IIS 7. For examples of how to access the `<httpTracing>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

You can configure the `<httpTracing>` element at the server level in the ApplicationHost.config file, or at the site, application, or directory level in a Web.config file.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`traceUrls`](traceurls/index.md) | Optional element. <br><br>Specifies the URL for which you want to enable request-based ETW tracing. |

### Configuration Sample

The following example will enable tracing for the sample home page that ships with IIS 7 when placed in a Web.config file in the root of the Default Web Site.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable tracing for the sample home page that ships with IIS 7 on Web site named Contoso by adding an entry to the `<traceUrls>` collection for that site.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
