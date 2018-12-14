---
title: "PFN_WEBHOST_LISTENER_APPLICATION_CREATED Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: feca9299-f97b-e8e8-e296-9a98b2ab6eed
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md).  
  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Callback Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/listener-adapter-callback-functions.md)   
 [WebhostRegisterProtocol Function](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/webhostregisterprotocol-function.md)