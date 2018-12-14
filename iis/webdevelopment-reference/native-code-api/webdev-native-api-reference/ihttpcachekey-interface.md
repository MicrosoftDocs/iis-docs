---
title: "IHttpCacheKey Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5aee4c82-06de-08c4-ce8d-813dfcb8c506
caps.latest.revision: 53
author: "shirhatti"
manager: "wpickett"
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
|[Enum](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-enum-method.md)|Enumerates an [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) pointer.|  
|[GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getcachename-method.md)|Returns the unique name of the cache where a [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event has occurred.|  
|[GetHash](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-gethash-method.md)|Returns the unique hash code of an item in the global cache.|  
|[GetIsEqual](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisequal-method.md)|Returns a value indicating whether two `IHttpCacheKey` pointers are equivalent.|  
|[GetIsPrefix](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisprefix-method.md)|Returns a value indicating whether two `IHttpCacheKey` pointers have the same prefix.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md)|Represents key information for accessing associated data in the global file cache.|  
|[IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md)|Represents key information for accessing associated data in the global token cache.|  
|[IUriKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md)|Represents key information for accessing associated data in the Uniform Resource Identifier (URI) cache.|  
  
## Remarks  
 You can retrieve an `IHttpCacheKey` pointer from an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer by calling the [ICacheProvider::GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcachekey-method.md) method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCacheKey#1](IHttpCacheKey#1)]  -->  
  
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
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 `IHttpCacheKey`  
  
 [IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md)  
  
 [IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md)  
  
 [IUriKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)