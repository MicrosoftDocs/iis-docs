---
title: "IHttpResponse2::WriteEntityChunks Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8a7882f2-aa37-4890-b747-57f3a91b46d9
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse2::WriteEntityChunks Method
Appends one or more [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structures to the response body for an asynchronous operation.  
  
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
  
#### Parameters  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse2-interface.md)