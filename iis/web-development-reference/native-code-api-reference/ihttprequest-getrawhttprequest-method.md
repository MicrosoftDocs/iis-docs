---
title: "IHttpRequest::GetRawHttpRequest Method"
ms.date: "10/07/2016"
ms.assetid: fa0ce96b-acb6-5dd8-5225-08909ff40868
---
# IHttpRequest::GetRawHttpRequest Method
Returns a structure that contains the raw HTTP request.  
  
## Syntax  
  
```cpp  
virtual HTTP_REQUEST* GetRawHttpRequest(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [HTTP_REQUEST](https://go.microsoft.com/fwlink/?LinkId=56010) structure.  
  
## Remarks  
 The `GetRawHttpRequest` method retrieves the raw request and returns a pointer to an `HTTP_REQUEST` structure that contains the current request entity.  
  
> [!NOTE]
>  The `HTTP_REQUEST` structure is defined in the Http.h file.  
  
 The lifetime of this structure is controlled by the server, and the structure is available until the end of the request.  
  
## Example  
 The following code example demonstrates how to use the `GetRawHttpRequest` method to create an HTTP module that retrieves the `HTTP_REQUEST` structure for the current request. The code example then shows how to use the structure to retrieve the HTTP verb, HTTP major version, and HTTP minor version for the request.  
  
 [!code-cpp[IHttpRequestGetRawHttpRequest#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestGetRawHttpRequest/cpp/IHttpRequestGetRawHttpRequest.cpp#1)]  
  
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
 [IHttpResponse::GetRawHttpResponse Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getrawhttpresponse-method.md)
