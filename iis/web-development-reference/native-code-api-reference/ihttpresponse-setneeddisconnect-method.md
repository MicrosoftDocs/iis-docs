---
title: "IHttpResponse::SetNeedDisconnect Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 118ce2da-ce8f-5dac-6662-d49f43ce9c9d
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::SetNeedDisconnect Method
Resets the socket after the response is complete.  
  
## Syntax  
  
```cpp  
virtual VOID SetNeedDisconnect(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `SetNeedDisconnect` method requests that the socket be disconnected after the server finishes processing the current request. This method differs from the [IHttpResponse::ResetConnection](../../web-development-reference\webdev-native-api-reference/ihttpresponse-resetconnection-method.md) method, which terminates the socket connection immediately.  
  
## Example  
 The following code example demonstrates how to use the `SetNeedDisconnect` method to create an HTTP module that disconnects the socket connection after the server finishes processing the current request.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseSetNeedDisconnect#1](IHttpResponseSetNeedDisconnect#1)]  -->  
  
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
 [IHttpResponse::ResetConnection Method](../../web-development-reference\webdev-native-api-reference/ihttpresponse-resetconnection-method.md)   
 [IHttpContext::CancelIo Method](../../web-development-reference\webdev-native-api-reference/ihttpcontext-cancelio-method.md)