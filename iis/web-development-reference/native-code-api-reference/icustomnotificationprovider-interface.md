---
title: "ICustomNotificationProvider Interface"
ms.date: "10/07/2016"
ms.assetid: c5128143-054d-e2a2-f839-2a1231e1f31e
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
|[QueryNotificationType](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-querynotificationtype-method.md)|Returns the unique identifier for a custom notification provider.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] provides the `ICustomNotificationProvider` interface to allow developers to create custom notifications. To implement a custom notification, you will need to create an instance of an `ICustomNotificationProvider` interface that provides [QueryNotificationType](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-querynotificationtype-method.md) and [SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md) methods.  
  
 Your custom notification will use the `QueryNotificationType` method to identify itself to modules that have registered for the [RQ_CUSTOM_NOTIFICATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) or [GL_CUSTOM_NOTIFICATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
 When a custom notification is raised, IIS will call a module's [CHttpModule::OnCustomRequestNotification](../../web-development-reference/native-code-api-reference/chttpmodule-oncustomrequestnotification-method.md) or [CGlobalModule::OnGlobalCustomNotification](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcustomnotification-method.md) method to process the custom notification. IIS will pass a pointer to the `ICustomNotificationProvider` interface for the custom notification that was raised, and the module should call the custom notification's `QueryNotificationType` method to verify that it is processing the correct notification.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that does the following:  
  
1.  Registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and `RQ_CUSTOM_NOTIFICATION` notifications.  
  
2.  Creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md) and [OnCustomRequestNotification](../../web-development-reference/native-code-api-reference/chttpmodule-oncustomrequestnotification-method.md) methods.  
  
    -   The `OnBeginRequest` method writes an event to the Event Viewer that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the [IHttpContext::NotifyCustomNotification](../../web-development-reference/native-code-api-reference/ihttpcontext-notifycustomnotification-method.md) method.  
  
    -   The `OnCustomRequestNotification` method uses the `QueryNotificationType` method to retrieve the unique identifier for the custom notification. If the unique identifier matches, the `OnCustomRequestNotification` method writes an event to the Event Viewer that specifies that the custom notification was raised.  
  
3.  Removes the `CHttpModule` class from memory and exits.  
  
 [!code-cpp[IHttpContextNotifyCustomNotification#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextNotifyCustomNotification/cpp/IHttpContextNotifyCustomNotification.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `ICustomNotificationProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)