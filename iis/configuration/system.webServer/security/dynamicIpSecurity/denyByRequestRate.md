---
title: "Deny by Request Rate <denyByRequestRate> &lt;denyByRequestRate&gt;"
author: rick-anderson
description: "Overview The &lt;denyByRequestRate&gt; element specifies that a remote client will be blocked if the number of requests received over a period of time exceed..."
ms.date: 09/26/2016
ms.assetid: 8f0bd47d-adf6-4738-978d-8071b2747048
msc.legacyurl: /configreference/system.webserver/security/dynamicipsecurity/denybyrequestrate
msc.type: config
---
# Deny by Request Rate <denyByRequestRate> &lt;denyByRequestRate&gt;

<a id="001"></a>
## Overview

The `<denyByRequestRate>` element specifies that a remote client will be blocked if the number of requests received over a period of time exceeds a specific number.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<denyByRequestRate>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<denyByRequestRate>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<denyByRequestRate>` element was introduced in IIS 8.0. |
| IIS 7.5 | N/A |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

To support blocking a client on your Web server by the number of requests received, you must install the IP and Domain Restrictions role service.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **IP and Domain Restrictions**. Click **Next**.  
    [![](denyByRequestRate/_static/image2.png)](denyByRequestRate/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **IP Security**.  
    [![](denyByRequestRate/_static/image4.png)](denyByRequestRate/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

<a id="004"></a>
## How To

### How to deny an IP address by request rate

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or later: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or later: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, select the server name to add dynamic IP restrictions for the server, or expand **Sites** and then select a site to add dynamic IP restrictions for the site.
3. In the **Home** pane, double-click the **IP Address and Domain Restrictions** feature.
4. In the **Actions** pane, click **Edit Dynamic Restriction Settings...**.
5. In the **Dynamic IP Restriction Settings** dialog box, select **Deny IP Address based on the number of requests over a period of time**, enter the maximum number of requests, enter the time period (in milliseconds) that is used to determine the request rate, and then click **OK**.  
  
    [![](denyByRequestRate/_static/image6.png)](denyByRequestRate/_static/image5.png)

<a id="005"></a>
## Configuration

The `<denyByRequestRate>` element is configured at the server or site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br><br>Enables a remote client to be blocked based on the number of requests received over a period of time.<br><br>The default value is `false`. |
| `maxRequests` | Optional uint attribute.<br><br>The number of requests received from a specific client over a specified period of time that will result in the client being blocked (if the check is enabled).<br><br>The default value is `20`. |
| `requestIntervalInMilliseconds` | Optional uint attribute.<br><br>The period of time (in milliseconds) that is used to determine the request rate for a specific client. This rate is used to determine whether the receive rate exceeds that the maximum specified, resulting in the client being blocked (if the check is enabled).<br><br>The default value is `200`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample demonstrates how to set dynamic IP address restrictions.

[!code-xml[Main](denyByRequestRate/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure **&lt;dynamicIpSecurity&gt;** for a site.

### AppCmd.exe

[!code-console[Main](denyByRequestRate/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when using AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](denyByRequestRate/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](denyByRequestRate/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](denyByRequestRate/samples/sample5.js)]

### VBScript

[!code-vb[Main](denyByRequestRate/samples/sample6.vb)]

### PowerShell

[!code-powershell[Main](denyByRequestRate/samples/sample7.ps1)]
