---
title: "Listener Adapter Callback Functions | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7e786e2b-c8a6-42d0-9aaa-572e7d19b30d
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
---
# Listener Adapter Callback Functions
This section describes the functions that support listener adapter callbacks, which enable the Windows Process Activation Service (WAS) to communicate information to a listener adapter.  
  
## In This Section  
  
|Function|Description|  
|--------------|-----------------|  
|[PFN_WEBHOST_LISTENER_APPLICATION_APP_POOL_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-app-pool-changed-function.md)|Notifies the listener adapter that the application pool for a particular application has changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-bindings-changed-function.md)|Notifies the listener adapter that the bindings for a particular application have changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_CREATED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-created-function.md)|Notifies the listener adapter that an application configured for the listener associated with this listener adapter has been created.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_DELETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-deleted-function.md)|Notifies the listener adapter that the application is no longer active for a protocol.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/a86ad76a-d123-3b43-c3a1-c43698b68b38.md)|Notifies the listener adapter that all instances of a particular listener channel have been stopped.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/33178979-1e15-46c9-f704-c8b44ffc4e51.md)|Notifies the listener adapter that it is possible to launch other instances of this listener channel.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-created-function.md)|Notifies the listener adapter that the application pool configured to receive messages has been created.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-deleted-function.md)|Notifies the listener adapter that the application pool has been deleted from its view.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-identity-changed-function.md)|Notifies the listener adapter that an application pool identity has changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_STATE_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-pool-state-changed-function.md)|Notifies the listener adapter that the state of an application pool has changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_REQUESTS_BLOCKED_CHANGED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-application-requests-blocked-changed-function.md)|Notifies the listener adapter that the requests-blocked state has changed.|  
|[PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-connected-function.md)|Notifies the listener adapter that the [WebhostRegisterProtocol](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md) function call was successful and the configuration manager has connected.|  
|[PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-disconnect-function.md)|Notifies the listener adapter that the Windows Process Activation Service (WAS) has disconnected.|  
|[PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md)|Notifies the listener adapter that the Windows Process Activation Service (WAS) has completed passing all configuration information.|  
  
## Reference  
 [IIS Development](../Topic/Internet%20Information%20Services%20Development.md)  
  
 [Listener Adapter API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-api-reference.md)