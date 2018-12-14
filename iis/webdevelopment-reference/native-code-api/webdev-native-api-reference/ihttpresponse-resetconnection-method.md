---
title: "IHttpResponse::ResetConnection Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7c4a08fd-596f-7ec3-01d3-d780e8373229
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::ResetConnection Method
Resets the socket connection immediately.  
  
## Syntax  
  
```cpp  
virtual VOID ResetConnection(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `ResetConnection` method notifies HTTP.sys to trigger an immediate reset of the socket connection with the client.  
  
> [!NOTE]
>  If you do not return the [RQ_NOTIFICATION_FINISH_REQUEST](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-notification-status-enumeration.md) notification after you call the `ResetConnection` method, the server request-processing pipeline will continue to process the response even though the connection to the client will have been reset.  
  
 This method differs from the [IHttpResponse::SetNeedDisconnect](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setneeddisconnect-method.md) method, which disconnects the socket after the server finishes processing the current request.  
  
## Example  
 The following code example demonstrates how to use the `ResetConnection` method to create an HTTP module that terminates the client response. The example module clears the response buffer and inserts a string into the response to return to the client. The example module then calls the `ResetConnection` method to terminate the response. Finally, the module inserts another string into the response; this method will succeed even though the connection with the client has been reset.  
  
> [!NOTE]
>  Because the connection with the client is reset, neither of the calls to return a string to the client in this module will send any text to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseResetConnection#1](IHttpResponseResetConnection#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::SetNeedDisconnect Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setneeddisconnect-method.md)   
 [IHttpContext::CancelIo Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-cancelio-method.md)