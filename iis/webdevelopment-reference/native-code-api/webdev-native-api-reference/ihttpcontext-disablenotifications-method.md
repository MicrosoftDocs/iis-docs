---
title: "IHttpContext::DisableNotifications Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9014508e-a74b-8efe-bde1-426df6728b34
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::DisableNotifications Method
Disables specific notifications that are pending for this request in the current module.  
  
## Syntax  
  
```cpp  
virtual VOID DisableNotifications(  
   IN DWORD dwNotifications,  
   IN DWORD dwPostNotifications  
) = 0;  
```  
  
#### Parameters  
 `dwNotifications`  
 [IN] A `DWORD` that contains a bitmask that specifies the request notifications to disable for this module.  
  
 `dwPostNotifications`  
 [IN] A `DWORD` that contains a bitmask that specifies the post-request notifications to disable for this module.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 You can use the `DisableNotifications` method to specify which notifications or post-request notifications you want to disable for the current request. For example, if a module that you are creating has registered for the [RQ_AUTHENTICATE_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [RQ_AUTHORIZE_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notifications, your module could be configured to ignore the `RQ_AUTHORIZE_REQUEST` notification based on conditions that are processed in the `RQ_AUTHENTICATE_REQUEST` notification.  
  
> [!NOTE]
>  Notifications can be disabled only for the current request and in the current module. The only way to disable notifications that are implemented in other modules would be to return [RQ_NOTIFICATION_FINISH_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md) from your module.  
  
> [!NOTE]
>  Notifications can be disabled only for deterministic events; they cannot be disabled for nondeterministic events. For more information, see [Comparing Native-Code and Managed-Code Notifications](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/comparing-native-code-and-managed-code-notifications.md).  
  
## Example  
 The following example demonstrates how to use the `DisableNotifications` method to create an HTTP module that disables a pending [CHttpModule::OnPostBeginRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onpostbeginrequest-method.md) notification on the current request.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextDisableNotifications#1](IHttpContextDisableNotifications#1)]  -->  
  
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
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetIsLastNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getislastnotification-method.md)   
 [IHttpContext::GetNextNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getnextnotification-method.md)   
 [PFN_REGISTERMODULE Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md)