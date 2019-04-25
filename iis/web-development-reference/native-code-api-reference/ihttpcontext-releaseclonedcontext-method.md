---
title: "IHttpContext::ReleaseClonedContext Method"
ms.date: "10/07/2016"
ms.assetid: f43a4f35-dc84-d61d-09e1-cd512ee0b14a
---
# IHttpContext::ReleaseClonedContext Method
Releases a cloned [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) instance.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReleaseClonedContext(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the parent context for the current request is not valid (for example, a child context is being released after the parent has been released).|  
  
## Remarks  
 The `ReleaseClonedContext` method releases an instance of an `IHttpContext` interface. For example, if you create a child context by using the [IHttpContext::CloneContext](../../web-development-reference/native-code-api-reference/ihttpcontext-clonecontext-method.md) method, you would call the child's `ReleaseClonedContext` method to release the child context when you are finished using it.  
  
> [!IMPORTANT]
>  Calling the `ReleaseClonedContext` method to release a child request after releasing its parent context will return ERROR_INVALID_PARAMETER. For example, if you create a child context and then use that child to create a nested child request, you will need to release the child contexts in reverse-order of their creation.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  The module registers for the [RQ_MAP_PATH](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2.  The module creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnMapPath](../../web-development-reference/native-code-api-reference/chttpmodule-onmappath-method.md) and [OnAsyncCompletion](../../web-development-reference/native-code-api-reference/chttpmodule-onasynccompletion-method.md) methods.  
  
3.  When a Web client requests a URL, IIS calls the module's `OnMapPath` method. This method performs the following tasks:  
  
    1.  Tests to see whether the URL for the current request has a trailing slash or ends with /default.aspx. If the URL ends with either element, the module uses the `IHttpContext::CloneContext` method to create a clone of the current request.  
  
    2.  Calls the clone's `IHttpRequest::SetUrl` method to set the URL for the clone to /example/default.aspx.  
  
    3.  Calls the [IHttpContext::ExecuteRequest](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md) method to execute the child request.  
  
    4.  Tests for asynchronous completion. If asynchronous completion is pending, the module returns processing to the integrated request-processing pipeline. If not, the module releases the cloned context.  
  
4.  If asynchronous completion is required, IIS calls the module's `OnAsyncCompletion` method. This method releases the cloned context.  
  
5.  The module removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpContextExecuteRequest#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextExecuteRequest/cpp/IHttpContextExecuteRequest.cpp#1)]  
  
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
 [IHttpContext::ExecuteRequest Method](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md)