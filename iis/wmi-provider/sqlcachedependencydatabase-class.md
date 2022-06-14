---
title: "SqlCacheDependencyDatabase Class"
description: SqlCacheDependencyDatabase class specifies Exposes configuration settings for SQL data in an vstecasp cache.
ms.date: "10/07/2016"
ms.assetid: 51602b5f-115f-373d-a75a-339b91c9ff94
---
# SqlCacheDependencyDatabase Class
Exposes configuration settings for SQL data in an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] cache.  
  
## Syntax  
  
```vbs  
class SqlCacheDependencyDatabase : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SqlCacheDependencyDatabase` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ConnectionStringName`|A read/write `string` value that specifies the name of the connection string to the SQL data source.|  
|`Name`|A read-only `string` value that contains the name of the SQL database whose data is cached by [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)].|  
|`PollTime`|A read/write `sint32` value, in milliseconds, that specifies how often the SQL data source is queried for changes. The default is 60000. This property cannot be set to less than 500.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Databases` array property of the [SqlCacheDependencyDatabaseSettings](../wmi-provider/sqlcachedependencydatabasesettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `SqlCacheDependencyDatabase`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Caching.SqlCacheDependency](/dotnet/api/system.web.caching.sqlcachedependency) 
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [SqlCacheDependencySection Class](../wmi-provider/sqlcachedependencysection-class.md)   
 [SqlCacheDependencyDatabaseSettings Class](../wmi-provider/sqlcachedependencydatabasesettings-class.md)
