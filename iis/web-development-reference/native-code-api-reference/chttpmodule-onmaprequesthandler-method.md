---
title: "CHttpModule::OnMapRequestHandler Method"
ms.date: "10/07/2016"
ms.assetid: 9ed609a7-6575-a032-83dc-07a1565313c0
---
# CHttpModule::OnMapRequestHandler Method
Represents the method that will handle a `MapRequestHandler` event, which occurs when IIS maps the current request to an event handler.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnMapRequestHandler(  
   IN IHttpContext* pHttpContext,  
   IN IMapHandlerProvider* pProvider  
);  
```  
  
### Parameters  
 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
 `pProvider`  
 [IN] A pointer to an [IMapHandlerProvider](../../web-development-reference/native-code-api-reference/imaphandlerprovider-interface.md) interface.  
  
## Return Value  
 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  
 When a request-level module is registered for the [RQ_MAP_REQUEST_HANDLER](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnMapRequestHandler` method when IIS maps the current request to an event handler.  
  
> [!NOTE]
>  Request-level modules can register for the `MapRequestHandler` event notification by registering for `RQ_MAP_REQUEST_HANDLER` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create a request-level HTTP module that registers for the `RQ_MAP_REQUEST_HANDLER` event and post-event notifications. When IIS maps a request to an event handler, IIS will call the example module's `OnMapRequestHandler` and [OnPostMapRequestHandler](../../web-development-reference/native-code-api-reference/chttpmodule-onpostmaprequesthandler-method.md) methods. Each method will write an entry in the application log of the Windows Event Viewer. When processing is complete, the module will exit.  
  
 [!code-cpp[CHttpModuleMapRequestHandler#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/CHttpModuleMapRequestHandler/cpp/CHttpModuleMapRequestHandler.cpp#1)]  
  
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
 [CHttpModule::OnPostMapRequestHandler Method](../../web-development-reference/native-code-api-reference/chttpmodule-onpostmaprequesthandler-method.md)