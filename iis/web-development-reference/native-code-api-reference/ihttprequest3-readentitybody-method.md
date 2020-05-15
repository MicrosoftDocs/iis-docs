---
title: "IHttpRequest3::ReadEntityBody Method"
ms.date: "10/07/2016"
ms.assetid: 4ae5283e-43eb-4f0c-9f42-a40c9e2bf317
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
  
### Parameters  

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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpRequest3](../../web-development-reference/native-code-api-reference/ihttprequest3-readentitybody-method.md)
