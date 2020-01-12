---
title: "IHttpCacheKey::GetIsPrefix Method"
ms.date: "10/07/2016"
ms.assetid: 12816d70-6ae9-8035-f7d1-e4ceb2b78db0
---
# IHttpCacheKey::GetIsPrefix Method
Returns a value that indicates whether two [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) pointers have the same prefix.  
  
## Syntax  
  
```cpp  
virtual bool GetIsPrefix(  
   IHttpCacheKey* pCacheCompareKey  
) const = 0;  
```  
  
### Parameters  
 `pCacheCompareKey`  
 A pointer to an `IHttpCacheKey` to compare with the current `IHttpCacheKey`.  
  
## Return Value  
 `true` if the current `IHttpCacheKey` has the same prefix as the `pCacheCompareKey` parameter; otherwise, `false`.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an `IHttpCacheKey` pointer by calling the [ICacheProvider::GetCacheKey](../../web-development-reference/native-code-api-reference/icacheprovider-getcachekey-method.md) method on the `ICacheProvider` pointer. You can then comparing two `IHttpCacheKey` pointers by calling the `GetIsPrefix` method.  
  
 The `pCacheCompareKey` parameter must not be NULL; otherwise, `GetIsPrefix` will throw an access violation. In addition, `pCacheCompareKey` must be the same extended interface type as the current `IHttpCacheKey` pointer. For example, if the current `IHttpCacheKey` pointer implements the [IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md) interface, the `pCacheCompareKey` parameter must implement `IFileKey`, as well.  
  
 The `GetIsPrefix` return value depends on both interface and implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that implement `IFileKey` return `true` only if the [IFileKey::GetPath](../../web-development-reference/native-code-api-reference/ifilekey-getpath-method.md) method on the current `IHttpCacheKey` pointer returns a `PCWSTR` that is a substring of the `PCWSTR` returned from the same method on the `pCacheCompareKey` pointer, starting at index 0.  
  
-   Classes that implement the [IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md) interface return `false`.  
  
-   Classes that implement the [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md) interface return `false` immediately if the [IUriKey::GetSiteId](../../web-development-reference/native-code-api-reference/iurikey-getsiteid-method.md) value of the current `IHttpCacheKey` pointer is not the same as the value returned from the same method on the `pCacheCompareKey` parameter. Otherwise, `GetIsPrefix` returns `true` only if the [IUriKey::GetUrl](../../web-development-reference/native-code-api-reference/iurikey-geturl-method.md) method on the current `IHttpCacheKey` pointer returns a `PCWSTR` that is a substring of the `PCWSTR` returned from the same method on the `pCacheCompareKey` pointer, starting at index 0.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` and the `GetIsPrefix` information to the Event Viewer. It also demonstrates that if the same `IHttpCacheKey` pointer is compared against itself, the `GetIsPrefix` method will return `true`.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheKey#5](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheKey/cpp/GetIsPrefix.cpp#5)]  
  
 The above code writes new events to the Event Viewer, where the Data box contains strings similar to the following. If the cache name is TOKEN, `false` is returned.  
  
```  
IHttpCacheKey::GetIsPrefix: true  
```  
  
```  
IHttpCacheKey::GetIsPrefix: false  
```  
  
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
 [IHttpCacheKey Interface](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md)