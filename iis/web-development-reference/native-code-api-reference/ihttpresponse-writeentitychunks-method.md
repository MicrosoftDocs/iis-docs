---
title: "IHttpResponse::WriteEntityChunks Method"
ms.date: "10/07/2016"
ms.assetid: e511b4dc-b775-3d48-f850-a3178ae6bd17
---
# IHttpResponse::WriteEntityChunks Method
Appends one or more [HTTP_DATA_CHUNK](https://go.microsoft.com/fwlink/?LinkId=56011) structures to the response body.  
  
## Syntax  
  
```cpp  
virtual HRESULT WriteEntityChunks(  
   IN HTTP_DATA_CHUNK* pDataChunks,  
   IN DWORD nChunks,  
   IN BOOL fAsync,  
   IN BOOL fMoreData,  
   OUT DWORD* pcbSent,  
   OUT BOOL* pfCompletionExpected = NULL  
) = 0;  
```  
  
### Parameters  
 `pDataChunks`  
 [IN] A pointer to one or more `HTTP_DATA_CHUNK` structures.  
  
 `nChunks`  
 [IN] A `DWORD` that contains the number of chunks pointed to by `pDataChunks`.  
  
 `fAsync`  
 [IN] `true` if the method should complete asynchronously; otherwise, `false`.  
  
 `fMoreData`  
 [IN] `true` if more data is to be sent in the response; `false` if this is the last data.  
  
 `pcbSent`  
 [OUT] The number of bytes that were sent to the client if the call completes synchronously.  
  
 `pfCompletionExpected`  
 [OUT] `true` if an asynchronous completion is pending for this call; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the parameter is not valid (for example, the `pDataChunks` pointer is set to NULL).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
|ERROR_ARITHMETIC_OVERFLOW|More than 65535 chunks have been added to the response.|  
  
## Remarks  
 Developers can use the `WriteEntityChunks` method to insert a single `HTTP_DATA_CHUNK` structure or an array of `HTTP_DATA_CHUNK` structures into the response body. If the operation has completed synchronously, the `pcbSent` parameter will receive the number of bytes that were inserted into the response.  
  
 If buffering is turned on, the `WriteEntityChunks` method will create a copy of any `HTTP_DATA_CHUNK` structures, thereby duplicating the underlying data so that it does not need to be preserved. If buffering is turned off, or the response buffer limit is reached, the `WriteEntityChunks` method will also flush the response. If buffering is off and the `fAsync` parameter is `true`, the memory must be preserved until the request completes.  
  
 You can configure a `WriteEntityChunks` operation to complete asynchronously by setting the `fAsync` parameter to `true`. In this situation, the `WriteEntityChunks` method will return immediately to the caller, and the `pcbSent` parameter will not receive the number of bytes that were inserted into the response. If buffering is disabled and the `fAsync` parameter is `true`, the memory for the `pDataChunks` parameter must be persisted until the asynchronous call completes.  
  
 A maximum of 65535 chunks (64 KB minus 1) can be written to a request.  
  
## Example  
 The following example demonstrates how to use the `WriteEntityChunks` method to create an HTTP module that inserts an array of two data chunks into the response. The example then returns the response to a Web client.  
  
 [!code-cpp[IHttpResponseWriteEntityChunks#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseWriteEntityChunks/cpp/IHttpResponseWriteEntityChunks.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md)
 [IHttpResponse::WriteEntityChunkByReference Method](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunkbyreference-method.md)
