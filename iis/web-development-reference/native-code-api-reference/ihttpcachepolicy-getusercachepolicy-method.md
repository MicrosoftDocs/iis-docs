---
title: "IHttpCachePolicy::GetUserCachePolicy Method"
ms.date: "10/07/2016"
ms.assetid: 8d007e1a-16e6-ab44-bb60-7ce16e56f806
---
# IHttpCachePolicy::GetUserCachePolicy Method
Returns the cache policy for the user.  
  
## Syntax  
  
```cpp  
virtual HTTP_CACHE_POLICY* GetUserCachePolicy(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [HTTP_CACHE_POLICY](https://go.microsoft.com/fwlink/?LinkId=62468).  
  
## Remarks  
 [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) derived classes that register for request or response events receive an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) pointer as a parameter on the corresponding `virtual` method. Call the [IHttpContext::GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) method, then the [IHttpResponse::GetCachePolicy](../../web-development-reference/native-code-api-reference/ihttpresponse-getcachepolicy-method.md) method, and finally the `GetUserCachePolicy` method to retrieve an `HTTP_CACHE_POLICY` pointer.  
  
 The `GetUserCachePolicy` return value depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 The current default implementer of the [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) interface declares a `private``HTTP_CACHE_POLICY` structure. During the construction of this implementer, the [Policy](https://go.microsoft.com/fwlink/?LinkId=62468) member of this structure is set to `HttpCachePolicyNocache`, and the [SecondsToLive](https://go.microsoft.com/fwlink/?LinkId=62468) member of this structure is set to 0. The `GetUserCachePolicy` method returns the address of this same `HTTP_CACHE_POLICY` structure.  
  
## Notes for Implementers  
 [IHttpCachePolicy](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpCachePolicy` implementers that use dynamic memory allocation must release or call `delete` on the `HTTP_CACHE_POLICY` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpCachePolicy` implementers are responsible for memory management with this data; therefore, `IHttpCachePolicy` clients must not release or call `delete` on the returned `HTTP_CACHE_POLICY` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events. The module then retrieves an `IHttpCachePolicy` pointer and writes cache policy information for the user to the response stream.  
  
 [!code-cpp[IHttpCachePolicy#6](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCachePolicy/cpp/GetUserCachePolicy.cpp#6)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes data that is similar to the following to the response stream:  
  
```  
Policy Type: HttpCachePolicyNocache  
Seconds-to-Live: 0  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Thread Safety  
 The `GetUserCachePolicy` method is thread safe. However, modifying the `HTTP_CACHE_POLICY` members independently is not thread safe because these members are `public` fields on a shared structure.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCachePolicy Interface](../../web-development-reference/native-code-api-reference/ihttpcachepolicy-interface.md)
