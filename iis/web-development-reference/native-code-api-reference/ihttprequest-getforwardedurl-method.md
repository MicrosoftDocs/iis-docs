---
title: "IHttpRequest::GetForwardedUrl Method"
ms.date: "10/07/2016"
ms.assetid: 610c7fcd-5354-9021-d7a7-f8543c916143
---
# IHttpRequest::GetForwardedUrl Method

Returns the forwarded URL.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetForwardedUrl(  
   VOID  
) const = 0;  
```  
  
### Parameters

This method takes no parameters.  
  
## Return Value

A pointer to a string that contains the forwarded URL.  
  
## Remarks

The `GetForwardedUrl` method retrieves the URL after a call to the [IHttpRequest::SetUrl](../../web-development-reference/native-code-api-reference/ihttprequest-seturl-method.md) method, but only when the URL does not refer to a local address. If you use `SetUrl` to specify a local URL, the `GetForwardedUrl` method will return NULL.  
  
## Example

The following code example demonstrates how to create an HTTP module that calls the `IHttpRequest::SetUrl` method to set the URL for the request to `http://www.microsoft.com`. The module then calls the `GetForwardedUrl` method to retrieve the forwarded URL. The module tests whether the forwarded URL is NULL. If the forwarded URL is not NULL, the module displays the URL to a Web client.  
  
[!code-cpp[IHttpRequestGetForwardedUrl#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestGetForwardedUrl/cpp/IHttpRequestGetForwardedUrl.cpp#1)]  
  
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

- [IHttpRequest Interface](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)
- [IHttpRequest::SetUrl Method](../../web-development-reference/native-code-api-reference/ihttprequest-seturl-method.md)
