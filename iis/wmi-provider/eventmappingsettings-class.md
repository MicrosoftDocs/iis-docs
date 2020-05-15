---
title: "EventMappingSettings Class"
ms.date: "10/07/2016"
ms.assetid: ab1dcd94-ec87-e260-9828-ed4cc6c1221e
---
# EventMappingSettings Class

Contains mappings of friendly event names to related event types.  
  
## Syntax  
  
```vbs  
class EventMappingSettings : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `EventMappingSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`EventMappings`|An array of [EventMappingElement](../wmi-provider/eventmappingelement-class.md) objects that map friendly event names to related event types.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `EventMappings` array property of the [HealthMonitoringSection](../wmi-provider/healthmonitoringsection-class.md) class.  
  
 Event mappings allow you to assign friendly names to event sources. These names are used to associate event sources with the related event consumers, called providers, in the `Rules` property of the `HealthMonitoringSection` class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `EventMappingSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [System.Web.Management.WebEventCodes](/dotnet/api/system.web.management.webeventcodes)
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [EventMappingElement Class](../wmi-provider/eventmappingelement-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [ProviderSettings Class](../wmi-provider/providersettings-class.md)   
 [RuleSettings Class](../wmi-provider/rulesettings-class.md)
