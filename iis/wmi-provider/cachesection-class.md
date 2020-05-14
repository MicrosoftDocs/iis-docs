---
title: "CacheSection Class"
ms.date: "10/07/2016"
ms.assetid: 399f2fd6-95c6-908a-a7ea-312cca9b1107
---
# CacheSection Class
Defines cache settings for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] Web application.  
  
## Syntax  
  
```vbs  
class CacheSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `CacheSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `CacheSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DisableExpiration`|An optional read/write `boolean` value. `true` if cache expiration is disabled; otherwise, `false`. The default is `false`.<br /><br /> When disabled, cached items do not expire and background cleanup of expired cache items does not occur.|  
|`DisableMemoryCollection`|An optional read/write `boolean` value. `true` if the cache memory collection that occurs when the computer is under memory pressure is disabled; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`PercentagePhysicalMemoryUsedLimit`|An optional read/write `sint32` value that specifies the maximum percentage of a computer's physical memory that can be consumed by an application before the cache starts to flush expired items and attempts to reclaim memory. The default is 89.<br /><br /> The specified percentage includes both memory used by the cache as well as the normal memory used by the running application. A setting of 0 indicates that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] will use its own heuristics for determining when to start reclaiming memory.|  
|`PrivateBytesLimit`|An optional read/write `string` value that specifies the maximum size, in bytes, of an application's private memory cache before the cache starts to flush expired items and attempts to reclaim memory. The default is 0.<br /><br /> The specified limit includes both memory used by the cache as well as normal memory used by the running application. A setting of 0 indicates that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] will use its own heuristics for determining when to start reclaiming memory.|  
|`PrivateBytesPollTime`|An optional read/write `datetime` value that specifies the time interval between successive pollings for an application's private memory usage. The default is 2 minutes.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `CacheSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CachingProfileElement Class](../wmi-provider/cachingprofileelement-class.md)
 [CachingSection Class](../wmi-provider/cachingsection-class.md)
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)
 [OutputCacheSection Class](../wmi-provider/outputcachesection-class.md)
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)
