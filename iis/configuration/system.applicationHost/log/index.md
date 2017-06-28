---
title: "Log &lt;log&gt; | Microsoft Docs"
author: rick-anderson
description: "Overview The &lt;log&gt; element specifies several global logging options for Internet Information Services (IIS) 7. For example, the centralLogFileMode attr..."
ms.author: iiscontent
manager: soshir
ms.date: 09/26/2016
ms.topic: article
ms.assetid: 
ms.technology: iis-config
ms.prod: iis
msc.legacyurl: /configreference/system.applicationhost/log
msc.type: config
---
Log &lt;log&gt;
====================
<a id="001"></a>
## Overview

The `<log>` element specifies several global logging options for Internet Information Services (IIS) 7. For example, the **centralLogFileMode** attribute specifies whether site-level logging, central W3C logging, or central binary logging is enabled.

Site-level logging creates individual log file directories for each site on your server, where each folder contains only the log files for that site. Central logging enables the use of a single log file for all sites for the time period specified by the **period** attribute for the `<centralBinaryLogFile>` or `<centralW3CLogFile>` element. The time period can be daily, weekly, monthly, hourly, or a maximum file size.

> [!NOTE]
> Log files in W3C format are text-based files that most log-parsing utilities can process. Binary log files use a proprietary storage format that requires the use of an application that can process log files in that format, such as [Microsoft's LogParser](https://www.microsoft.com/en-us/download/details.aspx?id=24659) utility.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<log>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<log>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<log>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<log>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<log>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<log>` element replaces the following IIS 6.0 attributes: - **CentralBinaryLoggingEnabled**- **CentralW3CLoggingEnabled**- **LogInUTF8** |

<a id="003"></a>
## Setup

The `<log>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

### How to enable central binary logging for a server

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
3. In the server's **Home** pane, double-click **Logging**.  
    [![](index/_static/image2.png)](index/_static/image1.png)
4. On the **Logging** page, under **One log file per**, select **Server** from the drop-down list, then choose **Binary** from the **Format** drop-down list.  
    [![](index/_static/image4.png)](index/_static/image3.png)
5. Click **Apply** in the **Actions** pane.

### How to enable central W3C logging for a server

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
3. In the server's **Home** pane, double-click **Logging**.  
    [![](index/_static/image6.png)](index/_static/image5.png)
4. On the **Logging** page, under **One log file per**, select **Server** from the drop-down list, then choose **W3C** from the **Format** drop-down list.  
    [![](index/_static/image8.png)](index/_static/image7.png)
5. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `centralLogFileMode` | Optional enum attribute.<br><br>Specifies the central logging mode for the server.<br><br>The **centralLogFileMode** attribute can have one of the following possible values. The default is `Site`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Site</code></th> <td>Configures all sites to use site logging instead of central logging. This is the default setting.<br><br>The numerical value is <strong>0</strong>.</td></tr> <tr> <th><code>CentralBinary</code></th> <td>Creates one log file for all Web sites on a Web server. The data in the log file is binary-based, unformatted data that is not customizable.<br><br>The numerical value is <strong>1</strong>.</td></tr> <tr> <th><code>CentralW3C</code></th> <td>Logs requests for all sites on a Web server to a single central log file in a text-based, customizable ASCII format.<br><br>The numerical value is <strong>2</strong>.</td></tr></tbody></table> |
| `logInUTF8` | Optional Boolean attribute.<br><br>Specifies whether IIS should log all strings in UCS Transformation Format 8 (UTF-8). This setting applies server-wide to all text-mode logging.<br><br>The default value is `true`. |

### Child Elements

| Element | Description |
| --- | --- |
| [`centralBinaryLogFile`](centralbinarylogfile.md) | Optional element.<br><br>Specifies the central binary log settings for all sites on a server. |
| [`centralW3CLogFile`](centralw3clogfile.md) | Optional element.<br><br>Specifies the central W3C log settings for all sites on a server. |

### Configuration Sample

The following configuration sample specifies that IIS will use site-level logging.

[!code-xml[Main](index/samples/sample1.xml)]

The following configuration sample specifies that IIS will use central binary logging, and configures binary log file rotation on a daily basis.

[!code-xml[Main](index/samples/sample2.xml)]

The following configuration sample specifies that IIS will use central W3C logging, and configures W3C log file rotation on a daily basis.

[!code-xml[Main](index/samples/sample3.xml)]

<a id="006"></a>
## Sample Code

The following code samples specify that IIS will use central binary logging, and configure binary log file rotation on a daily basis.

### AppCmd.exe

[!code-console[Main](index/samples/sample4.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample5.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample6.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample7.js)]

### VBScript

[!code-vb[Main](index/samples/sample8.vb)]

The following code samples specify that IIS will use central W3C logging, and configure W3C log file rotation on a daily basis.

### AppCmd.exe

[!code-console[Main](index/samples/sample9.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](index/samples/sample10.cs)]

### VB.NET

[!code-vb[Main](index/samples/sample11.vb)]

### JavaScript

[!code-javascript[Main](index/samples/sample12.js)]

### VBScript

[!code-vb[Main](index/samples/sample13.vb)]