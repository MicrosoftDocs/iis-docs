---
title: "IHttpSite::GetSiteId Method"
ms.date: "10/07/2016"
ms.assetid: 6caea2a6-61c6-b527-0127-e2cbb1d0d6bf
---
# IHttpSite::GetSiteId Method
Retrieves the unique ID for the Web site.  
  
## Syntax  
  
```cpp  
virtual DWORD GetSiteId(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the unique ID for the Web site.  
  
## Remarks  
 The `GetSiteId` method lets you retrieve the unique numeric value that identifies the Web site that is processing the current request. Each site that a Web administrator creates on an IIS Web server is automatically assigned a number that differentiates the Web site from other Web sites on the same server.  
  
> [!NOTE]
>  This unique identifier is used for managing Web sites and for logging Web requests. For example, the default Web site on a server running IIS will be assigned the number 1, and by default all log files from Web activity for the default Web site will be stored in the %SystemRoot%\System32\Logfiles\W3SVC1 folder. Additional Web sites that are created will be assigned a unique numeric value that is generated algorithmically from the Web site's settings.  
  
## Example  
 The following code example demonstrates how to use the `GetSiteId` method to create an HTTP module that retrieves an [IHttpSite](../../web-development-reference\native-code-api-reference/ihttpsite-interface.md) interface. The module uses `GetSiteId` to retrieve the unique identifier for the Web site. The module then returns the identifier for the Web site to a Web client and exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpSiteGetSiteId#1](IHttpSiteGetSiteId#1)]  -->  
  
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
 [IHttpContext::GetSite Method](../../web-development-reference\native-code-api-reference/ihttpcontext-getsite-method.md)   
 [IHttpSite Interface](../../web-development-reference\native-code-api-reference/ihttpsite-interface.md)   
 [IHttpSite::GetSiteName Method](../../web-development-reference\native-code-api-reference/ihttpsite-getsitename-method.md)