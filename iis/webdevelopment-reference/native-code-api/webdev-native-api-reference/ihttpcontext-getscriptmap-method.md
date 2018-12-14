---
title: "IHttpContext::GetScriptMap Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 40fada80-5a67-0c1c-d9cd-0bfedf8ffcd1
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpContext::GetScriptMap Method
Returns the script map container for the current context.  
  
## Syntax  
  
```cpp  
virtual IScriptMapInfo* GetScriptMap(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IScriptMapInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md) interface.  
  
## Remarks  
 The `GetScriptMap` method is used to retrieve a pointer to the `IScriptMapInfo` interface for the current context. The `IScriptMapInfo` interface contains several methods that return information about the scripting environment.  
  
> [!NOTE]
>  The HTTP context object owns the lifetime of this object. Therefore, you do not free this pointer when writing HTTP modules.  
  
## Example  
 The following code example demonstrates how to use the `GetScriptMap` method to create an HTTP module that retrieves a pointer to an `IScriptMapInfo` interface. The example then uses the [IScriptMapInfo::GetAllowedVerbs](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getallowedverbs-method.md) method to retrieve the list of HTTP methods that are allowed for the current request path.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetScriptMap#1](IHttpContextGetScriptMap#1)]  -->  
  
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
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IScriptMapInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md)   
 [IHttpContext::GetScriptName Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getscriptname-method.md)   
 [IHttpContext::GetScriptTranslated Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getscripttranslated-method.md)