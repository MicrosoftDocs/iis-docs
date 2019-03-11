---
title: "Default Settings for All Sites &lt;siteDefaults&gt;"
author: rick-anderson
description: "Overview The &lt;siteDefaults&gt; element specifies default settings for all sites on the server. These settings are useful when you want to specify options..."
ms.date: 09/26/2016
ms.assetid: bc1dce1f-21a6-4a6c-a518-35fb7fde1f28
msc.legacyurl: /configreference/system.applicationhost/sites/sitedefaults
msc.type: config
---
Default Settings for All Sites &lt;siteDefaults&gt;
====================
<a id="001"></a>
## Overview

The `<siteDefaults>` element specifies default settings for all sites on the server. These settings are useful when you want to specify options for all Web sites that differ from the schema defaults for IIS 7 and later.

> [!NOTE]
> If the same attribute or child element is configured in both the `<siteDefaults>` section and in the `<sites>` section for a specific site, the configuration in the `<sites>` section is used for that site.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<siteDefaults>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<siteDefaults>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<siteDefaults>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<siteDefaults>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<siteDefaults>` element of the `<sites>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<siteDefaults>` element is analogous to the default Web site options at the **W3SVC** level in the IIS 6.0 metabase. |

<a id="003"></a>
## Setup

The `<siteDefaults>` element of the `<sites>` element is included in the default installation of IIS 7 and later.

<a id="004"></a>
## How To

### How to configure the site defaults for a server

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
2. In the **Connections** pane, expand the server name, then click the **Sites** node.
3. In the server's **Sites** pane, click **Set Web Site Defaults...** in the **Actions** pane.  
    [![](index/_static/image2.png)](index/_static/image1.png)
4. In the **Web Site Defaults** dialog box, specify your default options for all Web sites, and then click **OK**.  
  
    [![](index/_static/image4.png)](index/_static/image3.png)

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `id` | Optional uint attribute.<br><br>Specifies the random numeric identifier that is assigned by IIS when the site is created.<br><br>The default Web site is numbered 1. Other Web sites server-assigned numbers that may be composed of multiple digits. |
| `name` | Optional string attribute.<br><br>Specifies a friendly name that uniquely identifies a Web site, for example, "Contoso HR Forms." |
| `serverAutoStart` | Optional Boolean attribute.<br><br>Specifies whether the site should start automatically when the Management Service is started.<br><br>The default value is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`bindings`](bindings/index.md) | Optional element.<br><br>Specifies default bindings for access to sites. |
| [`ftpServer`](ftpserver/index.md) | Optional element.<br><br>Specifies default settings for FTP sites.<br><br>**Note:** This requires installing FTP 7.0 or FTP 7.5. |
| [`limits`](limits.md) | Optional element.<br><br>Configures default settings to limit the amount of bandwidth, the number of connections, or the amount of time for connections to sites. |
| [`logFile`](logfile/index.md) | Optional element.<br><br>Configures default settings for handling and storage of log files for sites. |
| [`traceFailedRequestsLogging`](tracefailedrequestslogging.md) | Optional element.<br><br>Specifies default settings for logging failed-request traces for sites. |

### Configuration Sample

The following configuration sample specifies the default `limits`, `logFile`, `traceFailedRequestsLogging`, `bindings`, and `ftpServer` options for IIS 7.

[!code-xml[Main](index/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples configure the default `limits`, `logFile`, `traceFailedRequestsLogging`, `bindings`, and `ftpServer` options for IIS 7.

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