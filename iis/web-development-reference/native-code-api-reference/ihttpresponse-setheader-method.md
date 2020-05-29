---
title: "IHttpResponse::SetHeader Method"
ms.date: "10/07/2016"
ms.assetid: fda1440f-9c59-34cf-9f25-d3c632aca2b5
---
# IHttpResponse::SetHeader Method
Sets or appends the value of a specified HTTP response header.  
  
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
 [IN] Specifies whether the existing header should be overwritten.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the data is not valid (for example, the data in the header is too long).|  
|ERROR_INVALID_PARAMETER|Indicates that the specified parameter is not valid (for example, the parameter is set to NULL).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `SetHeader` method sets the value of an HTTP header for the current response. There are two overloaded versions of the `SetHeader` method. The first enables you to specify the header by using a string that is contained in the `pszHeaderName` parameter. The other overload uses an unsigned long integer that is contained in the `ulHeaderIndex` parameter.  
  
> [!NOTE]
>  You should not use the overload that uses the `ulHeaderIndex` parameter to set the value of the `Server` header, because your value will be appended to the existing header value. Use the `pszHeaderName` parameter instead.  
  
 The header name specified by the `pszHeaderName` parameter can be a custom header or a header defined in Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," or RFC 2616, "Hypertext Transfer Protocol -- HTTP/1.1."  
  
> [!NOTE]
> The `pszHeaderName` parameter cannot be NULL.  
  
 The `ulHeaderIndex` parameter specifies the ID of an HTTP header that is listed in the `HTTP_HEADER_ID` enumeration.  
  
> [!NOTE]
> The `HTTP_HEADER_ID` enumeration is defined in the Http.h header file.  
  
 If the `fReplace` parameter is `true`, the specified header value will replace the existing header value if the header exists. If `fReplace` is `false`, the specified header value should be appended to the existing header and separated from the header itself by a comma.  
  
> [!NOTE]
> Other modules or handlers may call the `SetHeader` method to replace your value or append values to the value that you have specified.  
  
## Example  
 The following code example demonstrates how to use both overloads of the `SetHeader` method to replace the HTTP `Content-Type` and `Server` headers with custom values and set the HTTP `Refresh` header to a specific number of seconds.  
  
 [!code-cpp[IHttpResponseSetHeader#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseSetHeader/cpp/IHttpResponseSetHeader.cpp#1)]  
  
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
 [IHttpResponse::DeleteHeader Method](../../web-development-reference/native-code-api-reference/ihttpresponse-deleteheader-method.md)   
 [IHttpResponse::GetHeader Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getheader-method.md)
