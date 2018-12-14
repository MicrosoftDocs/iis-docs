---
title: "IWpfApplicationInfoUtil::GetApplicationPropertiesFromAppId Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d6401224-4d22-a604-2afe-18fba495f7bd
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IWpfApplicationInfoUtil::GetApplicationPropertiesFromAppId Method
Retrieves the virtual path and site ID for an application.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetApplicationPropertiesFromAppId(  
   IN PCWSTR pszAppId,  
   __out_ecount_opt(*pcchVirtualPath) PWSTR pszVirtualPath,  
   OUT DWORD* pcchVirtualPath,  
   OUT DWORD* pdwSiteId  
) = 0;  
```  
  
#### Parameters  
 `pszAppId`  
 A pointer to a string that contains an ID for the application. This may be a virtual path, a physical path, or a site ID.  
  
 `pszVirtualPath`  
 A pointer to a string buffer that receives the virtual path to the application.  
  
 `pcchVirtualPath`  
 A pointer to a `DWORD` buffer that receives the length of the string returned by `pszVirtualPath`.  
  
 `pdwSiteId`  
 A pointer to a `DWORD` buffer that receives the site ID.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_FOUND|Indicates that the requested application ID is either not valid or is not available on the server.|  
  
## Remarks  
 The `GetApplicationPropertiesFromAppId` method retrieves the virtual path and site ID for an application that is specified by a virtual path, a physical path, or a site ID. For example, calling this method and specifying a virtual path as the identifier for an application would obtain the site ID.  
  
 Because the `pszVirtualPath` parameter is optional, it may be NULL.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfApplicationInfoUtil Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfapplicationinfoutil-interface.md)