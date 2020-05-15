---
title: "CHttpModule::OnCustomRequestNotification Method"
ms.date: "10/07/2016"
ms.assetid: 6df88fb0-5384-5777-8b7f-6cdf04c07b7e
---
# CHttpModule::OnCustomRequestNotification Method

Represents the method that will handle a custom event, which occurs when a module raises a user-defined notification.  
  
## Syntax  
  
```cpp  
virtual REQUEST_NOTIFICATION_STATUS OnCustomRequestNotification(  
   IN IHttpContext* pHttpContext,  
   IN ICustomNotificationProvider* pProvider  
);  
```  
  
### Parameters  

 `pHttpContext`  
 [IN] A pointer to an [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
 `pProvider`  
 [IN] A pointer to an [ICustomNotificationProvider](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md) interface.  
  
## Return Value  

 A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) value.  
  
## Remarks  

 When a request-level module is registered for the [RQ_CUSTOM_NOTIFICATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification, IIS will call the module's `OnCustomRequestNotification` method when a custom notification is raised.  
  
> [!NOTE]
>  Request-level modules can register for a custom event notification by registering for `RQ_CUSTOM_NOTIFICATION` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  

 The following code example demonstrates how to create an HTTP module that does the following:  
  
1. Registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and `RQ_CUSTOM_NOTIFICATION` notifications.  
  
2. Creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md) and `OnCustomRequestNotification` methods.  
  
    - `OnBeginRequest` writes an event to the Event Viewer that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the [IHttpContext::NotifyCustomNotification](../../web-development-reference/native-code-api-reference/ihttpcontext-notifycustomnotification-method.md) method.  
  
    - `OnCustomRequestNotification` uses the [ICustomNotificationProvider::QueryNotificationType](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-querynotificationtype-method.md) method to retrieve the unique identifier for the custom notification. If the unique identifier matches, `OnCustomRequestNotification` writes an event to the Event Viewer that specifies the custom notification.  
  
3. Removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpContextNotifyCustomNotification#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextNotifyCustomNotification/cpp/IHttpContextNotifyCustomNotification.cpp#1)]  
  
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
