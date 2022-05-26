---
title: "WebRequestModuleElement Class"
description: The WebRequestModuleElement Class represents a Uniform Resource Identifier (URI) prefix and the associated class that creates Web requests for the prefix.
ms.date: "10/07/2016"
ms.assetid: 5336b292-a515-5615-d97c-ef14e2c9c10c
---
# WebRequestModuleElement Class
Represents a Uniform Resource Identifier (URI) prefix and the associated class that creates Web requests for the prefix.  
  
## Syntax  
  
```vbs  
class WebRequestModuleElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `WebRequestModuleElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Prefix`|A required unique read/write `string` value that contains the URI prefix for the Web request module specified by the `Type` property. The key property.|  
|`Type`|A read/write `string` value that specifies the managed type for a class that creates Web requests for the prefix specified in the `Prefix` property. **Note:**  The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `WebRequestModules` property of the [WebRequestModulesSection](../wmi-provider/webrequestmodulessection-class.md) class.  
  
 The [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)] provides Web request modules that create requests for resources with the following prefixes:  
  
- HTTP  
  
- HTTPS  
  
- FTP  
  
- FILE  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `WebRequestModuleElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HttpWebRequestSettings Class](../wmi-provider/httpwebrequestsettings-class.md)   
 [WebRequestModulesSection Class](../wmi-provider/webrequestmodulessection-class.md)   
 [\<add> Element for webRequestModules (Network Settings)](https://go.microsoft.com/fwlink/?LinkId=70917)
