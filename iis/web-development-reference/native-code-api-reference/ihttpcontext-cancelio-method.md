---
title: "IHttpContext::CancelIo Method"
ms.date: "10/07/2016"
ms.assetid: 19c06998-0eb7-41f9-81b2-7fd0278dac34
---
# IHttpContext::CancelIo Method
Cancels any pending send or receive operations.  
  
## Syntax  
  
```cpp  
virtual HRESULT CancelIo(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_HANDLE|Indicates that IIS was unable to retrieve and lock an asynchronous handle for the operation.|  
  
## Remarks  
 The `CancelIo` method terminates any pending send or receive operations with a Web client. For example, if an HTTP module is reading information from the Web client, calling the `CancelIo` method will cancel any pending read operations.  
  
 This method differs from the [IHttpResponse::ResetConnection](../../web-development-reference/native-code-api-reference/ihttpresponse-resetconnection-method.md) and [IHttpResponse::SetNeedDisconnect](../../web-development-reference/native-code-api-reference/ihttpresponse-setneeddisconnect-method.md) methods, which reset the socket connection with a Web client immediately or after the response is complete, respectively.  
  
## Example  
 The following code example demonstrates how to use the `CancelIo` method to create an HTTP module that cancels any pending send or receive operations.  
  
 [!code-cpp[IHttpContextCancelIo#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextCancelIo/cpp/IHttpContextCancelIo.cpp#1)]  
  
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
 [IHttpResponse::ResetConnection Method](../../web-development-reference/native-code-api-reference/ihttpresponse-resetconnection-method.md)   
 [IHttpResponse::SetNeedDisconnect Method](../../web-development-reference/native-code-api-reference/ihttpresponse-setneeddisconnect-method.md)