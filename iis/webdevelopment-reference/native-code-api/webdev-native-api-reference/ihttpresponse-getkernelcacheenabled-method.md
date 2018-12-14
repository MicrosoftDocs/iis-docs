---
title: "IHttpResponse::GetKernelCacheEnabled Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 26fd4e99-9c54-abfa-9782-86bdbee4ad05
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::GetKernelCacheEnabled Method
Determines whether the kernel cache is enabled for the current response.  
  
## Syntax  
  
```cpp  
virtual BOOL GetKernelCacheEnabled(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the kernel cache is enabled for the current response; otherwise, `false`.  
  
## Remarks  
 The `GetKernelCacheEnabled` method returns a Boolean value of `true` if kernel-mode caching is enabled for the current response, and it returns a value of `false` if caching is disabled.  
  
> [!NOTE]
>  There are additional reasons why a response may not be cached by the server (for example, compression settings or Secure Sockets Layer settings). Therefore, a value of `true` does not mean that the response will be cached; it means only that caching is enabled.  
  
## Example  
 The following code example demonstrates how to use the `GetKernelCacheEnabled` method to create an HTTP module that determines whether kernel caching is enabled for the current response. The module then returns this information to the client.  
  
> [!NOTE]
>  Combine this example module with the example module that is listed for the [IHttpResponse::DisableKernelCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-disablekernelcache-method.md) method if you want to disable caching and return the status to the client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseGetKernelCacheEnabled#1](IHttpResponseGetKernelCacheEnabled#1)]  -->  
  
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
 [IHttpResponse::GetCachePolicy Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getcachepolicy-method.md)