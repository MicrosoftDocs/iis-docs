---
title: "IHttpRequest::GetHeader Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: be6a7069-7be4-6bdc-046e-29db7ab27b1b
caps.latest.revision: 30
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest::GetHeader Method
Returns the value of a specified HTTP header.  
  
## Syntax  
  
```cpp  
virtual PCSTR GetHeader(  
   IN PCSTR pszHeaderName,  
   OUT USHORT* pcchHeaderValue = NULL  
) const = 0;  
  
virtual PCSTR GetHeader(  
   IN HTTP_HEADER_ID ulHeaderIndex,  
   OUT USHORT* pcchHeaderValue = NULL  
) const = 0;  
```  
  
#### Parameters  
 `pszHeaderName`  
 [IN] A pointer to a string that contains the name of the header to return.  
  
 `ulHeaderIndex`  
 [IN] The ID of the HTTP header to return.  
  
 `pcchHeaderValue`  
 [OUT] A pointer to an unsigned long integer that receives the length of the returned header value.  
  
## Return Value  
 A pointer to a string that contains the specified header, or 0 if the header was not found.  
  
## Remarks  
 The `GetHeader` method returns the value of an HTTP header for the current request. There are two overloaded versions of the `GetHeader` method. One specifies the header by using a string that is contained in the `pszHeaderName` parameter. The other overload uses an unsigned long integer that is contained in the `ulHeaderIndex` parameter. After you call the `GetHeader` method, the `pcchHeaderValue` parameter will contain the length, in characters, of the header value, not including the terminating character. `pcchHeaderValue` will be 0 if the header is not found.  
  
 The header name specified by the `pszHeaderName` parameter can be a custom header or a header defined in Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," or RFC 2616, "Hypertext Transfer Protocol -- HTTP/1.1.  
  
> [!NOTE]
>  The `pszHeaderName` parameter cannot be set to `null`.  
  
 The `ulHeaderIndex` parameter specifies the ID of an HTTP header that is listed in the `HTTP_HEADER_ID` enumeration.  
  
> [!NOTE]
>  The `HTTP_HEADER_ID` enumeration is defined in the Http.h header file.  
  
## Example  
 The following code example demonstrates how to use both versions of the `GetHeader` method to create an HTTP module that retrieves the `User-Agent` and `Accept-Language` HTTP headers for the request.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestGetHeader#1](IHttpRequestGetHeader#1)]  -->  
  
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
 [IHttpRequest Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::DeleteHeader Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-deleteheader-method.md)   
 [IHttpRequest::SetHeader Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-setheader-method.md)