---
title: "EventMappingElement Class"
ms.date: "10/07/2016"
ms.assetid: 715f98e4-5d04-4813-ae6e-ec148f201a2e
---
# EventMappingElement Class
Maps friendly event names to related event types.  
  
## Syntax  
  
```vbs  
class EventMappingElement: CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `EventMappingElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`EndEventCode`|A read/write `sint32` value that specifies the ending event code of the event mapping range. The default is 2147483647.|  
|`Name`|A read-only unique `string` value that specifies the friendly name of the event mapping setting. The key property. **Note:**  Duplicate event mapping names may cause a loss of data when the configuration section is saved.|  
|`StartEventCode`|A read/write `sint32` value that specifies the starting event code of the event mapping range. The default is 0.|  
|`Type`|A read/write `string` value that specifies the type of a custom event. The specified type can be the actual class type or a parent type of the event class. If it is an empty string (""), no event is mapped, and the event mapping acts as a placeholder. **Note:**  The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNameSpace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `EventMappings` array property of the [EventMappingSettings](../wmi-provider/eventmappingsettings-class.md) class.  
  
 Event codes are mapped to events defined by the constants in the [System.Web.Management.WebEventCodes](/dotnet/api/system.web.management.webeventcodes) object. The mapping uses a range specified by the `StartEventCode` and `EndEventCode` properties.  
  
 Event mappings enable you to assign friendly names to event sources. The `Rules` property of the [HealthMonitoringSection](../wmi-provider/healthmonitoringsection-class.md) class uses these names to associate event sources with the related event consumers, called providers.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
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
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [ProviderSettings Class](../wmi-provider/providersettings-class.md)   
 [RuleSettings Class](../wmi-provider/rulesettings-class.md)