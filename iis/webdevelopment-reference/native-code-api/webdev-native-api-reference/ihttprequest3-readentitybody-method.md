---
title: "IHttpRequest3::ReadEntityBody Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4ae5283e-43eb-4f0c-9f42-a40c9e2bf317
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest3::ReadEntityBody Method
Reads the request results into a specified buffer.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReadEntityBody(  
   _Out_writes_bytes_all_(cbBuffer)  
   VOID *                          pvBuffer,  
   _In_     DWORD                  cbBuffer,  
   _In_     BOOL                   fAsync,  
   _In_     PFN_ASYNC_COMPLETION   pfnCompletionCallback,  
   _In_     VOID *                 pvCompletionContext,  
   _Out_    DWORD *                pcbBytesReceived,  
   _Out_    BOOL *                 pfCompletionPending = NULL  
) = 0;  
```  
  
#### Parameters  
 `pvBuffer`  
 [OUT] A pointer to a buffer that receives the request body.  
  
 `cbBuffer`  
 [IN] The size, in bytes, of the buffer pointed to by `pvBuffer`.  
  
 `fAsync`  
 [IN] `true` to complete the operation asynchronously; otherwise, `false`.  
  
 `pfnCompletionCallback`  
 [IN] Pointer to a callback function for completing the operation.  
  
 `pvCompletionContext`  
 [IN] Points to the completion context information for the operation.  
  
 `pcbBytesReceived`  
 [OUT] Number of bytes received in `pvBuffer`.  
  
 `pfCompletionPending`  
 [OUT] `true` if completion is pending; otherwise `false`.  
  
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
 [IHttpRequest3](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest3-readentitybody-method.md)