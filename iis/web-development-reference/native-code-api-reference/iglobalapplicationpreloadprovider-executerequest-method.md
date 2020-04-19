---
title: "IGlobalApplicationPreloadProvider::ExecuteRequest Method"
ms.date: "10/07/2016"
ms.assetid: 1aa835a0-0dc5-4a77-a241-fab587dba22e
---
# IGlobalApplicationPreloadProvider::ExecuteRequest Method
Runs an HTTP request given its context and user information.  
  
## Syntax  
  
```cpp  
Virtual HRESULT ExecuteRequest(  
   _In_ IHttpContext *         pHttpContext,  
   _In_ IHttpUser *            pHttpUser  
) = 0;  
```  
  
### Parameters  
 `pHttpContext`  
 [IN] A context object that encapsulates all HTTP-specific information about an individual HTTP request.  
  
 `pHttpUser`  
 [IN] Request-specific information about the user, such as credentials.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, the values listed in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalApplicationPreloadProvider Interface](../../web-development-reference/native-code-api-reference/iglobalapplicationpreloadprovider-interface.md)