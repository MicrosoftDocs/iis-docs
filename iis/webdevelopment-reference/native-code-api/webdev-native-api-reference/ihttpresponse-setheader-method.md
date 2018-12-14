---
title: "IHttpResponse::SetHeader Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fda1440f-9c59-34cf-9f25-d3c632aca2b5
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
>  The `pszHeaderName` parameter cannot be NULL.  
  
 The `ulHeaderIndex` parameter specifies the ID of an HTTP header that is listed in the `HTTP_HEADER_ID` enumeration.  
  
> [!NOTE]
>  The `HTTP_HEADER_ID` enumeration is defined in the Http.h header file.  
  
 If the `fReplace` parameter is `true`, the specified header value will replace the existing header value if the header exists. If `fReplace` is `false`, the specified header value should be appended to the existing header and separated from the header itself by a comma.  
  
> [!NOTE]
>  Other modules or handlers may call the `SetHeader` method to replace your value or append values to the value that you have specified.  
  
## Example  
 The following code example demonstrates how to use both overloads of the `SetHeader` method to replace the HTTP `Content-Type` and `Server` headers with custom values and set the HTTP `Refresh` header to a specific number of seconds.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseSetHeader#1](IHttpResponseSetHeader#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::DeleteHeader Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-deleteheader-method.md)   
 [IHttpResponse::GetHeader Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getheader-method.md)