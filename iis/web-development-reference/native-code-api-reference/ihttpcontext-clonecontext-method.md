---
title: "IHttpContext::CloneContext Method"
description: IHttpContext::CloneContext Method creates a clone of the current request context.
ms.date: "10/07/2016"
ms.assetid: fca3d2f4-9ebc-9615-53bc-2447fb65e301
---
# IHttpContext::CloneContext Method
Creates a clone of the current request context.  
  
## Syntax  
  
```cpp  
virtual HRESULT CloneContext(  
   IN DWORD dwCloneFlags,  
   OUT IHttpContext** ppHttpContext  
) = 0;  
```  
  
### Parameters  
 `dwCloneFlags`  
 [IN] A `DWORD` that contains the clone flags.  
  
 `ppHttpContext`  
 [OUT] A dereferenced pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md).  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that a specified parameter was not valid.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `CloneContext` method creates a clone of the current request context. You can control the cloning behavior by specifying the appropriate flags in the `dwCloneFlags` parameter. The following table lists the possible values for these flags.  
  
|Value|Description|  
|-----------|-----------------|  
|CLONE_FLAG_BASICS|Clone the URL, query string, and HTTP method.|  
|CLONE_FLAG_HEADERS|Clone the request headers.|  
|CLONE_FLAG_ENTITY|Clone the entity body.|  
|CLONE_FLAG_NO_PRECONDITION|Do not include any "range" and "if-" headers for the request.|  
|CLONE_FLAG_NO_DAV|Do not include any WebDAV headers for the request.|  
  
 Once you have created a cloned context, you can use the clone as you would use the parent context. For example, to execute a child request for a different URL than the parent URL, you would use the [IHttpRequest::SetUrl](../../web-development-reference/native-code-api-reference/ihttprequest-seturl-method.md) method for the cloned context to change the URL of the cloned context before calling the parent context's [IHttpContext::ExecuteRequest](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md) method.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. The module registers for the [RQ_MAP_PATH](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2. The module creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnMapPath](../../web-development-reference/native-code-api-reference/chttpmodule-onmappath-method.md) and [OnAsyncCompletion](../../web-development-reference/native-code-api-reference/chttpmodule-onasynccompletion-method.md) methods.  
  
3. When a Web client requests a URL, IIS calls the module's `OnMapPath` method. This method performs the following tasks:  
  
    1. Tests to see whether the URL for the current request has a trailing slash or ends with /default.aspx. If the URL ends with either element, the module uses the `CloneContext` method to create a clone of the current request.  
  
    2. Calls the clone's `IHttpRequest::SetUrl` method to set the URL for the clone to /example/default.aspx.  
  
    3. Calls the `IHttpContext::ExecuteRequest` method to execute the child request.  
  
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
 [IHttpContext::ExecuteRequest Method](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md)   
 [IHttpContext::ReleaseClonedContext Method](../../web-development-reference/native-code-api-reference/ihttpcontext-releaseclonedcontext-method.md)
