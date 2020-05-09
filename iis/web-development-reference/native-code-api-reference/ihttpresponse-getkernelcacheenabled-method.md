---
title: "IHttpResponse::GetKernelCacheEnabled Method"
ms.date: "10/07/2016"
ms.assetid: 26fd4e99-9c54-abfa-9782-86bdbee4ad05
---
# IHttpResponse::GetKernelCacheEnabled Method
Determines whether the kernel cache is enabled for the current response.  
  
## Syntax  
  
```cpp  
virtual BOOL GetKernelCacheEnabled(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the kernel cache is enabled for the current response; otherwise, `false`.  
  
## Remarks  
 The `GetKernelCacheEnabled` method returns a Boolean value of `true` if kernel-mode caching is enabled for the current response, and it returns a value of `false` if caching is disabled.  
  
> [!NOTE]
>  There are additional reasons why a response may not be cached by the server (for example, compression settings or Secure Sockets Layer settings). Therefore, a value of `true` does not mean that the response will be cached; it means only that caching is enabled.  
  
## Example  
 The following code example demonstrates how to use the `GetKernelCacheEnabled` method to create an HTTP module that determines whether kernel caching is enabled for the current response. The module then returns this information to the client.  
  
> [!NOTE]
> Combine this example module with the example module that is listed for the [IHttpResponse::DisableKernelCache](../../web-development-reference/native-code-api-reference/ihttpresponse-disablekernelcache-method.md) method if you want to disable caching and return the status to the client.  
  
 [!code-cpp[IHttpResponseGetKernelCacheEnabled#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseGetKernelCacheEnabled/cpp/IHttpResponseGetKernelCacheEnabled.cpp#1)]  
  
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
 [IHttpResponse::GetCachePolicy Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md)
