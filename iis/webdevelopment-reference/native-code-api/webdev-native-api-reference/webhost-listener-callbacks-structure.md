---
title: "WEBHOST_LISTENER_CALLBACKS Structure | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e8978941-3c73-cf7f-c3eb-3375e7d12b85
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# WEBHOST_LISTENER_CALLBACKS Structure
Defines a pointer to the callback structure that is passed to the [WebhostRegisterProtocol](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md) function.  
  
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
|`pfnWebhostListenerConfigManagerConnected`|A pointer to a [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-connected-function.md) function.|  
|`pfnWebhostListenerConfigManagerDisconnected`|A pointer to a [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-disconnect-function.md) function.|  
|`pfnWebhostListenerConfigManagerInitializationCompleted`|A pointer to a [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md) function.|  
|`pfnWebhostListenerApplicationPoolCreated`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-created-function.md) function.|  
|`pfnWebhostListenerApplicationPoolDeleted`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-deleted-function.md) function.|  
|`pfnWebhostListenerApplicationPoolIdentityChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-identity-changed-function.md) function.|  
|`pfnWebhostListenerApplicationPoolStateChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_STATE_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-state-changed-function.md) function.|  
|`pfnWebhostListenerApplicationPoolCanOpenNewListenerChannelInstance`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/33178979-1e15-46c9-f704-c8b44ffc4e51.md) function.|  
|`pfnWebhostListenerApplicationPoolAllListenerChannelInstancesStopped`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/a86ad76a-d123-3b43-c3a1-c43698b68b38.md) function.|  
|`pfnWebhostListenerApplicationCreated`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_CREATED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-created-function.md) function.|  
|`pfnWebhostListenerApplicationDeleted`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_DELETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-deleted-function.md) function.|  
|`pfnWebhostListenerApplicationBindingsChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-bindings-changed-function.md) function.|  
|`pfnWebhostListenerApplicationAppPoolChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_APP_POOL_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-app-pool-changed-function.md) function.|  
|`pfnWebhostListenerApplicationRequestsBlockedChanged`|A pointer to a [PFN_WEBHOST_LISTENER_APPLICATION_REQUESTS_BLOCKED_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-requests-blocked-changed-function.md) function.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Structures](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-structures.md)   
 [WebhostRegisterProtocol Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md)