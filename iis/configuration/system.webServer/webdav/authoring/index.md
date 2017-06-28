---
title: "WebDAV Authoring &lt;authoring&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;authoring&gt; element specifies the site-level settings for WebDAV. The most important of these settings is whether WebDAV authoring is enab..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/webdav/authoring
msc.type: config
---
WebDAV Authoring &lt;authoring&gt;
====================
<a id="001"></a>
## Overview

The `<authoring>` element specifies the site-level settings for WebDAV. The most important of these settings is whether WebDAV authoring is enabled for the site. Additional elements define the behavior for the WebDAV module, such as compatibility options and how the WebDAV module works with properties, locks, and the underlying file system.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<authoring>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<authoring>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<authoring>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<authoring>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<authoring>` element was introduced in WebDAV 7.0, which was a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

> [!NOTE]
> The WebDAV 7.0 and WebDAV 7.5 modules shipped out-of-band for IIS 7.0, which required downloading and installing the modules from the following URL:

> [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)


With Windows 7 and Windows Server 2008 R2, the WebDAV 7.5 module ships as a feature for IIS 7.5, so downloading WebDAV is no longer necessary.

<a id="003"></a>
## Setup

To support WebDAV publishing for your Web server, you must install the WebDAV module. To do so, use the following steps.

### Windows Server 2012 or Windows Server 2012 R2

1. On the taskbar, click **Server Manager**. - In **Server Manager**, click the **Manage** menu, and then click **Add Roles and Features**. - In the **Add Roles and Features** wizard, click **Next**. Select the installation type and click **Next**. Select the destination server and click **Next**. - On the **Server Roles** page, expand **Web Server (IIS)**, expand **Web Server**, expand **Common HTTP Features**, and then select **WebDAV Publishing**. Click **Next**.  
    [![](index/_static/image2.png)](index/_static/image1.png) . - On the **Select features** page, click **Next**. - On the **Confirm installation selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 8 or Windows 8.1

1. On the **Start** screen, move the pointer all the way to the lower left corner, right-click the **Start** button, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows features on or off**. - Expand **Internet Information Services**, expand **World Wide Web Services**, expand **Common HTTP Features**, and then select **WebDAV Publishing**.  
    [![](index/_static/image4.png)](index/_static/image3.png)- Click **OK**.
- Click **Close**.

### Windows Server 2008 R2

1. On the taskbar, click **Start**, point to **Administrative Tools**, and then click **Server Manager**. - In the **Server Manager** hierarchy pane, expand **Roles**, and then click **Web Server (IIS)**. - In the **Web Server (IIS)** pane, scroll to the **Role Services** section, and then click **Add Role Services**. - On the **Select Role Services** page of the **Add Role Services Wizard**, expand **Common HTTP Features**, select **WebDAV Publishing**, and then click **Next**.   
    [![](index/_static/image6.png)](index/_static/image5.png)- On the **Confirm Installation Selections** page, click **Install**. - On the **Results** page, click **Close**.

### Windows 7

1. On the taskbar, click **Start**, and then click **Control Panel**. - In **Control Panel**, click **Programs and Features**, and then click **Turn Windows Features on or off**. - Expand **Internet Information Services**, then **World Wide Web Services**, and then **Common HTTP Features**. - Select **WebDAV Publishing**, and then click **OK**.   
    [![](index/_static/image8.png)](index/_static/image7.png)

### Windows Server 2008 or Windows Vista

- Download the installation package from the following URL: 

    - [https://www.iis.net/expand/WebDAV](https://www.iis.net/downloads/microsoft/webdav)
- Follow the instructions in the following walkthrough to install the WebDAV module: 

    - [Installing and Configuring WebDAV on IIS 7.0](https://go.microsoft.com/fwlink/?LinkId=105146)

<a id="004"></a>
## How To

### How to enable WebDAV publishing

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
2. In the **Connections** pane, expand the server name, and then go to the site, application, or directory where you want to enable WebDAV publishing.
3. In the **Home** pane, double-click **WebDAV Authoring Rules**.  
    [![](index/_static/image10.png)](index/_static/image9.png)
4. In the **Actions** pane, click **Enable WebDAV**.  
    [![](index/_static/image12.png)](index/_static/image11.png)

> [!NOTE]
> Once you have enabled WebDAV publishing, you will need to add authoring rules before users or groups can publish content to your server. For more information about how to create authoring rules, see the [`authoringRules`](../authoringrules/index.md) topic.

<a id="005"></a>
## Configuration

The `<authoring>` element is configurable only at the site level in the ApplicationHost.config file. Any `<authoring>` elements at other levels or in Web.config files are ignored.

### Attributes

| Attribute | Description |
| --- | --- |
| `compatFlags` | Optional flags attribute.<br><br>Specifies the compatibility options for WebDAV. There are several behaviors that were used in previous versions of Microsoft's WebDAV implementations, and the flags in this attribute specify which of those behaviors the new WebDAV module will implement.<br><br>The **compatFlags** attribute can have one or more of the following possible values. If you specify more than one value, separate them with a comma (,). The default value is `MsAuthorVia, MultiProp, CompactXml, IsHidden, IsCollection`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>None</code></th> <td>No compatibility options should be used.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>MsAuthorVia</code></th> <td> <p>Specifies whether the WebDAV module should return the "MS-Author-Via" header to WebDAV clients.<br><br><strong>Note</strong>: Some WebDAV clients expect this header.<br><br>The numeric value is <code>1</code>.</p></td></tr> <tr> <th><code>MultiProp</code></th> <td>Specifies whether multiple <code>&lt;prop&gt;</code> statements should be allowed in WebDAV requests.<br><br><strong>Note</strong>: This violates RFC 4918, but some earlier WebDAV implementations supported this syntax.<br><br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>CompactXml</code></th> <td>Specifies whether the XML that is returned by the WebDAV module should be formatted hierarchically.<br><br><strong>Note</strong>: Normally the WebDAV module will simply return XML responses with no CRLF characters and no indentation. This cuts down on the size of the data that is transmitted over the wire, but it's very difficult to read without an XML parser.<br><br>The numeric value is <code>4</code>.</td></tr> <tr> <th><code>IsHidden</code></th> <td>Specifies that the IsHidden pseudo-live property should be supported.<br><br><strong>Note</strong>: This property is an informal standard that is not defined in RFC 4918.<br><br>The numeric value is <code>8</code>.</td></tr> <tr> <th><code>IsCollection</code></th> <td>Specifies that the IsCollection pseudo-live property should be supported.<br><br><strong>Note</strong>: This property is an informal standard that is not defined in RFC 4918.<br><br>The numeric value is <code>16</code>.</td></tr></tbody></table> |
| `enabled` | Optional **Boolean** attribute.<br><br>**true** if WebDAV authoring is enabled; otherwise, **false**.<br><br>The default value is `false`. |
| `maxAllowedXmlRequestLength` | Optional uint attribute.<br><br>Specifies the maximum length, in bytes, of the request XML body for WebDAV requests.<br><br>**Note:** This attribute was added in WebDAV 7.5 and IIS 7.5.<br><br>The default value is `1000000`. |
| `requireSsl` | Optional **Boolean** attribute.<br><br>**true** if SSL is required for WebDAV authoring; otherwise, **false**. Requiring SSL for WebDAV authoring adds an additional layer of security, but adds to the processing overhead for each request.<br><br>The default value is `false`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`fileSystem`](filesystem.md) | Optional element.<br><br>Specifies how the WebDAV module interacts with the underlying file system. |
| [`locks`](locks.md) | Optional element.<br><br>Specifies the WebDAV locking settings. |
| [`properties`](properties/index.md) | Optional element. Specifies the WebDAV property settings. |

### Configuration Sample

The following example lists a sample `<webdav>` element for the Default Web Site. This example clears any existing authoring rules, adds a single rule for the administrators group, enables WebDAV authoring, specifies that hidden files are allowed, enables WebDAV locks and specifies the lock provider, and enables WebDAV properties and specifies the default XML namespace for property mapping.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples enable WebDAV authoring for the Default Web Site, and configure the site so that SSL is not required for WebDAV authoring.

### AppCmd.exe

[!code-console[Main](index/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample5.js)]

### VBScript

[!code-vb[Main](index/samples/sample6.vb)]

* * *

The following examples enable WebDAV locks for the Default Web Site by using the simple lock provider, and configure the site so that locks are not required for WebDAV authoring.

### AppCmd.exe

[!code-console[Main](index/samples/sample7.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample8.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample9.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample10.js)]

### VBScript

[!code-vb[Main](index/samples/sample11.vb)]

* * *

The following examples configure the WebDAV property settings so that both anonymous and infinite depth property queries are disabled, and enable custom properties with the default XML namespace mapped to the built-in *webdav\_simple\_prop* provider.

### AppCmd.exe

[!code-console[Main](index/samples/sample12.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample13.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample14.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample15.js)]

### VBScript

[!code-vb[Main](index/samples/sample16.vb)]