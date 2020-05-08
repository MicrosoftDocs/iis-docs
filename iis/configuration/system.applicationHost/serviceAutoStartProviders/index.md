---
title: "Service Autostart Providers &lt;serviceAutoStartProviders&gt;"
author: rick-anderson
description: "Overview The &lt;serviceAutoStartProviders&gt; element specifies a collection of managed assemblies that Windows Process Activation Service (WAS) will load a..."
ms.date: 09/26/2016
ms.assetid: 24c9eba5-ac24-4564-93a4-e1ad23d26929
msc.legacyurl: /configreference/system.applicationhost/serviceautostartproviders
msc.type: config
---
Service Autostart Providers &lt;serviceAutoStartProviders&gt;
====================
<a id="001"></a>
## Overview

The `<serviceAutoStartProviders>` element specifies a collection of managed assemblies that Windows Process Activation Service (WAS) will load automatically when the `startMode` attribute of an application pool is set to `AlwaysRunning`. This collection allows developers to specify assemblies that perform initialization tasks before any HTTP requests are serviced. For example, an application developer may want to establish the initial database connections for the application before IIS begins request processing; this will enable the application to perform faster for initial requests that require round trips to and from a database.

For more information about how to configure application pools to start automatically, see the [`<applicationPools>`](../applicationpools/index.md) topic.

> [!NOTE]
> This element was introduced in IIS 7.5.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<serviceAutoStartProviders>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<serviceAutoStartProviders>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<serviceAutoStartProviders>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<serviceAutoStartProviders>` element was introduced in IIS 7.5. |
| IIS 7.0 | N/A |
| IIS 6.0 | N/A |

<a id="003"></a>
## Setup

The `<serviceAutoStartProviders>` element is included in the default installation of IIS 7.5. 

<a id="004"></a>
## How To

### How to configure a service autostart provider

> [!NOTE]
> There is no direct user interface that lets you configure the `<serviceAutoStartProviders>` element, therefore the following steps will use the IIS Configuration Editor feature.

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
2. In the **Connections** pane, click the server name.
3. In the **Home** pane, double-click the **Configuration Editor** feature.  
    [![](index/_static/image2.png)](index/_static/image1.png)
4. In the **Section** drop-down menu, expand **system.applicationHost**, and then click **serviceAutoStartProviders**.  
    [![](index/_static/image4.png)](index/_static/image3.png)
5. Click the ellipsis (**...**) on the right-side of the **(Collection)** field.
6. In the **Actions** pane, click **Add**.
7. When the Collection Editor dialog box appears: 

    - Enter the name of your autostart provider in the **name** field. For example:  
 "MyAutostartProvider"
    - Enter the managed type of your autostart assembly in the **type** field. For example:  
 "MyAutostartProvider, MyAutostartProvider, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
    - Close the Collection Editor dialog box.  
        [![](index/_static/image6.png)](index/_static/image5.png)
8. In the **Actions** pane, click **Apply**.

> [!NOTE]
> This section contains information about how to modify your IIS settings by using the IIS Configuration Editor. Incorrectly editing your IIS configuration settings can severely damage your IIS installation. Therefore, make sure that you follow these steps carefully. For added security, you should back up your IIS configuration settings before you use the IIS Configuration Editor to make any modifications. For more information about how to back up your IIS configuration settings and how to use the IIS Configuration Editor, see the following topics:

- **How to Back Up an IIS 7 Configuration**  
    [https://technet.microsoft.com/library/dd819406.aspx](https://technet.microsoft.com/library/dd819406.aspx)
- **Configuration Editor Page**  
    [https://technet.microsoft.com/library/dd569081.aspx](https://technet.microsoft.com/library/dd569081.aspx)
 
<a id="005"></a>
## Configuration

The `<serviceAutoStartProviders>` element is configured at the global level in the ApplicationHost.config file.

### Attributes

None.

### Child Elements

| Element | Description |
| --- | --- |
| [`add`](add.md) | Optional element.<br><br>Adds a provider to the collection of autostart providers. |
| `clear` | Optional element.<br><br>Clears the collection of autostart providers. |
| `remove` | Optional element.<br><br>Removes a provider from the collection of autostart providers. |

### Configuration Sample

The following sample displays a `<serviceAutoStartProviders>` element that adds a custom autostart provider to the collection.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following examples add a sample provider to the collection of autostart providers.

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
