---
title: "IHttpCacheKey Interface"
ms.date: "10/07/2016"
ms.assetid: 5aee4c82-06de-08c4-ce8d-813dfcb8c506
---
# IHttpCacheKey Interface
Provides key information for corresponding data that is stored in a global cache.  
  
## Syntax  
  
```cpp  
class IHttpCacheKey  
```  
  
## Methods  
  
|Topic|Description|  
|-----------|-----------------|  
|[Enum](../../web-development-reference/native-code-api-reference/ihttpcachekey-enum-method.md)|Enumerates an [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) pointer.|  
|[GetCacheName](../../web-development-reference/native-code-api-reference/ihttpcachekey-getcachename-method.md)|Returns the unique name of the cache where a [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event has occurred.|  
|[GetHash](../../web-development-reference/native-code-api-reference/ihttpcachekey-gethash-method.md)|Returns the unique hash code of an item in the global cache.|  
|[GetIsEqual](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisequal-method.md)|Returns a value indicating whether two `IHttpCacheKey` pointers are equivalent.|  
|[GetIsPrefix](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisprefix-method.md)|Returns a value indicating whether two `IHttpCacheKey` pointers have the same prefix.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md)|Represents key information for accessing associated data in the global file cache.|  
|[IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md)|Represents key information for accessing associated data in the global token cache.|  
|[IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md)|Represents key information for accessing associated data in the Uniform Resource Identifier (URI) cache.|  
  
## Remarks  
 You can retrieve an `IHttpCacheKey` pointer from an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer by calling the [ICacheProvider::GetCacheKey](../../web-development-reference/native-code-api-reference/icacheprovider-getcachekey-method.md) method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheKey#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheKey/cpp/IHttpCacheKey.cpp#1)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider>  
    <fileKey
        path="C:\INETPUB\WWWROOT\IISSTART.HTM"
        cacheName="FILE"
        hash="59594512"
        isEqual="true"
        isPrefix="true"/>  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
    <uriKey
        siteId="1"
        siteName=""
        url="/IISSTART.HTM"
        cacheName="URI"
        hash="-1945651104"
        isEqual="true"
        isPrefix="true"/>  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
    <tokenKey
        userName="IUSR"
        hashedPassword="abcdefg"
        logon="3"
        cacheName="TOKEN"
        hash="0"
        isEqual="true"
        isPrefix="false"/>  
</cacheProvider>  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 `IHttpCacheKey`  
  
 [IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md)  
  
 [IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md)  
  
 [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
