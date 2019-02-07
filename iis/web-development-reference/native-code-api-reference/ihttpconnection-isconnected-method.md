---
title: "IHttpConnection::IsConnected Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a2b6d5e7-48d7-2eba-6fe3-1fec9586b846
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpConnection::IsConnected Method
Determines whether a Web client is still connected to the current request.  
  
## Syntax  
  
```cpp  
virtual BOOL IsConnected(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the Web client is still connected; otherwise, `false`.  
  
## Remarks  
 The `IsConnected` method determines whether a Web client has remained connected to the current request or has disconnected from the current request. For example, if a request is taking a long time to process, a Web client may choose to end the connection. If an HTTP module calls the `IsConnected` method and determines that the connection has been terminated by the client, the module can bypass remaining notifications and end additional request processing by returning [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference\native-code-api-reference/request-notification-status-enumeration.md). This frees IIS from continuing to process a request for a disconnected Web client.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetConnection](../../web-development-reference\native-code-api-reference/ihttpcontext-getconnection-method.md) method to create an HTTP module that retrieves a pointer to an [IHttpConnection](../../web-development-reference\native-code-api-reference/ihttpconnection-interface.md) interface. The example then calls the `IHttpConnection::IsConnected` method to determine whether the Web client that initiated the current request is still connected. If the client is still connected, the HTTP module will return a status message to the Web client. If the client is not connected, the module will return `RQ_NOTIFICATION_FINISH_REQUEST` to end additional processing.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpConnectionIsConnected#1](IHttpConnectionIsConnected#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpConnection Interface](../../web-development-reference\native-code-api-reference/ihttpconnection-interface.md)