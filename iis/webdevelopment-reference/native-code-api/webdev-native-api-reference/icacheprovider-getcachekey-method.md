---
title: "ICacheProvider::GetCacheKey Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 557ae36c-12e4-cbda-4178-67c3620067c6
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# ICacheProvider::GetCacheKey Method
Returns the cache key for the cache provider.  
  
## Syntax  
  
```cpp  
virtual IHttpCacheKey* GetCacheKey(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md) for the cache provider.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an `IHttpCacheKey` pointer by calling the `GetCacheKey` method on the `ICacheProvider` pointer.  
  
## Notes for Implementers  
 `ICacheProvider` implementers are responsible for memory management with this data; therefore, `ICacheProvider` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpCacheKey` pointer when it is no longer needed.  
  
 The following table is a sample of one-to-one interface mappings that must be returned from the `GetCacheKey` and [GetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacherecord-method.md) methods from the same implementer of the `ICacheProvider` interface.  
  
|GetCacheKey interface|GetCacheRecord interface|  
|---------------------------|------------------------------|  
|[IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md)|[IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md)|  
|[IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md)|[IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md)|  
|`IHttpCacheKey`|[IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)|  
  
## Notes for Callers  
 `ICacheProvider` implementers are responsible for memory management with this data; therefore, `ICacheProvider` clients must not release or call `delete` on the returned `IHttpCacheKey` pointer when this data is no longer needed.  
  
 In some cases, an `IHttpCacheSpecificData` pointer returned from `GetCacheRecord` may be downcast to a more specific interface to access extended behavior. Call the `GetCacheKey` method to retrieve the `IHttpCacheKey` pointer, and then call the [IHttpCacheKey::GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getcachename-method.md) method to retrieve the name of the cache. The following table is a sample of values returned from `GetCacheName` and the corresponding interface to which the current `IHttpCacheSpecificData` pointer may then be safely downcast, assuming an otherwise correct downcast procedure takes place. See [IIS Caching Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/caching-constants.md) for constant values.  
  
|GetCacheName value|Interface|  
|------------------------|---------------|  
|FILE|`IHttpFileInfo`|  
|TOKEN|`IHttpTokenEntry`|  
  
> [!CAUTION]
>  Before performing any downcast operation, always verify that the cast is correct to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `ICacheProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [ICacheProvider#2](ICacheProvider#2)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICacheProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md)