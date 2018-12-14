---
title: "IHttpResponse::DisableKernelCache Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cb176222-ffa6-4591-b5ec-dc22d164fa3e
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::DisableKernelCache Method
Disables the kernel cache for this response.  
  
## Syntax  
  
```cpp  
virtual VOID DisableKernelCache(  
   ULONG reason = 9  
) = 0;  
```  
  
#### Parameters  
 `reason`  
 The optional reason for disabling the kernel cache.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `DisableKernelCache` method disables kernel caching for the current response.  
  
 You can optionally pass a `reason` parameter that contains a value defined in the `IISCacheEvents::HTTPSYS_CACHEABLE::enumReason` enumeration to indicate why you are disabling caching.  
  
> [!NOTE]
>  If you do not pass a `reason` parameter to the `DisableKernelCache` method, the default value of 9 (`HANDLER_HTTPSYS_UNFRIENDLY`) will be used.  
  
## Example  
 The following code example demonstrates how to use the `DisableKernelCache` method to disable kernel caching for the current request.  
  
> [!NOTE]
>  Combine this example module with the example module listed for the [GetKernelCacheEnabled](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getkernelcacheenabled-method.md) method if you want to return the current caching status.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseDisableKernelCache#1](IHttpResponseDisableKernelCache#1)]  -->  
  
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
 [IHttpResponse::GetCachePolicy Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getcachepolicy-method.md)   
 [IHttpResponse::GetKernelCacheEnabled Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getkernelcacheenabled-method.md)   
 [IHttpServer::FlushKernelCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-flushkernelcache-method.md)