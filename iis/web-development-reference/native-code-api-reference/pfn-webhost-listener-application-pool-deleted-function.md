---
title: "PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 22e77a24-aaca-c593-c46f-cbbe073e1b4a
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED Function
Notifies the listener adapter that the application pool has been deleted from its view.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_APPLICATION_POOL_DELETED)(  
   IN VOID* pContext,  
   IN LPCWSTR AppPoolId  
);  
```  
  
#### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference\webdev-native-api-reference/webhostregisterprotocol-function.md).  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the application pool that has been deleted from the listener adapter's view.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The application pool can be deleted from the listener adapter's view if the Windows Process Activation Service (WAS) no longer has any applications that use this application pool, or the WAS is not tracking any more listener channels for this pool. The WAS tracks listener channels that are connected to a worker process and listener channels that it has not notified the listener adapter to start (for example, when the application pool is disabled).  
  
 All applications in the pool should be either deleted or notified to move to another application pool before the WAS stops tracking all listener channels for the application pool. As each application exits or moves to another application pool, the listener adapter notifies the WAS to stop tracking their listener channels. Once the WAS has no listener channels to track for the application pool, this notification is called.  
  
 The WAS calls this function asynchronously and does not wait for the completion of the notification.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Listeneradapter.h|  
  
## See Also  
 [Listener Adapter Callback Functions](../../web-development-reference\webdev-native-api-reference/listener-adapter-callback-functions.md)