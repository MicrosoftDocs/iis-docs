---
title: "Listener Adapter Callback Functions"
ms.date: "10/07/2016"
ms.assetid: 7e786e2b-c8a6-42d0-9aaa-572e7d19b30d
---
# Listener Adapter Callback Functions

This section describes the functions that support listener adapter callbacks, which enable the Windows Process Activation Service (WAS) to communicate information to a listener adapter.  
  
## In This Section  
  
|Function|Description|  
|--------------|-----------------|  
|[PFN_WEBHOST_LISTENER_APPLICATION_APP_POOL_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-app-pool-changed-function.md)|Notifies the listener adapter that the application pool for a particular application has changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-bindings-changed-function.md)|Notifies the listener adapter that the bindings for a particular application have changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_CREATED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-created-function.md)|Notifies the listener adapter that an application configured for the listener associated with this listener adapter has been created.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_DELETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-deleted-function.md)|Notifies the listener adapter that the application is no longer active for a protocol.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_ALL_LISTENER_CHANNEL_INSTANCES_STOPPED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-all-listener-channel-instances-stopped-function.md)|Notifies the listener adapter that all instances of a particular listener channel have been stopped.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_CAN_OPEN_NEW_LISTENER_CHANNEL_INSTANCE](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-all-listener-channel-instance-function.md)|Notifies the listener adapter that it is possible to launch other instances of this listener channel.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-created-function.md)|Notifies the listener adapter that the application pool configured to receive messages has been created.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-deleted-function.md)|Notifies the listener adapter that the application pool has been deleted from its view.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_IDENTITY_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-identity-changed-function.md)|Notifies the listener adapter that an application pool identity has changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_POOL_STATE_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-pool-state-changed-function.md)|Notifies the listener adapter that the state of an application pool has changed.|  
|[PFN_WEBHOST_LISTENER_APPLICATION_REQUESTS_BLOCKED_CHANGED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-application-requests-blocked-changed-function.md)|Notifies the listener adapter that the requests-blocked state has changed.|  
|[PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-connected-function.md)|Notifies the listener adapter that the [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md) function call was successful and the configuration manager has connected.|  
|[PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-disconnect-function.md)|Notifies the listener adapter that the Windows Process Activation Service (WAS) has disconnected.|  
|[PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md)|Notifies the listener adapter that the Windows Process Activation Service (WAS) has completed passing all configuration information.|  
  
## Reference  

 [IIS Development](https://msdn.microsoft.com/library/6c07a4d0-1bf0-45d3-8178-25df76e6740c)  
  
 [Listener Adapter API Reference](../../web-development-reference/native-code-api-reference/listener-adapter-api-reference.md)
