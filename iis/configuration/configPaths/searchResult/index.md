---
title: "Configuration Path Search Results &lt;searchResult&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;searchResult&gt; element of the &lt;configPaths&gt; element contains a collection of configuration search results. Compatibility Version Not..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/configpaths/searchresult
msc.type: config
---
Configuration Path Search Results &lt;searchResult&gt;
====================
<a id="001"></a>
## Overview

The `<searchResult>` element of the `<configPaths>` element contains a collection of configuration search results.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<searchResult>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<searchResult>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<searchResult>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<searchResult>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<searchResult>` element of the `<configPaths>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<searchResult>` element of the `<configPaths>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for the `<configPaths>` element for IIS 7. For examples of how to access the `<configPaths>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `path` | Required string attribute. Indicates the absolute virtual path of the configuration file. |
| `locationPath` | Required string attribute. Indicates the relative path for the location tag inside the configuration file. |
| `status` | Required int attribute. Specifies a status code that indicates whether the search for **path** and **locationPath** was successful. |

### Child Elements

| Element | Description |
| --- | --- |
| [`section`](section.md) | Contains a collection of section names returned by the configuration search, for example, "system.webServer/security/authentication/windowsAuthentication." |

### Configuration Sample

> [!NOTE]
> The `<configPaths>` element is generated dynamically. Because of this, you cannot add a `<configPaths>` element to your configuration files. For examples of how to access the `<configPaths>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="006"></a>
## Sample Code

The following code examples use the `<configPaths>` element to search the Default Web Site configuration namespace for every `<system.webServer/defaultDocument>` element, and then output the path and location for each element to the console.

### AppCmd.exe

> [!NOTE]
> You cannot query `<configPaths>` settings using AppCmd.exe.

### C#

[!code-csharp[Main](index/samples/sample1.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample2.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample3.js)]

### VBScript

[!code-vb[Main](index/samples/sample4.vb)]