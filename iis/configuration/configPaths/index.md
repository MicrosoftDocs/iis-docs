---
title: "Configuration Paths &lt;configPaths&gt;"
author: rick-anderson
description: "Overview The &lt;configPaths&gt; element lists the locations where a configuration setting is set across the Internet Information Services (IIS) 7 distribute..."
ms.date: 09/26/2016
ms.assetid: 68879fd3-9da5-4f4b-b905-09626583a143
msc.legacyurl: /configreference/configpaths
msc.type: config
---
Configuration Paths &lt;configPaths&gt;
====================
<a id="001"></a>
## Overview

The `<configPaths>` element lists the locations where a configuration setting is set across the Internet Information Services (IIS) 7 distributed configuration file system. The contents of the `<configPaths>` element are generated dynamically, and can be accessed programmatically to list configuration settings starting from a user-specified path through each descendant path. You can also list the settings in the ApplicationHost.config and Web.config files by using the `<configPaths>` element.

The `<configPaths>` element contains a collection of `<searchResult>` elements that specify the following information:

- The **path** attribute of each `<searchResult>` element specifies the absolute virtual path of the configuration file for the search result. - The **locationPath** attribute of each `<searchResult>` element specifies the relative path for the `<location>` tag inside the configuration file that is specified by the **path** attribute.  
  
    > [!NOTE]
    > If the `<searchResult>` element points to a .config file, the **locationPath** attribute for the `<searchResult>` element will contain an empty string. 

- The **status** attribute of each `<searchResult>` element contains an HRESULT code for the search result. 

- Each `<searchResult>` element contains a collection of `<section>` elements that contain the name of each element in the search results.

> [!NOTE]
> The `<configPaths>` element and its child elements are read-only and cannot be configured by an end user.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<configPaths>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<configPaths>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<configPaths>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<configPaths>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<configPaths>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<configPaths>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for configuring the `<configPaths>` element for IIS 7. For examples of how to configure the `<configPaths>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`searchResult`](searchresult/index.md) | Contains a collection of configuration search results. |

### Configuration Sample

> [!NOTE]
> The `<configPaths>` element is generated dynamically. Because of this, you cannot add a `<configPaths>` element to your configuration files. For examples of how to access the `<configPaths>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="006"></a>
## Sample Code

The following code examples use the `<configPaths>` element to search the Default Web Site configuration namespace for every `<system.webServer/defaultDocument>` element, and then output the path and location for each element to the console.

### AppCmd.exe

> [!NOTE]
> You cannot query `<configPaths>` settings using AppCmd.exe.

### C\#

[!code-csharp[Main](index/samples/sample1.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample2.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample3.js)]

### VBScript

[!code-vb[Main](index/samples/sample4.vb)]