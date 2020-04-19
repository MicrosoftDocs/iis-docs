---
title: "IScriptMapInfo::GetAllowedVerbs Method"
ms.date: "10/07/2016"
ms.assetid: d3e0a65b-859d-b782-9469-4979ae0fb7bd
---
# IScriptMapInfo::GetAllowedVerbs Method
Retrieves the list of allowed verbs for a script map.  
  
## Syntax  
  
```cpp  
virtual PCSTR GetAllowedVerbs(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the list of allowed verbs.  
  
## Remarks  
 Developers can use the `GetAllowedVerbs` method to retrieve the list of allowed HTTP verbs for a page handler. For example, if you request a static HTML page that is hosted by an [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] Web site, the static file handler may be configured to allow all HTTP verbs. However, if you if you request a dynamic ASP page that is hosted by the same [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] Web site, the ASP page handler may be configured to allow only the GET and POST verbs.  
  
> [!NOTE]
>  Web administrators can configure the list of allowed verbs by using [!INCLUDE[iismgr](../../wmi-provider/includes/iismgr-md.md)].  
  
## Example  
 The following code example demonstrates how to create an HTTP module that retrieves a pointer to an [IHttpContext::IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetAllowedVerbs` method to retrieve the list of verbs that are allowed for the script map. The module returns the list of allowed verbs to a Web client and then exits.  
  
 [!code-cpp[IScriptMapInfoGetAllowedVerbs#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IScriptMapInfoGetAllowedVerbs/cpp/IScriptMapInfoGetAllowedVerbs.cpp#1)]  
  
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