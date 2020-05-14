---
title: "Listener Adapters &lt;listenerAdapters&gt;"
author: rick-anderson
description: "Overview The &lt;listenerAdapters&gt; element specifies configuration settings for listener adapters for Internet Information Services (IIS) 7. Listener adap..."
ms.date: 09/26/2016
ms.assetid: e4baaeca-18d7-4094-8e03-61410d413947
msc.legacyurl: /configreference/system.applicationhost/listeneradapters
msc.type: config
---
# Listener Adapters &lt;listenerAdapters&gt;

<a id="001"></a>
## Overview

The `<listenerAdapters>` element specifies configuration settings for listener adapters for Internet Information Services (IIS) 7. Listener adapters are components that establish communication between non-HTTP protocol listener services and the Windows Process Activation Service (WAS). Changes to the `<listenerAdapters>` element take effect only when a listener adapter connects with WAS. In most cases, this connection requires that the server be restarted.

**Notes**:

- The World Wide Web Publishing Service (W3SVC) contains HTTP-specific functionality for IIS 7, so it does not use additional `<listenerAdapters>` attributes. - The FTP service, which does not require the WAS, does not have a `<listenerAdapters>` entry.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<listenerAdapters>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<listenerAdapters>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<listenerAdapters>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<listenerAdapters>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<listenerAdapters>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<listenerAdapters>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding listener adapters for IIS 7. For examples of how to add listener adapters programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. <br><br>Specifies the configuration for a listener adapter. |

### Configuration Sample

The following configuration sample adds a listener adapter for a Gopher protocol provider, and specifies both the name of the DLL and its initialization function.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples add a listener adapter for a Gopher protocol provider, and specify both the name of the DLL and its initialization function.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]
