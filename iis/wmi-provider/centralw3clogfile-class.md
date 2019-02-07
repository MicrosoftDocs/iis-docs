---
title: "CentralW3CLogFile Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d74c5089-999e-e827-7ebe-f6946f52013c
caps.latest.revision: 26
author: "shirhatti"
manager: "wpickett"
---
# CentralW3CLogFile Class1
Configures settings for World Wide Web Consortium (W3C) centralized logging on a server.  
  
## Syntax  
  
```vbs  
class CentralW3CLogFile : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `CentralW3CLogFile` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Directory`|A nonempty read/write `string` value that specifies the directory to which log entries should be written. The default is "%SystemDrive%\inetpub\logs\LogFiles".|  
|`Enabled`|A read/write `boolean` value. `true` if W3C centralized logging is enabled; otherwise, `false`. The default is `true`.|  
|`LocalTimeRollover`|A read/write `boolean` value. `true` if a new log file is based on local time; `false` if it is based on Coordinated Universal Time (UTC). The default is `false`.|  
|`LogExtFileFlags`|A read/write `sint32` value that contains a mask that specifies the attributes to be recorded in the log file. The possible values are listed later in the Remarks section.|  
|`Period`|A read/write `sint32` enumeration that specifies how frequently the current log file is closed and a new log file is started. The possible values are listed later in the Remarks section.|  
|`TruncateSize`|A read/write `string` value that specifies, in bytes, the size at which the log file contents should be truncated. This attribute must be configured when `Period` is set to `MaxSize`. The size must be between 1048576 (1 megabyte) and 4294967295 (4 gigabytes). The default is 20971520 (20 megabytes).|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `CentralW3CLogFile` property of the [LogSection](../wmi-provider/logsection-class.md) class.  
  
 The following table lists the possible values for the `LogExtFileFlags` property. The default attributes are `ClientIP`, `Date`, `HttpStatus`, `HttpSubStatus`, `Method`, `ServerIP`, `ServerPort`, `SiteName`, `Time`, `UriQuery`, `UriStem`, `UserAgent`, `UserName`, and `Win32Status`.  
  
|Value|Attribute|  
|-----------|---------------|  
|1|`Date`|  
|2|`Time`|  
|4|`ClientIP`|  
|8|`UserName`|  
|16|`SiteName`|  
|32|`ComputerName`|  
|64|`ServerIP`|  
|128|`Method`|  
|256|`UriStem`|  
|512|`UriQuery`|  
|1024|`HttpStatus`|  
|2048|`Win32Status`|  
|4096|`BytesSent`|  
|8192|`BytesRecv`|  
|16384|`TimeTaken`|  
|32768|`ServerPort`|  
|65536|`UserAgent`|  
|131072|`Cookie`|  
|262144|`Referer`|  
|524288|`ProtocolVersion`|  
|1048576|`Host`|  
|2097152|`HttpSubStatus`|  
  
 The following table lists the possible values for the `Period` property. The default is 1 (`Daily`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`MaxSize`|The log file is closed and a new log file is started when the value in `TruncateSize` is reached.|  
|1|`Daily`|The log file is closed and a new log file is started once per day.|  
|2|`Weekly`|The log file is closed and a new log file is started once per week.|  
|3|`Monthly`|The log file is closed and a new log file is started once per month.|  
|4|`Hourly`|The log file is closed and a new log file is started once per hour.|  
  
## Example  
 The following code example sets the log file mode to `CentralW3C`, enables centralW3C logging, sets the `Period` property to `MaxSize`, specifies that log files use local time, and limits the log size to 100 megabytes. Helper functions display the settings before and after the changes are made.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the log configuration section.  
Set oSection = oWebAdmin.Get("LogSection.Path=" & _  
   "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Show the initial settings.  
DisplaySettings("Initial Values")  
  
' Set the log file mode to CentralW3C.  
oSection.CentralLogFileMode = 2  
  
' Enable central W3C logging.  
oSection.CentralW3CLogFile.Enabled = True  
  
' Set local time rollover to true.  
oSection.CentralW3CLogFile.LocalTimeRollover = True  
  
' Set the Period property to MaxSize.  
oSection.CentralW3CLogFile.Period = 0  
  
' Set the log truncate size to 100 megabytes.  
oSection.CentralW3CLogFile.TruncateSize = 104857600  
  
' Save the values to configuration.  
oSection.Put_  
  
' Refresh the oSection object variable with the new values.  
oSection.Refresh_  
  
' Show the changed settings.  
Call DisplaySettings("New Values")  
  
' ==== This section contains helper functions. ====  
Function DisplaySettings(HeadingText)  
   WScript.Echo String(Len(HeadingText), "=")  
   WScript.Echo HeadingText  
   WScript.Echo String(Len(HeadingText), "=")  
  
   ' Display the current central log file mode.  
   WScript.Echo "CentralLogFileMode: " & _  
      oSection.CentralLogFileMode  
  
   ' Display the current W3C log file properties.  
   Call ShowPropVals(oSection.CentralW3CLogFile)  
  
End Function  
  
' Display the property values.  
Function ShowPropVals(oObject)  
  
   For Each Prop In oObject.Properties_  
      WScript.Echo Prop.Name & ": " & Prop.Value  
   Next  
  
   WScript.Echo  
  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `CentralW3CLogFile`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CentralBinaryLogFile Class](../wmi-provider/centralbinarylogfile-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [LogSection Class](../wmi-provider/logsection-class.md)   
 [SiteLogFile Class](../wmi-provider/sitelogfile-class.md)