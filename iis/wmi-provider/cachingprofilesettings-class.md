---
title: "CachingProfileSettings Class"
ms.date: "10/07/2016"
ms.assetid: 1d6bc1a4-e594-464f-9521-0093f06d901f
---
# CachingProfileSettings Class

Contains profiles for output and kernel caching.  
  
## Syntax  
  
```vbs  
class CachingProfileSettings : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `CachingProfileSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Profiles`|An array of [CachingProfileElement](../wmi-provider/cachingprofileelement-class.md) values that configure caching for specific request extensions.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `Profiles` array property of the [CachingSection](../wmi-provider/cachingsection-class.md) class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `CachingProfileSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [AspCache Class](../wmi-provider/aspcache-class.md)   
 [CachingProfileElement Class](../wmi-provider/cachingprofileelement-class.md)   
 [CachingSection Class](../wmi-provider/cachingsection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [HttpClientCache Class](../wmi-provider/httpclientcache-class.md)
