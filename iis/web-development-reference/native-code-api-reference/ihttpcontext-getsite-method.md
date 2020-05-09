---
title: "IHttpContext::GetSite Method"
ms.date: "10/07/2016"
ms.assetid: 6f8d5532-f308-dca2-7d5a-ca62b959f801
---
# IHttpContext::GetSite Method
Retrieves the site information container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpSite* GetSite(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpSite](../../web-development-reference/native-code-api-reference/ihttpsite-interface.md) interface.  
  
## Remarks  
 The `GetSite` method retrieves a pointer to an `IHttpSite` interface, which can retrieve additional information about the Web site that is processing the request, for the current context. For example, you could create an HTTP module that uses the [IHttpSite::GetSiteId](../../web-development-reference/native-code-api-reference/ihttpsite-getsiteid-method.md) method to retrieve the site ID.  
  
> [!NOTE]
>  The HTTP context object owns the lifetime of this object. Therefore, you do not free this pointer when you write HTTP modules.  
  
## Example  
 The following code example demonstrates how to use the `GetSite` method to create an HTTP module that retrieves an `IHttpSite` interface. The module uses the [IHttpSite::GetSiteName](../../web-development-reference/native-code-api-reference/ihttpsite-getsitename-method.md) method to retrieve the name of the Web site for the current request, and then it returns the name of the Web site to a Web client.  
  
 [!code-cpp[IHttpContextGetSite#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetSite/cpp/IHttpContextGetSite.cpp#1)]  
  
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
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)
