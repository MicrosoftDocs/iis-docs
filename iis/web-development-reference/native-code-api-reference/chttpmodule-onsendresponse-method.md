---
title: "CHttpModule::OnSendResponse Method"
ms.date: "10/07/2016"
ms.assetid: 972128f3-0603-da95-814b-3befc92d1764
---
# CHttpModule::OnSendResponse Method
Represents the method that will handle a `SendResponse` event, which occurs when IIS sends the response buffer.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnSendResponse(  
   IN IHttpContext* pHttpContext,  
   IN ISendResponseProvider* pProvider  
);  
```  
  
### Parameters  
 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
 `pProvider`  
 [IN] A pointer to an [ISendResponseProvider](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md) interface.  
  
## Return Value  
 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  
 When a request-level module is registered for the [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnSendResponse` method when it sends the response buffer.  
  
> [!NOTE]
>  Request-level modules can register for the `SendResponse` event notification by registering for `RQ_SEND_RESPONSE` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create a request-level HTTP module that registers for the `RQ_SEND_RESPONSE` event notification. When IIS sends the response buffer, it will call the example module's `OnSendResponse` method. The method will write an entry in the Application log of the Windows Event Viewer. When processing is complete, the module will exit.  
  
 [!code-cpp[CHttpModuleSendResponse#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/CHttpModuleSendResponse/cpp/CHttpModuleSendResponse.cpp#1)]  
  
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
