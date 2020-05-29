---
title: "PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED Function"
ms.date: "10/07/2016"
ms.assetid: pfn-webhost-listener-application-pool-all-listener-channel-instances-stopped-function
---
# PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED Function
Notifies the listener adapter that all instances of a specific listener channel have been stopped.  
  
## Syntax  
  
```cpp  
typedef VOID(  
   * PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED)(  
   IN VOID* pContext,  
   IN LPCWSTR AppPoolId,  
   IN DWORD ListenerChannelId  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the application pool for the stopped listener channels.  
  
 `ListenerChannelId`  
 [IN] A `DWORD` that contains the listener channel ID for the listener channel that no longer has any instances.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 When the Service Control Manager (SCM) notifies a listener adapter to stop, the listener adapter should wait for the `PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED` notification before stopping; otherwise, if other listener channels are in use, the listener adapter may encounter conflicts when it attempts to restart.  
  
 This notification will occur only if the [WebhostCloseAllListenerChannelInstances](../../web-development-reference/native-code-api-reference/webhostclosealllistenerchannelinstances-function.md) function has been called.  
  
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
