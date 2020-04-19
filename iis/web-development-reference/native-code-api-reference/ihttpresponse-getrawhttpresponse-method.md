---
title: "IHttpResponse::GetRawHttpResponse Method"
ms.date: "10/07/2016"
ms.assetid: c035a882-5efc-4597-44ec-50501cef4ca9
---
# IHttpResponse::GetRawHttpResponse Method
Retrieves a structure that contains the raw HTTP response.  
  
## Syntax  
  
```cpp  
virtual HTTP_RESPONSE* GetRawHttpResponse(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [HTTP_RESPONSE](https://go.microsoft.com/fwlink/?LinkId=56009) structure.  
  
## Remarks  
 The `GetRawHttpResponse` method retrieves the raw response and returns a pointer to an `HTTP_RESPONSE` structure that contains the current response entity.  
  
> [!NOTE]
>  The `HTTP_RESPONSE` structure is defined in the Http.h header file.  
  
 The lifetime of this structure is controlled by the server, and the structure is available until the end of the response.  
  
## Example  
 The following code example demonstrates how to use the `GetRawHttpResponse` to create an HTTP module that retrieves a pointer to an `HTTP_RESPONSE` structure that contains the current response. The module uses the structure to retrieve the data chunk count in the response, and then it uses the [IHttpResponse::Clear](../../web-development-reference/native-code-api-reference/ihttpresponse-clear-method.md) method to clear the current response. Finally the module returns the chunk count to the client.  
  
 [!code-cpp[IHttpResponseGetRawHttpResponse#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseGetRawHttpResponse/cpp/IHttpResponseGetRawHttpResponse.cpp#1)]  
  
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
 [IHttpRequest::GetRawHttpRequest Method](../../web-development-reference/native-code-api-reference/ihttprequest-getrawhttprequest-method.md)