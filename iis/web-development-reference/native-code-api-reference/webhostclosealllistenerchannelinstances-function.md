---
title: "WebhostCloseAllListenerChannelInstances Function"
ms.date: "10/07/2016"
ms.assetid: f8fbf5d5-83ce-0e07-15fd-cf40174ea7bd
---
# WebhostCloseAllListenerChannelInstances Function
Requests all instances of this listener channel to stop.  
  
## Syntax  
  
```cpp  
HRESULT WebhostCloseAllListenerChannelInstances(  
   IN DWORD ProtocolHandle,  
   IN LPCWSTR AppPoolId,  
   IN DWORD ListenerChannelId  
);  
```  
  
### Parameters  
 `ProtocolHandle`  
 [IN] A `DWORD` that contains the protocol handle that represents the protocol for this listener channel.  
  
 `AppPoolId`  
 [IN] A string that contains the application pool ID for this listener channel.  
  
 `ListenerChannelId`  
 [IN] A `DWORD` that contains the listener channel ID that the listener adapter has requested to stop.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that one of the parameters is not valid.|  
|HRESULT_FROM_WIN32( ERROR_NOT_FOUND)|Indicates that the protocol has not been registered.|  
|HRESULT_FROM_WIN32(ERROR_PIPE_NOT_CONNECTED)|Indicates that the listener adapter is not connected to the Windows Process Activation Service.|  
  
## Remarks  
 Calling this function with no listener channels running does not return an error code.  
  
 This function is called under the following conditions:  
  
- The listener adapter service is stopping.  
  
- The listener adapter is routing by application, and the application is being deleted.  
  
- The application pool is being deleted.  
  
- The listener adapter is routing by application, and the application is moving to another application pool.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Exported Functions](../../web-development-reference/native-code-api-reference/listener-adapter-exported-functions.md)   
 [PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED Function](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-all-listener-channel-instances-stopped-function.md)
