---
title: "IHttpResponse::DisableKernelCache Method"
ms.date: "10/07/2016"
ms.assetid: cb176222-ffa6-4591-b5ec-dc22d164fa3e
---
# IHttpResponse::DisableKernelCache Method
Disables the kernel cache for this response.  
  
## Syntax  
  
```cpp  
virtual VOID DisableKernelCache(  
   ULONG reason = 9  
) = 0;  
```  
  
### Parameters  
 `reason`  
 The optional reason for disabling the kernel cache.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `DisableKernelCache` method disables kernel caching for the current response.  
  
 You can optionally pass a `reason` parameter that contains a value defined in the `IISCacheEvents::HTTPSYS_CACHEABLE::enumReason` enumeration to indicate why you are disabling caching.  
  
> [!NOTE]
>  If you do not pass a `reason` parameter to the `DisableKernelCache` method, the default value of 9 (`HANDLER_HTTPSYS_UNFRIENDLY`) will be used.  
  
## Example  
 The following code example demonstrates how to use the `DisableKernelCache` method to disable kernel caching for the current request.  
  
> [!NOTE]
> Combine this example module with the example module listed for the [GetKernelCacheEnabled](../../web-development-reference/native-code-api-reference/ihttpresponse-getkernelcacheenabled-method.md) method if you want to return the current caching status.  
  
 [!code-cpp[IHttpResponseDisableKernelCache#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseDisableKernelCache/cpp/IHttpResponseDisableKernelCache.cpp#1)]  
  
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
 [IHttpResponse::GetCachePolicy Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md)   
 [IHttpResponse::GetKernelCacheEnabled Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getkernelcacheenabled-method.md)   
 [IHttpServer::FlushKernelCache Method](../../web-development-reference/native-code-api-reference/ihttpserver-flushkernelcache-method.md)
