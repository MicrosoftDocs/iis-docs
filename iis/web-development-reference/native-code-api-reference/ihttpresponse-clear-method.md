---
title: "IHttpResponse::Clear Method"
description: IHttpResponse::Clear Method clears the response entity. 
ms.date: "10/07/2016"
ms.assetid: a85335e5-7fe8-d504-1a18-7ca0081c7317
---
# IHttpResponse::Clear Method
Clears the response entity.  
  
## Syntax  
  
```cpp  
virtual VOID Clear(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `Clear` method empties the response contents, including the HTTP headers, the response body, and the HTTP status information. This method resets the response headers and body to default values.  
  
> [!NOTE]
>  If the server has already flushed the response buffer to the client when you call the `Clear` method, the method may appear to have no effect.  
  
## Example  
 The following code example demonstrates how to use the `Clear` method to create an HTTP module that clears the response headers and body and returns a default response to the client.  
  
 [!code-cpp[IHttpResponseClear#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseClear/cpp/IHttpResponseClear.cpp#1)]  
  
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
 [IHttpResponse::ClearHeaders Method](../../web-development-reference/native-code-api-reference/ihttpresponse-clearheaders-method.md)
