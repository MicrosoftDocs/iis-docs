---
title: "IHttpResponse::ClearHeaders Method"
ms.date: "10/07/2016"
ms.assetid: 2b25fafe-a88a-ed99-699d-7f5ee33003c8
---
# IHttpResponse::ClearHeaders Method
Clears the response headers and sets headers to default values.  
  
## Syntax  
  
```cpp  
virtual VOID ClearHeaders(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `ClearHeaders` method removes the existing HTTP headers and then adds a default set of headers to the response.  
  
> [!NOTE]
>  If the server has already flushed the response buffer to the client when you call the `ClearHeaders` method, the method may appear to have no effect.  
  
## Example  
 The following code example demonstrates how to use the `ClearHeaders` method to create an HTTP module that clears the response headers and returns a default set of response headers to the client.  
  
 [!code-cpp[IHttpResponseClearHeaders#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseClearHeaders/cpp/IHttpResponseClearHeaders.cpp#1)]  
  
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
 [IHttpResponse::Clear Method](../../web-development-reference/native-code-api-reference/ihttpresponse-clear-method.md)   
 [IHttpResponse::DeleteHeader Method](../../web-development-reference/native-code-api-reference/ihttpresponse-deleteheader-method.md)