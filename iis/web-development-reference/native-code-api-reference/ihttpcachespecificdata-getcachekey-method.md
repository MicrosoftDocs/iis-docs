---
title: "IHttpCacheSpecificData::GetCacheKey Method"
ms.date: "10/07/2016"
ms.assetid: 3e91916c-8c29-70fa-7985-acb0b2beccdc
---
# IHttpCacheSpecificData::GetCacheKey Method

Returns the cache key associated with the cached data.  
  
## Syntax  
  
```cpp  
virtual IHttpCacheKey* GetCacheKey(  
   VOID  
) const = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 An [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) pointer.  
  
## Remarks  

 The behavior of the `GetCacheKey` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
- Classes that implement the [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface usually return a downcasted [IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md) pointer.  
  
- Classes that implement the [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md) interface usually return a downcasted [IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md) pointer.  
  
- Classes that implement both the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) and [IHttpUrlInfo](../../web-development-reference/native-code-api-reference/ihttpurlinfo-interface.md) interfaces usually return a downcasted [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md) pointer.  
  
> [!CAUTION]
>  Before you perform any downcast operation, always verify that the cast is valid to guarantee correct program behavior.  
  
> [!NOTE]
>  Consider using the [dynamic_cast](https://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Notes for Implementers  

 `IHttpCacheSpecificData` implementers are responsible for memory management with this data; therefore, `IHttpCacheSpecificData` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpCacheKey` pointer when it is no longer needed.  
  
## Notes for Callers  

 `IHttpCacheSpecificData` implementers are responsible for memory management with this data; therefore, `IHttpCacheSpecificData` clients must not release or call `delete` on the returned `IHttpCacheKey` pointer when this data is no longer needed.  
  
## Example  

 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpCacheKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IHttpCacheSpecificData#2](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpCacheSpecificData/cpp/GetCacheKey.cpp#2)]  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpCacheSpecificData Interface](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)
