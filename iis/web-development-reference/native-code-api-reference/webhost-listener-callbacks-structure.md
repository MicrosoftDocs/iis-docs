---
title: "WEBHOST_LISTENER_CALLBACKS Structure"
ms.date: "10/07/2016"
ms.assetid: e8978941-3c73-cf7f-c3eb-3375e7d12b85
---
# WEBHOST_LISTENER_CALLBACKS Structure
Defines a pointer to the callback structure that is passed to the [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md) function.  
  
## Syntax  
  
```cpp  
struct WEBHOST_LISTENER_CALLBACKS{  
   DWORD dwBytesInCallbackStructure;  
   PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED pfnWebhostListenerConfigManagerConnected;  
   PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT pfnWebhostListenerConfigManagerDisconnected;  
   PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED pfnWebhostListenerConfigManagerInitializationCompleted;  
   PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED pfnWebhostListenerApplicationPoolCreated;  
   PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED pfnWebhostListenerApplicationPoolDeleted;  
   PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED pfnWebhostListenerApplicationPoolIdentityChanged;  
   PFN_WEBHOST_LISTENER_APPLICATION_POOL_STATE_CHANGED pfnWebhostListenerApplicationPoolStateChanged;  
   PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE pfnWebhostListenerApplicationPoolCanOpenNewListenerChannelInstance;  
   PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED pfnWebhostListenerApplicationPoolAllListenerChannelInstancesStopped;  
   PFN_WEBHOST_LISTENER_APPLICATION_CREATED pfnWebhostListenerApplicationCreated;  
   PFN_WEBHOST_LISTENER_APPLICATION_DELETED pfnWebhostListenerApplicationDeleted;  
   PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED pfnWebhostListenerApplicationBindingsChanged;  
   PFN_WEBHOST_LISTENER_APPLICATION_APP_POOL_CHANGED pfnWebhostListenerApplicationAppPoolChanged;  
   PFN_WEBHOST_LISTENER_APPLICATION_REQUESTS_BLOCKED_CHANGED pfnWebhostListenerApplicationRequestsBlockedChanged;  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`dwBytesInCallbackStructure`|A `DWORD` that contains the number of bytes in the structure.|  
|`pfnWebhostListenerConfigManagerConnected`|A pointer to a [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-connected-function.md) function.|  
|`pfnWebhostListenerConfigManagerDisconnected`|A pointer to a [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-disconnect-function.md) function.|  
|`pfnWebhostListenerConfigManagerInitializationCompleted`|A pointer to a [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md) function.|  
|`pfnWebhostListenerApplicationPoolCreated`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-created-function.md) function.|  
|`pfnWebhostListenerApplicationPoolDeleted`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-deleted-function.md) function.|  
|`pfnWebhostListenerApplicationPoolIdentityChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-identity-changed-function.md) function.|  
|`pfnWebhostListenerApplicationPoolStateChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_STATE_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-state-changed-function.md) function.|  
|`pfnWebhostListenerApplicationPoolCanOpenNewListenerChannelInstance`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-all-listener-channel-instance-function.md) function.|  
|`pfnWebhostListenerApplicationPoolAllListenerChannelInstancesStopped`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-all-listener-channel-instances-stopped-function.md) function.|  
|`pfnWebhostListenerApplicationCreated`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_CREATED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-created-function.md) function.|  
|`pfnWebhostListenerApplicationDeleted`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_DELETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-deleted-function.md) function.|  
|`pfnWebhostListenerApplicationBindingsChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-bindings-changed-function.md) function.|  
|`pfnWebhostListenerApplicationAppPoolChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_APP_POOL_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-app-pool-changed-function.md) function.|  
|`pfnWebhostListenerApplicationRequestsBlockedChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_REQUESTS_BLOCKED_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-requests-blocked-changed-function.md) function.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Structures](../../web-development-reference/native-code-api-reference/listener-adapter-structures.md)   
 [WebhostRegisterProtocol Function](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md)