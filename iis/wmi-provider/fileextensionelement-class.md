---
title: "FileExtensionElement Class"
ms.date: "10/07/2016"
ms.assetid: 4c300d66-0bce-4cb4-bd1a-11ac82457fed
---
# FileExtensionElement Class
Specifies a file extension that is allowed or denied in requests.  
  
## Syntax  
  
```vbs  
class FileExtensionElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
  
|Name|Description|  
|----------|-----------------|  
|`Allowed`|A read/write `boolean` value. `true` if files with the extension specified in `FileExtension` are allowed in requests; otherwise, `false`. The default is `true`.|  
|`FileExtension`|A read-only `string` value that specifies a file extension that is allowed or denied in requests depending on the value in the `Allowed` property. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `FileExtensions` array property of the [FileExtensionsSettings](../wmi-provider/fileextensionssettings-class.md) class. In the ApplicationHost.config file, this class represents a `<fileExtension>` element under the `<fileExtensions>` section.  
  
> [!NOTE]
>  You must install the Request Filtering Module (Modrqflt.dll) for this configuration setting to take effect.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `FileExtensionElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [FileExtensionsSettings Class](../wmi-provider/fileextensionssettings-class.md)   
 [RequestFilteringSection Class](../wmi-provider/requestfilteringsection-class.md)
