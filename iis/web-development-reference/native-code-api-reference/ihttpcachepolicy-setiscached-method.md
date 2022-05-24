---
title: "IHttpCachePolicy::SetIsCached Method"
descriptions: This article contains information about syntax and requirements for the IHttpCachePolicy::SetIsCached method.
ms.date: "10/07/2016"
ms.assetid: eb65432f-c325-3cda-3c56-a8f9c1cbb4d9
---
# IHttpCachePolicy::SetIsCached Method
Sets a value that indicates that the data is cached.  
  
## Syntax  
  
```cpp  
virtual VOID SetIsCached(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Remarks  
 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. To enable caching, call the [IHttpContext::GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) method, the [IHttpResponse::GetCachePolicy](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `SetIsCached` method.  
  
 `SetIsCached` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
- The current default implementer of the [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) interface declares a `private` Boolean value that is initialized to `false` at construction. When `SetIsCached` is called, this Boolean value is set to `true`. After `SetIsCached` is called, there is no method to reset this Boolean value to `false`.  
  
- `SetIsCached` returns the value of this Boolean.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy Interface](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md)
