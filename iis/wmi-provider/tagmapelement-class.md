---
title: "TagMapElement Class"
ms.date: "10/07/2016"
ms.assetid: d7ab3ae1-eb52-436f-ae9b-8be91af32849
---
# TagMapElement Class

Contains a statement that remaps a tag type.  
  
## Syntax  
  
```vbs  
class TagMapElement : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `TagMapElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`MappedTagType`|A read/write nonempty `string` value that specifies the name of the type to which the tag is remapped. **Note:**  An empty string value for this property will cause the configuration system to throw an exception when the object is serialized.|  
|`TagType`|A read-only nonempty `string` value that specifies the name of the original type for the tag that is being remapped. The key property. **Note:**  An empty string value for this property will cause the configuration system to throw an exception when the object is serialized.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are exposed as members of the `TagMapping` property on the [TagMapInfo](../wmi-provider/tagmapinfo-class.md) class.  
  
 Tag remapping, which occurs at compile time, replaces the original tag type (specified by the `TagType` property) with the mapped type (specified by the `MappedTagType` property) for all pages and controls in the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application in the scope of the configuration file.  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TagMapElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [System.Web.Configuration.TagMapInfo](/dotnet/api/system.web.configuration.tagmapinfo)  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [PagesSection Class](../wmi-provider/pagessection-class.md)   
 [TagMapInfo Class](../wmi-provider/tagmapinfo-class.md)
