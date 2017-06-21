HTTP Tracing <httpTracing>
====================
<a id="001"></a>
## Overview

The `<httpTracing>` element allows you to configure request-based event tracing for incoming IIS requests, and contains a `<traceUrls>` element which contains a collection of `<add>` elements, each of which defines a unique URL to enable tracing.

> [!NOTE]
> Event Tracing for Windows (ETW) is a general-purpose, high-speed tracing facility provided by the operating system. Using a buffering and logging mechanism implemented in the kernel, ETW provides a tracing mechanism for events raised by both user-mode applications and kernel-mode device drivers. Additionally, ETW gives you the ability to enable and disable logging dynamically, making it easy to perform detailed tracing in production environments without requiring reboots or application restarts. The logging mechanism uses per-processor buffers that are written to disk by an asynchronous writer thread. This allows large-scale server applications to write events with minimum disturbance.

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
| `[traceUrls](https://www.iis.net/configreference/system.webserver/httptracing/traceurls)` | Optional element. Specifies the URL for which you want to enable request-based ETW tracing. |

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

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]