---
title: "IWebSocketContext::SendConnectionClose Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e2870934-24f9-4e42-a9eb-affe437eccc6
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# IWebSocketContext::SendConnectionClose Method
Signals the close of a WebSocket connection.  
  
## Syntax  
  
```cpp  
virtual HRESULT SendConnectionClose(  
   _In_ BOOL fAsync,  
   _In_ USHORT* pStatusCode = NULL,  
   _In_ LPCWSTR pszReason = NULL,  
   _In_ PFN_WEBSOCKET_COMPLETION pfnCompletion = NULL,  
   _In_ VOID* pvCompletionContext = NULL,  
   _Out_ BOOL* pfCompletionExpected = NULL  
) = 0;  
```  
  
#### Parameters  
 `fAsync`  
 [IN] `true` if the method should complete asynchronously; otherwise, `false`.  
  
 `pStatusCode`  
 [IN] Points to the status code for the connection.  
  
 `pszReason`  
 [IN] Points to the reason text for the status.  
  
 `pfnCompletion`  
 [IN] Points to the function that will complete the operation.  
  
 `pvCompletionContext`  
 [IN] Points to the completion context information for the operation.  
  
 `pfCompletionExpected`  
 [OUT] `true` if an asynchronous completion is pending for this call; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Iiswebsocket.h|  
  
## See Also  
 [IWebSocketContext Interface](../../web-development-reference\webdev-native-api-reference/iwebsocketcontext-interface.md)