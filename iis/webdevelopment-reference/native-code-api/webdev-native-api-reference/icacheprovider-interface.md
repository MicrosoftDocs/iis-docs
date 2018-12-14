---
title: "ICacheProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ab6b60bf-88e1-51e1-7c34-e28000868c6a
caps.latest.revision: 37
author: "shirhatti"
manager: "wpickett"
---
# ICacheProvider Interface
Extends the [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md) interface by adding support for retrieving cache information from a cache provider.  
  
## Syntax  
  
```cpp  
class ICacheProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `ICacheProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcachekey-method.md)|Returns the cache key for the cache provider.|  
|[GetCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacheoperation-method.md)|Returns the cache operation for the cache provider.|  
|[GetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacherecord-method.md)|Returns the cache record for the cache provider.|  
|[GetTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-gettracecontext-method.md)|Returns the trace context for the cache provider.|  
|[SetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-setcacherecord-method.md)|Sets the cache-specific data on the cache provider.|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from `IHttpEventProvider`.)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `ICacheProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [ICacheProvider#1](ICacheProvider#1)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
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
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `ICacheProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)