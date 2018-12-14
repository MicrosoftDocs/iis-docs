---
title: "IHttpResponse::GetCachePolicy Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ca34e089-b2d7-386a-e3f5-4c7dfa213d91
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::GetCachePolicy Method
Retrieves the response output cache policy.  
  
## Syntax  
  
```cpp  
virtual IHttpCachePolicy* GetCachePolicy(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpCachePolicy](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-interface.md) interface.  
  
## Remarks  
 The `GetCachePolicy` method returns a pointer to an `IHttpCachePolicy` interface, which enables you to call any one of the available methods for that interface.  
  
> [!NOTE]
>  The server owns the lifetime of the `IHttpCachePolicy` interface, and the interface is available through the end of your response processing.  
  
## Example  
 The following code example demonstrates how to use the `GetCachePolicy` method to return a pointer to an `IHttpCachePolicy` interface, and it uses the [IHttpCachePolicy::IsUserCacheEnabled](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachepolicy-isusercacheenabled-method.md) method to determine whether the user cache is enabled. The module then returns the status to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseGetCachePolicy#1](IHttpResponseGetCachePolicy#1)]  -->  
  
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
 [IHttpResponse Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::DisableKernelCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-disablekernelcache-method.md)   
 [IHttpResponse::GetKernelCacheEnabled Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getkernelcacheenabled-method.md)