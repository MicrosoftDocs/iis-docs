---
title: "IHttpContext::ExecuteRequest Method"
description: The I H t t p Context Execute Request Method executes a child request.
ms.date: "10/07/2016"
ms.assetid: b52b477c-0e04-f8f1-4607-13ba5212f91e
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
  
### Parameters  
 `fAsync`  
 [IN] Always `true` (specifies asynchronous execution).  
  
 `pHttpContext`  
 [IN] A pointer to the child [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) to execute.  
  
 `dwExecuteFlags`  
 [IN] A `DWORD` that contains the request execution flags.  
  
 `pHttpUser`  
 [IN] A pointer to an [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) for the request. (Optional)  
  
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
 The `ExecuteRequest` method executes the child request that is specified by the [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface in the `pHttpContext` parameter. You must create this request context by using the [IHttpContext::CloneContext](../../web-development-reference/native-code-api-reference/ihttpcontext-clonecontext-method.md) method.  
  
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
  
1. The module registers for the [RQ_MAP_PATH](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2. The module creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnMapPath](../../web-development-reference/native-code-api-reference/chttpmodule-onmappath-method.md) and [OnAsyncCompletion](../../web-development-reference/native-code-api-reference/chttpmodule-onasynccompletion-method.md) methods.  
  
3. When a Web client requests a URL, IIS calls the module's `OnMapPath` method. This method performs the following tasks:  
  
    1. Tests to see whether the URL for the current request matches two specific URLs at the root of the Web site. If the URL matches either of the specified URLs, the module uses the `IHttpContext::CloneContext` method to create a clone of the current request.  
  
    2. Calls the clone's `IHttpRequest::SetUrl` method to set the URL for the clone to /example/default.aspx.  
  
    3. Calls the `ExecuteRequest` method to execute the child request.  
  
    4. Tests for asynchronous completion. If asynchronous completion is pending, the module returns processing to the integrated request-processing pipeline. If not, the module releases the cloned context.  
  
4. If asynchronous completion is required, IIS calls the module's `OnAsyncCompletion` method. This method releases the cloned context.  
  
5. The module removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpContextExecuteRequest#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextExecuteRequest/cpp/IHttpContextExecuteRequest.cpp#1)]  
  
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
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::CloneContext Method](../../web-development-reference/native-code-api-reference/ihttpcontext-clonecontext-method.md)   
 [IHttpContext::GetParentContext Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getparentcontext-method.md)   
 [IHttpContext::ReleaseClonedContext Method](../../web-development-reference/native-code-api-reference/ihttpcontext-releaseclonedcontext-method.md)
