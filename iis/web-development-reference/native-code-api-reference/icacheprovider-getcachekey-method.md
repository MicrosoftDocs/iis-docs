---
title: ICacheProvider::GetCacheKey Method
description: Describes the ICacheProvider::GetCacheKey method and provides the method's syntax, return value, remarks, notes for implementers, an example, and requirements.
ms.date: 10/07/2016
ms.assetid: 557ae36c-12e4-cbda-4178-67c3620067c6
---
# ICacheProvider::GetCacheKey Method
Returns the cache key for the cache provider.  
  
## Syntax  
  
```cpp  
virtual IHttpCacheKey* GetCacheKey(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) for the cache provider.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an `IHttpCacheKey` pointer by calling the `GetCacheKey` method on the `ICacheProvider` pointer.  
  
## Notes for Implementers  
 `ICacheProvider` implementers are responsible for memory management with this data; therefore, `ICacheProvider` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpCacheKey` pointer when it is no longer needed.  
  
 The following table is a sample of one-to-one interface mappings that must be returned from the `GetCacheKey` and [GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md) methods from the same implementer of the `ICacheProvider` interface.  
  
|GetCacheKey interface|GetCacheRecord interface|  
|---------------------------|------------------------------|  
|[IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md)|[IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)|  
|[IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md)|[IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)|  
|`IHttpCacheKey`|[IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)|  
  
## Notes for Callers  
 `ICacheProvider` implementers are responsible for memory management with this data; therefore, `ICacheProvider` clients must not release or call `delete` on the returned `IHttpCacheKey` pointer when this data is no longer needed.  
  
 In some cases, an `IHttpCacheSpecificData` pointer returned from `GetCacheRecord` may be downcast to a more specific interface to access extended behavior. Call the `GetCacheKey` method to retrieve the `IHttpCacheKey` pointer, and then call the [IHttpCacheKey::GetCacheName](../../web-development-reference/native-code-api-reference/ihttpcachekey-getcachename-method.md) method to retrieve the name of the cache. The following table is a sample of values returned from `GetCacheName` and the corresponding interface to which the current `IHttpCacheSpecificData` pointer may then be safely downcast, assuming an otherwise correct downcast procedure takes place. See [IIS Caching Constants](../../web-development-reference/native-code-api-reference/caching-constants.md) for constant values.  
  
|GetCacheName value|Interface|  
|------------------------|---------------|  
|FILE|`IHttpFileInfo`|  
|TOKEN|`IHttpTokenEntry`|  
  
> [!CAUTION]
>  Before performing any downcast operation, always verify that the cast is correct to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](https://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `ICacheProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[ICacheProvider#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ICacheProvider/cpp/GetCacheKey.cpp#2)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes new events to the application log of the Event Viewer, where the Data box contains XML similar to the following (depending on the `IHttpCacheKey` type).  
  
```  
<cacheProvider>  
    <uriKey />  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
    <tokenKey />  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
   <fileKey />  
</cacheProvider>  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICacheProvider Interface](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md)
