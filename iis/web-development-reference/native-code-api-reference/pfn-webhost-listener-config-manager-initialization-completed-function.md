---
title: "PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED Function"
ms.date: "10/07/2016"
ms.assetid: cb801a1f-1c2e-e4f0-04be-c288dbd77447
---
# PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED Function

Notifies the listener adapter that the Windows Process Activation Service (WAS) has completed passing all configuration information.  
  
## Syntax  
  
```cpp  
typedef VOID(  
   * PFN_WEBHOST_LISTENER_CONFIG_MANAGER_INITIALIZATION_COMPLETED  
)(IN VOID* pContext);  
```  
  
### Parameters  

 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
## Return Value  

 `VOID`.  
  
## Remarks  

 This call marks the point after which a listener adapter should activate listening and begin processing requests. If the listener adapter processes requests prior to this call, it will have incomplete configuration information and could misroute requests. This call also notifies the listener adapter that the service status can be set to [SERVICE_RUNNING](https://go.microsoft.com/fwlink/?LinkId=63964). After this function is called, no more configuration data will be passed until the listener adapter is notified by a change-notification callback function.  
  
 The WAS calls this function asynchronously and does not wait for the completion of this notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  

 [Listener Adapter Callback Functions](../../web-development-reference/native-code-api-reference/listener-adapter-callback-functions.md)
