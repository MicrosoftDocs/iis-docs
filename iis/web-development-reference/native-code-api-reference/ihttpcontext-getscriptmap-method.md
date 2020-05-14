---
title: "IHttpContext::GetScriptMap Method"
ms.date: "10/07/2016"
ms.assetid: 40fada80-5a67-0c1c-d9cd-0bfedf8ffcd1
---
# IHttpContext::GetScriptMap Method
Returns the script map container for the current context.  
  
## Syntax  
  
```cpp  
virtual IScriptMapInfo* GetScriptMap(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface.  
  
## Remarks  
 The `GetScriptMap` method is used to retrieve a pointer to the `IScriptMapInfo` interface for the current context. The `IScriptMapInfo` interface contains several methods that return information about the scripting environment.  
  
> [!NOTE]
>  The HTTP context object owns the lifetime of this object. Therefore, you do not free this pointer when writing HTTP modules.  
  
## Example  
 The following code example demonstrates how to use the `GetScriptMap` method to create an HTTP module that retrieves a pointer to an `IScriptMapInfo` interface. The example then uses the [IScriptMapInfo::GetAllowedVerbs](../../web-development-reference/native-code-api-reference/iscriptmapinfo-getallowedverbs-method.md) method to retrieve the list of HTTP methods that are allowed for the current request path.  
  
 [!code-cpp[IHttpContextGetScriptMap#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetScriptMap/cpp/IHttpContextGetScriptMap.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)
 [IScriptMapInfo Interface](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md)
 [IHttpContext::GetScriptName Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getscriptname-method.md)
 [IHttpContext::GetScriptTranslated Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getscripttranslated-method.md)
