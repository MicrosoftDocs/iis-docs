---
title: "CHttpModule::OnPostExecuteRequestHandler Method"
description: Learn how the OnPostExecuteRequestHandler method represents the method handles an ExecuteRequestHandler post-event.
ms.date: "10/07/2016"
ms.assetid: 98fae259-b939-7e27-a268-b56dbc639b2f
---
# CHttpModule::OnPostExecuteRequestHandler Method
Represents the method that will handle an `ExecuteRequestHandler` post-event, which occurs after IIS executes the handler for the current request.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnPostExecuteRequestHandler(  
   IN IHttpContext* pHttpContext,  
   IN IHttpEventProvider* pProvider  
);  
```  
  
### Parameters  
 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
 `pProvider`  
 [IN] A pointer to an [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface.  
  
## Return Value  
 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  
 When a request-level module is registered for the [RQ_EXECUTE_REQUEST_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) post-event notification, IIS will call the module's `OnPostExecuteRequestHandler` method after it executes the appropriate handler for the current request.  
  
> [!NOTE]
>  Request-level modules can register for the `ExecuteRequestHandler` post-event notification by registering for `RQ_EXECUTE_REQUEST_HANDLER` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create a request-level HTTP module that registers for the `RQ_EXECUTE_REQUEST_HANDLER` event and post-event notifications. When IIS executes the appropriate handler for a request, it will call the example module's [OnExecuteRequestHandler](../../web-development-reference/native-code-api-reference/chttpmodule-onexecuterequesthandler-method.md) and `OnPostExecuteRequestHandler` methods. Each method will write an entry in the application log of the Windows Event Viewer. When processing is complete, the module will exit.  
  
 [!code-cpp[CHttpModuleExecuteRequestHandler#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/CHttpModuleExecuteRequestHandler/cpp/CHttpModuleExecuteRequestHandler.cpp#1)]  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CHttpModule Class](../../web-development-reference/native-code-api-reference/chttpmodule-class.md)   
 [CHttpModule::OnExecuteRequestHandler Method](../../web-development-reference/native-code-api-reference/chttpmodule-onexecuterequesthandler-method.md)
