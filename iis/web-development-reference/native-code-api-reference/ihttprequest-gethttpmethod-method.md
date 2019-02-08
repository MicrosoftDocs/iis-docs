---
title: "IHttpRequest::GetHttpMethod Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f9d9766f-8022-74ce-f819-daba64b93498
caps.latest.revision: 27
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest::GetHttpMethod Method
Returns the HTTP method for the current request.  
  
## Syntax  
  
```cpp  
virtual PCSTR GetHttpMethod(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the HTTP method for the request.  
  
## Remarks  
 The `GetHttpMethod` method retrieves the HTTP method for the current request. For most Internet traffic, the HTTP method will typically be a GET or POST method. Retrieving the HTTP method in your application enables you to process a request differently depending on the type of request method. For example, you may want your application to process only GET requests.  
  
> [!NOTE]
>  Standard HTTP methods are defined in Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," or RFC 2616, "Hypertext Transfer Protocol -- HTTP/1.1".  
  
## Example  
 The following code example demonstrates how to use the `GetHttpMethod` method to create an HTTP module that retrieves the HTTP method for the current request. The example then displays the method to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestGetHttpMethod#1](IHttpRequestGetHttpMethod#1)]  -->  
  
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
 [IHttpRequest Interface](../../web-development-reference\native-code-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::SetHttpMethod Method](../../web-development-reference\native-code-api-reference/ihttprequest-sethttpmethod-method.md)