---
title: "IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method"
description: "The IHttpModuleRegistrationInfoSetPriorityForGlobalNotification method sets the global-level priority for a module."
ms.date: "10/07/2016"
ms.assetid: ad47de99-e784-6394-0193-696bfdc3e89d
---
# IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method
Sets the global-level priority for a module.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetPriorityForGlobalNotification(  
   IN DWORD dwGlobalNotification,  
   IN PCWSTR pszPriority  
) = 0;  
```  
  
### Parameters  
 `dwGlobalNotification`  
 [IN] A bitmask value that contains the global notifications to set for the priority level. (Defined in [Httpserv.h](../../web-development-reference/native-code-api-reference/request-processing-constants.md).)  
  
 `pszPriority`  
 [IN] A pointer to a string that contains the priority alias. (Defined in Httpserv.h.)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `SetPriorityForGlobalNotification` method sets the priority level for a list of global-level notifications for which an HTTP module has registered. IIS uses the priority level to determine the order within a notification that modules should be organized. For example, a global module that has registered for the [OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) notification by using the `PRIORITY_ALIAS_HIGH` alias would be prioritized before a module that has registered for the [OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) notification by using the `PRIORITY_ALIAS_LOW` alias.  
  
> [!NOTE]
>  The bitmask values for global-level notifications and priority aliases are defined in the Httpserv.h file.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function and the following methods to register a module for global-level and request-level notifications.  
  
- The [SetRequestNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method registers a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class for a request-level [OnBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onbeginrequest-method.md) notification.  
  
- The [SetPriorityForRequestNotification](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) method sets the module's priority for request-level notifications.  
  
- The [SetGlobalNotifications](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md) method registers a [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) class for a global-level [OnGlobalPreBeginRequest](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) notification.  
  
- The `SetPriorityForGlobalNotification` method sets the module's priority for global-level notification.  
  
  The module responds to the registered notifications and writes entries to the application log in the Event Viewer.  
  
> [!NOTE]
> The entries in the Event Viewer will display "IISADMIN" as the event source.  
  
 [!code-cpp[IHttpModuleRegistrationInfoSetPriorityForGlobalNotification#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpModuleRegistrationInfoSetPriorityForGlobalNotification/cpp/IHttpModuleRegistrationInfoSetPriorityForGlobalNotification.cpp#1)]  
  
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
 [IHttpModuleRegistrationInfo Interface](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-interface.md)   
 [IHttpModuleRegistrationInfo::SetGlobalNotifications Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setglobalnotifications-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetRequestNotifications Method](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)
