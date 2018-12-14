---
title: "IHttpContext::ExecuteRequest Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b52b477c-0e04-f8f1-4607-13ba5212f91e
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::ExecuteRequest Method
Executes a child request.  
  
## Syntax  
  
```cpp  
virtual HRESULT ExecuteRequest(  
   IN BOOL fAsync,  
   IN IHttpContext* pHttpContext,  
   IN DWORD dwExecuteFlags,  
   IN IHttpUser* pHttpUser,  
   OUT BOOL* pfCompletionExpected = NULL  
) = 0;  
```  
  
#### Parameters  
 `fAsync`  
 [IN] Always `true` (specifies asynchronous execution).  
  
 `pHttpContext`  
 [IN] A pointer to the child [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) to execute.  
  
 `dwExecuteFlags`  
 [IN] A `DWORD` that contains the request execution flags.  
  
 `pHttpUser`  
 [IN] A pointer to an [IHttpUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md) for the request. (Optional)  
  
 `pfCompletionExpected`  
 [OUT] `true` if asynchronous completion is still pending; otherwise, `false`. (Optional)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_SUPPORTED|Indicates that the request is not supported (for example, `fAsync` is set to `false` or the child request was not cloned from the parent request).|  
|ERROR_STACK_OVERFLOW|Indicates that request exceeds the limit for recursive child requests.|  
  
## Remarks  
 The `ExecuteRequest` method executes the child request that is specified by the [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) interface in the `pHttpContext` parameter. You must create this request context by using the [IHttpContext::CloneContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-clonecontext-method.md) method.  
  
> [!IMPORTANT]
>  Attempting to execute a child request that was not cloned by the parent request will return ERROR_NOT_SUPPORTED.  
  
 Each child context can be executed only once, although child requests can be nested recursively.  
  
> [!NOTE]
>  The limit for recursive child requests is 10.  
  
 The `ExecuteRequest` method supports only asynchronous operation, which prevents exhausting the thread pool.  
  
> [!IMPORTANT]
>  Attempting to execute a synchronous child request will return ERROR_NOT_SUPPORTED.  
  
 You can control the execution behavior for the child request by specifying execution flags in `dwExecuteFlags`. The following table lists the possible values for these flags.  
  
|Value|Description|  
|-----------|-----------------|  
|EXECUTE_FLAG_NO_HEADERS|Suppress the HTTP headers for the child request.|  
|EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR|Ignore the current script map handler for this request chain.|  
|EXECUTE_FLAG_IGNORE_APPPOOL|Execute the request even if the child request is not in the same application pool.|  
|EXECUTE_FLAG_DISABLE_CUSTOM_ERROR|Disable custom errors for the child request.|  
|EXECUTE_FLAG_SAME_URL|The URL for the child request is the same as the parent request. **Note:**  Script map handlers use this flag to forward execution.|  
|EXECUTE_FLAG_BUFFER_RESPONSE|Do not flush the child response; return the response to the parent request.|  
|EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE|The child response is still eligible for caching by Http.sys. **Note:**  Caching is disabled by default when a child request is executed.|  
  
 If you specify an `IHttpUser` interface for `pHttpUser`, authentication will be skipped for the child request.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the [RQ_MAP_PATH](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification.  
  
2.  The module creates a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class that contains [OnMapPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onmappath-method.md) and [OnAsyncCompletion](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onasynccompletion-method.md) methods.  
  
3.  When a Web client requests a URL, IIS calls the module's `OnMapPath` method. This method performs the following tasks:  
  
    1.  Tests to see whether the URL for the current request matches two specific URLs at the root of the Web site. If the URL matches either of the specified URLs, the module uses the `IHttpContext::CloneContext` method to create a clone of the current request.  
  
    2.  Calls the clone's `IHttpRequest::SetUrl` method to set the URL for the clone to /example/default.aspx.  
  
    3.  Calls the `ExecuteRequest` method to execute the child request.  
  
    4.  Tests for asynchronous completion. If asynchronous completion is pending, the module returns processing to the integrated request-processing pipeline. If not, the module releases the cloned context.  
  
4.  If asynchronous completion is required, IIS calls the module's `OnAsyncCompletion` method. This method releases the cloned context.  
  
5.  The module removes the `CHttpModule` class from memory and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextExecuteRequest#1](IHttpContextExecuteRequest#1)]  -->  
  
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
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::CloneContext Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-clonecontext-method.md)   
 [IHttpContext::GetParentContext Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getparentcontext-method.md)   
 [IHttpContext::ReleaseClonedContext Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-releaseclonedcontext-method.md)