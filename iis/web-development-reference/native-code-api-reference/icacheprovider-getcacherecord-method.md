---
title: "ICacheProvider::GetCacheRecord Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 212ddfc3-7d3c-eca9-efa5-a87f340dcd69
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# ICacheProvider::GetCacheRecord Method
Returns the cache record for the cache provider.  
  
## Syntax  
  
```cpp  
virtual IHttpCacheSpecificData* GetCacheRecord(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpCacheSpecificData](../../web-development-reference\native-code-api-reference/ihttpcachespecificdata-interface.md) interface.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference\native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference\native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an `IHttpCacheSpecificData` pointer by calling the `GetCacheRecord` method on the `ICacheProvider` pointer.  
  
## Notes for Implementers  
 [ICacheProvider](../../web-development-reference\native-code-api-reference/icacheprovider-interface.md) implementers declare a `private``IHttpCacheSpecificData` pointer as member data. When constructors of these implementers are called, this member data is assigned to an `IHttpCacheSpecificData` pointer. Before calling the `SetCacheRecord method`, the caller is responsible for first calling the [IHttpCacheSpecificData::ReferenceCacheData](../../web-development-reference\native-code-api-reference/ihttpcachespecificdata-referencecachedata-method.md) method on the `IHttpCacheSpecificData` pointer; `SetCacheRecord` implementers then assign the `private` variable to this `IHttpCacheSpecificData` pointer.  
  
 The following table is a sample of one-to-one interface mappings that must be returned from the [GetCacheKey](../../web-development-reference\native-code-api-reference/icacheprovider-getcachekey-method.md) and `GetCacheRecord` methods from the same implementer of the `ICacheProvider` interface.  
  
|GetCacheKey interface|GetCacheRecord interface|  
|---------------------------|------------------------------|  
|[IFileKey](../../web-development-reference\native-code-api-reference/ifilekey-interface.md)|[IHttpFileInfo](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md)|  
|[IHttpTokenKey](../../web-development-reference\native-code-api-reference/ihttptokenkey-interface.md)|[IHttpTokenEntry](../../web-development-reference\native-code-api-reference/ihttptokenentry-interface.md)|  
|[IHttpCacheKey](../../web-development-reference\native-code-api-reference/ihttpcachekey-interface.md)|`IHttpCacheSpecificData`|  
  
## Notes for Callers  
 `ICacheProvider` implementers take ownership of the `IHttpCacheSpecificData` pointer. Before calling `SetCacheRecord`, first call `IHttpCacheSpecificData::ReferenceCacheData` on the pointer so that this pointer has one owner. Callers of `GetCacheRecord` do not take ownership of the returned `IHttpCacheSpecificData` pointer.  
  
 In some cases, an `IHttpCacheSpecificData` pointer returned from `GetCacheRecord` may be downcast to a more specific interface to access extended behavior. Call the `GetCacheKey` method to retrieve the `IHttpCacheKey` pointer, and then call the [IHttpCacheKey::GetCacheName](../../web-development-reference\native-code-api-reference/ihttpcachekey-getcachename-method.md) method to retrieve the name of the cache. The following table lists sample values returned from `GetCacheName` and the corresponding interface to which the current `IHttpCacheSpecificData` pointer may then be safely downcast, assuming an otherwise correct downcast procedure takes place. See [IIS Caching Constants](../../web-development-reference\native-code-api-reference/caching-constants.md) for constant values.  
  
|GetCacheName value|Interface|  
|------------------------|---------------|  
|FILE|`IHttpFileInfo`|  
|TOKEN|`IHttpTokenEntry`|  
  
> [!CAUTION]
>  Before performing any downcast operation, always verify that the cast is correct to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheSpecificData` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [ICacheProvider#4](ICacheProvider#4)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes a new event to the application log of the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider>  
    <fileInfo />  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
    <tokenEntry />  
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
 [ICacheProvider Interface](../../web-development-reference\native-code-api-reference/icacheprovider-interface.md)