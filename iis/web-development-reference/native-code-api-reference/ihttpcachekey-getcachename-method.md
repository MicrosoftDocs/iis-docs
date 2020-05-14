---
title: "IHttpCacheKey::GetCacheName Method"
ms.date: "10/07/2016"
ms.assetid: 9051f74f-4c24-4af5-9cdb-a3b6038b6149
---
# IHttpCacheKey::GetCacheName Method
Returns the unique name of the cache where a [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event has occurred.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetCacheName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the unique name of the cache where a `GL_CACHE_OPERATION` event has occurred.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for `GL_CACHE_OPERATION` events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) pointer by calling the [ICacheProvider::GetCacheKey](../../web-development-reference/native-code-api-reference/icacheprovider-getcachekey-method.md) method on the `ICacheProvider` pointer. You can then retrieve the unique name of the global cache by calling the `GetCacheName` method on the `IHttpCacheKey` pointer.  
  
## Notes for Implementers  
 `IHttpCacheKey` implementers are responsible for memory management with this data; therefore, `IHttpCacheKey` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpCacheKey` implementers are responsible for memory management with this data; therefore, `IHttpCacheKey` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR` as either an access violation will be thrown, or the data will become invalid.  
  
 In some cases, an `IHttpCacheKey` pointer may be downcast to a more specific interface to access extended behavior. For more information, see [IIS Caching Constants](../../web-development-reference/native-code-api-reference/caching-constants.md).  
  
## Notes for Inheritors  
 Any interface that directly extends the `IHttpCacheKey` interface must return a well-known and unique default value for that extended interface. This allows clients to safely downcast an `IHttpCacheKey` pointer to the more specific interface in some cases.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` and the cache name information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheKey#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheKey/cpp/GetCacheName.cpp#2)]  
  
 The above code writes new events to the Event Viewer, where the Data box contains strings similar to the following.  
  
```  
IHttpCacheKey::GetCacheName: FILE  
```  
  
```  
IHttpCacheKey::GetCacheName: TOKEN  
```  
  
```  
IHttpCacheKey::GetCacheName: URI  
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
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
