---
title: "Adding Modules &lt;add&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;modules&gt; element adds a module to the collection of feature modules that are available in IIS Manager when a u..."
ms.author: iiscontent
manager: soshir
ms.date: 9/26/2016 12:00:00 AM
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/modules/add
msc.type: config
---
Adding Modules &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<modules>` element adds a module to the collection of feature modules that are available in IIS Manager when a user is connected to a site or an application.

> [!NOTE]
> This collection of modules is specific to IIS Manager and should not be confused with the [&lt;system.webServer/modules&gt;](../system.webserver/modules/index.md) collection, which defines modules that affect HTTP request processing.

> [!NOTE]
> The settings in the `<modules>` element can only be configured in the Administration.config file.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<modules>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<add>` element of the `<modules>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding modules to the `<modules>` element for IIS 7. For examples of how to add modules to the `<modules>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute. Specifies the unique name of a managed module on the Web server. |

### Child Elements

None.

### Configuration Sample

The following sample configuration excerpt from the Administration.config file adds a managed module provider named ContosoProvider to the end of the `<modules>` collection.

> [!NOTE]
> This sample configuration excerpt has been shortened for easier reading.

[!code-xml[Main](add/samples/sample1.xml)]

The following sample configuration excerpt from the Administration.config file specifies custom `<modules>` elements for the Default Web Site and a child application by defining unique `<location>` elements that clear the default module lists and define the specific modules that will be respectively enabled for each location. When a remote administration connects to either location, IIS Manager will only display those features that are represented by the modules that are listed in each `<location>` element.

[!code-xml[Main](add/samples/sample2.xml)]
 
<a id="006"></a>
## Sample Code

The following code examples enable a managed module provider named ContosoProvider to the global location level in the Administration.config file.

### AppCmd.exe

> [!NOTE]
> You cannot configure `<modules>` settings using AppCmd.exe.

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]