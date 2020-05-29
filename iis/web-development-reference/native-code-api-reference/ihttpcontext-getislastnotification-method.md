---
title: "IHttpContext::GetIsLastNotification Method"
ms.date: "10/07/2016"
ms.assetid: 6e2375e4-264e-ccdb-6fee-3f07d258ca3b
---
# IHttpContext::GetIsLastNotification Method
Indicates whether more notifications are pending for this request within the current module host.  
  
## Syntax  
  
```cpp  
virtual BOOL GetIsLastNotification(  
   IN REQUEST_NOTIFICATION_STATUS status  
) = 0;  
```  
  
### Parameters  
 `status`  
 [IN] A [REQUEST_NOTIFICATION_STATUS](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) enumeration value.  
  
## Return Value  
 `true` if additional notifications are pending; otherwise, `false`.  
  
## Remarks  
 The `GetIsLastNotification` method retrieves the status of pending notifications for the current request within the current module host. That is, the `GetIsLastNotification` method does not indicate whether additional notifications are pending for another request, or whether additional notifications are pending for a module that is executing in a different module host.  
  
 The value of the `status` parameter directly affects the return value for the `GetIsLastNotification` method. For example, specifying [RQ_NOTIFICATION_CONTINUE](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) may return `true` to indicate that additional notifications are pending, whereas specifying [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) may return `false` for the same request. This behavior occurs because a status value of `RQ_NOTIFICATION_CONTINUE` will continue to process additional notifications that a status value of `RQ_NOTIFICATION_FINISH_REQUEST` would bypass.  
  
## Example  
 The following code example demonstrates how to use the `GetIsLastNotification` method to create an HTTP module that indicates whether more notifications are pending for the current request. Then module then returns that information to the Web client.  
  
 [!code-cpp[IHttpContextGetIsLastNotification#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetIsLastNotification/cpp/IHttpContextGetIsLastNotification.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::DisableNotifications Method](../../web-development-reference/native-code-api-reference/ihttpcontext-disablenotifications-method.md)   
 [IHttpContext::GetNextNotification Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getnextnotification-method.md)
