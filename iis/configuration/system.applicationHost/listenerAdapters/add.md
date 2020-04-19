---
title: "Adding Listener Adapters &lt;add&gt;"
author: rick-anderson
description: "Overview The &lt;add&gt; element of the &lt;listenerAdapters&gt; specifies configuration settings for a non-HTTP listener adapter that can be used by Windows..."
ms.date: 09/26/2016
ms.assetid: f4e10fa9-5489-4b45-b9ff-9bcdf0848352
msc.legacyurl: /configreference/system.applicationhost/listeneradapters/add
msc.type: config
---
Adding Listener Adapters &lt;add&gt;
====================
<a id="001"></a>
## Overview

The `<add>` element of the `<listenerAdapters>` specifies configuration settings for a non-HTTP listener adapter that can be used by Windows Process Activation Service (WAS) to communicate with a listener service.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<add>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<add>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<add>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<add>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<add>` element of the `<listenerAdapters>` element was introduced in IIS 7.0. |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<add>` element of the `<listenerAdapters>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for adding listener adapters for IIS 7. For examples of how to add listener adapters programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `identity` | Optional string attribute. <br><br>Specifies a local account name, a domain account, or a built-in account. The identity is used to help secure the WAS communication channel between the listener service and the listener adapter. |
| `name` | Required string attribute. <br><br>Specifies the unique name of the listener adapter to which WAS connects the listener service. |
| `protocolManagerDll` | Optional string attribute. <br><br>Specifies the fully qualified path or short name of the DLL that contains the listener adapter's code. The DLL must be found on disk (by using standard search procedures that depend on DLL type) in order for the function specified in **protocolManagerDllInitFunction** to be called. |
| `protocolManagerDllInitFunction` | Optional string attribute. <br><br>Specifies the name of the function to call in the custom listener adapter code. The DLL specified in the **protocolManagerDll** attribute must contain the function specified in the **protocolManagerDllInitFunction** attribute.<br><br>**Note:** This attribute is case-sensitive; you must use the correct case when you specify the name of the initialization function. |

### Child Elements

None.

### Configuration Sample

The following configuration sample adds a listener adapter for a Gopher protocol provider, and specifies both the name of the DLL and its initialization function.

[!code-xml[Main](add/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples add a listener adapter for a Gopher protocol provider, and specify both the name of the DLL and its initialization function.

### AppCmd.exe

[!code-console[Main](add/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](add/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](add/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](add/samples/sample5.js)]

### VBScript

[!code-vb[Main](add/samples/sample6.vb)]
