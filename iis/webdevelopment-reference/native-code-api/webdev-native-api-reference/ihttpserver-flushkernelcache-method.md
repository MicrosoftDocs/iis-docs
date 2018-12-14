---
title: "IHttpServer::FlushKernelCache Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 935f7c14-8427-1283-859c-fbb0f45dabeb
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::FlushKernelCache Method
Flushes the kernel cache for a specific Uniform Resource Identifier (URI).  
  
## Syntax  
  
```cpp  
virtual HRESULT FlushKernelCache(  
   IN PCWSTR pszUrl  
) = 0;  
```  
  
#### Parameters  
 `pszUrl`  
 [IN] A pointer to a string that contains the URI to flush.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|NO_ERROR|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
|ERROR_NOT_SUPPORTED|Indicates that the operation is not supported within the current context.|  
  
## Remarks  
 Developers can use the `FlushKernelCache` method to remove a specific URI from the kernel cache.  
  
> [!NOTE]
>  The `FlushKernelCache` method differs from the [IHttpResponse::DisableKernelCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-disablekernelcache-method.md) method, which disables kernel caching for the URI that is processing the current response.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `FlushKernelCache` method to flush the kernel cache for the /default.aspx URI.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerFlushKernelCache#1](IHttpServerFlushKernelCache#1)]  -->  
  
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
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)   
 [IHttpResponse::DisableKernelCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-disablekernelcache-method.md)   
 [IHttpResponse::GetCachePolicy Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getcachepolicy-method.md)   
 [IHttpResponse::GetKernelCacheEnabled Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-getkernelcacheenabled-method.md)