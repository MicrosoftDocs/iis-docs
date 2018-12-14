---
title: "IHttpContext::GetIsLastNotification Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6e2375e4-264e-ccdb-6fee-3f07d258ca3b
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetIsLastNotification Method
Indicates whether more notifications are pending for this request within the current module host.  
  
## Syntax  
  
```cpp  
virtual BOOL GetIsLastNotification(  
   IN REQUEST_NOTIFICATION_STATUS status  
) = 0;  
```  
  
#### Parameters  
 `status`  
 [IN] A [REQUEST_NOTIFICATION_STATUS](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md) enumeration value.  
  
## Return Value  
 `true` if additional notifications are pending; otherwise, `false`.  
  
## Remarks  
 The `GetIsLastNotification` method retrieves the status of pending notifications for the current request within the current module host. That is, the `GetIsLastNotification` method does not indicate whether additional notifications are pending for another request, or whether additional notifications are pending for a module that is executing in a different module host.  
  
 The value of the `status` parameter directly affects the return value for the `GetIsLastNotification` method. For example, specifying [RQ_NOTIFICATION_CONTINUE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md) may return `true` to indicate that additional notifications are pending, whereas specifying [RQ_NOTIFICATION_FINISH_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md) may return `false` for the same request. This behavior occurs because a status value of `RQ_NOTIFICATION_CONTINUE` will continue to process additional notifications that a status value of `RQ_NOTIFICATION_FINISH_REQUEST` would bypass.  
  
## Example  
 The following code example demonstrates how to use the `GetIsLastNotification` method to create an HTTP module that indicates whether more notifications are pending for the current request. Then module then returns that information to the Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetIsLastNotification#1](IHttpContextGetIsLastNotification#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::DisableNotifications Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-disablenotifications-method.md)   
 [IHttpContext::GetNextNotification Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getnextnotification-method.md)