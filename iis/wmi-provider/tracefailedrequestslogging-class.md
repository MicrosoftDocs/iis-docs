---
title: TraceFailedRequestsLogging Class1
description: Describes the TraceFiledRequestsLogging class and provides the class' syntax, properties, remarks, an example, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 8940ea70-501f-ef7a-6c59-a88b909db8e4
---
# TraceFailedRequestsLogging Class1
Configures the trace logging of failed requests for a Web site.  
  
## Syntax  
  
```vbs  
class TraceFailedRequestsLogging : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TraceFailedRequestsLogging` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CustomActionsEnabled`|A read/write `boolean` value. `true` if custom actions are enabled; otherwise, `false`. The default is `false`. **Note:**  For more information about custom actions, see the `CustomActionExe` property of the [TraceUrl](../wmi-provider/traceurl-class.md) class.|  
|`Directory`|A read/write `string` value that specifies where the log files are saved. The default is "%SystemDrive%\inetpub\FailedReqLogFiles".|  
|`Enabled`|A read/write `boolean` value. `true` if trace logging of failed requests is enabled for the Web site; otherwise, `false.` The default is `false`.|  
|`MaxLogFiles`|A read/write `uint32` value that specifies the maximum number of log files to persist for the Web site. One log file is created for each failed request that is defined. The default is 50.|  
|`MaxLogFileSizeKB`|A read/write `uint32` value that specifies the maximum size, in kilobytes, of the log file to save to disk. The default is 512. 0 specifies that no limit is used. **Note:**  The actual log file size may vary somewhat from the specified size when the memory cache is saved to disk.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `TraceFailedRequestsLogging` property of the [Site](../wmi-provider/site-class.md) class and the [SiteElementDefaults](../wmi-provider/siteelementdefaults-class.md) class.  
  
## Example  
 The following example displays the properties of the `TraceFailedRequestsLogging` class, reverses the value of the `Enabled` property and saves it, and then displays the properties again to reveal the change.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' List the name of each property and display the property values.  
For Each vProp In oSite.TraceFailedRequestsLogging.Properties_  
    WScript.Echo vProp.Name & ": " & vProp.Value  
Next  
WScript.Echo   
  
' Switch the current value of the Enabled property.  
oSite.TraceFailedRequestsLogging.Enabled = _  
    Not(oSite.TraceFailedRequestsLogging.Enabled)  
  
' Save the change.  
oSite.Put_  
  
' Display the property names and values again.  
For Each vProp In oSite.TraceFailedRequestsLogging.Properties_  
    WScript.Echo vProp.Name & ": " & vProp.Value  
Next  
  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `TraceFailedRequestsLogging`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [Site Class](../wmi-provider/site-class.md)   
 [SiteElementDefaults Class](../wmi-provider/siteelementdefaults-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)
