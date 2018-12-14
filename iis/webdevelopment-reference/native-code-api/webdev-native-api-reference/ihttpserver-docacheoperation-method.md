---
title: "IHttpServer::DoCacheOperation Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0a0367e5-0463-3261-e359-41d2205827a4
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
 `cacheOperation`  
 [IN] A [CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cache-operation-enumeration.md) enumeration value.  
  
 `pCacheKey`  
 [IN] A pointer to an [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md) interface.  
  
 `ppCacheSpecificData`  
 [OUT] A pointer to the address of an [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) interface.  
  
 `pHttpTraceContext`  
 [IN] A pointer to an [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) interface. (Optional.)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `DoCacheOperation` method is used in HTTP modules to perform the cache operation that is specified by the `cacheOperation` parameter. For example, the [CACHE_OPERATION_ADD](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cache-operation-enumeration.md) and [CACHE_OPERATION_DELETE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cache-operation-enumeration.md) enumeration values store or remove objects, respectively, from the cache. When your module calls the `DoCacheOperation` method, it must pass an `IHttpCacheKey` interface in the `pCacheKey` parameter, and IIS will return an `IHttpCacheSpecificData` interface in the `ppCacheSpecificData` parameter. You can optionally specify an `IHttpTraceContext` interface in the `pHttpTraceContext` parameter to identify the request that triggered the call. (This is necessary only for tracing purposes.)  
  
> [!NOTE]
>  Implementers should not call [DoCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-docacheoperation-method.md) inside of [IHttpApplicationResolveModulesProvider::RegisterModule Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationresolvemodulesprovider-registermodule-method.md) because it is too early in the request pipeline.  
  
## Example  
 The following code example demonstrates how to use the `DoCacheOperation` method to create an HTTP module that tests for a [CACHE_OPERATION_RETRIEVE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cache-operation-enumeration.md) operation and triggers a [CACHE_OPERATION_ENUM](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cache-operation-enumeration.md) operation.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerDoCacheOperation#1](IHttpServerDoCacheOperation#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)   
 [CACHE_OPERATION Enumeration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cache-operation-enumeration.md)   
 [IHttpCacheKey Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md)   
 [IHttpCacheSpecificData Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)   
 [IHttpTraceContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md)