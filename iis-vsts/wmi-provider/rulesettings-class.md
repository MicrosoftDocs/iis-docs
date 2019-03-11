---
title: "RuleSettings Class"
ms.date: "10/07/2016"
ms.assetid: 4e3c52f7-ade6-e250-9a65-92e6c09bacd7
---
# RuleSettings Class
Maps Web events to health-monitoring providers.  
  
## Syntax  
  
```vbs  
class RuleSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `RuleSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Rules`|An array of [RuleElement](../wmi-provider/ruleelement-class.md) instances that maps Web events to health-monitoring providers.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Rules` array property of the [HealthMonitoringSection](../wmi-provider/healthmonitoringsection-class.md) class.  
  
 Health-monitoring events (also called Web events) are raised during Web application processing and are consumed by providers (listeners), which read and record the information packaged with the event.  
  
 You can subscribe an existing provider or a custom provider to a Web event by configuring a new `Rules` element. An event is enabled if it is mapped to an event provider in the [RuleElement](../wmi-provider/ruleelement-class.md) class. You must configure the event mappings and the provider settings, but the event is not raised unless you connect the event and provider in the `RuleElement` class.  
  
 To disable an event, you can remove it from the `Rules` property.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `RuleSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [EventMappingSettings Class](../wmi-provider/eventmappingsettings-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [ProfileSettings Class](../wmi-provider/profilesettings-class.md)   
 [ProviderSettings Class](../wmi-provider/providersettings-class.md)   
 [RuleElement Class](../wmi-provider/ruleelement-class.md)   
 [ASP.NET Health Monitoring Overview](https://go.microsoft.com/fwlink/?LinkId=69306)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)