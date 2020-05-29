---
title: "IHttpContext::MapHandler Method"
ms.date: "10/07/2016"
ms.assetid: 0903f587-51b1-4eb2-a38e-3c4b11c6c31a
---
# IHttpContext::MapHandler Method
Maps a handler for the specified URL and HTTP verb on a site.  
  
## Syntax  
  
```cpp  
virtual HRESULT MapHandler(  
    DWORD               dwSiteId,  
    PCWSTR              pszSiteName,  
    PCWSTR              pszUrl,  
    PCSTR               pszVerb,  
    IScriptMapInfo **   ppScriptMap,  
    BOOL                fIgnoreWildcardMappings  
) = 0;  
```  
  
### Parameters  
 `dwSiteId`  
 [IN] The ID of the site that contains the URL for mapping.  
  
 `pszSiteName`  
 [IN] A pointer to a string that contains the site name for the target URL.  
  
 `pszUrl`  
 [IN] A pointer to a string that contains the relative URL for mapping.  
  
 `pszVerb`  
 [IN] A pointer to a string that contains the HTTP verb for mapping.  
  
 `ppScriptMap`  
 [OUT] A pointer to the [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface that contains details for the selected script map.  
  
 `fIgnoreWildcardMappings`  
 [IN] `true` to ignore wildcard mapping; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `IScriptMapInfo` interface is valid to use for the lifetime of the [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md) interface.  
  
## Example  
 The following code example demonstrates how to use the `MapHandler` method to create an HTTP module that returns.  
  
 [!code-cpp[IHttpContextMapHandler#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/_New/IHttpContextMapHandler/cpp/IHttpContextMapHandler.cpp#1)]
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
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
