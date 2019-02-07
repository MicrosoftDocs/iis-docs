---
title: "IHttpContext::GetParentContext Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 99ef993a-b8a5-71d4-0223-f3d2acf489c8
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetParentContext Method
Retrieves a pointer to the parent context for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpContext* GetParentContext(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpContext](../../web-development-reference\webdev-native-api-reference/ihttpcontext-interface.md) interface.  
  
## Remarks  
 The `GetParentContext` method retrieves a pointer to the `IHttpContext` interface for the parent context of the current request. For example, if an HTTP module creates a child context by using the [CloneContext](../../web-development-reference\webdev-native-api-reference/ihttpcontext-clonecontext-method.md) method, the `GetParentContext` method can help determine whether the module is processing on the parent context or on the child context.  
  
> [!NOTE]
>  When the current context does not have a parent context, the `GetParentContext` method will return `NULL`.  
  
## Example  
 The following code example demonstrates how to use the `GetParentContext` method to create an HTTP module that retrieves the parent context for the request. The module compares the parent context with `NULL` and the current request context to determine whether the parent context is different than the current context. The module then returns a message to the Web client and exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetParentContext#1](IHttpContextGetParentContext#1)]  -->  
  
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
 [IHttpContext::CloneContext Method](../../web-development-reference\webdev-native-api-reference/ihttpcontext-clonecontext-method.md)   
 [IHttpContext::GetRootContext Method](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getrootcontext-method.md)