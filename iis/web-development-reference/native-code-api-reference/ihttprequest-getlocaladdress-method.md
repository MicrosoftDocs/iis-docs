---
title: "IHttpRequest::GetLocalAddress Method"
ms.date: "10/07/2016"
ms.assetid: d46b161f-c91a-77e8-51b0-7975f80284c1
---
# IHttpRequest::GetLocalAddress Method

Returns the address of the local interface for the current request.  
  
## Syntax  
  
```cpp  
virtual PSOCKADDR GetLocalAddress(  
   VOID  
) const = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 A pointer to a [SOCKADDR](https://go.microsoft.com/fwlink/?LinkId=55151) structure.  
  
## Remarks  

 The `GetLocalAddress` method retrieves the address of the local interface on which the request was received and returns a pointer to a `SOCKADDR` structure.  
  
## Example  

 The following code example demonstrates how to use the `GetLocalAddress` method to create an HTTP module that retrieves the local address of the server. The example then returns this information to a Web client.  
  
 [!code-cpp[IHttpRequestGetLocalAddress#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestGetLocalAddress/cpp/IHttpRequestGetLocalAddress.cpp#1)]  
  
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
 [IHttpRequest::GetRemoteAddress Method](../../web-development-reference/native-code-api-reference/ihttprequest-getremoteaddress-method.md)
