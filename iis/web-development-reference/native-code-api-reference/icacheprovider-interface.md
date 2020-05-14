---
title: "ICacheProvider Interface"
ms.date: "10/07/2016"
ms.assetid: ab6b60bf-88e1-51e1-7c34-e28000868c6a
---
# ICacheProvider Interface
Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by adding support for retrieving cache information from a cache provider.  
  
## Syntax  
  
```cpp  
class ICacheProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `ICacheProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetCacheKey](../../web-development-reference/native-code-api-reference/icacheprovider-getcachekey-method.md)|Returns the cache key for the cache provider.|  
|[GetCacheOperation](../../web-development-reference/native-code-api-reference/icacheprovider-getcacheoperation-method.md)|Returns the cache operation for the cache provider.|  
|[GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md)|Returns the cache record for the cache provider.|  
|[GetTraceContext](../../web-development-reference/native-code-api-reference/icacheprovider-gettracecontext-method.md)|Returns the trace context for the cache provider.|  
|[SetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-setcacherecord-method.md)|Sets the cache-specific data on the cache provider.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from `IHttpEventProvider`.)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `ICacheProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[ICacheProvider#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ICacheProvider/cpp/ICacheProvider.cpp#1)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes a new event to the application log of the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider cacheOperation="CACHE_OPERATION_RETRIEVE">  
    <fileKey
        path="D:\INETPUB\WWWROOT"
        cacheName="FILE"
        hash="-711969814"
        isEqual="true"
        isPrefix="true"/>  
    <fileInfo
        changed="false"
        attributes="32"
        eTag="1234567890abcde:0"
        buffer="true"
        path="C:\INETPUB\WWWROOT\DEFAULT.HTM"
        handle="INVALID_HANDLE_VALUE"
        cacheAllowed="true"
        secondsToLive="-1"
        lastModifiedString="Tue, 13 Dec 2005 10:57:41 GMT"
        lastModifiedTime="12/13/2005 02:57"
        size="50"
        vrPath="NULL"
        vrToken="NULL">  
        <fileKey
            path="C:\INETPUB\WWWROOT\DEFAULT.HTM"
            cacheName="FILE"
            hash="-711969814"
            isEqual="true"
            isPrefix="true" />  
        <contextContainer>  
            <storedContext />  
        </contextContainer>  
    </fileInfo>  
    <traceContext
        activityId="{00000000-0000-0000-3400-0080000000FF}">  
        <traceConfiguration
            providerGuid=""
            areas="0"
            verbosity="0"
            providerEnabled="false"/>  
    </traceContext>  
</cacheProvider>  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `ICacheProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
