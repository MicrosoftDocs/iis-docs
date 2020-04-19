---
title: "IHttpCachePolicy::SetKernelCacheInvalidatorSet Method"
ms.date: "10/07/2016"
ms.assetid: 32faf704-9760-5436-9c4a-80bd106fc41c
---
# IHttpCachePolicy::SetKernelCacheInvalidatorSet Method
Sets a value that indicates that the kernel cache is invalidated.  
  
## Syntax  
  
```cpp  
virtual VOID SetKernelCacheInvalidatorSet(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Remarks  
 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. To invalidate the cache, call the [IHttpContext::GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) method, the [IHttpResponse::GetCachePolicy](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `SetKernelCacheInvalidatorSet` method.  
  
 `SetKernelCacheInvalidatorSet` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 The current default implementer of the [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) interface declares a `private` Boolean value that is initialized to `false` at construction. When `SetKernelCacheInvalidatorSet` is called, this Boolean value is set to `true`. After `SetKernelCacheInvalidatorSet` is called, there is no method to reset this Boolean value to `false`.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy Interface](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md)