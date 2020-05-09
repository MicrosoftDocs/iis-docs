---
title: "Configuration History &lt;configHistory&gt;"
author: rick-anderson
description: "Overview The &lt;configHistory&gt; element defines the settings for the built-in IIS configuration history feature, which keeps a running history of changes..."
ms.date: 09/26/2016
ms.assetid: e8921ba8-48b1-4529-b383-499c3764b8c3
msc.legacyurl: /configreference/system.applicationhost/confighistory
msc.type: config
---
Configuration History &lt;configHistory&gt;
====================
<a id="001"></a>
## Overview

The `<configHistory>` element defines the settings for the built-in IIS configuration history feature, which keeps a running history of changes to your configuration files. This history is especially useful for recovering from mistakes made when manually editing your configuration files.

For example, if you were making changes to your ApplicationHost.config file and the changes contained invalid syntax, end users would see the following error when browsing to your Web site:

**HTTP Error 503. The service is unavailable.**

To resolve the issue, you would only need to copy the ApplicationHost.config from the history folder into your %*windir*%\system32\inetsrv\config folder in order to restore your server to operational state.

> [!NOTE]
> The configuration history feature requires that the **Application Host Help Service** is running on your server; if this service is stopped or disabled, changes to your configuration files will not be kept in the history folder.

<a id="002"></a>
## Compatibility

| Version | Notes |
| --- | --- |
| IIS 10.0 | The `<configHistory>` element was not modified in IIS 10.0. |
| IIS 8.5 | The `<configHistory>` element was not modified in IIS 8.5. |
| IIS 8.0 | The `<configHistory>` element was not modified in IIS 8.0. |
| IIS 7.5 | The `<configHistory>` element was not modified in IIS 7.5. |
| IIS 7.0 | The `<configHistory>` element was introduced in IIS 7.0. |
| IIS 6.0 | The `<configHistory>` element replaces the **EnableHistory** and **MaxHistoryFiles** attributes of the IIS 6.0 **IIsComputerSetting** metabase object. |

<a id="003"></a>
## Setup

The `<configHistory>` element is included in the default installation of IIS 7.

<a id="004"></a>
## How To

There is no user interface for setting the configuration history options for IIS 7. For examples of how to set the configuration history options programmatically, see the [Code Samples](#006) section of this document.

<a id="005"></a>
## Configuration

### Attributes

| Attribute | Description |
| --- | --- |
| `enabled` | Optional Boolean attribute.<br><br>Specifies whether configuration history is enabled.<br><br>The default value is `true`. |
| `path` | Optional string attribute.<br><br>Specifies the path to the configuration history files.<br><br>The default value is `%SystemDrive%\inetpub\history`. |
| `maxHistories` | Optional uint attribute.<br><br>Specifies the maximum number of history files to keep.<br><br>The default value is `10`. |
| `period` | Optional timeSpan attribute.<br><br>Specifies the interval that IIS uses to check for configuration changes.<br><br>The default value is `00:02:00` (two minutes). |

### Child Elements

None.

### Configuration Sample

The following configuration sample enables the configuration history feature, sets the path of the history files to %*SystemDrive*%\inetpub\history, sets the maximum number of history files to 50, and sets the history interval to 5 minutes.

[!code-xml[Main](configHistory/samples/sample1.xml)]

<a id="006"></a>
## Sample Code

The following code samples enable configuration history for IIS 7, and configure the following options: the path of the history files is set to %*SystemDrive*%\inetpub\history, the maximum number of history files is set to 50, and the time interval for checking the configuration settings is set to 5 minutes.

### AppCmd.exe

[!code-console[Main](configHistory/samples/sample2.cmd)]

> [!NOTE]
> You must be sure to set the **commit** parameter to `apphost` when you use AppCmd.exe to configure these settings. This commits the configuration settings to the appropriate location section in the ApplicationHost.config file.

### C\#

[!code-csharp[Main](configHistory/samples/sample3.cs)]

### VB.NET

[!code-vb[Main](configHistory/samples/sample4.vb)]

### JavaScript

[!code-javascript[Main](configHistory/samples/sample5.js)]

### VBScript

[!code-vb[Main](configHistory/samples/sample6.vb)]
