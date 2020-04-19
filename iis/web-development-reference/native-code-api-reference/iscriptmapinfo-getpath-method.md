---
title: "IScriptMapInfo::GetPath Method"
ms.date: "10/07/2016"
ms.assetid: 94934509-f6be-8dd3-3d06-a5505a126c56
---
# IScriptMapInfo::GetPath Method
Retrieves the `path` attribute for a request handler.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetPath(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the request handler's `path` attribute.  
  
## Remarks  
 The `GetPath` method retrieves the `path` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the path definition that the request handler will process.  
  
 For example, if a Web client requests a classic ASP page, the `GetPath` method will return "*.ASP" by default.  
  
> [!NOTE]
>  Do not confuse `GetPath` with the [IScriptMapInfo::GetName](../../web-development-reference/native-code-api-reference/iscriptmapinfo-getname-method.md) or [IScriptMapInfo::GetScriptProcessor](../../web-development-reference/native-code-api-reference/iscriptmapinfo-getscriptprocessor-method.md) methods, which return the `name` and `scriptProcessor` attributes, respectively, for the request handler.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference/native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetPath` method to retrieve the `path` attribute for the request handler that is processing the current request. The module returns the `path` attribute to a Web client and then exits.  
  
 [!code-cpp[IScriptMapInfoGetPath#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IScriptMapInfoGetPath/cpp/IScriptMapInfoGetPath.cpp#1)]  
  
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