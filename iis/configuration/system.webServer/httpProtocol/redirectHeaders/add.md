---
title: "Adding Redirect Headers &lt;add&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;redirectHeaders&gt; element adds an HTTP response header to the collection of custom HTTP headers that Internet I..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/httpprotocol/redirectheaders/add
msc.type: config
---
Adding Redirect Headers &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<redirectHeaders>` element adds an HTTP response header to the collection of custom HTTP headers that Internet Information Services (IIS) 7 will add to HTTP redirects.

> [!NOTE]
> HTTP headers are name and value pairs that are returned in responses from a Web server. Unlike custom headers, which are returned in every response from a Web server, redirect headers are returned only when redirection occurs.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<redirectHeaders>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<add>` element of the `<redirectHeaders>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding values to the `<redirectHeaders>` element for IIS 7. For examples of how to add values to the `<redirectHeaders>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute. <br><br>Specifies a field name for the redirect header. In a response, a field name precedes the related field value. |
| `Value` | Optional string attribute. <br><br>Specifies a field value for the redirect header. In a response, a field value follows the related field name. |

### Child Elements

None.

### Configuration Sample

The following configuration sample specifies a custom HTTP header and value that will only be added to the response when IIS 7 redirects a request.

[!code-xml[Main](add/samples/sample1.xml)]

> [!NOTE]
> The following default `<httpProtocol>` element is configured in the ApplicationHost.config file in IIS 7.

[!code-xml[Main](add/samples/sample2.xml)]

<a id="006"></a>
## Sample Code

The following code samples specify a custom HTTP header and value that will only be added to the response when IIS 7 redirects a request.

### AppCmd.exe

[!code-console[Main](add/samples/sample3.cmd)]

### C#

[!code-csharp[Main](add/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample6.js)]

### VBScript

[!code-vb[Main](add/samples/sample7.vb)]