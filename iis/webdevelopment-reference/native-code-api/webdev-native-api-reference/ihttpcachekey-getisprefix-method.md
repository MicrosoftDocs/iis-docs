---
title: "IHttpCacheKey::GetIsPrefix Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 12816d70-6ae9-8035-f7d1-e4ceb2b78db0
caps.latest.revision: 39
author: "shirhatti"
manager: "wpickett"
---
# IHttpCacheKey::GetIsPrefix Method
Returns a value that indicates whether two [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md) pointers have the same prefix.  
  
## Syntax  
  
```cpp  
virtual bool GetIsPrefix(  
   IHttpCacheKey* pCacheCompareKey  
) const = 0;  
```  
  
#### Parameters  
 `pCacheCompareKey`  
 A pointer to an `IHttpCacheKey` to compare with the current `IHttpCacheKey`.  
  
## Return Value  
 `true` if the current `IHttpCacheKey` has the same prefix as the `pCacheCompareKey` parameter; otherwise, `false`.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an `IHttpCacheKey` pointer by calling the [ICacheProvider::GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcachekey-method.md) method on the `ICacheProvider` pointer. You can then comparing two `IHttpCacheKey` pointers by calling the `GetIsPrefix` method.  
  
 The `pCacheCompareKey` parameter must not be NULL; otherwise, `GetIsPrefix` will throw an access violation. In addition, `pCacheCompareKey` must be the same extended interface type as the current `IHttpCacheKey` pointer. For example, if the current `IHttpCacheKey` pointer implements the [IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md) interface, the `pCacheCompareKey` parameter must implement `IFileKey`, as well.  
  
 The `GetIsPrefix` return value depends on both interface and implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that implement `IFileKey` return `true` only if the [IFileKey::GetPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-getpath-method.md) method on the current `IHttpCacheKey` pointer returns a `PCWSTR` that is a substring of the `PCWSTR` returned from the same method on the `pCacheCompareKey` pointer, starting at index 0.  
  
-   Classes that implement the [IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md) interface return `false`.  
  
-   Classes that implement the [IUriKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md) interface return `false` immediately if the [IUriKey::GetSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-getsiteid-method.md) value of the current `IHttpCacheKey` pointer is not the same as the value returned from the same method on the `pCacheCompareKey` parameter. Otherwise, `GetIsPrefix` returns `true` only if the [IUriKey::GetUrl](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-geturl-method.md) method on the current `IHttpCacheKey` pointer returns a `PCWSTR` that is a substring of the `PCWSTR` returned from the same method on the `pCacheCompareKey` pointer, starting at index 0.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` and the `GetIsPrefix` information to the Event Viewer. It also demonstrates that if the same `IHttpCacheKey` pointer is compared against itself, the `GetIsPrefix` method will return `true`.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCacheKey#5](IHttpCacheKey#5)]  -->  
  
 The above code writes new events to the Event Viewer, where the Data box contains strings similar to the following. If the cache name is TOKEN, `false` is returned.  
  
```  
IHttpCacheKey::GetIsPrefix: true  
```  
  
```  
IHttpCacheKey::GetIsPrefix: false  
```  
  
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
 [IHttpCacheKey Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md)