---
title: "HealthMonitoringSection Class"
ms.date: "10/07/2016"
ms.assetid: 8fd30064-d022-b1a0-6011-75b020d101dd
---
# HealthMonitoringSection Class
Configures an application for health monitoring.  
  
## Syntax  
  
```vbs  
class HealthMonitoringSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HealthMonitoringSection` class.  
  
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
 The following table lists the properties exposed by the `HealthMonitoringSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`BufferModes`|A [BufferModeSettings](../wmi-provider/buffermodesettings-class.md) value that configures the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] event-buffering settings for event providers.|  
|`Enabled`|A read/write `boolean` value. `true` if health monitoring is enabled for the Web application; otherwise, `false`. The default is `true`.|  
|`EventMappings`|A [EventMappingSettings](../wmi-provider/eventmappingsettings-class.md) value that maps friendly event names to related event types.|  
|`HeartbeatInterval`|A read/write `datetime` value that specifies the interval between [System.Web.Management.WebHeartbeatEvent](/dotnet/api/system.web.management.webheartbeatevent) events. The default is 0, which indicates that no `WebHeartbeatEvent` event is raised.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Profiles`|A [ProfileSettings](../wmi-provider/profilesettings-class.md) value that specifies event profiles that determine how events are collected by [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and raised to providers.|  
|`Providers`|A [ProviderSettings](../wmi-provider/providersettings-class.md) value that specifies the names and types of health monitoring providers that process events.|  
|`Rules`|A [RuleSettings](../wmi-provider/rulesettings-class.md) value that maps events to health monitoring providers.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HealthMonitoringSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Management.WebHeartbeatEvent](/dotnet/api/system.web.management.webheartbeatevent)
 [BufferModeSettings Class](../wmi-provider/buffermodesettings-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [EventMappingSettings Class](../wmi-provider/eventmappingsettings-class.md)   
 [ProfileSettings Class](../wmi-provider/profilesettings-class.md)   
 [ProviderSettings Class](../wmi-provider/providersettings-class.md)   
 [RuleSettings Class](../wmi-provider/rulesettings-class.md)   
 [ASP.NET Health Monitoring Overview](https://go.microsoft.com/fwlink/?LinkId=69306)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)