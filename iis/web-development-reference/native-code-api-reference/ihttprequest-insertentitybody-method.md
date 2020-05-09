---
title: "IHttpRequest::InsertEntityBody Method"
ms.date: "10/07/2016"
ms.assetid: 8e30471e-981b-9026-dc07-5dd2c1e81b02
---
# IHttpRequest::InsertEntityBody Method
Inserts a new entity body into the existing HTTP request body.  
  
## Syntax  
  
```cpp  
virtual HRESULT InsertEntityBody(  
   IN VOID* pvBuffer,  
   IN DWORD cbBuffer  
) = 0;  
```  
  
### Parameters  
 `pvBuffer`  
 [IN] A pointer to a `VOID` buffer that contains the request entity body.  
  
 `cbBuffer`  
 [IN] A `DWORD` that contains the size, in bytes, of the buffer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The [InsertEntityBody](../../web-development-reference/native-code-api-reference/ihttprequest-insertentitybody-method.md) method inserts the entity body that is pointed to by the `pvBuffer` parameter into the HTTP request entity body.  
  
> [!NOTE]
>  The insertion point of the new entity body is before any remaining unread entity body that can be subsequently retrieved from the Web client.  
  
> [!IMPORTANT]
>  IIS does not make a copy of the entity body buffer. Your module's entity buffer must be preserved until the end of the request.  
>   
>  This method does not update the Content-Length header value. A module that uses this method must update the Content-Length separately.  
  
## Example  
 The following code example demonstrates how create an HTTP module that calls the [IHttpContext::AllocateRequestMemory](../../web-development-reference/native-code-api-reference/ihttpcontext-allocaterequestmemory-method.md) method to allocate a 1-KB buffer. The module then copies the string "Hello World" into the buffer. Finally, the module calls the `InsertEntityBody` method to replace the preloaded HTTP request entity body with the buffer and then exits.  
  
 [!code-cpp[IHttpRequestInsertEntityBody#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestInsertEntityBody/cpp/IHttpRequestInsertEntityBody.cpp#1)]  
  
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
