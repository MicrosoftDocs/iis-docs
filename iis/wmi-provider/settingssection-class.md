---
title: "SettingsSection Class"
description: "This article lists syntax, methods, properties, subclasses, inheritance hierarchy, and requirements for the SettingSection Class, which contains information specified in the protection element inside the manifest."
ms.date: "10/07/2016"
ms.assetid: 437b7c23-a582-c80c-c23d-15610b504be2
---
# SettingsSection Class
Contains settings that specify how the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] connects to the network.  
  
## Syntax  
  
```vbs  
class SettingsSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `SettingsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `SettingsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`HttpWebRequest`|An [HttpWebRequestSettings](../wmi-provider/httpwebrequestsettings-class.md) value that customizes Web request parameters.|  
|`Ipv6`|An [Ipv6Settings](../wmi-provider/ipv6settings-class.md) value that specifies whether members of the [System.Net.Dns](https://go.microsoft.com/fwlink/?LinkId=70922) class return Internet Protocol version 6 (IPv6) addresses.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`PerformanceCounters`|A [PerformanceCountersSettings](../wmi-provider/performancecounterssettings-class.md) value that enables or disables network performance counters.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`ServicePointManager`|A [ServicePointManagerSettings](../wmi-provider/servicepointmanagersettings-class.md) value that configures connections to network resources.|  
|`Socket`|A [SocketSettings](../wmi-provider/socketsettings-class.md) value that specifies whether socket operations use completion ports.|  
|`WebProxyScript`|A [WebProxyScriptSettings](../wmi-provider/webproxyscriptsettings-class.md) value that configures the characteristics of the script that is used to discover Web proxies.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `SettingsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [HttpWebRequestSettings Class](../wmi-provider/httpwebrequestsettings-class.md)   
 [Ipv6Settings Class](../wmi-provider/ipv6settings-class.md)   
 [PerformanceCountersSettings Class](../wmi-provider/performancecounterssettings-class.md)   
 [ServicePointManagerSettings Class](../wmi-provider/servicepointmanagersettings-class.md)   
 [SocketSettings Class](../wmi-provider/socketsettings-class.md)   
 [WebProxyScriptSettings Class](../wmi-provider/webproxyscriptsettings-class.md)   
 [System.Net.Dns Class](https://go.microsoft.com/fwlink/?LinkId=70922)
