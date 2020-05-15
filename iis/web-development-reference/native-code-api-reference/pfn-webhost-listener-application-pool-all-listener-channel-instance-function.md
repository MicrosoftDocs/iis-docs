---
title: "PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE Function"
ms.date: "10/07/2016"
ms.assetid: pfn-webhost-listener-application-pool-all-listener-channel-instance-function
---
# PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE Function

Notifies the listener adapter that it is possible to launch other instances of this listener channel.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE)(  
   IN VOID* pContext,  
   IN LPCWSTR AppPoolId,  
   IN DWORD ListenerChannelId  
);  
```  
  
### Parameters  

 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the application pool to which the listener adapter belongs.  
  
 `ListenerChannelId`  
 [IN] A `DWORD` that contains the listener channel ID.  
  
## Return Value  

 `VOID`.  
  
## Remarks  

 The listener adapter should call the [WebhostOpenListenerChannelInstance](../../web-development-reference/native-code-api-reference/webhostopenlistenerchannelinstance-function.md) function to open the initial listener channel when it receives the first request. The listener adapter should not call `WebhostOpenListenerChannelInstance` again until it is notified through this function.  
  
 This notification can be called whenever a new instance of a listener channel can be connected to a worker process. The following are some of the situations in which this notification may occur:  
  
- A Web garden contains processes that can either be launched or that are not currently running the processing code for this listener channel.  
  
- A worker process has idled out and a new one can be launched.  
  
- A non-overlap recycle process has occurred and a new worker process can be launched.  
  
- A worker process has terminated unexpectedly and a new one can be launched.  
  
- The application domain the listener channel was connected to has idled out.  
  
- The application domain was shut down (for any reason); therefore, the listener channel was stopped and can now be restarted.  
  
  The Windows Process Activation Service (WAS) calls this function asynchronously and does not wait for the completion of the notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  

 [Listener Adapter Callback Functions](../../web-development-reference/native-code-api-reference/listener-adapter-callback-functions.md)   
 [WebhostRegisterProtocol Function](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md)
