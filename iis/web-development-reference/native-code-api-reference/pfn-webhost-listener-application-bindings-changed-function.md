---
title: "PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED Function"
description: Learn how the PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED function notifies the listener adapter that the bindings for a particular application have changed. 
ms.date: "10/07/2016"
ms.assetid: 118d5eb3-05f8-340b-a6b2-3c0dcdb0594a
---
# PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED Function
Notifies the listener adapter that the bindings for a particular application have changed.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_APPLICATION_BINDINGS_CHANGED)(  
   IN VOID* pContext,  
   IN LPCWSTR AppKey,  
   IN PBYTE Bindings,  
   IN DWORD NumberOfBindings  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppKey`  
 [IN] A pointer to a string that contains the name of the application.  
  
 `Bindings`  
 [IN] A pointer to a `BYTE` value that contains the new bindings.  
  
 `NumberOfBindings`  
 [IN] A `DWORD` that contains the number of bindings in the `Bindings` parameter.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 There are a number of ways that the bindings for an application can change. The listener adapter can release old endpoints, create new endpoints and connect them to existing listener channels, or close existing listener channels and create new ones.  
  
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
