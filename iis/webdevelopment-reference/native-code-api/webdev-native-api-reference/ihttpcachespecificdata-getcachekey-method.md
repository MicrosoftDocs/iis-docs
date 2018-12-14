---
title: "IHttpCacheSpecificData::GetCacheKey Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3e91916c-8c29-70fa-7985-acb0b2beccdc
caps.latest.revision: 31
author: "shirhatti"
manager: "wpickett"
---
# IHttpCacheSpecificData::GetCacheKey Method
Returns the cache key associated with the cached data.  
  
## Syntax  
  
```cpp  
virtual IHttpCacheKey* GetCacheKey(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md) pointer.  
  
## Remarks  
 The behavior of the `GetCacheKey` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that implement the [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md) interface usually return a downcasted [IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md) pointer.  
  
-   Classes that implement the [IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md) interface usually return a downcasted [IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md) pointer.  
  
-   Classes that implement both the [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) and [IHttpUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-interface.md) interfaces usually return a downcasted [IUriKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md) pointer.  
  
> [!CAUTION]
>  Before you perform any downcast operation, always verify that the cast is valid to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Notes for Implementers  
 `IHttpCacheSpecificData` implementers are responsible for memory management with this data; therefore, `IHttpCacheSpecificData` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpCacheKey` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpCacheSpecificData` implementers are responsible for memory management with this data; therefore, `IHttpCacheSpecificData` clients must not release or call `delete` on the returned `IHttpCacheKey` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpCacheSpecificData#2](IHttpCacheSpecificData#2)]  -->  
  
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
        <fileKey path="D:\INETPUB\WWWROOT\DEFAULT.HTM"   
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
  
```  
<cacheProvider>  
    <cacheSpecificData   
        flushed="false">  
        <uriKey   
            siteId="1"   
            siteName="Default Web Site"   
            url="/"   
            cacheName="URI"   
            hash="46"   
            isEqual="true"   
            isPrefix="true"/>  
    </cacheSpecificData>  
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
 [IHttpCacheSpecificData Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)