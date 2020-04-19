---
title: "Adding Trace URLs &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;traceUrls&gt; collection adds a trace URL to the collection of URLs for ETW tracing. Note : Event Tracing for Win..."
ms.date: 09/26/2016
ms.assetid: 5e85ba6c-78bc-4730-b0ed-1d46e3a074bb
msc.legacyurl: /configreference/system.webserver/httptracing/traceurls/add
msc.type: config
---
Adding Trace URLs &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<traceUrls>` collection adds a trace URL to the collection of URLs for ETW tracing.

> [!NOTE]
> Event Tracing for Windows (ETW) is a general-purpose, high-speed tracing facility provided by the operating system. Using a buffering and logging mechanism implemented in the kernel, ETW provides a tracing mechanism for events raised by both user-mode applications and kernel-mode device drivers. Additionally, ETW gives you the ability to enable and disable logging dynamically, making it easy to perform detailed tracing in production environments without requiring reboots or application restarts. The logging mechanism uses per-processor buffers that are written to disk by an asynchronous writer thread. This allows large-scale server applications to write events with minimum disturbance.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<traceUrls>` collection was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<traceUrls>` element of the `<httpTracing>` collection is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for the `<httpTracing>` element for IIS 7. For examples of how to access the `<httpTracing>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `Value` | Required string attribute. <br><br>Specifies the URL to trace. |

### Child Elements

None.

### Configuration Sample

The following example will enable tracing for the sample home page that ships with IIS 7 when placed in a Web.config file in the root of the Default Web Site.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable tracing for the sample home page that ships with IIS 7 on Web site named Contoso by adding an entry to the `<traceUrls>` collection for that site.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]