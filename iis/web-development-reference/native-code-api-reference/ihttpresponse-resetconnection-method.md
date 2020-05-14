---
title: "IHttpResponse::ResetConnection Method"
ms.date: "10/07/2016"
ms.assetid: 7c4a08fd-596f-7ec3-01d3-d780e8373229
---
# IHttpResponse::ResetConnection Method
Resets the socket connection immediately.  
  
## Syntax  
  
```cpp  
virtual VOID ResetConnection(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `ResetConnection` method notifies HTTP.sys to trigger an immediate reset of the socket connection with the client.  
  
> [!NOTE]
>  If you do not return the [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) notification after you call the `ResetConnection` method, the server request-processing pipeline will continue to process the response even though the connection to the client will have been reset.  
  
 This method differs from the [IHttpResponse::SetNeedDisconnect](../../web-development-reference/native-code-api-reference/ihttpresponse-setneeddisconnect-method.md) method, which disconnects the socket after the server finishes processing the current request.  
  
## Example  
 The following code example demonstrates how to use the `ResetConnection` method to create an HTTP module that terminates the client response. The example module clears the response buffer and inserts a string into the response to return to the client. The example module then calls the `ResetConnection` method to terminate the response. Finally, the module inserts another string into the response; this method will succeed even though the connection with the client has been reset.  
  
> [!NOTE]
> Because the connection with the client is reset, neither of the calls to return a string to the client in this module will send any text to the client.  
  
 [!code-cpp[IHttpResponseResetConnection#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseResetConnection/cpp/IHttpResponseResetConnection.cpp#1)]  
  
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
 [IHttpResponse::SetNeedDisconnect Method](../../web-development-reference/native-code-api-reference/ihttpresponse-setneeddisconnect-method.md)
 [IHttpContext::CancelIo Method](../../web-development-reference/native-code-api-reference/ihttpcontext-cancelio-method.md)
