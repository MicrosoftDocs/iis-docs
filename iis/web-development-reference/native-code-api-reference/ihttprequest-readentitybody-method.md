---
title: "IHttpRequest::ReadEntityBody Method"
ms.date: "10/07/2016"
ms.assetid: e29ce6f7-d839-ee92-184f-747f98f6a456
---
# IHttpRequest::ReadEntityBody Method
Returns the HTTP request entity body.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReadEntityBody(  
   OUT VOID* pvBuffer,  
   IN DWORD cbBuffer,  
   IN BOOL fAsync,  
   OUT DWORD* pcbBytesReceived,  
   OUT BOOL* pfCompletionPending = NULL  
) = 0;  
```  
  
### Parameters  
 `pvBuffer`  
 [OUT] A pointer to a buffer that receives the request body.  
  
 `cbBuffer`  
 [IN] The size, in bytes, of the buffer pointed to by `pvBuffer`.  
  
 `fAsync`  
 [IN] `true` to complete the operation asynchronously; otherwise, `false`.  
  
 `pcbBytesReceived`  
 [OUT] A pointer to a `DWORD` buffer that receives the number of bytes actually read if the method call completes synchronously.  
  
 `pfCompletionPending`  
 [OUT] A pointer to a Boolean buffer that receives a value that specifies whether an asynchronous completion is pending.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_CONNECTION_INVALID|Indicates that the byte count for the current request is incorrect.|  
|ERROR_HANDLE_EOF|Indicates that there is no remaining data to be read.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `ReadEntityBody` method supports both synchronous and asynchronous calls.  
  
> [!NOTE]
>  If you are calling the `ReadEntityBody` method asynchronously, your module needs to return immediately after the call.  
  
 After the `ReadEntityBody` method is called, the `pvBuffer` buffer will contain the request body, and the `pcbBytesReceived` buffer will contain the size, in bytes, of the request body that was returned in the `pvBuffer` buffer if the method call completed synchronously.  
  
 In addition, the `pfCompletionPending` buffer will contain a Boolean value that specifies whether an asynchronous completion is pending.  
  
## Example  
 The following code example demonstrates how to use the `ReadEntityBody` method to create an HTTP module that retrieves a 1-KB buffer section from the current request.  
  
 [!code-cpp[IHttpRequestReadEntityBody#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestReadEntityBody/cpp/IHttpRequestReadEntityBody.cpp#1)]  
  
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
 [IHttpRequest Interface](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::GetRemainingEntityBytes Method](../../web-development-reference/native-code-api-reference/ihttprequest-getremainingentitybytes-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../web-development-reference/native-code-api-reference/ihttprequest-insertentitybody-method.md)
