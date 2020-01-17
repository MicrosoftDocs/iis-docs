---
title: "IScriptMapInfo::GetModules Method"
ms.date: "10/07/2016"
ms.assetid: b998fa9b-2ca5-9c15-c857-1fc0b0e2417d
---
# IScriptMapInfo::GetModules Method
Retrieves the list of modules for a request handler.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetModules(  
   DWORD* pcchModules = NULL  
) const = 0;  
```  
  
### Parameters  
 `pcchModules`  
 A pointer to a `DWORD` buffer that receives the length, in characters, of the module list.  
  
## Return Value  
 A pointer to a string that contains a comma-delimited list of modules.  
  
## Remarks  
 The `GetModules` method retrieves the `modules` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains a comma-delimited list of modules for the request handler.  
  
 For example, if a Web client requests a classic ASP page, `GetModules` returns "IsapiModule" by default. If a client requests a static file, `GetModules` returns a comma-delimited list that contains "StaticFileModule", "DefaultDocumentModule", and "DirectoryListingModule" by default.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference/native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetModules` method to retrieve the list of modules for the request handler that is processing the current request. The module returns the module list to a Web client and then exits.  
  
 [!code-cpp[IScriptMapInfoGetModules#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IScriptMapInfoGetModules/cpp/IScriptMapInfoGetModules.cpp#1)]  
  
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
 [IScriptMapInfo Interface](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md)