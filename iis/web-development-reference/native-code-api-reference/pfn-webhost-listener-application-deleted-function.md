---
title: "PFN_WEBHOST_LISTENER_APPLICATION_DELETED Function"
ms.date: "10/07/2016"
ms.assetid: 48bb404c-cee5-574f-652f-068666f12571
---
# PFN_WEBHOST_LISTENER_APPLICATION_DELETED Function
Notifies the listener adapter that the application is no longer active for a protocol.  
  
## Syntax  
  
```cpp  
typedef VOID(  
   * PFN_WEBHOST_LISTENER_APPLICATION_DELETED)(IN VOID* pContext,  
   IN LPCWSTR AppKey  
);  
```  
  
### Parameters  
 `pContext`  
 [IN] A pointer to a `VOID` context that the listener adapter passed to [WebhostRegisterProtocol](../../web-development-reference/native-code-api-reference/webhostregisterprotocol-function.md).  
  
 `AppKey`  
 [IN] A pointer to a string that contains the name of the application.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The listener adapter will get this call when the application is deleted or when all applications for the site no longer use this protocol.  
  
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
