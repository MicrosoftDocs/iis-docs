---
title: "IScriptMapInfo::GetName Method"
ms.date: "10/07/2016"
ms.assetid: 9b717857-631e-9a0e-38fd-ab2b62c3d284
---
# IScriptMapInfo::GetName Method
Retrieves the configured name for a request handler.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the name of the request handler.  
  
## Remarks  
 The `GetName` method retrieves the `name` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the display name for the request handler as it will appear in the list of handlers that are defined in [!INCLUDE[iismgr](../../wmi-provider/includes/iismgr-md.md)].  
  
> [!NOTE]
>  Do not confuse `GetName` with the [IScriptMapInfo::GetPath](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getpath-method.md) or [IScriptMapInfo::GetScriptProcessor](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getscriptprocessor-method.md) methods, which return the `path` and `scriptProcessor` attributes, respectively, for the request handler.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference\native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetName` method to retrieve the configured name for the request handler that is processing the current request. The module returns the configured name to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetName#1](IScriptMapInfoGetName#1)]  -->  
  
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
 [IScriptMapInfo Interface](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md)