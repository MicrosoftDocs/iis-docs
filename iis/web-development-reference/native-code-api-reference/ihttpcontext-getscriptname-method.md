---
title: "IHttpContext::GetScriptName Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: be5e6a7d-b4b4-adf7-6d38-8619d053a0e0
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetScriptName Method
Retrieves the URL for the current request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetScriptName(  
   DWORD* pcchScriptName = NULL  
) const = 0;  
```  
  
#### Parameters  
 `pcchScriptName`  
 A pointer to a DWORD value that receives the length of the returned string.  
  
## Return Value  
 A pointer to a string that contains the name of the current script.  
  
## Remarks  
 The `GetScriptName` method is used to retrieve a pointer to a buffer that contains the URL of the current request.  
  
> [!NOTE]
>  The server owns the lifetime of this pointer.  
  
## Example  
 The following code example demonstrates how to use the `GetScriptName` method to create an HTTP module that retrieves the name of the current script. The module returns that information to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetScriptName#1](IHttpContextGetScriptName#1)]  -->  
  
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
 [IHttpContext::GetScriptMap Method](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getscriptmap-method.md)   
 [IHttpContext::GetScriptTranslated Method](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getscripttranslated-method.md)