---
title: "IHttpCacheSpecificData Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2cdc07d4-1786-31ca-28fa-7b57db3c5f8f
caps.latest.revision: 49
author: "shirhatti"
manager: "wpickett"
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
|[DecrementTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-decrementttl-method.md)|Decrements the Time-to-Live (TTL) setting of the cached data.|  
|[DereferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md)|Decrements the internal reference count for the cached data.|  
|[GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-getcachekey-method.md)|Returns the cache key associated with the cached data.|  
|[GetFlushed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-getflushed-method.md)|Returns a value indicating whether the specific data has been flushed from the cache.|  
|[ReferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-referencecachedata-method.md)|Increments the internal reference count for the cached data.|  
|[ResetTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-resetttl-method.md)|Resets the Time-to-Live (TTL) setting of the cached data.|  
|[SetFlushed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-setflushed-method.md)|Sets a value indicating that the specific data is to be flushed from the cache.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md)|Extends the `IHttpCacheSpecificData` interface by adding file-specific information for files that are cached on a server.|  
|[IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md)|Extends the `IHttpCacheSpecificData` interface by adding token-specific information for tokens that are cached on a server.|  
  
## Remarks  
 You can retrieve an `IHttpCacheSpecificData` pointer from an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer by calling the [ICacheProvider::GetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacherecord-method.md) method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheSpecificData` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCacheSpecificData#1](IHttpCacheSpecificData#1)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
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
  
 [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md)  
  
 [IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IHttpFileInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md)   
 [IHttpTokenEntry Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md)