---
title: "IHttpCacheKey::GetHash Method"
ms.date: "10/07/2016"
ms.assetid: 4dbfc063-f7f7-d86d-f19e-2451bf72f70f
---
# IHttpCacheKey::GetHash Method
Returns the unique hash code of an item in the global cache.  
  
## Syntax  
  
```cpp  
virtual DWORD GetHash(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that represents the unique hash code of an item in the global cache.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) pointer by calling the [ICacheProvider::GetCacheKey](../../web-development-reference/native-code-api-reference/icacheprovider-getcachekey-method.md) method on the `ICacheProvider` pointer. You can then retrieve the hash code of the item involved in the cache operation by calling the `GetHash` method on the `IHttpCacheKey` pointer.  
  
 The `GetHash` return value depends on both interface and implementation. For example, implementers of the [IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md), [IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md), and [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md) interfaces all use different hashing algorithms based upon the data that they hold.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` and the hash information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheKey#3](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheKey/cpp/GetHash.cpp#3)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains a string similar to the following.  
  
```  
IHttpCacheKey::GetHash: 46  
  
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