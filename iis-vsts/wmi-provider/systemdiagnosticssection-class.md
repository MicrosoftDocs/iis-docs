---
title: "SystemDiagnosticsSection Class"
ms.date: "10/07/2016"
ms.assetid: d7245c41-accd-e0ea-162b-412d8c1cdd33
---
# SystemDiagnosticsSection Class
Configures system diagnostics and tracing.  
  
## Syntax  
  
```vbs  
class SystemDiagnosticsSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `SystemDiagnosticsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `SystemDiagnosticsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Assert`|An [AssertSettings](../wmi-provider/assertsettings-class.md) value that specifies the user-interface mode for the [System.Diagnostics.Debug.Assert](https://go.microsoft.com/fwlink/?LinkId=70960) method and the name of a message log file.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`PerformanceCounters`|A [PerformanceCounterSettings](../wmi-provider/performancecountersettings-class.md) value that specifies the size of the global memory shared by performance counters.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SharedListeners`|A [ListenerSettings](../wmi-provider/listenersettings-class.md) value that contains listeners that any source or trace element can reference.|  
|`Sources`|A [SourceSettings](../wmi-provider/sourcesettings-class.md) value that specifies trace sources that initiate tracing messages.|  
|`Switches`|A [SwitchSettings](../wmi-provider/switchsettings-class.md) value that contains trace switch definitions.|  
|`Trace`|A [TraceSettings](../wmi-provider/tracesettings-class.md) value that contains listeners that collect, store, and route tracing messages.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `SystemDiagnosticsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AssertSettings Class](../wmi-provider/assertsettings-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [ListenerSettings Class](../wmi-provider/listenersettings-class.md)   
 [PerformanceCounterSettings Class](../wmi-provider/performancecountersettings-class.md)   
 [SourceSettings Class](../wmi-provider/sourcesettings-class.md)   
 [SwitchSettings Class](../wmi-provider/switchsettings-class.md)   
 [TraceSettings Class](../wmi-provider/tracesettings-class.md)   
 [System.Diagnostics.Debug.Assert Method](https://go.microsoft.com/fwlink/?LinkId=70960)