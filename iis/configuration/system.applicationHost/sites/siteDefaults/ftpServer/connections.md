---
title: "Default FTP Connection Settings &lt;connections&gt;"
author: rick-anderson
description: "Overview The &lt;connections&gt; element specifies the connection-related settings for FTP sites. More specifically, the settings in the &lt;connections&gt;..."
ms.date: 09/26/2016
ms.assetid: 33a52399-07b1-432b-9c4e-4634c8eaf0e5
msc.legacyurl: /configreference/system.applicationhost/sites/sitedefaults/ftpserver/connections
msc.type: config
---
Default FTP Connection Settings &lt;connections&gt;
====================
<a id="001"></a>
## Overview

The `<connections>` element specifies the connection-related settings for FTP sites. More specifically, the settings in the `<connections>` element control the behavior for the FTP service with regard to how to manage clients that are connecting to an FTP site.

For example, the `unauthenticatedTimeout`, `controlChannelTimeout`, and `dataChannelTimeout` attributes specify the time-outs for an FTP site. The settings specify, respectively, when the FTP service will disconnect an FTP client that has not successfully logged in or is idle, or when to disconnect an idle data connection. Specifying values for the attributes in the `<connections>` element can directly affect the overall performance of your server by helping to police the number of active client sessions for your FTP sites.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<connections>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<connections>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<connections>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<connections>` element of the `<ftpServer>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<connections>` element of the `<ftpServer>` element was introduced in FTP 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

> [!NOTE]
> The FTP 7.0 and FTP 7.5 services shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:
>
> [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)

With Windows 7 and Windows Server 2008 R2, the FTP 7.5 service ships as a feature for IIS 7.5, so downloading the FTP service is no longer necessary.

<a id="003"></a>
## Setup

To support FTP publishing for your Web server, you must install the FTP service. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**.
2. In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**.
3. In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**.
4. On the **Server Roles** page, expand **Web Server (IIS)**, and then select **FTP Server**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will need to select **FTP Extensibility**, in addition to **FTP Service**.  
    [![](connections/_static/image2.png)](connections/_static/image1.png) .
5. Click **Next**, and then on the **Select features** page, click **Next** again.
6. On the **Confirm installation selections** page, click **Install**.
7. On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**.
3. Expand **Internet Information Services**, and then select **FTP Server**.
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.
    [![](connections/_static/image4.png)](connections/_static/image3.png)
4. Click **OK**.
5. Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**.
2. In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**.
3. In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**.
4. On the **Select Role Services** page of the **Add Role Services Wizard**, expand **FTP Server**.
5. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.  
    [![](connections/_static/image6.png)](connections/_static/image5.png)
6. Click **Next**.
7. On the **Confirm Installation Selections** page, click **Install**.
8. On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**.
2. In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**.
3. Expand **Internet Information Services**, and then **FTP Server**.
4. Select **FTP Service**.  
  
    > [!NOTE]
    > To support ASP.Membership authentication or IIS Manager authentication for the FTP service, you will also need to select **FTP Extensibility**.
    [![](connections/_static/image8.png)](connections/_static/image7.png)
5. Click **OK**.

### Windows Server 2008 or Windows Vista

1. Download the installation package from the following URL:

    - [https://www.iis.net/expand/FTP](https://www.iis.net/downloads/microsoft/ftp)
2. Follow the instructions in the following walkthrough to install the FTP service:

     - [Installing and Troubleshooting FTP 7](https://go.microsoft.com/fwlink/?LinkId=88547)

<a id="004"></a>
## How To

### How to configure the default control and data channel time-outs for all FTP sites

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
2. In the **Connections** pane, click the server name, and then click the **Sites** node.
3. In the **Sites** pane, click **Set FTP Site Defaults...** in the **Actions** pane.
4. In the **Advanced Settings** dialog box, expand **Connections**, specify your time-outs in the **Control Channel Timeout** and **Data Channel Timeout** fields, and then click **OK**.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `controlChannelTimeout` | Optional int attribute.<br><br>Specifies the timeout, in seconds, when a connection will be timed out because of inactivity on the control channel. **Note:** The FTP service will disconnect the session when this timeout is reached.<br><br>The default value is `120`. |
| `dataChannelTimeout` | Optional int attribute.<br><br>Specifies the timeout, in seconds, when a connection will be timed out because of inactivity on the data channel. **Note:** The FTP service will only disconnect the data channel when this timeout is reached.<br><br>The default value is `30`. |
| `disableSocketPooling` | Optional **Boolean** attribute. **true** if socket pooling is disabled; otherwise, **false**. The `disableSocketPooling` attribute specifies whether socket pooling is used for sites that are distinguished by IP address rather than port number or host name. If `disableSocketPooling` is set to **false**, then socket pooling is enabled and sockets are shared between sites that use the same socket number but different IP addresses. In this situation, the FTP service becomes the exclusive owner of the port on each address that is bound to the server. For example, if socket pooling is enabled on a server that has two IP addresses, 10.0.0.1 and 10.0.0.2, and an FTP site is bound to address 10.0.0.1 on port 21, the FTP service will also own port 21 on the 10.0.0.2 address. If `disableSocketPooling` is set to **true**, then there is no socket sharing for sites based on IP address. The default value is `false`. |
| `maxBandwidth` | Unused uint attribute.<br><br>**Note:** This attribute is not implemented for FTP 7. |
| `maxConnections` | Optional unit attribute.<br><br>Specifies the maximum number of simultaneous connections for an FTP site.<br><br>**Note:** Use the maxClientsMessage attribute of the &lt;messages&gt; element to specify a message that the FTP service will return to clients when the maximum number of simultaneous connections has been exceeded.<br><br>The default value is `4294967295` (unlimited.) |
| `minBytesPerSecond` | Optional int attribute.<br><br>Specifies the minimum bandwidth requirements for data transfers. **Note:** The FTP service will disconnect the data channel when the minimum bandwidth is not met.<br><br>The default value is `240`. |
| `resetOnMaxConnections` | Optional **Boolean** attribute.<br><br>**true** if the FTP service should quickly disconnect an FTP session instead of sending a maximum connections response; otherwise **false**.<br><br>**Note:** The `resetOnMaxConnections` attribute optimizes the overhead when processing connections that are not allowed to connect because **maxConnection** limit was reached.<br><br>The default value is `false`. |
| `serverListenBacklog` | Optional int attribute.<br><br>Specifies the number of outstanding sockets that can be queued.<br><br>The default value is `60`. |
| `unauthenticatedTimeout` | Optional int attribute.<br><br>Specifies the idle time-out, in seconds, between when a new connection is made and authentication succeeds. If the client does not successfully authenticate within the specified time period, the FTP service will disconnect the session.<br><br>The default value is `30`. |

### Child Elements

None.

### Configuration Sample

The following configuration sample displays an example `<connections>` element for a server that has the default control channel time-out set to 300 seconds.

[!code-xml[Main](connections/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples illustrate how to set the default control channel time-out to 300 seconds..

### AppCmd.exe

[!code-console[Main](connections/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](connections/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](connections/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](connections/samples/sample5.js)]

### VBScript

[!code-vb[Main](connections/samples/sample6.vb)]
