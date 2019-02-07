---
title: "IHttpRequest::GetSiteId Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 672d53ab-7144-3a6b-8997-f7ab213a5f7f
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest::GetSiteId Method
Retrieves the site ID for the current HTTP request.  
  
## Syntax  
  
```cpp  
virtual DWORD GetSiteId(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the site ID.  
  
## Remarks  
 The `GetSiteId` method is used to retrieve the site identifier for the current request. The site ID is a unique identifier for each Web site that is used to differentiate Web sites in the configuration settings.  
  
> [!NOTE]
>  You can view the site ID in the sites collection of the IIS Admin service.  
  
## Example  
 The following code example demonstrates how to use the `GetSiteId` method to create an HTTP module that retrieves the site ID for the Web site that is processing the current request. The example then displays the site ID to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestGetSiteId#1](IHttpRequestGetSiteId#1)]  -->  
  
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
 [IHttpRequest Interface](../../web-development-reference\webdev-native-api-reference/ihttprequest-interface.md)