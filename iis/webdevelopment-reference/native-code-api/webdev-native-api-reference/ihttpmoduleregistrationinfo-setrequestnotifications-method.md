---
title: "IHttpModuleRegistrationInfo::SetRequestNotifications Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9cd93045-71ee-c3ce-fdce-33f3fb105a05
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleRegistrationInfo::SetRequestNotifications Method
Registers the request-level notifications for a module.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetRequestNotifications(  
   IN IHttpModuleFactory* pModuleFactory,  
   IN DWORD dwRequestNotifications,  
   IN DWORD dwPostRequestNotifications  
) = 0;  
```  
  
#### Parameters  
 `pModuleFactory`  
 [IN] A pointer to an [IHttpModuleFactory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md) interface.  
  
 `dwRequestNotifications`  
 [IN] A bitmask value that contains the request notifications to register. (Defined in [Httpserv.h](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md).)  
  
 `dwPostRequestNotifications`  
 [IN] A bitmask value that contains the post-event notifications to register. (Defined in Httpserv.h.)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_ALREADY_EXISTS|Indicates that the module has already been registered.|  
  
## Remarks  
 The `SetRequestNotifications` method registers the request-level notifications for a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class. A module can register for two events for each notification: the event notification, as indicated by the bitmask in the `dwRequestNotifications` parameter, and the post-event notification, as indicated by the bitmask in the `dwPostRequestNotifications` parameter.  
  
 For example, an HTTP module could register for the [RQ_AUTHENTICATE_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification and the post-event notification for that same notification. In so doing, the module could provide additional processing functionality for the event notification and clean up any processing details in the post-event notification.  
  
> [!NOTE]
>  Some events do not have post-event notification. Use 0 for the `dwPostRequestNotifications` parameter when you do not want notification or when post-event notification is not supported.  
  
> [!NOTE]
>  The bitmask values for request-level notifications are defined in the Httpserv.h file.  
  
 The `SetRequestNotifications` method requires a pointer to an [IHttpModuleFactory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md) interface, which IIS will use to create an instance of a `CHttpModule` class. This factory must handle creating the instance of the `CHttpModule` class and returning any error messages if the class cannot be created.  
  
## Example  
 The following example demonstrates how to create an HTTP module that uses the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function and the following methods to register a module for global-level and request-level notifications.  
  
-   The `SetRequestNotifications` method registers a `CHttpModule` class for a request-level [OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md) notification.  
  
-   The [SetPriorityForRequestNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) method sets the module's priority for request-level notifications.  
  
-   The [SetGlobalNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md) method registers a [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) class for a global-level [OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) notification.  
  
-   The [SetPriorityForGlobalNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md) method sets the module's priority for global-level notification.  
  
 The module responds to the registered notifications and writes entries to the application log in the Event Viewer.  
  
> [!NOTE]
>  The entries in the Event Viewer will display "IISADMIN" as the event source.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleRegistrationInfoSetRequestNotifications#1](IHttpModuleRegistrationInfoSetRequestNotifications#1)]  -->  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleRegistrationInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-interface.md)   
 [IHttpModuleRegistrationInfo::SetGlobalNotifications Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)   
 [PFN_REGISTERMODULE Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md)