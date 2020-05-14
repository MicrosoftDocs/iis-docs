---
title: "SiteLogFile Class1"
ms.date: "10/07/2016"
ms.assetid: 050e3616-7de7-3c97-187e-11d9fd4dc070
---
# SiteLogFile Class1
Configures logging for a Web site.  
  
## Syntax  
  
```vbs  
class SiteLogFile : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SiteLogFile` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CustomLogPluginClsid`|A read/write `string` value that specifies the GUID of a plug-in module used for custom logging. The default is "FF160663-DE82-11CF-BC0A-00AA006111E0".|  
|`Directory`|A nonempty read/write `string` value that specifies the name of the directory where log files are stored. The default is "%SystemDrive%\inetpub\logs\LogFiles". **Note:**  If the IIS_IUSRS group does not have the permission to write to this directory, the logs will not be generated. If you specify a directory other than the default, be sure that the IIS_IUSRS group has the permission to write to it.|  
|`Enabled`|A read/write `boolean` value. `true` if site logging is enabled for a Web site; otherwise, `false`. The default is `true`.|  
|`LocalTimeRollover`|A read/write `boolean` value. `true` if a new log file is based on local time; `false` if it is based on Coordinated Universal Time (UTC). The default is `false`.|  
|`LogExtFileFlags`|A read/write `sint32` value that contains a mask that specifies the attributes to be recorded in the log file. This property applies only to World Wide Web Consortium (W3C) format logging. The possible values are listed later in the Remarks section.|  
|`LogFormat`|A read/write `sint32` enumeration that specifies the format of the log file. The possible values are listed later in the Remarks section.|  
|`Period`|A read/write `sint32` enumeration that specifies how frequently log file contents are rolled over (that is, the current log file is closed and a new log file is started). The possible values are listed later in the Remarks section.|  
|`TruncateSize`|A read/write `string` value that specifies the size, in bytes, at which the log file contents are truncated. To enable this property, set `Period` to `MaxSize`. The size must be between 1048576 (1 megabyte) and 4294967295 (4 gigabytes). The default is 20971520 (20 megabytes).|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `LogFile` property of the `Site` and `SiteElementDefaults` classes.  
  
 The following table lists the possible values for the `LogExtFileFlags` property. The default attributes are `ClientIP`, `Date`, `HttpStatus`, `HttpSubStatus`, `Method`, `ServerIP`, `ServerPort`, `Time`, `UriQuery`, `UriStem`, `UserAgent`, `UserName`, and `Win32Status`.  
  
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
  
 The following table lists the possible values for the `LogFormat` property. The default is 2 (`W3C`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`IIS`|The log file records in IIS format. This format is fixed ASCII text and is not customizable.|  
|1|`NCSA`|The log file records in National Center for Supercomputing Applications (NCSA) Common log file format. This format is fixed ASCII text and is not customizable.|  
|2|`W3C`|The log file records in W3C Extended log file format. This format is in ASCII text and is customizable.|  
|3|`Custom`|The log file records in a custom format decided by the user.|  
  
 The following table lists the possible values for the `Period` property. The default is 1 (`Daily`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`MaxSize`|The log file is closed and a new log file is started when the value in `TruncateSize` is reached.|  
|1|`Daily`|The log file is closed and a new log file is started once per day.|  
|2|`Weekly`|The log file is closed and a new log file is started once per week.|  
|3|`Monthly`|The log file is closed and a new log file is started once per month.|  
|4|`Hourly`|The log file is closed and a new log file is started once per hour.|  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SiteLogFile`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CentralBinaryLogFile Class](../wmi-provider/centralbinarylogfile-class.md)
 [CentralW3CLogFile Class](../wmi-provider/centralw3clogfile-class.md)
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
 [LogSection Class](../wmi-provider/logsection-class.md)
 [Site Class](../wmi-provider/site-class.md)
 [SiteElementDefaults Class](../wmi-provider/siteelementdefaults-class.md)
 [Log File Formats in IIS](https://go.microsoft.com/fwlink/?LinkId=62471)
