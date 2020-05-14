---
title: "CentralBinaryLogFile Class1"
ms.date: "10/07/2016"
ms.assetid: d4a0f006-fd94-007a-5d82-3cd577bbd014
---
# CentralBinaryLogFile Class1
Configures settings for centralized binary logging on a server.  
  
## Syntax  
  
```vbs  
class CentralBinaryLogFile : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `CentralBinaryLogFile` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Directory`|A read/write `string` value that specifies the directory to which log entries should be written. The default is "%SystemDrive%\inetpub\logs\LogFiles".|  
|`Enabled`|A read/write `boolean` value. `true` if centralized binary logging is enabled; otherwise, `false`. The default is `true`.|  
|`LocalTimeRollover`|A read/write `boolean` value. `true` if a new log file is based on local time; `false` if it is based on Coordinated Universal Time (UTC). The default is `false`.|  
|`Period`|A read/write `sint32` enumeration that specifies how frequently the current log file is closed and a new log file is started. The possible values are listed later in the Remarks section.|  
|`TruncateSize`|A read/write `string` value that specifies, in bytes, the size at which the log file contents should be truncated. This attribute must be configured when `Period` is set to `MaxSize`. The size must be between 1048576 (1 megabyte) and 4294967295 (4 gigabytes). The default is 20971520 (20 megabytes).|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `CentralBinaryLogFile` property of the [LogSection](../wmi-provider/logsection-class.md) class.  
  
 The following table lists the possible values for the `Period` property. The default is 1 (`Daily`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`MaxSize`|The log file is closed and a new log file is started when the value in `TruncateSize` is reached.|  
|1|`Daily`|The log file is closed and a new log file is started once per day.|  
|2|`Weekly`|The log file is closed and a new log file is started once per week.|  
|3|`Monthly`|The log file is closed and a new log file is started once per month.|  
|4|`Hourly`|The log file is closed and a new log file is started once per hour.|  
  
## Example  
 The following code example sets the log file mode to `CentralBinary`, enables binary logging, sets the `Period` property to `Weekly`, specifies that log files use local time, and limits the log size to 1 gigabyte. Helper functions display the settings before and after the changes are made.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the log configuration section.  
Set oSection = oWebAdmin.Get("LogSection.Path=" & _  
   "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Show the initial settings.  
DisplaySettings("Initial Values")  
  
' Set the log file mode to CentralBinary.  
oSection.CentralLogFileMode = 1  
  
' Enable central binary logging.  
oSection.CentralBinaryLogFile.Enabled = True  
  
' Set local time rollover to true.  
oSection.CentralBinaryLogFile.LocalTimeRollover = True  
  
' Set the Period property to Weekly.  
oSection.CentralBinaryLogFile.Period = 2  
  
' Set the log truncate size to 1 gigabyte.  
oSection.CentralBinaryLogFile.TruncateSize = 1073741824  
  
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
  
   ' Display the current binary log file properties.  
   Call ShowPropVals(oSection.CentralBinaryLogFile)  
  
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
  
 `CentralBinaryLogFile`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CentralW3CLogFile Class](../wmi-provider/centralw3clogfile-class.md)
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
 [LogSection Class](../wmi-provider/logsection-class.md)
 [SiteLogFile Class](../wmi-provider/sitelogfile-class.md)
