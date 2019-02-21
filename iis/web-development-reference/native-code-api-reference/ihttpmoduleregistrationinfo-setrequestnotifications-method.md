---
title: "IHttpModuleRegistrationInfo::SetRequestNotifications Method"
ms.date: "10/07/2016"
ms.assetid: 9cd93045-71ee-c3ce-fdce-33f3fb105a05
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
  
### Parameters  
 `pModuleFactory`  
 [IN] A pointer to an [IHttpModuleFactory](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-interface.md) interface.  
  
 `dwRequestNotifications`  
 [IN] A bitmask value that contains the request notifications to register. (Defined in [Httpserv.h](../../web-development-reference\native-code-api-reference/request-processing-constants.md).)  
  
 `dwPostRequestNotifications`  
 [IN] A bitmask value that contains the post-event notifications to register. (Defined in Httpserv.h.)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_ALREADY_EXISTS|Indicates that the module has already been registered.|  
  
## Remarks  
 The `SetRequestNotifications` method registers the request-level notifications for a [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class. A module can register for two events for each notification: the event notification, as indicated by the bitmask in the `dwRequestNotifications` parameter, and the post-event notification, as indicated by the bitmask in the `dwPostRequestNotifications` parameter.  
  
 For example, an HTTP module could register for the [RQ_AUTHENTICATE_REQUEST](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notification and the post-event notification for that same notification. In so doing, the module could provide additional processing functionality for the event notification and clean up any processing details in the post-event notification.  
  
> [!NOTE]
>  Some events do not have post-event notification. Use 0 for the `dwPostRequestNotifications` parameter when you do not want notification or when post-event notification is not supported.  
  
> [!NOTE]
> The bitmask values for request-level notifications are defined in the Httpserv.h file.  
  
 The `SetRequestNotifications` method requires a pointer to an [IHttpModuleFactory](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-interface.md) interface, which IIS will use to create an instance of a `CHttpModule` class. This factory must handle creating the instance of the `CHttpModule` class and returning any error messages if the class cannot be created.  
  
## Example  
 The following example demonstrates how to create an HTTP module that uses the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function and the following methods to register a module for global-level and request-level notifications.  
  
-   The `SetRequestNotifications` method registers a `CHttpModule` class for a request-level [OnBeginRequest](../../web-development-reference\native-code-api-reference/chttpmodule-onbeginrequest-method.md) notification.  
  
-   The [SetPriorityForRequestNotification](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) method sets the module's priority for request-level notifications.  
  
-   The [SetGlobalNotifications](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md) method registers a [CGlobalModule](../../web-development-reference\native-code-api-reference/cglobalmodule-class.md) class for a global-level [OnGlobalPreBeginRequest](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) notification.  
  
-   The [SetPriorityForGlobalNotification](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md) method sets the module's priority for global-level notification.  
  
 The module responds to the registered notifications and writes entries to the application log in the Event Viewer.  
  
> [!NOTE]
> The entries in the Event Viewer will display "IISADMIN" as the event source.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleRegistrationInfoSetRequestNotifications#1](IHttpModuleRegistrationInfoSetRequestNotifications#1)]  -->  
  
 Your module must export the `RegisterModule` function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleRegistrationInfo Interface](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-interface.md)   
 [IHttpModuleRegistrationInfo::SetGlobalNotifications Method](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md)