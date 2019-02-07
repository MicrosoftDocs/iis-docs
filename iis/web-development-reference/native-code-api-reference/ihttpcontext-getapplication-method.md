---
title: "IHttpContext::GetApplication Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b6785cd1-7502-24ea-1b46-e6b29e6fc72c
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetApplication Method
Retrieves the application container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpApplication* GetApplication(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpApplication](../../web-development-reference\webdev-native-api-reference/ihttpapplication-interface.md) interface.  
  
## Remarks  
 The `GetApplication` method returns an `IHttpApplication` interface that is used to retrieve information about the application that is processing the current request. For example, the [IHttpApplication::GetApplicationId](../../web-development-reference\webdev-native-api-reference/ihttpapplication-getapplicationid-method.md) and [IHttpApplication::GetApplicationPhysicalPath](../../web-development-reference\webdev-native-api-reference/ihttpapplication-getapplicationphysicalpath-method.md) methods will return the application's identity and physical path.  
  
> [!NOTE]
>  `IHttpContext` owns the lifetime of this object. Therefore, you do not free this pointer when you write your application.  
  
## Example  
 The following code example demonstrates how to use the `GetApplication` method to create an HTTP module that retrieves the physical path for the current request and returns the path to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetApplication#1](IHttpContextGetApplication#1)]  -->  
  
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
 [IHttpContext Interface](../../web-development-reference\webdev-native-api-reference/ihttpcontext-interface.md)