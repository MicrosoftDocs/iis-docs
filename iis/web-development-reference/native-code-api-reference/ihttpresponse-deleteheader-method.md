---
title: "IHttpResponse::DeleteHeader Method"
ms.date: "10/07/2016"
ms.assetid: 39de98ea-52fa-2f0c-b077-646f1995042a
---
# IHttpResponse::DeleteHeader Method
Deletes a specified HTTP header.  
  
## Syntax  
  
```cpp  
virtual HRESULT DeleteHeader(  
   IN PCSTR pszHeaderName  
) = 0;  
  
virtual HRESULT DeleteHeader(  
   IN HTTP_HEADER_ID ulHeaderIndex  
) = 0;  
```  
  
### Parameters  
 `pszHeaderName`  
 [IN] A pointer to a string that contains the name of the header to delete.  
  
 `ulHeaderIndex`  
 [IN] The ID of an HTTP header to delete.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
> [!NOTE]
>  The `DeleteHeader` method always returns a successful status, even if the specified header does not exist.  
  
## Remarks  
 The `DeleteHeader` method deletes a specified HTTP header from the current response. There are two overloaded versions of the `DeleteHeader` method. One specifies the header by using a string that is contained in the `pszHeaderName` parameter. The other overload uses an unsigned long integer that is contained in the `ulHeaderIndex` parameter.  
  
 The header name specified by the `pszHeaderName` parameter can be a custom header or a header defined in Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," or RFC 2616, "Hypertext Transfer Protocol -- HTTP/1.1."  
  
> [!NOTE]
> The `pszHeaderName` parameter cannot be set to NULL.  
  
 The `ulHeaderIndex` parameter specifies the ID of an HTTP header that is listed in the `HTTP_HEADER_ID` enumeration.  
  
> [!NOTE]
> The `HTTP_HEADER_ID` enumeration is defined in the Http.h header file.  
  
## Example  
 The following code example demonstrates how to use the `DeleteHeader` method to create an HTTP module that removes the `Server` and `Location` headers from the response.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseDeleteHeader#1](IHttpResponseDeleteHeader#1)]  -->  
  
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
 [IHttpResponse Interface](../../web-development-reference\native-code-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::GetHeader Method](../../web-development-reference\native-code-api-reference/ihttpresponse-getheader-method.md)   
 [IHttpResponse::SetHeader Method](../../web-development-reference\native-code-api-reference/ihttpresponse-setheader-method.md)