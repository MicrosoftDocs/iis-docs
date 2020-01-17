---
title: "Central W3C Log File &lt;centralW3CLogFile&gt;"
author: rick-anderson
description: "Overview The &lt;centralW3CLogFile&gt; element specifies the central W3C log settings for all sites on a server. Note : You need to set the centralLogFileMod..."
ms.date: 09/26/2016
ms.assetid: cfd8e668-0392-44d1-a677-524a6c72cd76
msc.legacyurl: /configreference/system.applicationhost/log/centralw3clogfile
msc.type: config
---
Central W3C Log File &lt;centralW3CLogFile&gt;
====================
<a id="001"></a>
## Overview

The `<centralW3CLogFile>` element specifies the central W3C log settings for all sites on a server.

> [!NOTE]
> You need to set the **centralLogFileMode** attribute of the parent `<log>` element to **CentralW3C** in order for the attributes on the `<centralW3CLogFile>` element to have effect. If the **centralLogFileMode** attribute of the `<log>` element is set to **CentralBinary** or **Site**, the attributes on the `<centralW3CLogFile>` element will be ignored.

> [!NOTE]
> Log files in W3C format are text-based files that most log-parsing utilities can process. Binary log files use a proprietary storage format that requires the use of an application that can process log files in that format, such as [Microsoft's LogParser](https://www.microsoft.com/download/details.aspx?id=24659) utility.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<centralW3CLogFile>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<centralW3CLogFile>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<centralW3CLogFile>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<centralW3CLogFile>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<centralW3CLogFile>` element of the `<log>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<log>` element replaces the IIS 6.0 **CentralW3CLoggingEnabled** flag. |

<a id="003"></a>
## Setup

The `<centralW3CLogFile>` element of the `<log>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

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
    [![](centralW3CLogFile/_static/image2.png)](centralW3CLogFile/_static/image1.png)
4. On the **Logging** page, under **One log file per**, select **Server** from the drop-down list, then choose **W3C** from the **Format** drop-down list.  
    [![](centralW3CLogFile/_static/image4.png)](centralW3CLogFile/_static/image3.png)
5. Click **Apply** in the **Actions** pane.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `directory` | Optional string attribute.<br><br>Specifies the directory where log entries are written.<br><br>The default value is `%SystemDrive%\inetpub\logs\LogFiles`. |
| `enabled` | Optional Boolean attribute.<br><br>Specifies whether central W3C logging is enabled.<br><br>The default value is `true`. |
| `localTimeRollover` | Optional Boolean attribute.<br><br>Specifies whether a new log file is created based on local time or Coordinated Universal Time (UTC). A value of **true** means the new log file is based on local time; **false** means it is based on UTC.<br><br>The default value is `false`. |
| `logExtFileFlags` | Optional flags attribute.<br><br>Specifies which fields to log.<br><br>The **logExtFileFlags** attribute can have one of the following values or a list of these values. The default is a list of these values: `Date`, `Time`, `ClientIP`, `UserName`, `SiteName`, `ServerIP`, `Method`, `UriStem`, `UriQuery`, `HttpStatus`, `TimeTaken`,`Win32Status`, `ServerPort`, `UserAgent`, `HttpSubStatus`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>Date</code></th> <td>The date on which the activity occurred.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>Time</code></th> <td>The time, in Coordinated Universal Time (UTC), at which the activity occurred.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>ClientIP</code></th> <td>The IP address of the client that made the request.<br><br>The numeric value is <code>4</code>.</td></tr> <tr> <th><code>UserName</code></th> <td>The name of the authenticated user who accessed your server. Anonymous users are indicated by a hyphen.<br><br>The numeric value is <code>8</code>.</td></tr> <tr> <th><code>SiteName</code></th> <td>The name of the server on which the log file entry was generated.<br><br>The numeric value is <code>16</code>.</td></tr> <tr> <th><code>ComputerName</code></th> <td>The name of the computer from which the request was made.<br><br>The numeric value is <code>32</code>.</td></tr> <tr> <th><code>ServerIP</code></th> <td>The IP address of the server on which the log file entry was generated.<br><br>The numeric value is <code>64</code>.</td></tr> <tr> <th><code>Method</code></th> <td>The requested action, for example, a <strong>GET</strong> method.<br><br>The numeric value is <code>128</code>.</td></tr> <tr> <th><code>UriStem</code></th> <td>The target of the action, for example, Default.htm.<br><br>The numeric value is <code>256</code>.</td></tr> <tr> <th><code>UriQuery</code></th> <td>The query, if any, that the client was trying to perform. A Universal Resource Identifier (URI) query is necessary only for dynamic pages.<br><br>The numeric value is <code>512</code>.</td></tr> <tr> <th><code>HttpStatus</code></th> <td>The HTTP status code.<br><br>The numeric value is <code>1024</code>.</td></tr> <tr> <th><code>Win32Status</code></th> <td>The Windows status code.<br><br>The numeric value is <code>2048</code>.</td></tr> <tr> <th><code>BytesSent</code></th> <td>The number of bytes that the server sent.<br><br>The numeric value is <code>4096</code>.</td></tr> <tr> <th><code>BytesRecv</code></th> <td>The number of bytes that the server received.<br><br>The numeric value is <code>8192</code>.</td></tr> <tr> <th><code>TimeTaken</code></th> <td>The time that the action took, in milliseconds.<br><br>The numeric value is <code>16384</code>.</td></tr> <tr> <th><code>ServerPort</code></th> <td>The server port number that is configured for the service.<br><br>The numeric value is <code>32768</code>.</td></tr> <tr> <th><code>UserAgent</code></th> <td>The browser type that the client used.<br><br>The numeric value is <code>65536</code>.</td></tr> <tr> <th><code>Cookie</code></th> <td>The content of the cookie sent or received, if a cookie was sent or received.<br><br>The numeric value is <code>131072</code>.</td></tr> <tr> <th><code>Referer</code></th> <td>The site that the user last visited. This site provided a link to the current site.<br><br>The numeric value is <code>262144</code>.</td></tr> <tr> <th><code>ProtocolVersion</code></th> <td>The protocol version that the client used.<br><br>The numeric value is <code>524288</code>.</td></tr> <tr> <th><code>Host</code></th> <td>The host header name, if there is a host header.<br><br>The numeric value is <code>1048576</code>.</td></tr> <tr> <th><code>HttpSubStatus</code></th> <td>The substatus error code.<br><br>The numeric value is <code>2097152</code>.</td></tr></tbody></table> |
| `period` | Optional enum attribute.<br><br>Specifies how frequently the current log file is closed and a new log file is started.<br><br>The period attribute can be one of the following possible values.<br><br>The default is `Daily`. <table> <tbody> <tr> <th>Value</th> <th>Description</th></tr> <tr> <th><code>MaxSize</code></th> <td>Start new log files whenever the log file reaches the size specified by the <strong>truncateSize</strong> attribute.<br><br>The numeric value is <code>0</code>.</td></tr> <tr> <th><code>Daily</code></th> <td>Start new log files every day.<br><br>The numeric value is <code>1</code>.</td></tr> <tr> <th><code>Weekly</code></th> <td>Start new log files once a week.<br><br>The numeric value is <code>2</code>.</td></tr> <tr> <th><code>Monthly</code></th> <td>Start new log files once a month.<br><br>The numeric value is <code>3</code>.</td></tr> <tr> <th><code>Hourly</code></th> <td>Start new log files every hour.<br><br>The numeric value is <code>4</code>.</td></tr></tbody></table> |
| `truncateSize` | Optional int64 attribute.<br><br>Specifies the size, in bytes, at which the log file contents will be truncated. This attribute must be set when the value of the period attribute is **maxSize**. The size must be between 1048576 (1 megabyte) and 4294967295 (4 gigabytes).<br><br>The default value is `20971520` (20 megabytes). |

### Child Elements

None.

### Configuration Sample

The following configuration sample specifies that IIS will use central W3C logging, and configures W3C log file rotation on a daily basis.

[!code-xml[Main](centralW3CLogFile/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples specify that IIS will use central W3C logging, and configure W3C log file rotation on a daily basis.

### AppCmd.exe

[!code-console[Main](centralW3CLogFile/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C#

[!code-csharp[Main](centralW3CLogFile/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](centralW3CLogFile/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](centralW3CLogFile/samples/sample5.js)]

### VBScript

[!code-vb[Main](centralW3CLogFile/samples/sample6.vb)]