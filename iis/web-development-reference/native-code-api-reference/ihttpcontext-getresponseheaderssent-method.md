---
title: "IHttpContext::GetResponseHeadersSent Method"
ms.date: "10/07/2016"
ms.assetid: 06006ede-2e42-a1c4-6627-3336ac22f636
---
# IHttpContext::GetResponseHeadersSent Method

Determines whether the HTTP response headers have been sent to the client.  
  
## Syntax  
  
```cpp  
virtual BOOL GetResponseHeadersSent(  
   VOID  
) const = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 `true` if the HTTP response headers have been sent; otherwise, `false`.  
  
## Remarks  

 The `GetResponseHeadersSent` method determines whether another module has already sent the HTTP response headers to the client (for example, another HTTP module has called the [IHttpResponse::Flush](../../web-development-reference/native-code-api-reference/ihttpresponse-flush-method.md) method). The `GetResponseHeadersSent` method is especially useful when you are creating an HTTP module that writes values to the headers, because it enables you to have deterministic control over the information that your HTTP module outputs to a Web client.  
  
## Example  

 The following code example demonstrates how to use the `GetResponseHeadersSent` method to create an HTTP module that determines whether the headers have been written to the client. The module indicates the result by returning a message to a Web client.  
  
 [!code-cpp[IHttpContextGetResponseHeadersSent#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetResponseHeadersSent/cpp/IHttpContextGetResponseHeadersSent.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpResponse::Flush Method](../../web-development-reference/native-code-api-reference/ihttpresponse-flush-method.md)
