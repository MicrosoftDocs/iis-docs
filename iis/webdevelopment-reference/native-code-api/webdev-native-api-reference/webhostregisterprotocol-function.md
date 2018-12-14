---
title: "WebhostRegisterProtocol Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 85ff51f6-ffcc-ff2c-1bbf-0b7fc3a556a8
caps.latest.revision: 16
author: "shirhatti"
manager: "wpickett"
---
# WebhostRegisterProtocol Function
Declares the protocol that the listener adapter supports.  
  
## Syntax  
  
```cpp  
HRESULT WebhostRegisterProtocol(  
   IN LPCWSTR ProtocolId,  
   IN VOID* pListenerCallbacks,  
   IN VOID* pContext,  
   OUT DWORD* pProtocolHandle  
);  
```  
  
#### Parameters  
 `ProtocolId`  
 [IN] A string that contains the protocol that this listener adapter supports.  
  
 `pListenerCallbacks`  
 [IN] A `VOID` pointer to the [WEBHOST_LISTENER_CALLBACKS](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhost-listener-callbacks-structure.md) structure.  
  
 `pContext`  
 [IN] An arbitrary `VOID` pointer that the listener adapter will pass.  
  
 `pProtocolHandle`  
 [OUT] A pointer to a `DWORD` that contains the process-unique key that represents this protocol.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|HRESULT_FROM_WIN32( ERROR_ALREADY_EXISTS )|Indicates there is already a listener adapter registered in this process for this protocol.|  
|E_INVALIDARG|Indicates that one of the parameters is not valid.|  
|E_OUTOFMEMORY|Indicates that heap memory is exhausted.|  
  
## Remarks  
 You must call the `WebhostRegisterProtocol` function first when you start a listener adapter. `WebhostRegisterProtocol` is asynchronous, so a successful return does not guarantee that the call was successful. The Windows Process Activation Service (WAS) notifies the listener of successful registration by using the [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-connected-function.md) function. `PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED` is passed in the `pListenerCallbacks` parameter to this call.  
  
 You should set a time-out for the listener adapter to wait for the `PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED` callback function. If the time-out expires, you should stop the listener adapter service and mark it as failed. A successful return from this call indicates that the client library is waiting for the Windows Process Activation Service and will connect when possible.  
  
 You should not set the listener service status to [SERVICE_RUNNING](http://go.microsoft.com/fwlink/?LinkId=63964) from this callback function. You should set the service status to SERVICE_RUNNING only when initialization is complete and the protocol listener is listening (typically after the [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md) notification).  
  
 The `pContext` parameter is passed to the listener adapter whenever a callback function is invoked. It can be used when multiple protocols that use the same callback structure are implemented.  
  
 For the client library to connect to the Windows Process Activation Service, the following conditions must be met:  
  
-   The `<listenerAdapters>` configuration section in the Was.config file must declare the protocol and the identity under which the listener adapters will be running.  
  
-   The Windows Process Activation Service must be running.  
  
-   Listener adapter services should register as dependent on the Windows Process Activation Service.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md)   
 [Listener Adapter Exported Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-exported-functions.md)