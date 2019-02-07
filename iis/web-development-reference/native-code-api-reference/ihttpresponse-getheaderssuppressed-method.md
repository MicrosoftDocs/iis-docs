---
title: "IHttpResponse::GetHeadersSuppressed Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6af99349-7a65-f42c-e9b7-3ee6b795632d
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::GetHeadersSuppressed Method
Determines whether the response status and headers are suppressed.  
  
## Syntax  
  
```cpp  
virtual BOOL GetHeadersSuppressed(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the headers are suppressed; otherwise, `false`.  
  
## Remarks  
 The `GetHeadersSuppressed` method determines whether the HTTP status and headers have been suppressed for this response. This method is helpful in determining whether another application has called the [IHttpResponse::SuppressHeaders](../../web-development-reference\webdev-native-api-reference/ihttpresponse-suppressheaders-method.md) method.  
  
## Example  
 The following code example demonstrates how to use the `GetHeadersSuppressed` method to create an HTTP module that determines whether the headers are currently suppressed. The module calls the `SuppressHeaders` method to prevent the default HTTP headers from being sent to the client, and then it uses the [IHttpResponse::WriteEntityChunks](../../web-development-reference\webdev-native-api-reference/ihttpresponse-writeentitychunks-method.md) method to return a raw HTTP response to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseGetHeadersSuppressed#1](IHttpResponseGetHeadersSuppressed#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../web-development-reference\webdev-native-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::SuppressHeaders Method](../../web-development-reference\webdev-native-api-reference/ihttpresponse-suppressheaders-method.md)