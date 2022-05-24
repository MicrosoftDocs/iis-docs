---
title: "IHttpContext::SetRequestHandled Method"
description: Learn how the SetRequestHandled method indicates that the handlers for the current request have completed.
ms.date: "10/07/2016"
ms.assetid: e83d7e00-39ad-b989-971a-d65b62220fe4
---
# IHttpContext::SetRequestHandled Method
Indicates that the handlers for the current request have completed.  
  
## Syntax  
  
```cpp  
virtual VOID SetRequestHandled(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `SetRequestHandled` method specifies that the handlers for the current request have finished processing. For example, if multiple request handlers are configured for a specific file type, you can use the `SetRequestHandled` method to indicate that processing has completed for the current request and that additional handlers should not be executed.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. The module registers for the [RQ_PRE_EXECUTE_REQUEST_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2. The module creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains an [OnPreExecuteRequestHandler](../../web-development-reference/native-code-api-reference/chttpmodule-onpreexecuterequesthandler-method.md) method.  
  
3. When a Web client requests a URL, IIS calls the module's `OnPreExecuteRequestHandler` method. This method performs the following tasks  
  
    1. Retrieves a pointer to an [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface.  
  
    2. Retrieves the script handler for the request by using the [IScriptMapInfo::GetScriptProcessor](../../web-development-reference/native-code-api-reference/iscriptmapinfo-getscriptprocessor-method.md) method.  
  
    3. If the request is for an ASP page, returns a message to the Web client that the request has been handled, and then calls the `SetRequestHandled` method to set the request as handled.  
  
4. The module removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpContextSetRequestHandled#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextSetRequestHandled/cpp/IHttpContextSetRequestHandled.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)
