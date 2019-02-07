---
title: "IHttpContext::GetScriptTranslated Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 80a1063c-b33b-7af1-b445-1a49922cd728
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetScriptTranslated Method
Retrieves the physical path of the current request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetScriptTranslated(  
   DWORD* pcchScriptName = NULL  
) = 0;  
```  
  
#### Parameters  
 `pcchScriptName`  
 A pointer to a `DWORD` that receives the length of the returned string.  
  
## Return Value  
 A pointer to a string that contains the translated path for the current script.  
  
## Remarks  
 The `GetScriptTranslated` method is used to retrieve a pointer to a buffer that contains the physical path of the current URL.  
  
> [!NOTE]
>  The server owns the lifetime of this pointer.  
  
## Example  
 The following code example demonstrates how to use the `GetScriptTranslated` method to create an HTTP module that retrieves the physical path of the current script. The example returns that information to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetScriptTranslated#1](IHttpContextGetScriptTranslated#1)]  -->  
  
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
 [IHttpContext Interface](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetScriptMap Method](../../web-development-reference\native-code-api-reference/ihttpcontext-getscriptmap-method.md)   
 [IHttpContext::GetScriptName Method](../../web-development-reference\native-code-api-reference/ihttpcontext-getscriptname-method.md)   
 [IHttpContext::MapPath Method](../../web-development-reference\native-code-api-reference/ihttpcontext-mappath-method.md)