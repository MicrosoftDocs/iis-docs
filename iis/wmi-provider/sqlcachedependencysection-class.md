---
title: "SqlCacheDependencySection Class"
description: "The SqlCacheDependencySection class represents a System.Web.Caching.SqlCacheDependency configuration section. The methods and properties exposed by this class are provided."
ms.date: "10/07/2016"
ms.assetid: 2a4b23dc-734b-7b32-bd9e-724ce3d88fb2
---
# SqlCacheDependencySection Class
Represents a [System.Web.Caching.SqlCacheDependency](/dotnet/api/system.web.caching.sqlcachedependency) configuration section.  
  
## Syntax  
  
```vbs  
class SqlCacheDependencySection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `SqlCacheDependencySection` class.  
  
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
 The following table lists the properties exposed by the `SqlCacheDependencySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Databases`|A [SqlCacheDependencyDatabaseSettings](../wmi-provider/sqlcachedependencydatabasesettings-class.md) value that contains configuration settings for cached SQL data in ASP.NET caches.|  
|`Enabled`|A `boolean` value. `true` if IIS is enabled to receive notifications of changes to cached SQL data; otherwise, `false`. The default is `true`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`PollTime`|A `sint32` value that represents, in milliseconds, how often SQL databases are queried for changes to cached data. The default is 60000. This property cannot be set to less than 500.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class allows data stored in an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application [System.Web.Caching.Cache](/dotnet/api/system.web.caching.cache) object to be updated when changes are made to its SQL Server data source (table or query). When the database table or query changes, the cached item is automatically deleted, and a new version of the item is added to the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] cache.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `SqlCacheDependencySection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Caching.SqlCacheDependency](/dotnet/api/system.web.caching.sqlcachedependency)
 [System.Web.Caching.Cache](/dotnet/api/system.web.caching.cache)
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [SqlCacheDependencyDatabase Class](../wmi-provider/sqlcachedependencydatabase-class.md)   
 [SqlCacheDependencyDatabaseSettings Class](../wmi-provider/sqlcachedependencydatabasesettings-class.md)
