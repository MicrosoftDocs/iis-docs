---
title: "IWebSocketContext::WriteFragment Method"
ms.date: "10/07/2016"
ms.assetid: 26d0aad9-adfb-4db9-83b0-d8dd936c1dbc
---
# IWebSocketContext::WriteFragment Method
Writes a data fragment to an asynchronous connection.  
  
## Syntax  
  
```cpp  
virtual HRESULT WriteFragment(  
   _In_ VOID* pData,  
   _Inout_ DWORD* pcbSent,  
   _In_ BOOL fAsync,  
   _In_ BOOL fUTF8Encoded,  
   _In_ BOOL fFinalFragment,  
   _In_ PFN_WEBSOCKET_COMPLETION pfnCompletion = NULL,  
   _In_ VOID* pvCompletionContext = NULL,  
   _Out_ BOOL* pfCompletionExpected = NULL  
) = 0;  
```  
  
### Parameters  
 `pData`  
 [IN] Data fragment to write.  
  
 `pcbSent`  
 [IN][OUT] Number of bytes sent to the client.  
  
 `fAsync`  
 [IN] `true` if the method should complete asynchronously; otherwise, `false`.  
  
 `fUTF8Encoded`  
 [IN] `true` if the data is Unicode (UTF-8) encoded; otherwise, `false`.  
  
 `fFinalFragment`  
 [IN] `true` if this is the final data fragment to write; otherwise `false`.  
  
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
 [IWebSocketContext Interface](../../web-development-reference/native-code-api-reference/iwebsocketcontext-interface.md)
