---
title: "IHttpResponse::Redirect Method"
ms.date: "10/07/2016"
ms.assetid: 1260ee72-2865-b370-00db-11dfde60e0a9
---
# IHttpResponse::Redirect Method
Redirects the client to a specified URL.  
  
## Syntax  
  
```cpp  
virtual HRESULT Redirect(  
   IN PCSTR pszUrl,  
   IN BOOL fResetStatusCode = TRUE,  
   IN BOOL fIncludeParameters = FALSE  
) = 0;  
```  
  
### Parameters  
 `pszUrl`  
 [IN] A pointer to a string that contains the URL for redirection.  
  
 `fResetStatusCode`  
 [IN] `true` to set the HTTP status code to a 302 status; `false` to return an HTML message that indicates the page has been moved.  
  
 `fIncludeParameters`  
 [IN] `true` to pass the query string from the original HTTP request to the redirected URL; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that a specified parameter was not valid.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 When the `fResetStatusCode` parameter is `true`, the `Redirect` method automatically redirects a client to a URL specified by the `pszUrl` parameter. When `fResetStatusCode` is `false`, the `Redirect` method returns an HTML message stating that the URL has moved to the new location. If the URL specified by the `pszUrl` parameter is a relative path, the URL will be converted to an absolute URL within the request domain.  
  
> [!NOTE]
>  If you do not return [RQ_NOTIFICATION_FINISH_REQUEST](../../web-development-reference/native-code-api-reference/request-notification-status-enumeration.md) from your module after you call the `Redirect` method, the `Redirect` method will not automatically clear the response buffer. In this situation, subsequent processing may add information to the response buffer, and you may receive unexpected results if you do not manually clear the response.  
  
> [!NOTE]
> The `Redirect` method does not flush the response entity to the client, and any data in the response will be removed when you call the `Redirect` method. If the response has already been flushed to the client, IIS will have sent the existing headers and data to the client, and the `Redirect` method will not redirect the client to the new URL.  
  
## Example  
 The following code example demonstrates how to use the `Redirect` method to create an HTTP module that redirects a client to a relative URL on the Web server.  
  
 [!code-cpp[IHttpResponseRedirect#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseRedirect/cpp/IHttpResponseRedirect.cpp#1)]  
  
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