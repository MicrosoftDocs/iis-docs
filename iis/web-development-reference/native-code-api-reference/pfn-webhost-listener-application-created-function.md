---
title: "PFN_WEBHOST_LISTENER_APPLICATION_CREATED Function"
ms.date: "10/07/2016"
ms.assetid: feca9299-f97b-e8e8-e296-9a98b2ab6eed
---
# PFN_WEBHOST_LISTENER_APPLICATION_CREATED Function
Notifies the listener adapter that an application configured for the listener associated with this listener adapter has been created. The listener adapter can choose whether to configure this application with the listener.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_APPLICATION_CREATED)(  
   IN VOID* pContext,  
   IN LPCWSTR AppKey,  
   IN LPCWSTR Path,  
   IN DWORD SiteId,  
   IN LPCWSTR AppPoolId,  
   IN PBYTE Bindings,  
   IN DWORD NumberOfBindings,  
   IN BOOL RequestsBlocked  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppKey`  
 [IN] A pointer to a string that contains the key for finding the application domain.  
  
 `Path`  
 [IN] A pointer to a string that contains the URL minus the bindings.  
  
 `SiteId`  
 [IN] A `DWORD` that contains the site identifier under which the application runs.  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the application pool to which this application should be routed.  
  
 `Bindings`  
 [IN] A pointer to a `BYTE` value that contains a collection of binding information that is used with the path to make up the URLs for this application.  
  
 `NumberOfBindings`  
 [IN] A `DWORD` that contains the number of bindings in the `Bindings` parameter.  
  
 `RequestsBlocked`  
 [IN] `true` to notify the listener adapter to listen on this application but not process requests on an unsupported protocol; `false` to send requests to parent applications when the child does not support the protocol.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 You should save the `AppKey` parameter with the application so it can be passed to the process protocol handler. The process protocol handler will inform the protocol manager to launch the application domain specified in `AppKey.`  
  
 `PBYTE` is declared in the WinDef.h header file.  
  
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