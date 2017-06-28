---
title: "Recycling Settings for an Application Pool &lt;recycling&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;recycling&gt; element contains configuration settings that control the conditions that trigger IIS 7 to restart an application pool. You can..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/applicationpools/add/recycling
msc.type: config
---
Recycling Settings for an Application Pool &lt;recycling&gt;
====================
<a id="001"></a>
## Overview

The `<recycling>` element contains configuration settings that control the conditions that trigger IIS 7 to restart an application pool. You can also control the types of events IIS writes to the event log when the application pool recycles.

You can specify that IIS recycle an application pool at set intervals (such as every 180 minutes), at a specific time each day, or after the application pool receives a certain number of requests. You can also configure the `<recycling>` element to restart the application pool when the worker process virtual memory and physical memory usage reaches a specific threshold.

You can use the `<recycling>` element to specify two classes of events to log to the event log when IIS recycles an application pool. The first class contains recycling events that you can configure, such as those mentioned in the previous paragraph. The second class includes run-time recycling events, such as on-demand recycling events, recycling events triggered by configuration changes in the application or applications running in the application pool, or recycling caused by an unhealthy Internet Server Application Programming Interface (ISAPI) filter or ISAPI extension.

The `<recycling>` element uses the following attribute and child element to implement these features:

- **logEventOnRecycle** attribute
- **periodicRestart** element

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The default value of the `logEventOnRecycle` attribute was modified in IIS 10.0. |
| IIS 8.5 | The `<recycling>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<recycling>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<recycling>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<recycling>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<recycling>` element replaces portions of the IIS 6.0 **IIsApplicationPools** metabase property. |

<a id="003"></a>
## Setup

The `<applicationPools>` collection is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to set up periodic recycling for an application pool

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or Windows Server 2012 R2: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or Windows 8.1: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Server 2008 or Windows Server 2008 R2: 

        - On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows Vista or Windows 7: 

        - On the taskbar, click **Start**, and then click **Control Panel**.
        - Double-click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, expand the server name, and then click **Application Pools**.
3. In the **Application Pools** pane, select the application pool you want edit.
4. In the **Actions** pane, click **Recycling...**   
    [![](index/_static/image2.png)](index/_static/image1.png)
5. On the Recycling Conditions page of the Edit Application Pool Recycling Settings Wizard, select at least one of the options in the **Fixed Intervals** section, type values into the appropriate text boxes, and then click **Next**.  
    [![](index/_static/image4.png)](index/_static/image3.png)
6. (Optional) On the Recycling Events to Log page of the Edit Application Pool Recycling Settings Wizard, select the configurable recycling events and run-time recycling events that you want IIS to send to the event log when they occur, and then click **Finish**.  
    [![](index/_static/image6.png)](index/_static/image5.png)
 
<a id="005"></a>
## Configuration

The `<recycling>` element is configurable at the server level in the ApplicationHost.config file.

### Attributes

| Attribute | Description |
| --- | --- |
| `disallowOverlappingRotation` | Optional Boolean attribute. Specifies whether the WWW Service should start another worker process to replace the existing worker process while that process is shutting down. The value of this property should be set to **true** if the worker process loads any application code that does not support multiple worker processes. The default value is `false`. |
| `disallowRotationOnConfigChange` | Optional Boolean attribute. Specifies whether the WWW Service should rotate worker processes in an application pool when the configuration has changed. The default value is `false`. |
| `logEventOnRecycle` | Optional flags attribute. Specifies that IIS should log an event when an application pool is recycled. The **logEventOnRecycle** property must have a bit set corresponding to the reason for the recycle if IIS is to log the event. The **logEventOnRecycle** attribute can have one or more of the following possible values. If you specify more than one value, separate them with a comma (,). The default flags for versions of IIS earlier than IIS 10 are `Time`, `Memory`, and `PrivateMemory`; for IIS 10 and later are `Time`, `Requests`, `Schedule`, `Memory`, `IsapiUnhealthy`, `OnDemand`, `ConfigChange`, and `PrivateMemory`; | Value | Description | | --- | --- | | `ConfigChange` | Log an event when an application pool recycles because of a configuration change. The numeric value is `64`. | | `IsapiUnhealthy` | Log an event when an application pool recycles after an ISAPI extension reports to the worker process that it is in an unhealthy state. The numeric value is `16`. | | `Memory` | Log an event when an application pool recycles after it uses a specified amount of virtual memory. The numeric value is `8`. | | `OnDemand` | Log an event when an application pool is recycled immediately to correct a problem. The numeric value is `32`. | | `PrivateMemory` | Log an event when an application pool recycles after it uses a specified amount of virtual memory. The numeric value is `128`. | | `Requests` | Log an event when an application pool recycles after it reaches a configured number of requests. The numeric value is `2`. | | `Schedule` | Log an event when an application pool recycles after it reaches a configured time of day. The numeric value is `4`. | | `Time` | Log an event when an application pool recycles after a configured time. The numeric value is `1`. | |

### Child Elements

| Element | Description |
| --- | --- |
| [`periodicRestart`](periodicrestart/index.md) | Optional element. Specifies conditions under which application pools are recycled. |

### Configuration Sample

The following configuration sample uses the application pool `<add>` element to create a new application pool named Contoso. The `<recycling>` element configures logging for application pool restarts, the `<periodicRestart>` element configures when the application pool restarts, and the `<processModel>` element configures the **shutdownTimeLimit** and **startupTimeLimit** attributes for shutting down and starting the worker processes in the application pool for 30 seconds each. If these time limits are exceeded, IIS terminates the worker process.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code examples add an application pool named Contoso to your IIS 7 server, then set the application pool to daily recycle at 3:00 A.M.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

You can also use the following syntax:

[!code-console[Main](index/samples/sample3.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample4.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample5.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample6.js)]

### VBScript

[!code-vb[Main](index/samples/sample7.vb)]