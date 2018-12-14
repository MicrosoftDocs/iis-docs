---
title: "IHttpModuleRegistrationInfo::SetGlobalNotifications Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a3d195c5-6bf1-27c5-d9a4-6be71d081161
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IHttpModuleRegistrationInfo::SetGlobalNotifications Method
Registers the global-level notifications for a module.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetGlobalNotifications(  
   IN CGlobalModule* pGlobalModule,  
   IN DWORD dwGlobalNotifications  
) = 0;  
```  
  
#### Parameters  
 `pGlobalModule`  
 [IN] A pointer to a [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) class.  
  
 `dwGlobalNotifications`  
 [IN] A bitmask value that contains the global notifications to register. (Defined in [Httpserv.h](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md).)  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_ALREADY_EXISTS|Indicates that the module has already been registered.|  
  
## Remarks  
 The `SetGlobalNotifications` method registers the request-level notifications for a `CGlobalModule` class.  
  
> [!NOTE]
>  The bitmask values for global-level notifications are defined in the Httpserv.h file.  
  
 The `SetGlobalNotifications` method requires a pointer to a `CGlobalModule` class, and IIS will automatically create an instance of that class.  
  
> [!NOTE]
>  The `CGlobalModule` class must define a [Terminate](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-terminate-method.md) method.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function and the following methods to register a module for global-level and request-level notifications.  
  
-   The [SetRequestNotifications](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md) method registers a [CHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-class.md) class for a request-level [OnBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onbeginrequest-method.md) notification.  
  
-   The [SetPriorityForRequestNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) method sets the module's priority for request-level notifications.  
  
-   The `SetGlobalNotifications` method registers a `CGlobalModule` class for a global-level [OnGlobalPreBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalprebeginrequest-method.md) notification.  
  
-   The [SetPriorityForGlobalNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md) method sets the module's priority for global-level notification.  
  
 The module responds to the registered notifications and writes entries to the application log in the Event Viewer.  
  
> [!NOTE]
>  The entries in the Event Viewer will display "IISADMIN" as the event source.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleRegistrationInfoSetGlobalNotifications#1](IHttpModuleRegistrationInfoSetGlobalNotifications#1)]  -->  
  
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
 [IHttpModuleRegistrationInfo::SetPriorityForGlobalNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforglobalnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md)   
 [IHttpModuleRegistrationInfo::SetRequestNotifications Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setrequestnotifications-method.md)   
 [PFN_REGISTERMODULE Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md)