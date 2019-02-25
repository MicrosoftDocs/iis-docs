---
title: "HttpCompressionMimeTypeElement Class"
ms.date: "10/07/2016"
ms.assetid: cda3cb3f-32b6-9ee2-9dec-35f00f19fc5b
---
# HttpCompressionMimeTypeElement Class
Specifies whether IIS will compress a particular MIME type before serving it.  
  
## Syntax  
  
```vbs  
class HttpCompressionMimeTypeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpCompressionMimeTypeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Enabled`|A read/write `boolean` value. `true` if the MIME type specified in the `MimeType` property will be compressed; otherwise, `false`. The default is `true`.|  
|`MimeType`|A read-only `string` value that specifies the MIME type to be compressed. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `DynamicTypes` array property of the [DynamicTypeSettings](../wmi-provider/dynamictypesettings-class.md) class and in the `StaticTypes` property of the [StaticTypeSettings](../wmi-provider/statictypesettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `HttpCompressionMimeTypeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [Compression Modules](https://go.microsoft.com/fwlink/?LinkId=64721)   
 [DynamicTypeSettings Class](../wmi-provider/dynamictypesettings-class.md)   
 [HttpCompressionSchemeElement Class](../wmi-provider/httpcompressionschemeelement-class.md)   
 [HttpCompressionSection Class](../wmi-provider/httpcompressionsection-class.md)   
 [StaticTypeSettings Class](../wmi-provider/statictypesettings-class.md)