---
title: "IHttpContext::GetRequest Method"
ms.date: "10/07/2016"
ms.assetid: 566b6315-00a6-0d9a-17ae-e531139a4912
---
# IHttpContext::GetRequest Method
Returns the HTTP request container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpRequest* GetRequest(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpRequest](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md) interface.  
  
## Remarks  
 The `GetRequest` method returns a pointer to an `IHttpRequest` interface that can be used to call any of the `IHttpRequest` methods.  
  
> [!NOTE]
>  The HTTP context object owns the lifetime of this object. Therefore, you do not free this pointer when writing HTTP modules.  
  
## Example  
 The following code example illustrates how to use the `IHttpContext::GetRequest` and [GetResponse](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md) methods to return pointers to `IHttpRequest` and [IHttpResponse](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md) interfaces. This example also demonstrates how to use the [IHttpRequest::GetHttpMethod](../../web-development-reference/native-code-api-reference/ihttprequest-gethttpmethod-method.md) method to retrieve the HTTP method for the current request, and it displays the method to a Web client by using the [IHttpResponse::WriteEntityChunks](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunks-method.md) method.  
  
 [!code-cpp[IHttpContextGetRequest#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetRequest/cpp/IHttpContextGetRequest.cpp#1)]  
  
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
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetResponse Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getresponse-method.md)