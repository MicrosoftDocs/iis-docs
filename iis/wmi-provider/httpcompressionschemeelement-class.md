---
title: "HttpCompressionSchemeElement Class"
description: Details the syntax for the HttpCompressionSchemeElement class and configures a compression scheme for dynamic or static content.
ms.date: "10/07/2016"
ms.assetid: ac61f270-669f-7a6f-08fe-88a293426d7a
---
# HttpCompressionSchemeElement Class
Configures a compression scheme for dynamic or static content.  
  
## Syntax  
  
```vbs  
class HttpCompressionSchemeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpCompressionSchemeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Dll`|A nonempty read/write `string` value that specifies the fully qualified file system path and file name of the DLL associated with the compression scheme. You must restart the World Wide Web Publishing Service (WWW service) before any changes to this property will take effect.|  
|`DoDynamicCompression`|A read/write `boolean` value. `true` if IIS compresses responses to requests for dynamic content, such as scripts in ASP pages and ISAPI extensions; otherwise, `false`. The default is `true`. **Note:**  Because this property cannot be inherited, you must set it to `true` at both the global level ([HttpCompressionSection](../wmi-provider/httpcompressionsection-class.md)) and the individual scheme level if the `Name` property is set to "gzip". If you change this value at the individual compression scheme level, you must restart the WWW service before the change will take effect.|  
|`DoStaticCompression`|A read/write `boolean` value. `true` if IIS compresses responses to requests for static content; otherwise, `false`. The default is `true`. **Note:**  Because this property cannot be inherited, you must set it to `true` at both the global level ([HttpCompressionSection](../wmi-provider/httpcompressionsection-class.md)) and the individual scheme level if the `Name` property is set to "gzip". If you change this value at the individual compression scheme level, you must restart the WWW service before the change will take effect. **Note:**  The static compression store needs to be located in a disk partition or remote share formatted with NTFS. If the file store is not NTFS, static compression is disabled. For security reasons, no compressed responses will be served from a FAT cache store.|  
|`DynamicCompressionLevel`|A read/write `uint32` value that specifies the compression level, from 0 through 10, for dynamic content. 10 is the maximum amount of compression; 0 means that compression is disabled. The default is 0 (disabled). Higher levels of compression require more CPU cycles. **Note:**  Because dynamic compression consumes considerable CPU time and memory resources, use it only on servers that have slow network connections but CPU time to spare. Compressed static responses can be cached and, therefore, do not affect CPU resources like dynamic responses do. **Note:**  You must restart the WWW service before any changes to this property will take effect.|  
|`Name`|A nonempty read-only `string` value that specifies the name of the compression scheme. Supported values are "gzip" and "deflate". The key property.|  
|`StaticCompressionLevel`|A `uint32` value that specifies the compression level, from 0 through 10, for static content. 10 is the maximum amount of compression; 0 means that compression is disabled. The default is 7. Higher levels of compression require more CPU cycles. **Note:**  You must restart the WWW service before any changes to this property will take effect.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `HttpCompression` property of the [HttpCompressionSection](../wmi-provider/httpcompressionsection-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `HttpCompressionSchemeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HttpCompressionMimeTypeElement Class](../wmi-provider/httpcompressionmimetypeelement-class.md)   
 [HttpCompressionSection Class](../wmi-provider/httpcompressionsection-class.md)   
 [UrlCompressionSection Class](../wmi-provider/urlcompressionsection-class.md)
