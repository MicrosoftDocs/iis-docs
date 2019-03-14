---
title: "IWebSocketContext::ReadFragment Method"
ms.date: "10/07/2016"
ms.assetid: d994bce0-d3e4-4cc5-b2b6-fbd68d974b0b
---
# IWebSocketContext::ReadFragment Method
Reads a data fragment from an asynchronous connection.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReadFragment(  
   _Out_ VOID* pData,  
   _Inout_ DWORD* pcbData,  
   _In_ BOOL fAsync,  
   _Out_ BOOL* pfUTF8Encoded,  
   _Out_ BOOL* pfFinalFragment,  
   _Out_ BOOL* pfConnectionClose,  
   _In_ PFN_WEBSOCKET_COMPLETION pfnCompletion = NULL,   _In_ VOID* pvCompletionContext = NULL,  
   _Out_ BOOL* pfCompletionExpected = NULL  
) = 0;  
```  
  
### Parameters  
 `pData`  
 [OUT] Data fragment that was read.  
  
 `pcbData`  
 [IN][OUT] Number of bytes in the data fragment.  
  
 `fAsync`  
 [IN] `true` if the method should complete asynchronously; otherwise, `false`.  
  
 `pfUTF8Encoded`  
 [OUT] `true` if the data is Unicode (UTF-8) encoded; otherwise, `false`.  
  
 `pfFinalFragment`  
 [OUT] `true` if this is the final data fragment; otherwise `false`.  
  
 `pfConnectionClose`  
 [OUT] `true` if the connection will close; otherwise `false`.  
  
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