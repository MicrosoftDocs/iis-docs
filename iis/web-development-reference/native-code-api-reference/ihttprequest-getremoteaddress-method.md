---
title: "IHttpRequest::GetRemoteAddress Method"
ms.date: "10/07/2016"
ms.assetid: 72b4d03f-3199-a3fd-008e-e5c819d26e15
---
# IHttpRequest::GetRemoteAddress Method
Returns the remote address of the client's interface for the current request.  
  
## Syntax  
  
```cpp  
virtual PSOCKADDR GetRemoteAddress(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a [SOCKADDR](https://go.microsoft.com/fwlink/?LinkId=55151)structure.  
  
## Remarks  
 The `GetRemoteAddress` method retrieves the remote interface address of the client that issued the request and returns a pointer to a `SOCKADDR` structure.  
  
## Example  
 The following code example demonstrates how to use the `GetRemoteAddress` method to create an HTTP module that retrieves the remote address of a client. The example then returns this information to a Web client.  
  
 [!code-cpp[IHttpRequestGetRemoteAddress#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestGetRemoteAddress/cpp/IHttpRequestGetRemoteAddress.cpp#1)]  
  
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
 [IHttpRequest::GetLocalAddress Method](../../web-development-reference/native-code-api-reference/ihttprequest-getlocaladdress-method.md)
