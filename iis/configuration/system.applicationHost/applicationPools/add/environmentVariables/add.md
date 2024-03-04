---
title: Adding Environment Variables &lt;add&gt; element
author: rick-anderson
description: Provides an overview of the &lt;add&gt; element of the &lt;environmentVariables&gt; element and its properties.
ms.date: 09/26/2016
ms.assetid: 41182993-2366-42b0-94b5-ebb940b873f8
msc.legacyurl: /configreference/system.applicationhost/applicationpools/add/environmentvariables/add
msc.type: config
---
# Adding Environment Variables &lt;add&gt; element

<a id="001"></a>
## Overview

The `<add>` element of the `<environmentVariables>` element specifies a unique name/value pair for an environment variable that Internet Information Services (IIS) 10 will pass to a worker process when an application is launched.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was introduced in IIS 10. |
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

| Attribute | Description |
| --- | --- |
| `name` | Required string attribute.<br><br>Specifies the unique name of the environment variable.<br><br>There is no default value. |
| `value` | Required unique string attribute.<br><br>Specifies the value of the environment variable.<br><br>There is no default value. |

### Child Elements

None.

### Configuration Sample

The following example adds an environment variable to an application pool.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples demonstrate how to add a name/value pair to the collection of environment variables.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

### C\#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
