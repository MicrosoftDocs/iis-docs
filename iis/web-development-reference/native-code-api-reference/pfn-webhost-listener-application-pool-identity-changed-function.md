---
title: "PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED Function"
ms.date: "10/07/2016"
ms.assetid: 1a2d44f9-3eb5-afbc-cd5b-dcaf8f6c33b4
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
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the application pool with the changed identity.  
  
 `PSID`  
 [IN] A pointer to a security identifier ([SID](https://go.microsoft.com/fwlink/?LinkId=63529)) value that contains the new identity of the worker processes.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 A listener adapter that is blocking this routine can block all others in the application pool from starting worker processes. The listener adapter does not directly start worker processes (W3wp.exe), but it can trigger their start (when no W3wp.exe file is running for the application pool) by requesting a listener channel for the application pool.  
  
 The Windows Process Activation Service (WAS) does not recycle existing worker processes and start new ones until all listener adapters acknowledge the identity change. If multiple listener adapters are configured for the same application pool, and one of the listener adapters blocks this call, it will prevent the new worker process from starting.  
  
 The WAS calls this function asynchronously and does not wait for the completion of the notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h, Windows.h for `PSID`|  
  
## See Also  
 [Listener Adapter Callback Functions](../../web-development-reference/native-code-api-reference/listener-adapter-callback-functions.md)   
 [WebhostRegisterProtocol Function](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md)