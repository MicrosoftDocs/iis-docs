---
title: "WebDAV Lock Store Defintions &lt;lockStores&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The WebDAV module is designed to support multiple lock store providers, which are defined in the webdav/globalSettings/lockStores collection. A seri..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.webserver/webdav/globalsettings/lockstores
msc.type: config
---
WebDAV Lock Store Defintions &lt;lockStores&gt;
====================
<a id="001"></a>
## Overview

The WebDAV module is designed to support multiple lock store providers, which are defined in the `webdav/globalSettings/lockStores` collection. A series of [`<add>`](add.md) elements define the settings for each lock provider in the `<lockStores>` collection.

> [!NOTE]
> Currently the only property store provider is **webdav\_simple\_lock**, which stores WebDAV locks in memory. Because this provider stores locks in memory, the locks are automatically released when IIS or an application pool are restarted.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<lockStores>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<lockStores>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<lockStores>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<lockStores>` element ships as a feature of IIS 7.5. |
| IIS 7.0 | The `<lockStores>` element was introduced in WebDAV 7.5 as part of a separate download for IIS 7.0. |
| IIS 6.0 | N/A |

> [!NOTE]
> The `<lockStores>` element was defined in the WebDAV 7.0 schema, but was ignored because WebDAV locks were not implemented in that version.

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

### How to configure WebDAV locking for a Web site

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
2. In the **Connections** pane, expand the server name, expand the **Sites** node, then click the name of the site.
3. In the site's **Home** pane, double-click **WebDAV Authoring Rules**.  
    [![](index/_static/image10.png)](index/_static/image9.png)
4. When the **WebDAV Authoring Rules** page is displayed, click **WebDAV Settings** in the **Actions** pane.
5. When the **WebDAV Settings** page is displayed, specify the following options in the **Lock Behavior** section:

    - Set **Allow Locks** to **True**.
    - For **Lock Store**, choose **webdav\_simple\_lock** from the drop-down list.
    - Set **Require Lock for Writing** to your desired setting.  
        [![](index/_static/image12.png)](index/_static/image11.png)
6. Once you have completed the steps, click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

The `<lockStores>` element is only configurable at the global level in the ApplicationHost.config file. Any settings at the site or application level or in Web.config files are ignored.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element. Specifies the settings for a lock store provider. |

### Configuration Sample

The following example lists a sample `<globalSettings>` element for a WebDAV server. This example defines the built-in simple providers for locks and properties, and enables WebDAV locks for the server.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

> [!NOTE]
> The [`propertyStores`](../propertystores/index.md) and  lockStores collections are populated with the built-in property and lock providers when you install WebDAV. These provider collections are not extensible at this time, so the code samples in this section are only for reference.

The following examples configure WebDAV global settings to re-add the built-in property and lock providers that are copied to your system when you install the WebDAV module.

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