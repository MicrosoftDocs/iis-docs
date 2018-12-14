---
title: "IAppHostMappingExtension::MapPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6daf0cdd-531a-223a-e875-8fc145223a56
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# IAppHostMappingExtension::MapPath Method
Maps a site to a physical path, virtual directory, and application path by using the site name and virtual path.  
  
## Syntax  
  
```cpp  
HRESULT MapPath(  
   [in,  
   string] BSTR bstrSiteName,  
   [in,  
   string] BSTR bstrVirtualPath,  
   [out,  
   string] BSTR* pbstrPhysicalPath,  
   [out] IAppHostElement** ppVirtualDirectoryElement,  
   [out] IAppHostElement** ppApplicationElement  
);  
```  
  
#### Parameters  
 `bstrSiteName`  
 A `BSTR` that contains the site name.  
  
 `bstrVirtualPath`  
 A `BSTR` that contains the virtual path.  
  
 `pbstrPhysicalPath`  
 A pointer to a `BSTR` that contains the physical path.  
  
 `ppVirtualDirectoryElement`  
 A pointer to a pointer for an [IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) interface.  
  
 `ppApplicationElement`  
 A pointer to a pointer for an [IAppHostElement](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostMappingExtension Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostmappingextension-interface.md)