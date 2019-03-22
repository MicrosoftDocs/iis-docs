---
title: "CGlobalModule::OnGlobalCustomNotification Method"
ms.date: "10/07/2016"
ms.assetid: f029ec16-7791-d9b4-042d-b18c2a4c36d7
---
# CGlobalModule::OnGlobalCustomNotification Method
Represents the method that will handle a `GlobalCustomNotification` event, which occurs when a module raises a user-defined notification.  
  
## Syntax  
  
```cpp  
virtual GLOBAL_NOTIFICATION_STATUS OnGlobalCustomNotification(  
   IN ICustomNotificationProvider* pProvider  
);  
```  
  
### Parameters  
 `pProvider`  
 [IN] A pointer to an [ICustomNotificationProvider](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md) interface.  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/global-notification-status-enumeration.md) value.  
  
## Remarks  
 When a global module has registered for the [GL_CUSTOM_NOTIFICATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event notification, IIS will call the module's `OnGlobalCustomNotification` method if a global custom notification is raised (for example, if a module calls [IHttpServer::NotifyCustomNotification](../../web-development-reference/native-code-api-reference/ihttpserver-notifycustomnotification-method.md)).  
  
> [!NOTE]
>  Global modules can register for the `GlobalCustomNotification` event notification by registering for `GL_CUSTOM_NOTIFICATION` in the module's [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for the [GL_PRE_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and `GL_CUSTOM_NOTIFICATION` notifications.  
  
2.  Creates a [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) class that contains [OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) and [OnGlobalCustomNotification](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcustomnotification-method.md) methods.  
  
    -   The `OnGlobalPreBeginRequest` method writes an event to the Event Viewer that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the `NotifyCustomNotification` method.  
  
    -   The `OnGlobalCustomNotification` method uses the [ICustomNotificationProvider::QueryNotificationType](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-querynotificationtype-method.md) method to retrieve the unique identifier for the custom notification. If the unique identifier matches, the `OnGlobalCustomNotification` method writes an event to the Event Viewer that specifies that the custom notification was raised.  
  
3.  Removes the `CGlobalModule` class from memory and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerNotifyCustomNotification#1](IHttpServerNotifyCustomNotification#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Global-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-global-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [CGlobalModule Class](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md)   
 [IHttpServer::NotifyCustomNotification Method](../../web-development-reference/native-code-api-reference/ihttpserver-notifycustomnotification-method.md)