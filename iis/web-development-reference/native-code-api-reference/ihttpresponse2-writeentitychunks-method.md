---
title: "IHttpResponse2::WriteEntityChunks Method"
ms.date: "10/07/2016"
ms.assetid: 8a7882f2-aa37-4890-b747-57f3a91b46d9
---
# IHttpResponse2::WriteEntityChunks Method
Appends one or more [HTTP_DATA_CHUNK](https://go.microsoft.com/fwlink/?LinkId=56011) structures to the response body for an asynchronous operation.  
  
## Syntax  
  
```cpp  
virtual HRESULT WriteEntityChunks(  
   _In_reads_(nChunks)  
   HTTP_DATA_CHUNK *               pDataChunks,  
   _In_  DWORD                     nChunks,  
   _In_  BOOL                      fAsync,  
   _In_  BOOL                      fMoreData,  
   _In_  PFN_ASYNC_COMPLETION      pfnCompletionCallback,  
   _In_  VOID *                    pvCompletionContext,  
   _Out_ DWORD *                   pcbSent,  
   _Out_ BOOL *                    pfCompletionExpected = NULL  
) = 0;  
```  
  
### Parameters  
 `pDataChunks`  
 [IN] A pointer to one or more `HTTP_DATA_CHUNK` structures.  
  
 `nChunks`  
 [IN] Number of chunks pointed to by `pDataChunks`.  
  
 `fAsync`  
 [IN] `true` if the method should complete asynchronously; otherwise, `false`.  
  
 `fMoreData`  
 [IN] `true` if more data is to be sent in the response; `false` if this is the last data.  
  
 `pfnCompletionCallback`  
 [IN] Pointer to a callback function for completing the operation.  
  
 `pvCompletionContext`  
 [IN] Points to the completion context information for the operation.  
  
 `pcbSent`  
 [OUT] Number of bytes sent to the client.  
  
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
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse2 Interface](../../web-development-reference\native-code-api-reference/ihttpresponse2-interface.md)