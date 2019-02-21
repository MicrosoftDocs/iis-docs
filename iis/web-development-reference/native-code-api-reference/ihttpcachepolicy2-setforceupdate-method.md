---
title: "IHttpCachePolicy2::SetForceUpdate Method"
ms.date: "10/07/2016"
ms.assetid: 21f01a8a-79fb-4fc5-8e53-3f80664c8686
---
# IHttpCachePolicy2::SetForceUpdate Method
Sets a value that indicates that the cache should be updated for a specific request or request variation  
  
## Syntax  
  
```cpp  
virtual VOID SetForceUpdate(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Remarks  
  
-   Certain modules need the ability to evaluate requests and update the cache based on variations of the request. The `SetForceUpdate` method ensures that the cache is updated. A module may keep track of the criteria needed to update the module cache and call this method. Additionally, modules may call [IHttpCachePolicy2::IsForceUpdateSet Method](../../web-development-reference\native-code-api-reference/ihttpcachepolicy2-isforceupdateset-method.md) to determine if the value has been set.  
  
-   [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. To enable caching, call the [IHttpContext::GetResponse](../../web-development-reference\native-code-api-reference/ihttpcontext-getresponse-method.md) method, the [IHttpResponse::GetCachePolicy](../../web-development-reference\native-code-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the [IHttpCachePolicy::SetIsCached Method](../../web-development-reference\native-code-api-reference/ihttpcachepolicy-setiscached-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy2 Interface](../../web-development-reference\native-code-api-reference/ihttpcachepolicy2-interface.md)