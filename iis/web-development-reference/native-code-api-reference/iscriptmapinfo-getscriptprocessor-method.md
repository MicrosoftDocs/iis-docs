---
title: "IScriptMapInfo::GetScriptProcessor Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4e84d8be-b26d-5514-4e4d-09718d9a827d
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetScriptProcessor Method
Retrieves the script processor for a request handler.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetScriptProcessor(  
   DWORD* pcchScriptProcessor = NULL  
) const = 0;  
```  
  
#### Parameters  
 `pcchScriptProcessor`  
 A pointer to a `DWORD` buffer that receives the length, in characters, of the request handler.  
  
## Return Value  
 A pointer to a string that contains the path of the script-processing engine.  
  
## Remarks  
 The `GetScriptProcessor` method retrieves the `scriptProcessor` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the full path to the script processor for the request handler, or nothing if the requested resource was not a script.  
  
 For example, if a Web client requests a file with a .txt extension, `GetScriptProcessor` returns nothing by default, because text files are not configured with a script processor. By contrast, if a Web client requests a file with an .asp extension, `GetScriptProcessor` returns the full path to the Asp.dll script engine.  
  
> [!NOTE]
>  Do not confuse `GetScriptProcessor` with the [IScriptMapInfo::GetPath](../../web-development-reference\webdev-native-api-reference/iscriptmapinfo-getpath-method.md) or [IScriptMapInfo::GetName](../../web-development-reference\webdev-native-api-reference/iscriptmapinfo-getname-method.md) methods, which return the `path` and `name` attributes, respectively, for the request handler.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference\webdev-native-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetScriptProcessor` method to retrieve the full path of the script engine for the request handler that is processing the current request. The module returns the path to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetScriptProcessor#1](IScriptMapInfoGetScriptProcessor#1)]  -->  
  
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