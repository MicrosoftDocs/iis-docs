---
title: "PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED Function"
ms.date: "10/07/2016"
ms.assetid: 21449350-c524-5a19-6847-698f4f353a38
---
# PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED Function
Notifies the listener adapter that the application pool configured to receive messages has been created.  
  
## Syntax  
  
```cpp  
typedef VOID(* PFN_WEBHOST_LISTENER_APPLICATION_POOL_CREATED)(  
   IN VOID* pContext,  
   IN LPCWSTR AppPoolId,  
   IN PSID pSID  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppPoolId`  
 [IN] A pointer to a string that contains the name of the application pool where messages should be routed  
  
 `PSID`  
 [IN] A pointer to a security identifier ([SID](https://go.microsoft.com/fwlink/?LinkId=63529)) of the worker process that will support this application pool.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 You will need to set the listener adapter's access control lists (ACLs) to the identity of the worker process for the worker process to use them. For example, if the listener channel is going to be a named pipe, you will need to set the listener adapter's ACLs for the named pipe so the worker process can open it.  
  
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