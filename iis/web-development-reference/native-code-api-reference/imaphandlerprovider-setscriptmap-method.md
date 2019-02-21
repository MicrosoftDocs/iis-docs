---
title: "IMapHandlerProvider::SetScriptMap Method"
ms.date: "10/07/2016"
ms.assetid: f1fde288-284d-7035-201c-fb3c508b0213
---
# IMapHandlerProvider::SetScriptMap Method
Specifies which [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface to use for the current context.  
  
## Syntax  
  
```cpp  
virtual VOID SetScriptMap(  
   IScriptMapInfo* pScriptMap  
) = 0;  
```  
  
### Parameters  
 `pScriptMap`  
 A pointer to an [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `SetScriptMap` method allows an HTTP module to specify which `IScriptMapInfo` interface to use when IIS processes a request within the current context. For example, you can create a custom `IScriptMapInfo` interface and specify that IIS use that interface to process the current request if a Web client requests a specific resource on your Web site.  
  
## Example  
 The following example code demonstrates how to create an HTTP module that creates a custom `IScriptMapInfo` interface. The module uses the `SetScriptMap` method to specify that IIS use the custom interface to process the current request and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IMapHandlerProviderSetScriptMap#1](IMapHandlerProviderSetScriptMap#1)]  -->  
  
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
 [IMapHandlerProvider Interface](../../web-development-reference\native-code-api-reference/imaphandlerprovider-interface.md)