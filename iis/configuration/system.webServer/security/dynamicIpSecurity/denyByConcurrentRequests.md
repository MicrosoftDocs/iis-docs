Deny by Concurrent Requests <denyByConcurrentRequests> <denyByConcurrentRequests>
====================
<a id="001"></a>
## Overview

The `<denyByConcurrentRequests>` element specifies that a remote client will be blocked if the number of concurrent HTTP connection requests from that client exceeds a specific number.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<denyByConcurrentRequests>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<denyByConcurrentRequests>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<denyByConcurrentRequests>` element was introduced in IIS 8.0. |
| IIS 7.5 | N/A |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

To support blocking a client on your Web server by the number of concurrent requests, you must install the IP and Domain Restrictions role service.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Security**, and then select **IP and Domain Restrictions**. Click **Next**.  
    [![](denyByConcurrentRequests/_static/image2.png)](denyByConcurrentRequests/_static/image1.png) .
5. On the **Select features** page, click **Next**.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Security**, and then select **IP Security**.  
    [![](denyByConcurrentRequests/_static/image4.png)](denyByConcurrentRequests/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

<a id="004"></a>
## How To

### How to deny an IP address by the number of concurrent requests

1. Open **Internet Information Services (IIS) Manager**: 

    - If you are using Windows Server 2012 or later: 

        - On the taskbar, click **Server Manager**, click **Tools**, and then click **Internet Information Services (IIS) Manager**.
    - If you are using Windows 8 or later: 

        - Hold down the **Windows** key, press the letter **X**, and then click **Control Panel**.
        - Click **Administrative Tools**, and then double-click **Internet Information Services (IIS) Manager**.
2. In the **Connections** pane, select the server name to add dynamic IP restrictions for the server, or expand **Sites** and then select a site to add dynamic IP restrictions for the site.
3. In the **Home** pane, double-click the **IP Address and Domain Restrictions** feature.
4. In the **Actions** pane, click **Edit Dynamic Restriction Settings...**.
5. In the **Dynamic IP Restriction Settings** dialog box, select **Deny IP Address based on the number of concurrent requests**, enter the maximum number of concurrent requests, and then click **OK**.  
  
    [![](denyByConcurrentRequests/_static/image6.png)](denyByConcurrentRequests/_static/image5.png)

<a id="005"></a>
## Configuration

The `<denyByConcurrentRequests>` element is configured at the server or site level.

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute. Enables a remote client to be blocked based on the number of concurrent HTTP connection requests from that client. The default value is `false`. |
| `maxConcurrentRequests` | Optional uint attribute. The number of concurrent HTTP connection requests from a client that will result in the client being blocked. The default value is `5`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample demonstrates how to set dynamic IP address restrictions.

[!code-xml[Main](denyByConcurrentRequests/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples configure **&lt;dynamicIpSecurity&gt;** for a site.

### AppCmd.exe

[!code-console[Main](denyByConcurrentRequests/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when using AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](denyByConcurrentRequests/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](denyByConcurrentRequests/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](denyByConcurrentRequests/samples/sample5.js)]

### VBScript

[!code-vb[Main](denyByConcurrentRequests/samples/sample6.vb)]

### PowerShell

[!code-ps[Main](denyByConcurrentRequests/samples/sample-0-7.unknown)]