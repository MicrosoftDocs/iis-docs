---
title: "IScriptMapInfo::GetIsStarScriptMap Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4b357c85-4be2-8ec0-d43e-8453736ddb9b
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetIsStarScriptMap Method
Retrieves a value that indicates whether a request handler is a wildcard mapping.  
  
## Syntax  
  
```cpp  
virtual BOOL GetIsStarScriptMap(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the request handler is a wildcard mapping; otherwise, `false`.  
  
## Remarks  
 The `GetIsStarScriptMap` method returns a value that indicates whether a request handler is defined as a wildcard mapping. Request handlers are usually defined for a specific file extension or file name. By contrast, request handlers that are defined as wildcard mappings process all requests.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference\webdev-native-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetIsStarScriptMap` method to determine whether the request handler for the current request is a wildcard mapping. The module returns the wildcard status to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetIsStarScriptMap#1](IScriptMapInfoGetIsStarScriptMap#1)]  -->  
  
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
 [IScriptMapInfo Interface](../../web-development-reference\webdev-native-api-reference/iscriptmapinfo-interface.md)