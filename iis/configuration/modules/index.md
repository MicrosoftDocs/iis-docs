---
title: "Modules &lt;modules&gt;"
author: rick-anderson
description: "Overview The &lt;modules&gt; element specifies the features that are available in IIS Manager when a user is connected to a site or an application. The &lt;m..."
ms.date: 09/26/2016
ms.assetid: 66270b50-8b2b-4346-8d0b-835d979eb2b5
msc.legacyurl: /configreference/modules
msc.type: config
---
Modules &lt;modules&gt;
====================
<a id="001"></a>
## Overview

The `<modules>` element specifies the features that are available in IIS Manager when a user is connected to a site or an application. The `<modules>` element works with the `<moduleProviders>` element in the following way:

- The `<moduleProviders>` element specifies the list of module providers for IIS Manager.
- The `<modules>` element specifies the list of modules that will appear as features when a user connects to a site or an application to IIS Manager.

You can configure which modules will be available for individual Web sites using `<location>` tags, so that each Web site or application can be customized to suit your needs. For example, you could configure the site-level management for a Web site to allow only a small subset of features, and configure a child application for a broader set of features.

> [!NOTE]
> This collection of modules is specific to IIS Manager and should not be confused with the [&lt;system.webServer modules&gt;](../system.webserver/modules/index.md) collection, which defines modules that affect HTTP request processing.

> [!NOTE]
> The settings in the `<modules>` element can only be configured in the Administration.config file.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<modules>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<modules>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<modules>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<modules>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<modules>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<modules>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding modules to the `<modules>` element for IIS 7. For examples of how to add modules to the `<modules>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Attribute | Description |
| --- | --- |
| [`add`](add.md) | Optional element. Adds a module to the collection of modules for IIS Manager. |
| `clear` | Optional element. Removes all references to modules from the parent modules collection. |
| `remove` | Optional element. Removes a reference to a module from the collection of modules for IIS Manager. |

### Configuration Sample

The following sample configuration excerpt from the Administration.config file adds a managed module provider named ContosoProvider to the end of the `<modules>` collection.

> [!NOTE]
> This sample configuration excerpt has been shortened for easier reading.

[!code-xml[Main](index/samples/sample1.xml)]

The following sample configuration excerpt from the Administration.config file specifies custom `<modules>` elements for the Default Web Site and a child application by defining unique `<location>` elements that clear the default module lists and define the specific modules that will be respectively enabled for each location. When a remote administration connects to either location, IIS Manager will only display those features that are represented by the modules that are listed in each `<location>` element.

[!code-xml[Main](index/samples/sample2.xml)]
 
<a id="006"></a>
## Sample Code

The following code examples enable a managed module provider named ContosoProvider to the global location level in the Administration.config file.

### AppCmd.exe

> [!NOTE]
> You cannot configure `<modules>` settings using AppCmd.exe.

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
