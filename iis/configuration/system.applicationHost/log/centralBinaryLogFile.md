---
title: "Central Binary Log File &lt;centralBinaryLogFile&gt;"
author: rick-anderson
description: "Overview The &lt;centralBinaryLogFile&gt; element specifies the central binary log settings for all sites on a server. Note : You need to set the centralLogF..."
ms.date: 09/26/2016
ms.assetid: 3ae84ea6-a327-4dc5-bc90-41c459c9f9fd
msc.legacyurl: /configreference/system.applicationhost/log/centralbinarylogfile
msc.type: config
---
Central Binary Log File &lt;centralBinaryLogFile&gt;
====================
<a id="001"></a>
## Overview

The `<centralBinaryLogFile>` element specifies the central binary log settings for all sites on a server.

> [!NOTE]
> You need to set the **centralLogFileMode** attribute of the parent `<log>` element to **CentralBinary** in order for the attributes on the `<centralW3CLogFile>` element to have effect. If the **centralLogFileMode** attribute of the `<log>` element is set to **CentralW3C** or **Site**, the attributes on the `<centralW3CLogFile>` element will be ignored.

> [!NOTE]
> Log files in W3C format are text-based files that most log-parsing utilities can process. Binary log files use a proprietary storage format that requires the use of an application that can process log files in that format, such as [Microsoft's LogParser](https://www.microsoft.com/download/details.aspx?id=24659) utility.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<centralBinaryLogFile>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<centralBinaryLogFile>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<centralBinaryLogFile>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<centralBinaryLogFile>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<centralBinaryLogFile>` element of the `<log>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<log>` element replaces the IIS 6.0 **CentralBinaryLoggingEnabled** flag. |

<a id="003"></a>
## Setup

The `<centralBinaryLogFile>` element of the `<log>` element is included in the default installation of IIS 7.

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
    [![](centralBinaryLogFile/_static/image2.png)](centralBinaryLogFile/_static/image1.png)
4. On the **Logging** page, under **One log file per**, select **Server** from the drop-down list, then choose **Binary** from the **Format** drop-down list.  
    [![](centralBinaryLogFile/_static/image4.png)](centralBinaryLogFile/_static/image3.png)
5. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `directory` | Optional string attribute.<br><br>Specifies the directory where log entries are written. |
| `enabled` | Optional Boolean attribute. <br><br>Specifies whether central binary logging is enabled. Additionally, **centralLogFileMode** must be set to **CentralBinary** in order to fully enable central binary logging.<br><br>The default value is `false`. |
| `localTimeRollover` | Optional Boolean attribute.<br><br>Specifies whether a new log file is created based on local time or Coordinated Universal Time (UTC). A value of **true** means the new log file is based on local time; **false** means it is based on UTC.<br><br>The default value is `false`. |
| `period` | Optional enum attribute.<br><br>Specifies how frequently the log file contents should be cleared.<br><br>The period attribute can be one of the following possible values.<br><br>The default value is `Daily`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>MaxSize</code></th> <td>Log files are cleared whenever the log file reaches the size specified by the <strong>truncateSize</strong> attribute.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>Daily</code></th> <td>Log files are cleared every day.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>Weekly</code></th> <td>Log files are cleared once a week.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>Monthly</code></th> <td>Log files are cleared once a month.<br><br>The numeric value is <code>3</code>.</td></tr> <tr> <th><code>Hourly</code></th> <td>Log files are cleared every hour.<br><br>The numeric value is <code>4</code>.</td></tr></tbody></table> |
| `truncateSize` | Optional int64 attribute.<br><br>Specifies the size at which the log file contents should be truncated. This attribute must be set when the value of the period attribute is **maxSize**. The size must be between 1048576 (1 megabyte) and 4294967295 (4 gigabytes).<br><br>The default value is `20971520` (20 megabytes). |

### Child Elements

None.

### Configuration Sample

The following configuration sample specifies that IIS will use central binary logging, and configures binary log file rotation on a daily basis.

[!code-xml[Main](centralBinaryLogFile/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples specify that IIS will use central binary logging, and configure binary log file rotation on a daily basis.

### AppCmd.exe

[!code-console[Main](centralBinaryLogFile/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](centralBinaryLogFile/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](centralBinaryLogFile/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](centralBinaryLogFile/samples/sample5.js)]

### VBScript

[!code-vb[Main](centralBinaryLogFile/samples/sample6.vb)]
