---
title: "ISendResponseProvider::GetHeadersBeingSent Method"
ms.date: "10/07/2016"
ms.assetid: 948a9a12-0ce1-9d96-c798-b3d8e6a377fa
---
# ISendResponseProvider::GetHeadersBeingSent Method
Retrieves a value that indicates whether the HTTP headers are being returned.  
  
## Syntax  
  
```cpp  
virtual BOOL GetHeadersBeingSent(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if headers are being returned; otherwise, `false`.  
  
## Remarks  
 The `GetHeadersBeingSent` method retrieves the status that indicates whether the HTTP headers are being returned with the current response. For example, if headers have been suppressed by the [IHttpResponse::SuppressHeaders](../../web-development-reference/native-code-api-reference/ihttpresponse-suppressheaders-method.md) method, `GetHeadersBeingSent` will return `false`.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `IHttpResponse::SuppressHeaders` method to suppress the default set of HTTP headers and creates a new set of basic HTTP headers. The module then calls the `GetHeadersBeingSent` method to retrieve the status of the headers being sent. Finally the module creates a response body with the status of the headers and returns this information to a Web client.  
  
 [!code-cpp[ISendResponseProviderGetHeadersBeingSent#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ISendResponseProviderGetHeadersBeingSent/cpp/ISendResponseProviderGetHeadersBeingSent.cpp#1)]  
  
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
 [ISendResponseProvider Interface](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md)
 [IHttpResponse::GetHeadersSuppressed Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getheaderssuppressed-method.md)
 [IHttpResponse::SuppressHeaders Method](../../web-development-reference/native-code-api-reference/ihttpresponse-suppressheaders-method.md)
