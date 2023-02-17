---
title: RuleElement Class
description: Describes the RuleElement class and provides the class' syntax, properties, remarks, inheritance hierarchies, and requirements.
ms.date: 10/07/2016
ms.assetid: cc574d49-ab7a-4bf9-8d38-5b20d01ff33a
---
# RuleElement Class
Maps a Web event to a health-monitoring provider.  
  
## Syntax  
  
```vbs  
class RuleElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `RuleElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Custom`|A read/write `string` value that specifies the fully qualified type of a custom class that implements the [System.Web.Management.IWebEventCustomEvaluator](/dotnet/api/system.web.management.iwebeventcustomevaluator) interface. The default is an empty string ("").<br /><br /> The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%"). **Note:**  This property is new in the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version 2.0.|  
|`EventName`|A read/write `string` value that specifies the name of an event from the [EventMappingSettings](../wmi-provider/eventmappingsettings-class.md) class.|  
|`MaxLimit`|A read/write `sint32` value that specifies the maximum number of times that the event specified in the `EventName` property is raised. The default is 2147483647 (infinite).|  
|`MinInstances`|A read/write `sint32` value that specifies the minimum number of occurrences of the event specified in the `EventName` property before the event is raised to the provider. The default is 1.|  
|`MinInterval`|A read/write `datetime` value that specifies the minimum interval between two events of the type specified in the `EventName` property. The default is 0 seconds. **Note:**  You can minimize the impact on performance of health monitoring by increasing the value of this property.|  
|`Name`|A read-only `string` value that specifies the name of the rule element. The key property.|  
|`Profile`|A read/write `string` value that specifies an event profile (in the [ProfileSettings](../wmi-provider/profilesettings-class.md) class) that determines the number of events and the frequency with which they should be raised.|  
|`Provider`|A read/write `string` value that specifies the name of a health monitoring provider from the [ProviderSettings](../wmi-provider/providersettings-class.md) class.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are exposed as members of the `Rules` property on the [RuleSettings](../wmi-provider/rulesettings-class.md) class.  
  
 Health-monitoring events (also called Web events) are raised during Web application processing and are consumed by providers (listeners), which read and record the information packaged with the event.  
  
 You can subscribe an existing provider or a custom provider to a Web event by configuring a new `RuleElement` instance. You can enable an event by mapping it to an event provider in this class. You must configure the event mappings and the provider settings, but unless you connect the event and provider, the event is not raised.  
  
 To disable an event, you can remove the event from the `RuleSettings` class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `RuleElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [EventMappingSettings Class](../wmi-provider/eventmappingsettings-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [ProfileSettings Class](../wmi-provider/profilesettings-class.md)   
 [ProviderSettings Class](../wmi-provider/providersettings-class.md)   
 [RuleSettings Class](../wmi-provider/rulesettings-class.md)   
 [ASP.NET Health Monitoring Overview](/previous-versions/aspnet/bb398933(v=vs.100))   
 CIM_DATETIME
