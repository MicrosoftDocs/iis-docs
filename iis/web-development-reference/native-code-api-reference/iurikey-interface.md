---
title: "IUriKey Interface"
ms.date: "10/07/2016"
ms.assetid: a922afbd-c069-af8f-3ac8-413c70eb1489
---
# IUriKey Interface
Represents key information for accessing associated data in the Uniform Resource Identifier (URI) cache.  
  
## Syntax  
  
```cpp  
class IUriKey : public IHttpCacheKey  
```  
  
## Methods  
 The following table lists the methods exposed by the `IUriKey` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[Enum](../../web-development-reference/native-code-api-reference/ihttpcachekey-enum-method.md)|(Inherited from [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md).)|  
|[GetCacheName](../../web-development-reference/native-code-api-reference/iurikey-getcachename-method.md)|Overridden. Returns the name of the URI cache.|  
|[GetConfigPath](../../web-development-reference/native-code-api-reference/iurikay-getconfigpath-method.md)|Returns the path of the configuration file.|  
|[GetHash](../../web-development-reference/native-code-api-reference/ihttpcachekey-gethash-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsEqual](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisequal-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsPrefix](../../web-development-reference/native-code-api-reference/ihttpcachekey-getisprefix-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetSiteId](../../web-development-reference/native-code-api-reference/iurikey-getsiteid-method.md)|Returns the site identifier associated with URI data.|  
|[GetSiteName](../../web-development-reference/native-code-api-reference/iurikey-getsitename-method.md)|Returns the site name associated with the URI data.|  
|[GetUrl](../../web-development-reference/native-code-api-reference/iurikey-geturl-method.md)|Returns the URL associated with the URI data.|  
|[UpdateFrequentlyHitTickCount](../../web-development-reference/native-code-api-reference/iurikey-interface.md)|Increments a counter each time the URI is requested.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 The `IUriKey` interface extends the [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) interface by adding support for returning a site identifier, a site name, and the URL of the data in the cache. `IUriKey` also overrides the [IHttpCacheKey::GetCacheName](../../web-development-reference/native-code-api-reference/ihttpcachekey-getcachename-method.md) method by providing the default implementation through the [IUriKey::GetCacheName](../../web-development-reference/native-code-api-reference/iurikey-getcachename-method.md) method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IUriKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IUriKey#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IUriKey/cpp/IUriKey.cpp#1)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML that is similar to the following.  
  
```  
<cacheProvider>  
   <uriKey   
        siteId="1"   
        siteName=""   
        url="/DEFAULT.HTM"   
        cacheName="URI"   
        hash="12345678"   
        isEqual="true"   
        isPrefix="true" />  
</cacheProvider>  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md)  
  
 `IUriKey`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)