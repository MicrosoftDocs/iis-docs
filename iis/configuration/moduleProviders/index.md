---
title: "Module Providers &lt;moduleProviders&gt;"
author: rick-anderson
description: "Overview The &lt;moduleProviders&gt; element specifies the list of module providers for IIS Manager. Each module provider entry contains the managed-code reg..."
ms.date: 09/26/2016
ms.assetid: a44c08c3-ed2e-49f9-8462-ba01420a844a
msc.legacyurl: /configreference/moduleproviders
msc.type: config
---
# Module Providers &lt;moduleProviders&gt;

<a id="001"></a>

## Overview

The `<moduleProviders>` element specifies the list of module providers for IIS Manager. Each module provider entry contains the managed-code registration information for a module, which enables the module as a feature in IIS Manager. The `<moduleProviders>` element works in relation with the `<modules>` element in the following way:

- The `<moduleProviders>` element specifies the list of module providers for IIS Manager.
- The `<modules>` element specifies the list of modules that will appear as features when a user connects to a site or an application by using IIS Manager.

> [!NOTE]
> The settings in the `<moduleProviders>` element can only be configured in the Administration.config file.

<a id="002"></a>

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<moduleProviders>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<moduleProviders>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<moduleProviders>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<moduleProviders>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<moduleProviders>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>

## Setup

The `<moduleProviders>` element is included in the default installation of IIS 7.

<a id="004"></a>

## How To

There is no user interface for adding modules to the `<moduleProviders>` element for IIS 7. For examples of how to add modules to the `<moduleProviders>` element programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>

## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. <br><br>Adds a module to the collection of module providers for IIS Manager. |
| `clear` | Optional element. <br><br>Removes all references to modules from the module providers collection. |
| `remove` | Optional element. <br><br>Removes a reference to a module from the collection of module providers for IIS Manager. |

### Configuration Sample

The following sample configuration excerpt from the Administration.config file adds a managed module provider named ContosoProvider to the end of the `<moduleProviders>` collection. The **name** property defines the name ContosoProvider for the module, and the **type** property defines the managed type for the module.

> [!NOTE]
> This sample configuration excerpt has been shortened for easier reading.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>

## Sample Code

> [!NOTE]
> The examples in this document illustrate using a managed-code assembly that has been stored in the .NET Global Assembly Cache (GAC). Before using the code in these examples to deploy your own assemblies, you need to retrieve the assembly information from the GAC. To do so, use the following steps:

- In Windows Explorer, open your C:\Windows\assembly path, where C: is your operating system drive.
- Locate your assembly.
- Right-click the assembly and click **Properties**.
- Copy the **Culture** value; for example: **Neutral**.
- Copy the **Version** number; for example: **1.0.0.0**.
- Copy the **Public Key Token** value; for example: **426f62526f636b73**.
- Click **Cancel**.

The following code examples add a managed module provider named ContosoProvider to the Administration.config file. The **name** property defines the name ContosoProvider for the module, and the **type** property defines the managed type for the module.

### AppCmd.exe

> [!NOTE]
> You cannot configure `<moduleProviders>` settings using AppCmd.exe.

### C\#

[!code-csharp[Main](index/samples/sample2.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample3.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample4.js)]

### VBScript

[!code-vb[Main](index/samples/sample5.vb)]
