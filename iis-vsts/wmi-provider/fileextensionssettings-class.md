---
title: "FileExtensionsSettings Class"
ms.date: "10/07/2016"
ms.assetid: b437c7ab-64b4-f7b7-6f22-a699a37cead7
---
# FileExtensionsSettings Class
Configures the filtering of file extensions in requests.  
  
## Syntax  
  
```vbs  
class FileExtensionsSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `FileExtensionsSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AllowUnlisted`|A read/write `boolean` value. `true` if file extensions not listed in the `FileExtensions` property are allowed in requests; otherwise, `false`. The default is `true`.|  
|`ApplyToWebDAV`|A read/write `boolean` value. `true` if the `AllowUnlisted` and `FileExtensions` properties are applied to WebDAV requests; otherwise, `false`. The default is `true`.|  
|`FileExtensions`|An array of read/write [FileExtensionElement](../wmi-provider/fileextensionelement-class.md) values that specifies file extensions that are allowed or denied.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `FileExtensions` property of the [RequestFilteringSection](../wmi-provider/requestfilteringsection-class.md) class. In the ApplicationHost.config file, this class represents the `<fileExtensions>` element of the `<requestFiltering>` section  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `FileExtensionsSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [FileExtensionElement Class](../wmi-provider/fileextensionelement-class.md)   
 [RequestFilteringSection Class](../wmi-provider/requestfilteringsection-class.md)