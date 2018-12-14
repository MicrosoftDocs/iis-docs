---
title: "IFileKey Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f99a547e-97e3-0298-09df-297719c95c20
caps.latest.revision: 53
author: "shirhatti"
manager: "wpickett"
---
# IFileKey Interface
Represents key information for accessing associated data in the global file cache.  
  
## Syntax  
  
```cpp  
class IFileKey : public IHttpCacheKey  
```  
  
## Methods  
 The following table lists the methods exposed by the `IFileKey` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[Enum](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-enum-method.md)|(Inherited from [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md).)|  
|[GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-getcachename-method.md)|Overridden. Returns the name of the global file cache.|  
|[GetHash](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-gethash-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsEqual](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisequal-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsPrefix](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getisprefix-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-getpath-method.md)|Returns the absolute physical path of a file.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 The `IFileKey` interface extends the [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md) interface by adding support for returning the absolute physical path of a file through the [IFileKey::GetPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-getpath-method.md) method. `IFileKey` also overrides the [IHttpCacheKey::GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getcachename-method.md) method by providing the default implementation through the [IFileKey::GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-getcachename-method.md) method.  
  
## Notes for Implementers  
 For each non-abstract class that implements the `IFileKey` interface, you must provide a hash code in the `GetHash` method to map the `IFileKey` pointer data to a unique `DWORD` value for that data.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `IFileKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IFileKey#1](IFileKey#1)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider>  
    <fileKey   
        path="C:\INETPUB\WWWROOT\DEFAULT.HTM"   
        cacheName="FILE"   
        hash="123456789"   
        isEqual="true"   
        isPrefix="true"/>  
</cacheProvider>  
```  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md)  
  
 `IFileKey`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)