---
title: "ISendResponseProvider::GetHeadersBeingSent Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 948a9a12-0ce1-9d96-c798-b3d8e6a377fa
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# ISendResponseProvider::GetHeadersBeingSent Method
Retrieves a value that indicates whether the HTTP headers are being returned.  
  
## Syntax  
  
```cpp  
virtual BOOL GetHeadersBeingSent(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if headers are being returned; otherwise, `false`.  
  
## Remarks  
 The `GetHeadersBeingSent` method retrieves the status that indicates whether the HTTP headers are being returned with the current response. For example, if headers have been suppressed by the [IHttpResponse::SuppressHeaders](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-suppressheaders-method.md) method, `GetHeadersBeingSent` will return `false`.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `IHttpResponse::SuppressHeaders` method to suppress the default set of HTTP headers and creates a new set of basic HTTP headers. The module then calls the `GetHeadersBeingSent` method to retrieve the status of the headers being sent. Finally the module creates a response body with the status of the headers and returns this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [ISendResponseProviderGetHeadersBeingSent#1](ISendResponseProviderGetHeadersBeingSent#1)]  -->  
  
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
 [ISendResponseProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-interface.md)   
 [IHttpResponse::GetHeadersSuppressed Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getheaderssuppressed-method.md)   
 [IHttpResponse::SuppressHeaders Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-suppressheaders-method.md)