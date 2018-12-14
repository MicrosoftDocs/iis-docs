---
title: "IHttpSite::GetSiteId Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6caea2a6-61c6-b527-0127-e2cbb1d0d6bf
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpSite::GetSiteId Method
Retrieves the unique ID for the Web site.  
  
## Syntax  
  
```cpp  
virtual DWORD GetSiteId(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the unique ID for the Web site.  
  
## Remarks  
 The `GetSiteId` method lets you retrieve the unique numeric value that identifies the Web site that is processing the current request. Each site that a Web administrator creates on an IIS Web server is automatically assigned a number that differentiates the Web site from other Web sites on the same server.  
  
> [!NOTE]
>  This unique identifier is used for managing Web sites and for logging Web requests. For example, the default Web site on a server running IIS will be assigned the number 1, and by default all log files from Web activity for the default Web site will be stored in the %SystemRoot%\System32\Logfiles\W3SVC1 folder. Additional Web sites that are created will be assigned a unique numeric value that is generated algorithmically from the Web site's settings.  
  
## Example  
 The following code example demonstrates how to use the `GetSiteId` method to create an HTTP module that retrieves an [IHttpSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md) interface. The module uses `GetSiteId` to retrieve the unique identifier for the Web site. The module then returns the identifier for the Web site to a Web client and exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpSiteGetSiteId#1](IHttpSiteGetSiteId#1)]  -->  
  
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
 [IHttpContext::GetSite Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getsite-method.md)   
 [IHttpSite Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md)   
 [IHttpSite::GetSiteName Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-getsitename-method.md)