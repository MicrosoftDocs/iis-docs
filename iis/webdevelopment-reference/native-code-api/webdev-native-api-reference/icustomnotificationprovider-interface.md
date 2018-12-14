---
title: "ICustomNotificationProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c5128143-054d-e2a2-f839-2a1231e1f31e
caps.latest.revision: 15
author: "shirhatti"
manager: "wpickett"
---
# ICustomNotificationProvider Interface
Provides an interface for creating custom notifications.  
  
## Syntax  
  
```cpp  
class ICustomNotificationProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `ICustomNotificationProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[QueryNotificationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-querynotificationtype-method.md)|Returns the unique identifier for a custom notification provider.|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] provides the `ICustomNotificationProvider` interface to allow developers to create custom notifications. To implement a custom notification, you will need to create an instance of an `ICustomNotificationProvider` interface that provides [QueryNotificationType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomnotificationprovider-querynotificationtype-method.md) and [SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md) methods.  
  
 Your custom notification will use the `QueryNotificationType` method to identify itself to modules that have registered for the [RQ_CUSTOM_NOTIFICATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) or [GL_CUSTOM_NOTIFICATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification.  
  
 When a custom notification is raised, IIS will call a module's [CHttpModule::OnCustomRequestNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-oncustomrequestnotification-method.md) or [CGlobalModule::OnGlobalCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcustomnotification-method.md) method to process the custom notification. IIS will pass a pointer to the `ICustomNotificationProvider` interface for the custom notification that was raised, and the module should call the custom notification's `QueryNotificationType` method to verify that it is processing the correct notification.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that does the following:  
  
1.  Registers for the [RQ_BEGIN_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and `RQ_CUSTOM_NOTIFICATION` notifications.  
  
2.  Creates a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md) and [OnCustomRequestNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-oncustomrequestnotification-method.md) methods.  
  
    -   The `OnBeginRequest` method writes an event to the Event Viewer that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the [IHttpContext::NotifyCustomNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-notifycustomnotification-method.md) method.  
  
    -   The `OnCustomRequestNotification` method uses the `QueryNotificationType` method to retrieve the unique identifier for the custom notification. If the unique identifier matches, the `OnCustomRequestNotification` method writes an event to the Event Viewer that specifies that the custom notification was raised.  
  
3.  Removes the `CHttpModule` class from memory and exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextNotifyCustomNotification#1](IHttpContextNotifyCustomNotification#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `ICustomNotificationProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)