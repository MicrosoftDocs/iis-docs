---
title: "Limits for a Web Site &lt;limits&gt;"
author: rick-anderson
description: "Overview The &lt;limits&gt; element of the &lt;site&gt; element configures settings that limit the amount of bandwidth, the number of connections, or the con..."
ms.date: 09/26/2016
ms.assetid: 3bc96a77-9318-4ad9-ae82-e215ecf89ad1
msc.legacyurl: /configreference/system.applicationhost/sites/site/limits
msc.type: config
---
Limits for a Web Site &lt;limits&gt;
====================
<a id="001"></a>
## Overview

The `<limits>` element of the `<site>` element configures settings that limit the amount of bandwidth, the number of connections, or the connection time-out for client requests to a site.

> [!NOTE]
> If the `<limits>` element is configured in both the `<siteDefaults>` section and in the `<site>` section for a specific site, the configuration in the `<site>` section is used for that site.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<limits>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<limits>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `maxUrlSegments` attribute was added to specify the maximum number of segments permitted in a URL. |
| IIS 7.5 | The `<limits>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<limits>` element of the `<site>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<limits>` element replaces the following IIS 6.0 metabase settings: <ul> <li><strong>ConnectionTimeout</strong></li> <li><strong>MaxBandwidth</strong></li> <li><strong>MaxConnections</strong> </li></ul> |

<a id="003"></a>
## Setup

The `<limits>` element of the `<site>` element is included in the default installation of IIS 7 and later.

<a id="004"></a>
## How To

### How to configure the connection limit options for a site

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
2. In the **Connections** pane, expand the server name, expand the **Sites** node, and then click the name of the site.
3. In the site's **Home** pane, click **Advanced Settings...** in the **Actions** pane.
4. In the **Advanced Settings** dialog box, expand **Limits**, specify connection limit options, and then click **OK**.  
  
    [![](limits/_static/image2.png)](limits/_static/image1.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `connectionTimeout` | Optional timeSpan attribute. <br><br>Specifies the time (in seconds) that IIS waits before it disconnects a connection that is considered inactive. Connections can be considered inactive for the following reasons: <ul> <li>The HTTP.sys Timer_ConnectionIdle timer expired. The connection expired and remains idle.</li> <li>The HTTP.sys Timer_EntityBody timer expired. The connection expired before the request entity body arrived. When it is clear that a request has an entity body, the HTTP API turns on the Timer_EntityBody timer. Initially, the limit of this timer is set to the connectionTimeout value. Each time another data indication is received on this request, the HTTP API resets the timer to give the connection more minutes as specified in the connectionTimeout attribute.</li> <li>The HTTP.sys Timer_AppPool timer expired. The connection expired because a request waited too long in an application pool queue for a server application to dequeue and process it. This time-out duration is connectionTimeout. </li></ul> The default value is `00:02:00` (two minutes). |
| `maxBandwidth` | Optional uint attribute. <br><br>Specifies the maximum network bandwidth, in bytes per second, that is used for a site. Use this setting to help prevent overloading the network with IIS activity. <br><br>The default value is `4294967295`. |
| `maxConnections` | Optional uint attribute.<br><br>Specifies the maximum number of connections for a site. Use this setting to limit the number of simultaneous client connections.<br><br>The default value is `4294967295`. |
| `maxurlSegments` | Optional uint attribute.<br><br>Specifies the maximum number of segments permitted in a URL.<br><br>The default value is `32`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample shows a Web site where the maximum bandwidth is set to 65,536 bytes per second, the maximum number of connections is set to 1024 , and the connection time-out is set to 1 minute.

[!code-xml[Main](limits/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples configure the Default Web Site for a maximum bandwidth of 65,536 bytes per second, 1024 maximum connections, and a connection time-out of 1 minute.

### AppCmd.exe

[!code-console[Main](limits/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](limits/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](limits/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](limits/samples/sample5.js)]

### VBScript

[!code-vb[Main](limits/samples/sample6.vb)]
