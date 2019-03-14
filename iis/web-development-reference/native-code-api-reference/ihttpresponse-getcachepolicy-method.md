---
title: "IHttpResponse::GetCachePolicy Method"
ms.date: "10/07/2016"
ms.assetid: ca34e089-b2d7-386a-e3f5-4c7dfa213d91
---
# IHttpResponse::GetCachePolicy Method
Retrieves the response output cache policy.  
  
## Syntax  
  
```cpp  
virtual IHttpCachePolicy* GetCachePolicy(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) interface.  
  
## Remarks  
 The `GetCachePolicy` method returns a pointer to an `IHttpCachePolicy` interface, which enables you to call any one of the available methods for that interface.  
  
> [!NOTE]
>  The server owns the lifetime of the `IHttpCachePolicy` interface, and the interface is available through the end of your response processing.  
  
## Example  
 The following code example demonstrates how to use the `GetCachePolicy` method to return a pointer to an `IHttpCachePolicy` interface, and it uses the [IHttpCachePolicy::IsUserCacheEnabled](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-isusercacheenabled-method.md) method to determine whether the user cache is enabled. The module then returns the status to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseGetCachePolicy#1](IHttpResponseGetCachePolicy#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::DisableKernelCache Method](../../web-development-reference/native-code-api-reference/ihttpresponse-disablekernelcache-method.md)   
 [IHttpResponse::GetKernelCacheEnabled Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getkernelcacheenabled-method.md)