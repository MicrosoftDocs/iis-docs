---
title: "IHttpServer::DoCacheOperation Method"
ms.date: "10/07/2016"
ms.assetid: 0a0367e5-0463-3261-e359-41d2205827a4
---
# IHttpServer::DoCacheOperation Method
Performs a specific cache operation.  
  
## Syntax  
  
```cpp  
virtual HRESULT DoCacheOperation(  
   IN CACHE_OPERATION cacheOperation,  
   IN IHttpCacheKey* pCacheKey,  
   OUT IHttpCacheSpecificData** ppCacheSpecificData,  
   IN IHttpTraceContext* pHttpTraceContext = NULL  
) = 0;  
```  
  
### Parameters  
 `cacheOperation`  
 [IN] A [CACHE_OPERATION](../../web-development-reference\native-code-api-reference/cache-operation-enumeration.md) enumeration value.  
  
 `pCacheKey`  
 [IN] A pointer to an [IHttpCacheKey](../../web-development-reference\native-code-api-reference/ihttpcachekey-interface.md) interface.  
  
 `ppCacheSpecificData`  
 [OUT] A pointer to the address of an [IHttpCacheSpecificData](../../web-development-reference\native-code-api-reference/ihttpcachespecificdata-interface.md) interface.  
  
 `pHttpTraceContext`  
 [IN] A pointer to an [IHttpTraceContext](../../web-development-reference\native-code-api-reference/ihttptracecontext-interface.md) interface. (Optional.)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `DoCacheOperation` method is used in HTTP modules to perform the cache operation that is specified by the `cacheOperation` parameter. For example, the [CACHE_OPERATION_ADD](../../web-development-reference\native-code-api-reference/cache-operation-enumeration.md) and [CACHE_OPERATION_DELETE](../../web-development-reference\native-code-api-reference/cache-operation-enumeration.md) enumeration values store or remove objects, respectively, from the cache. When your module calls the `DoCacheOperation` method, it must pass an `IHttpCacheKey` interface in the `pCacheKey` parameter, and IIS will return an `IHttpCacheSpecificData` interface in the `ppCacheSpecificData` parameter. You can optionally specify an `IHttpTraceContext` interface in the `pHttpTraceContext` parameter to identify the request that triggered the call. (This is necessary only for tracing purposes.)  
  
> [!NOTE]
>  Implementers should not call [DoCacheOperation](../../web-development-reference\native-code-api-reference/ihttpserver-docacheoperation-method.md) inside of [IHttpApplicationResolveModulesProvider::RegisterModule Method](../../web-development-reference\native-code-api-reference/ihttpapplicationresolvemodulesprovider-registermodule-method.md) because it is too early in the request pipeline.  
  
## Example  
 The following code example demonstrates how to use the `DoCacheOperation` method to create an HTTP module that tests for a [CACHE_OPERATION_RETRIEVE](../../web-development-reference\native-code-api-reference/cache-operation-enumeration.md) operation and triggers a [CACHE_OPERATION_ENUM](../../web-development-reference\native-code-api-reference/cache-operation-enumeration.md) operation.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerDoCacheOperation#1](IHttpServerDoCacheOperation#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md)   
 [CACHE_OPERATION Enumeration](../../web-development-reference\native-code-api-reference/cache-operation-enumeration.md)   
 [IHttpCacheKey Interface](../../web-development-reference\native-code-api-reference/ihttpcachekey-interface.md)   
 [IHttpCacheSpecificData Interface](../../web-development-reference\native-code-api-reference/ihttpcachespecificdata-interface.md)   
 [IHttpTraceContext Interface](../../web-development-reference\native-code-api-reference/ihttptracecontext-interface.md)