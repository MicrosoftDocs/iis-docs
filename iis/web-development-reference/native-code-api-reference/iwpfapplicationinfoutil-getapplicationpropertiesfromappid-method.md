---
title: "IWpfApplicationInfoUtil::GetApplicationPropertiesFromAppId Method"
ms.date: "10/07/2016"
ms.assetid: d6401224-4d22-a604-2afe-18fba495f7bd
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
  
### Parameters  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWpfApplicationInfoUtil Interface](../../web-development-reference/native-code-api-reference/iwpfapplicationinfoutil-interface.md)
