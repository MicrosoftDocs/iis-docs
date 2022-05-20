---
title: "IHttpContext::GetConnection Method"
description: Learn how the GetConnection method retrieves the connection container for the current context.
ms.date: "10/07/2016"
ms.assetid: d6bf938c-60e8-5d4b-408b-916efcad9f6c
---
# IHttpContext::GetConnection Method
Retrieves the connection container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpConnection* GetConnection(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpConnection](../../web-development-reference/native-code-api-reference/ihttpconnection-interface.md) interface.  
  
## Remarks  
 The `GetConnection` method retrieves a pointer to an `IHttpConnection` interface that can be used to retrieve information about the current connection. For example, the [IHttpConnection::IsConnected](../../web-development-reference/native-code-api-reference/ihttpconnection-isconnected-method.md) method returns a Boolean value that indicates whether a Web client is still connected to the current request.  
  
> [!NOTE]
>  `IHttpContext` owns the lifetime of this object. Therefore, you do not free this pointer when you write your application.  
  
## Example  
 The following code example demonstrates how to use the `GetConnection` method to create an HTTP module that retrieves a pointer to an `IHttpConnection` interface. The example then calls the `IHttpConnection::IsConnected` method to determine whether the Web client that initiated the current request is still connected. If the client is still connected, the HTTP module will return a status message to the Web client. If the client is not connected, the module will return [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) to end additional processing.  
  
 [!code-cpp[IHttpContextGetConnection#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetConnection/cpp/IHttpContextGetConnection.cpp#1)]  
  
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
