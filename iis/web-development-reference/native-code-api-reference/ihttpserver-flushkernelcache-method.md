---
title: "IHttpServer::FlushKernelCache Method"
ms.date: "10/07/2016"
ms.assetid: 935f7c14-8427-1283-859c-fbb0f45dabeb
---
# IHttpServer::FlushKernelCache Method

Flushes the kernel cache for a specific Uniform Resource Identifier (URI).  
  
## Syntax  
  
```cpp  
virtual HRESULT FlushKernelCache(  
   IN PCWSTR pszUrl  
) = 0;  
```  
  
### Parameters  

 `pszUrl`  
 [IN] A pointer to a string that contains the URI to flush.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|NO_ERROR|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
|ERROR_NOT_SUPPORTED|Indicates that the operation is not supported within the current context.|  
  
## Remarks  

 Developers can use the `FlushKernelCache` method to remove a specific URI from the kernel cache.  
  
> [!NOTE]
>  The `FlushKernelCache` method differs from the [IHttpResponse::DisableKernelCache](../../web-development-reference/native-code-api-reference/ihttpresponse-disablekernelcache-method.md) method, which disables kernel caching for the URI that is processing the current response.  
  
## Example  

 The following code example demonstrates how to create an HTTP module that uses the `FlushKernelCache` method to flush the kernel cache for the /default.aspx URI.  
  
 [!code-cpp[IHttpServerFlushKernelCache#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerFlushKernelCache/cpp/IHttpServerFlushKernelCache.cpp#1)]  
  
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

 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)   
 [IHttpResponse::DisableKernelCache Method](../../web-development-reference/native-code-api-reference/ihttpresponse-disablekernelcache-method.md)   
 [IHttpResponse::GetCachePolicy Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md)   
 [IHttpResponse::GetKernelCacheEnabled Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getkernelcacheenabled-method.md)
