---
title: "LogSection Class1"
ms.date: "10/07/2016"
ms.assetid: cc93d19f-64ef-2ee5-5266-93f14570d30c
---
# LogSection Class1
Configures the logging for a server or site.  
  
## Syntax  
  
```vbs  
class LogSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `LogSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `LogSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CentralBinaryLogFile`|A read/write [CentralBinaryLogFile](../wmi-provider/centralbinarylogfile-class.md) value that specifies the configuration of centralized binary logging for all sites on a server.|  
|`CentralLogFileMode`|A read/write `sint32` value that specifies the centralized logging mode for the server. The possible values are listed later in the Remarks section.|  
|`CentralW3CLogFile`|A read/write [CentralW3CLogFile](../wmi-provider/centralw3clogfile-class.md) value that specifies the configuration of World Wide Web Consortium (W3C) centralized logging for all sites on a server.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`LogInUTF8`|A read/write `boolean` value. `true` if IIS logs all strings in UCS Transformation Format 8 (UTF-8); otherwise, `false`. The default is `true`. This setting applies serverwide to all text-mode logging.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class corresponds to the `<system.applicationHost/log>` section in ApplicationHost.config.  
  
 The following table lists the possible values for the `CentralLogFileMode` property. The default is 0 (`Site`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Site`|All client requests are logged at the site level, not centrally at the server level. Log files are generated per site.|  
|1|`CentralBinary`|All client requests for all sites are logged to a single log file in centralized binary format on the server.|  
|2|`CentralW3C`|All client requests for all sites are logged to a single log file in W3C centralized format on the server.|  
  
## Example  
 The following code example displays the value of the `CentralLogFileMode` property. A helper function translates the enumeration value to text.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the log section.  
Set oSection = oWebAdmin.Get("LogSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]"  
  
' Display the path and location.  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo "Location: " & oSection.Location  
  
' Display the central log file mode.  
WScript.Echo "CentralLogFileMode: " & _  
                GetModeText(oSection.CentralLogFileMode)  
  
' ==== GetModeText helper function. ====  
Function GetModeText(intMode)  
    Select Case intMode  
        Case 0  
            GetModeText="Site"  
        Case 1  
            GetModeText="CentralBinary"  
        Case 2  
            GetModeText="CentralW3C"  
        Case Else  
            GetModeText="Undefined value"  
    End Select  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `LogSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [CentralBinaryLogFile Class](../wmi-provider/centralbinarylogfile-class.md)   
 [CentralW3CLogFile Class](../wmi-provider/centralw3clogfile-class.md)   
 [SiteLogFile Class](../wmi-provider/sitelogfile-class.md)