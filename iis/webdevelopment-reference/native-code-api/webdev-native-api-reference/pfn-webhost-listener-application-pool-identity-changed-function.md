---
title: "PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1a2d44f9-3eb5-afbc-cd5b-dcaf8f6c33b4
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED Function
Notifies the listener adapter that an application pool identity has changed.  
  
## Syntax  
  
```cpp  
typedef VOID(* FN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED)(  
   IN VOID* pContext,  
   IN LPCWSTR AppPoolId,  
   IN PSID pSID  
);  
```  
  
#### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md).  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the application pool with the changed identity.  
  
 `PSID`  
 [IN] A pointer to a security identifier ([SID](http://go.microsoft.com/fwlink/?LinkId=63529)) value that contains the new identity of the worker processes.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 A listener adapter that is blocking this routine can block all others in the application pool from starting worker processes. The listener adapter does not directly start worker processes (W3wp.exe), but it can trigger their start (when no W3wp.exe file is running for the application pool) by requesting a listener channel for the application pool.  
  
 The Windows Process Activation Service (WAS) does not recycle existing worker processes and start new ones until all listener adapters acknowledge the identity change. If multiple listener adapters are configured for the same application pool, and one of the listener adapters blocks this call, it will prevent the new worker process from starting.  
  
 The WAS calls this function asynchronously and does not wait for the completion of the notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h, Windows.h for `PSID`|  
  
## See Also  
 [Listener Adapter Callback Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-callback-functions.md)   
 [WebhostRegisterProtocol Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md)