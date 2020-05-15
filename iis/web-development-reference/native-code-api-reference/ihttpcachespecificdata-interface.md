---
title: "IHttpCacheSpecificData Interface"
ms.date: "10/07/2016"
ms.assetid: 2cdc07d4-1786-31ca-28fa-7b57db3c5f8f
---
# IHttpCacheSpecificData Interface

Provides information and access methods for data that is stored in a global cache.  
  
## Syntax  
  
```cpp  
class IHttpCacheSpecificData  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpCacheSpecificData` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[DecrementTTL](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-decrementttl-method.md)|Decrements the Time-to-Live (TTL) setting of the cached data.|  
|[DereferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md)|Decrements the internal reference count for the cached data.|  
|[GetCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-getcachekey-method.md)|Returns the cache key associated with the cached data.|  
|[GetFlushed](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-getflushed-method.md)|Returns a value indicating whether the specific data has been flushed from the cache.|  
|[ReferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-referencecachedata-method.md)|Increments the internal reference count for the cached data.|  
|[ResetTTL](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-resetttl-method.md)|Resets the Time-to-Live (TTL) setting of the cached data.|  
|[SetFlushed](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-setflushed-method.md)|Sets a value indicating that the specific data is to be flushed from the cache.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)|Extends the `IHttpCacheSpecificData` interface by adding file-specific information for files that are cached on a server.|  
|[IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)|Extends the `IHttpCacheSpecificData` interface by adding token-specific information for tokens that are cached on a server.|  
  
## Remarks  

 You can retrieve an `IHttpCacheSpecificData` pointer from an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer by calling the [ICacheProvider::GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md) method.  
  
## Example  

 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheSpecificData` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheSpecificData#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheSpecificData/cpp/IHttpCacheSpecificData.cpp#1)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes new events to the application log of the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider>  
    <cacheSpecificData   
        flushed="false">  
        <uriKey   
            siteId="1"   
            siteName="Default Web Site"   
            url="/DEFAULT.HTM"   
            cacheName="URI"   
            hash="59390334"   
            isEqual="true"   
            isPrefix="true"/>  
    </cacheSpecificData>  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
    <fileInfo   
        changed="false"   
        attributes="32"   
        eTag=""5e5e714ef4dc61:0""   
        buffer="false"   
        handle="valid"   
        path="C:\INETPUB\WWWROOT\DEFAULT.HTM"   
        cacheAllowed="true"   
        secondsToLive="-1"   
        lastModifiedString="Tue, 21 Mar 2006 17:45:56 GMT"   
        lastModifiedTime="valid"   
        size="92"   
        vrPath="C:\inetpub\wwwroot"   
        vrToken="NULL"   
        flushed="false">  
        <contextContainer>  
            <storedContext/>  
        </contextContainer>  
        <fileKey   
            path="D:\INETPUB\WWWROOT\DEFAULT.HTM"   
            cacheName="FILE"   
            hash="206817538"   
            isEqual="true"   
            isPrefix="true"/>  
    </fileInfo>  
</cacheProvider>  
```  
  
```  
<cacheProvider>  
    <tokenEntry   
        impersonationToken="valid"   
        primaryToken="valid"   
        sid="valid"   
        flushed="false">  
    <tokenKey   
        userName="IUSR"   
        passwordHash="1234567890"   
        logon="3"   
        cacheName="TOKEN"   
        hash="0"   
        isEqual="true"   
        isPrefix="false"/>  
    </tokenEntry>  
</cacheProvider>  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  

 `IHttpCacheSpecificData`  
  
 [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)  
  
 [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpFileInfo Interface](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)   
 [IHttpTokenEntry Interface](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)
