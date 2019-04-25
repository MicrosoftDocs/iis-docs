---
title: "IHttpContext::DisableNotifications Method"
ms.date: "10/07/2016"
ms.assetid: 9014508e-a74b-8efe-bde1-426df6728b34
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
  
### Parameters  
 `dwNotifications`  
 [IN] A `DWORD` that contains a bitmask that specifies the request notifications to disable for this module.  
  
 `dwPostNotifications`  
 [IN] A `DWORD` that contains a bitmask that specifies the post-request notifications to disable for this module.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 You can use the `DisableNotifications` method to specify which notifications or post-request notifications you want to disable for the current request. For example, if a module that you are creating has registered for the [RQ_AUTHENTICATE_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [RQ_AUTHORIZE_REQUEST](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications, your module could be configured to ignore the `RQ_AUTHORIZE_REQUEST` notification based on conditions that are processed in the `RQ_AUTHENTICATE_REQUEST` notification.  
  
> [!NOTE]
>  Notifications can be disabled only for the current request and in the current module. The only way to disable notifications that are implemented in other modules would be to return [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) from your module.  
  
> [!NOTE]
> Notifications can be disabled only for deterministic events; they cannot be disabled for nondeterministic events. For more information, see [Comparing Native-Code and Managed-Code Notifications](../../web-development-reference/native-code-development-overview/comparing-native-code-and-managed-code-notifications.md).  
  
## Example  
 The following example demonstrates how to use the `DisableNotifications` method to create an HTTP module that disables a pending [CHttpModule::OnPostBeginRequest](../../web-development-reference/native-code-api-reference/chttpmodule-onpostbeginrequest-method.md) notification on the current request.  
  
 [!code-cpp[IHttpContextDisableNotifications#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextDisableNotifications/cpp/IHttpContextDisableNotifications.cpp#1)]  
  
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
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetIsLastNotification Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getislastnotification-method.md)   
 [IHttpContext::GetNextNotification Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getnextnotification-method.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)