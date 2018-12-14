---
title: "IScriptMapInfo::GetPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 94934509-f6be-8dd3-3d06-a5505a126c56
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetPath Method
Retrieves the `path` attribute for a request handler.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetPath(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the request handler's `path` attribute.  
  
## Remarks  
 The `GetPath` method retrieves the `path` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the path definition that the request handler will process.  
  
 For example, if a Web client requests a classic ASP page, the `GetPath` method will return "*.ASP" by default.  
  
> [!NOTE]
>  Do not confuse `GetPath` with the [IScriptMapInfo::GetName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getname-method.md) or [IScriptMapInfo::GetScriptProcessor](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getscriptprocessor-method.md) methods, which return the `name` and `scriptProcessor` attributes, respectively, for the request handler.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetPath` method to retrieve the `path` attribute for the request handler that is processing the current request. The module returns the `path` attribute to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetPath#1](IScriptMapInfoGetPath#1)]  -->  
  
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
 [IScriptMapInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md)