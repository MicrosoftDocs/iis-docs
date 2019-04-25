---
title: "IHttpRequest::SetUrl Method"
ms.date: "10/07/2016"
ms.assetid: 75496bd2-a34d-a635-6e39-dbc974e92390
---
# IHttpRequest::SetUrl Method
Modifies the request URL.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetUrl(  
   IN PCWSTR pszUrl,  
   IN DWORD cchUrl,  
   IN BOOL fResetQueryString  
) = 0;  
  
virtual HRESULT SetUrl(  
   IN PCSTR pszUrl,  
   IN DWORD cchUrl,  
   IN BOOL fResetQueryString  
) = 0;  
```  
  
### Parameters  
 `pszUrl`  
 [IN] A pointer to a string that contains the URL to set.  
  
 `cchUrl`  
 [IN] The length, in characters, of the URL specified by `pszUrl`.  
  
 `fResetQueryString`  
 [IN] `true` to reset the existing query string; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid (for example, the specified URL is too long).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `SetUrl` method modifies the URL for the current request. There are two overloaded versions of the `SetUrl` method. One enables you to specify the header by using a pointer to a string. The other overload uses a pointer to a wide string.  
  
 Subsequent request processing functions and logging operations will process the new URL as if the client had requested the URL. Therefore, any error conditions caused by modifying the URL will be returned to the client. For example, if the new URL does not exist, the Web server will return an HTTP 404 error.  
  
> [!WARNING]
>  The `SetUrl` method is called after the initial parameters for the request have been gathered, so subsequent request processing may be unaware of the changed URL. For example, retrieving the URL server variable will reflect the original request, not the changed URL. Implementers should call [IHttpContext::ExecuteRequest Method](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md) instead of `SetUrl` in order to run the request through the complete pipeline. The `SetUrl` method should not be used for URL rewriting.  
  
> [!NOTE]
>  Unlike the [IHttpResponse::Redirect](../../web-development-reference/native-code-api-reference/ihttpresponse-redirect-method.md) method, the `SetUrl` method does not redirect a client to a new URL.  
  
> [!NOTE]
> You must call the `SetUrl` method before the first event in the HTTP integrated request-processing pipeline. Calling the `SetUrl` method from an OnPostBeginRequest handler results in indeterminate behavior.  
  
## Example  
 The following code example demonstrates how to use the `SetUrl` method to change a requested URL to another URL.  
  
 [!code-cpp[IHttpRequestSetUrl#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestSetUrl/cpp/IHttpRequestSetUrl.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpRequest Interface](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::GetUrlChanged Method](../../web-development-reference/native-code-api-reference/ihttprequest-geturlchanged-method.md)