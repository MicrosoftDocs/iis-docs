---
title: "IHttpRequest::SetHeader Method"
ms.date: "10/07/2016"
ms.assetid: 30c45c81-36f6-4e0f-e21c-c983923a1af3
---
# IHttpRequest::SetHeader Method
Sets or appends the value of a specified HTTP request header.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetHeader(  
   IN PCSTR pszHeaderName,  
   IN PCSTR pszHeaderValue,  
   IN USHORT cchHeaderValue,  
   IN BOOL fReplace  
) = 0;  
  
virtual HRESULT SetHeader(  
   IN HTTP_HEADER_ID ulHeaderIndex,  
   IN PCSTR pszHeaderValue,  
   IN USHORT cchHeaderValue,  
   IN BOOL fReplace  
) = 0;  
```  
  
### Parameters  
 `pszHeaderName`  
 [IN] A pointer to a string that contains the name of the HTTP header to set.  
  
 `ulHeaderIndex`  
 [IN] The ID of an HTTP header to set.  
  
 `pszHeaderValue`  
 [IN] A pointer to a string that contains the value of the header to set.  
  
 `cchHeaderValue`  
 [IN] The length, in characters, of the header value, not including the \0 character.  
  
 `fReplace`  
 [IN] `true` to overwrite the existing header; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the data is not valid (for example, the data in the header is too long).|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid (for example, the parameter is NULL).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `SetHeader` method sets the value of an HTTP header for the current request. There are two overloaded versions of the `SetHeader` method. One enables you to specify the header by using a string that is contained in the `pszHeaderName` parameter. The other overload uses an unsigned long integer that is contained in the `ulHeaderIndex` parameter.  
  
 The header name specified by the `pszHeaderName` parameter can be a custom header or a header defined in Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," or RFC 2616, "Hypertext Transfer Protocol -- HTTP/1.1."  
  
> [!NOTE]
>  The `pszHeaderName` parameter cannot be set to NULL.  
  
 The `ulHeaderIndex` parameter specifies the ID of an HTTP header that is listed in the `HTTP_HEADER_ID` enumeration.  
  
> [!NOTE]
> The `HTTP_HEADER_ID` enumeration is defined in the Http.h header file.  
  
 If the `fReplace` parameter is `true`, the specified header value will replace the existing header value if the header exists. If `fReplace` is `false`, you should append the specified header value to the existing header and separate the value from the header itself with a comma.  
  
## Example  
 The following code example demonstrates how to use both overloads of the `SetHeader` method to create an HTTP module that replaces the HTTP `User-Agent` and `Accept-Language` headers with new values.  
  
 [!code-cpp[IHttpRequestSetHeader#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestSetHeader/cpp/IHttpRequestSetHeader.cpp#1)]  
  
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
 [IHttpRequest::DeleteHeader Method](../../web-development-reference/native-code-api-reference/ihttprequest-deleteheader-method.md)   
 [IHttpRequest::GetHeader Method](../../web-development-reference/native-code-api-reference/ihttprequest-getheader-method.md)