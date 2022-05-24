---
title: "PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT Function"
description: Learn how the PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT function notifies the listener adapter that the Windows Process Activation Service (WAS) has disconnected.
ms.date: "10/07/2016"
ms.assetid: f0bb001d-e5fe-3e6c-b8b5-6df3baa70d28
---
# PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT Function
Notifies the listener adapter that the Windows Process Activation Service (WAS) has disconnected.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_CONFIG_MANAGER_DISCONNECT)(  
   IN VOID* pContext,  
   IN HRESULT hr  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `hr`  
 [IN] An `HRESULT` error value that indicates the reason the WAS disconnected.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 If the WAS terminates unexpectedly, all current processing typically will fail, and the listener adapter should close all pipes, stop listening, and clear the WAS configuration settings. Once the WAS restarts, it will provide all running listener adapters with new configuration settings. As a result, several listener adapter properties may change, so it is important for the listener adapter to clear its settings in preparation for reconfiguration.  
  
 The WAS calls this function asynchronously and does not wait for the completion of the notification.  
  
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
 [Windows Process Activation Service API Reference](../../web-development-reference/native-code-api-reference/windows-process-activation-service-api-reference.md)
