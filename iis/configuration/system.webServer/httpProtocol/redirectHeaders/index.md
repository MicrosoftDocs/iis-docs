---
title: "Redirect Headers &lt;redirectHeaders&gt;"
author: rick-anderson
description: "Overview The &lt;redirectHeaders&gt; element specifies a collection of custom HTTP headers that Internet Information Services (IIS) 7 will add to HTTP redire..."
ms.date: 09/26/2016
ms.assetid: 50621259-4306-4ab5-8dc8-7c5c49c1decf
msc.legacyurl: /configreference/system.webserver/httpprotocol/redirectheaders
msc.type: config
---
Redirect Headers &lt;redirectHeaders&gt;
====================
<a id="001"></a>
## Overview

The `<redirectHeaders>` element specifies a collection of custom HTTP headers that Internet Information Services (IIS) 7 will add to HTTP redirects.

> [!NOTE]
> HTTP headers are name and value pairs that are returned in responses from a Web server. Unlike custom headers, which are returned in every response from a Web server, redirect headers are returned only when redirection occurs.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<redirectHeaders>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<redirectHeaders>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<redirectHeaders>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<redirectHeaders>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<redirectHeaders>` element of the `<httpProtocol>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<redirectHeaders>` element of the `<httpProtocol>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding values to the `<redirectHeaders>` element for IIS 7. For examples of how to add values to the `<redirectHeaders>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. <br><br>Adds a response header to the `<redirectHeaders>` collection. |
| `clear` | Optional element. <br><br>Removes all references to response headers from the `<redirectHeaders>` collection. |
| `remove` | Optional element. <br><br>Removes a reference to a response header from the `<redirectHeaders>` collection. |

### Configuration Sample

The following configuration sample specifies a custom HTTP header and value that will only be added to the response when IIS 7 redirects a request.

[!code-xml[Main](index/samples/sample1.xml)]

> [!NOTE]
> The following default `<httpProtocol>` element is configured in the ApplicationHost.config file in IIS 7.

[!code-xml[Main](index/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following code samples specify a custom HTTP header and value that will only be added to the response when IIS 7 redirects a request.

### AppCmd.exe

[!code-console[Main](index/samples/sample3.cmd)]

### C\#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]