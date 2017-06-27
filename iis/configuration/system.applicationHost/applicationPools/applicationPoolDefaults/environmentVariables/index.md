---
title: "Environment Variables  &lt;environmentVariables&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;environmentVariables&gt; element of the &lt;applicationPoolDefaults&gt; element specifies a list of environment variables that Internet Info..."
ms.author: iiscontent
manager: soshir
ms.date: 06/26/2017
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/applicationpools/applicationpooldefaults/environmentvariables
msc.type: config
---
Environment Variables  &lt;environmentVariables&gt;
====================
<a id="001"></a>
## Overview

The `<environmentVariables>` element of the `<applicationPoolDefaults>` element specifies a list of environment variables that Internet Information Services (IIS) 10 will pass to worker processes when applications are launched. The `<environmentVariables>` element contains a collection of `<add>` elements which define the individual name/value pairs for each environment variable.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<environmentVariables>` element was introduced in IIS 10. |
| IIS 8.0 | N/A |
| IIS 7.5 | N/A |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<environmentVariables>` element is included in the default installation of IIS 10.

<a id="004"></a>
## How To

There is no user interface for setting the environment variables for IIS 10. For examples of how to set the environment variables programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. Adds an environment variable to the collection of environment variables. |
| `remove` | Optional element. Removes an environment variable from the collection of environment variables. |

### Configuration Sample

The following example adds an environment variable to an application pool.

[!code-xml[Main](index/samples/sample1.xml)]
 
<a id="006"></a>
## Sample Code

The following examples demonstrate how to add a name/value pair to the collection of environment variables.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]