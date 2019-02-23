---
title: "DynamicTypeSettings Class"
ms.date: "10/07/2016"
ms.assetid: aad015a1-5db6-4792-aa51-300cde9889f9
---
# DynamicTypeSettings Class
Specifies the MIME types that IIS serves with dynamic compression.  
  
## Syntax  
  
```vbs  
class DynamicTypeSettings: EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `DynamicTypeSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DynamicTypes`|An array of [HttpCompressionMimeTypeElement](../wmi-provider/httpcompressionmimetypeelement-class.md) values that specify whether IIS will dynamically compress a particular MIME type before serving it.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `DynamicTypes` array property of the [HttpCompressionSection](../wmi-provider/httpcompressionsection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `DynamicTypeSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Compression Modules](https://go.microsoft.com/fwlink/?LinkId=64721)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [HttpCompressionMimeTypeElement Class](../wmi-provider/httpcompressionmimetypeelement-class.md)   
 [HttpCompressionSchemeElement Class](../wmi-provider/httpcompressionschemeelement-class.md)   
 [HttpCompressionSection Class](../wmi-provider/httpcompressionsection-class.md)   
 [StaticTypeSettings Class](../wmi-provider/statictypesettings-class.md)