---
title: "IPmApplicationPreload::PreloadApplication"
ms.date: "10/07/2016"
ms.assetid: 299d95c6-8184-4dda-8a54-8bcc9ce63447
---
# IPmApplicationPreload::PreloadApplication
Preloads an application into server memory given its site ID and configuration file path.  
  
## Syntax  
  
```cpp  
virtual HRESULT PreloadApplication(  
   IN DWORD dwSiteId,  
   IN PCWSTR pszAppConfigPath,  
   IN BOOL fRecycledWorkerProcess = FALSE  
) = 0;  
```  
  
### Parameters  
 `dwSiteId`  
 [IN] The ID of the application website.  
  
 `pszAppConfigPath`  
 [IN] Path to the application’s configuration file.  
  
 `fRecycledWorkerProcess`  
 [IN] Indicates whether the worker process associated with the application is recycled.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmApplicationPreload Interface](../../web-development-reference/native-code-api-reference/ipmapplicationpreload-interface.md)
