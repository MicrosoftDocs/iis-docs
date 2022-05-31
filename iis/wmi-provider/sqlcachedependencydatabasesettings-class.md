---
title: SqlCacheDependencyDatabaseSettings Class
description: Describes the SqlCacheDependencyDatabaseSettings class and provides the class' syntax, properties, remarks, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 56136d82-beb3-4e0a-b744-e778b9af5b51
---
# SqlCacheDependencyDatabaseSettings Class
Contains configuration settings for SQL data in an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] cache.  
  
## Syntax  
  
```vbs  
class SqlCacheDependencyDatabaseSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SqlCacheDependencyDatabaseSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Databases`|An array of [SqlCacheDependencyDatabase](../wmi-provider/sqlcachedependencydatabase-class.md) values that contain configuration settings for SQL data in an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] cache.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Databases` array property of the [SqlCacheDependencySection](../wmi-provider/sqlcachedependencysection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SqlCacheDependencyDatabaseSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [SqlCacheDependencyDatabase Class](../wmi-provider/sqlcachedependencydatabase-class.md)   
 [SqlCacheDependencySection Class](../wmi-provider/sqlcachedependencysection-class.md)
