---
title: "PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED Function"
ms.date: "10/07/2016"
ms.assetid: 02dd9317-b412-da4e-9744-723c85b06cc7
---
# PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED Function
Notifies the listener adapter that the [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md) function call was successful and the configuration manager has connected.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_CONFIG_MANAGER_CONNECTED )(  
  IN VOID* pContext  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to `WebhostRegisterProtocol`.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 This is the first callback function invoked by the client library. After this call, the listener adapter should set up the listener to wait on incoming requests.  
  
 You should set a time-out for the listener adapter to wait for this callback function. If the time-out expires, you should stop the listener adapter service and mark it as failed.  
  
 The listener adapter should be in a clean state (no configuration information set) when it receives this call.  
  
 You should not set the listener service status to [SERVICE_RUNNING](https://go.microsoft.com/fwlink/?LinkId=63964) from this callback function. You should set the service status to SERVICE_RUNNING only when initialization is complete and the protocol listener is listening (typically after the [PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED](../../web-development-reference/native-code-api-reference/pfn-webhost-listener-config-manager-initialization-completed-function.md) notification).  
  
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
