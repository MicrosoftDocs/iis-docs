---
title: "IHttpServer::NotifyCustomNotification Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fa61640c-8bb4-fb19-c69e-7219a3260fca
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::NotifyCustomNotification Method
Raises a custom global-level notification.  
  
## Syntax  
  
```cpp  
virtual GLOBAL_NOTIFICATION_STATUS NotifyCustomNotification(  
   ICustomNotificationProvider* pCustomOutput  
) = 0;  
```  
  
#### Parameters  
 `pCustomOutput`  
 A pointer to an [ICustomNotificationProvider](../../web-development-reference\webdev-native-api-reference/icustomnotificationprovider-interface.md).  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) value.  
  
## Remarks  
 The `NotifyCustomNotification` method raises the custom notification that is specified by the `ICustomNotificationProvider` interface in the `pCustomOutput` parameter.  
  
 Your module must register for the [GL_CUSTOM_NOTIFICATION](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) notification, and your module must contain a [CGlobalModule::OnGlobalCustomNotification](../../web-development-reference\webdev-native-api-reference/cglobalmodule-onglobalcustomnotification-method.md) method to process the custom notification. To raise the custom notification, your module must first create the instance of your custom `ICustomNotificationProvider` interface and pass that interface to the `NotifyCustomNotification` method for the current global context.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for the [GL_PRE_BEGIN_REQUEST](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) and `GL_CUSTOM_NOTIFICATION` notifications.  
  
2.  Creates a [CGlobalModule](../../web-development-reference\webdev-native-api-reference/cglobalmodule-class.md) class that contains [OnGlobalPreBeginRequest](../../web-development-reference\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) and [OnGlobalCustomNotification](../../web-development-reference\webdev-native-api-reference/cglobalmodule-onglobalcustomnotification-method.md) methods.  
  
    1.  The `OnGlobalPreBeginRequest` method writes an event to the Event Viewer that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the `NotifyCustomNotification` method.  
  
    2.  The `OnGlobalCustomNotification` method uses the [ICustomNotificationProvider::QueryNotificationType](../../web-development-reference\webdev-native-api-reference/icustomnotificationprovider-querynotificationtype-method.md) method to retrieve the unique identifier for the custom notification. If the unique identifier matches, the `OnGlobalCustomNotification` method writes an event to the Event Viewer that specifies that the custom notification was raised.  
  
3.  Removes the `CGlobalModule` class from memory and exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerNotifyCustomNotification#1](IHttpServerNotifyCustomNotification#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICustomNotificationProvider Interface](../../web-development-reference\webdev-native-api-reference/icustomnotificationprovider-interface.md)   
 [IHttpServer Interface](../../web-development-reference\webdev-native-api-reference/ihttpserver-interface.md)   
 [IHttpContext::NotifyCustomNotification Method](../../web-development-reference\webdev-native-api-reference/ihttpcontext-notifycustomnotification-method.md)