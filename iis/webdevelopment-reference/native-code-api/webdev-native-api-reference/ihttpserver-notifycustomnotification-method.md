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
 A pointer to an [ICustomNotificationProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-interface.md).  
  
## Return Value  
 A [GLOBAL_NOTIFICATION_STATUS](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) value.  
  
## Remarks  
 The `NotifyCustomNotification` method raises the custom notification that is specified by the `ICustomNotificationProvider` interface in the `pCustomOutput` parameter.  
  
 Your module must register for the [GL_CUSTOM_NOTIFICATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification, and your module must contain a [CGlobalModule::OnGlobalCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcustomnotification-method.md) method to process the custom notification. To raise the custom notification, your module must first create the instance of your custom `ICustomNotificationProvider` interface and pass that interface to the `NotifyCustomNotification` method for the current global context.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Registers for the [GL_PRE_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and `GL_CUSTOM_NOTIFICATION` notifications.  
  
2.  Creates a [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) class that contains [OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) and [OnGlobalCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcustomnotification-method.md) methods.  
  
    1.  The `OnGlobalPreBeginRequest` method writes an event to the Event Viewer that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the `NotifyCustomNotification` method.  
  
    2.  The `OnGlobalCustomNotification` method uses the [ICustomNotificationProvider::QueryNotificationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-querynotificationtype-method.md) method to retrieve the unique identifier for the custom notification. If the unique identifier matches, the `OnGlobalCustomNotification` method writes an event to the Event Viewer that specifies that the custom notification was raised.  
  
3.  Removes the `CGlobalModule` class from memory and exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerNotifyCustomNotification#1](IHttpServerNotifyCustomNotification#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICustomNotificationProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-interface.md)   
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)   
 [IHttpContext::NotifyCustomNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-notifycustomnotification-method.md)