---
title: "IHttpContext::NotifyCustomNotification Method"
description: "Describes the IHttpContext::NotifyCustomNotification method and details its syntax, parameters, return value, remarks, code example, and requirements."
ms.date: 10/07/2016
ms.assetid: a7ed6a0f-5a56-2420-5c1d-16364a5bda73
---
# IHttpContext::NotifyCustomNotification Method
Raises a custom request-level notification.  
  
## Syntax  
  
```cpp  
virtual HRESULT NotifyCustomNotification(  
   ICustomNotificationProvider* pCustomOutput,  
   BOOL* pfCompletionExpected  
) = 0;  
```  
  
### Parameters  
 `pCustomOutput`  
 A pointer to an [ICustomNotificationProvider](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md).  
  
 `pfCompletionExpected`  
 `true` if asynchronous completion is expected; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `NotifyCustomNotification` method raises the custom notification that is specified by the `ICustomNotificationProvider` interface in the `pCustomOutput` parameter.  
  
 Your module must register for the [RQ_CUSTOM_NOTIFICATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification, and your module must contain a [CHttpModule::OnCustomRequestNotification](../../web-development-reference/native-code-api-reference/chttpmodule-oncustomrequestnotification-method.md) method to process the custom notification. To raise the custom notification, your module must first create the instance of your custom `ICustomNotificationProvider` interface and pass that interface to the `NotifyCustomNotification` method for the current request context.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. Registers for the [RQ_BEGIN_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and `RQ_CUSTOM_NOTIFICATION` notifications.  
  
2. Creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md) and [OnCustomRequestNotification](../../web-development-reference/native-code-api-reference/chttpmodule-oncustomrequestnotification-method.md) methods.  
  
    1. The `OnBeginRequest` method writes to the Event Viewer an event that specifies the current notification. The method then creates an instance of an `ICustomNotificationProvider` interface and raises the custom notification by using the `NotifyCustomNotification` method.  
  
    2. The `OnCustomRequestNotification` method uses the [ICustomNotificationProvider::QueryNotificationType](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-querynotificationtype-method.md) method to retrieve the unique identifier for the custom notification. If the unique identifier matches, the `OnCustomRequestNotification` method writes to the Event Viewer an event that specifies that the custom notification was raised.  
  
3. Removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpContextNotifyCustomNotification#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextNotifyCustomNotification/cpp/IHttpContextNotifyCustomNotification.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICustomNotificationProvider Interface](../../web-development-reference/native-code-api-reference/icustomnotificationprovider-interface.md)   
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpServer::NotifyCustomNotification Method](../../web-development-reference/native-code-api-reference/ihttpserver-notifycustomnotification-method.md)
