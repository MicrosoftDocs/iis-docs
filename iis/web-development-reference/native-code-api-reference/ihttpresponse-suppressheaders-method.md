---
title: "IHttpResponse::SuppressHeaders Method"
ms.date: "10/07/2016"
ms.assetid: 09879c26-c001-5d7e-6c82-e53005d55120
---
# IHttpResponse::SuppressHeaders Method

Suppresses the response status and headers.  
  
## Syntax  
  
```cpp  
virtual VOID SuppressHeaders(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 `VOID`.  
  
## Remarks  

 The `SuppressHeaders` method enables you to create responses without HTTP headers. Status and headers are still available to your application, but they are not sent to the client.  
  
> [!NOTE]
>  When HTTP headers are suppressed, a Web client that requires a full HTTP response may appear to be working with an unresponsive server. This unresponsive behavior occurs because the Web client is waiting for the response status and headers before it continues processing the response.  
  
## Example  

 The following code example demonstrates how to use the [IHttpResponse::GetHeadersSuppressed](../../web-development-reference/native-code-api-reference/ihttpresponse-getheaderssuppressed-method.md) method to create an HTTP module that tests whether the headers are currently suppressed. The module then calls the `SuppressHeaders` method to prevent the default HTTP headers from being sent. Finally, the module uses the [IHttpResponse::WriteEntityChunks](../../web-development-reference/native-code-api-reference/ihttpresponse-writeentitychunks-method.md) method to return a raw HTTP response to the client.  
  
 [!code-cpp[IHttpResponseGetHeadersSuppressed#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseGetHeadersSuppressed/cpp/IHttpResponseGetHeadersSuppressed.cpp#1)]  
  
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
 [IHttpResponse::GetHeadersSuppressed Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getheaderssuppressed-method.md)
