---
title: "IHttpSite::GetSiteName Method"
ms.date: "10/07/2016"
ms.assetid: 0d33c3ee-09a3-2ec5-5f4e-804074f5ed18
---
# IHttpSite::GetSiteName Method
Retrieves the name for the Web site.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetSiteName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the name of the Web site.  
  
## Remarks  
 The `GetSiteName` method returns the name of the Web site that is processing the current request. The name that `GetSiteName` returns is the same name that is displayed in [!INCLUDE[iismgr](../../wmi-provider/includes/iismgr-md.md)] and is created or modified by a Web administrator when they create or manage a Web site.  
  
## Example  
 The following code example demonstrates how to use the `GetSiteName` method to create an HTTP module that retrieves an [IHttpSite](../../web-development-reference/native-code-api-reference/ihttpsite-interface.md) interface. The module uses `GetSiteName` to retrieve the name of the Web site for the current request. The module then returns the name of the Web site to a Web client and exits.  
  
 [!code-cpp[IHttpSiteGetSiteName#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpSiteGetSiteName/cpp/IHttpSiteGetSiteName.cpp#1)]  
  
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
 [IHttpContext::GetSite Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getsite-method.md)
 [IHttpSite Interface](../../web-development-reference/native-code-api-reference/ihttpsite-interface.md)
 [IHttpSite::GetSiteId Method](../../web-development-reference/native-code-api-reference/ihttpsite-getsiteid-method.md)
