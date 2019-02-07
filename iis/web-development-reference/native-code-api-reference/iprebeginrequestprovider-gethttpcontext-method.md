---
title: "IPreBeginRequestProvider::GetHttpContext Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a7903ec5-eff6-383f-8728-e70eee4ea783
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# IPreBeginRequestProvider::GetHttpContext Method
Retrieves an [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual IHttpContext* GetHttpContext(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md).  
  
## Remarks  
 The `GetHttpContext` method retrieves a pointer to an [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md) interface, which allows global-level notifications access to the context for a request. This is in contrast to request-level notifications, for which a pointer to an `IHttpContext` interface is provided.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that uses the `GetHttpContext` function to retrieve a pointer to an `IHttpContext` interface. The module calls the context's [IHttpContext::GetSite](../../web-development-reference\native-code-api-reference/ihttpcontext-getsite-method.md) method to retrieve a pointer to an [IHttpSite](../../web-development-reference\native-code-api-reference/ihttpsite-interface.md) interface, and then calls the [IHttpSite::GetSiteName](../../web-development-reference\native-code-api-reference/ihttpsite-getsitename-method.md) method to retrieve the name of the site that is processing the request.  
  
<!-- TODO: review snippet reference  [!CODE [IPreBeginRequestProviderGetHttpContext#1](IPreBeginRequestProviderGetHttpContext#1)]  -->  
  
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
 [IPreBeginRequestProvider Interface](../../web-development-reference\native-code-api-reference/iprebeginrequestprovider-interface.md)