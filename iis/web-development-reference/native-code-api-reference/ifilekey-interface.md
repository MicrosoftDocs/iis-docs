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
|[Enum](../../web-development-reference\native-code-api-reference/ihttpcachekey-enum-method.md)|(Inherited from [IHttpCacheKey](../../web-development-reference\native-code-api-reference/ihttpcachekey-interface.md).)|  
|[GetCacheName](../../web-development-reference\native-code-api-reference/ifilekey-getcachename-method.md)|Overridden. Returns the name of the global file cache.|  
|[GetHash](../../web-development-reference\native-code-api-reference/ihttpcachekey-gethash-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsEqual](../../web-development-reference\native-code-api-reference/ihttpcachekey-getisequal-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetIsPrefix](../../web-development-reference\native-code-api-reference/ihttpcachekey-getisprefix-method.md)|(Inherited from `IHttpCacheKey`.)|  
|[GetPath](../../web-development-reference\native-code-api-reference/ifilekey-getpath-method.md)|Returns the absolute physical path of a file.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 The `IFileKey` interface extends the [IHttpCacheKey](../../web-development-reference\native-code-api-reference/ihttpcachekey-interface.md) interface by adding support for returning the absolute physical path of a file through the [IFileKey::GetPath](../../web-development-reference\native-code-api-reference/ifilekey-getpath-method.md) method. `IFileKey` also overrides the [IHttpCacheKey::GetCacheName](../../web-development-reference\native-code-api-reference/ihttpcachekey-getcachename-method.md) method by providing the default implementation through the [IFileKey::GetCacheName](../../web-development-reference\native-code-api-reference/ifilekey-getcachename-method.md) method.  
  
## Notes for Implementers  
 For each non-abstract class that implements the `IFileKey` interface, you must provide a hash code in the `GetHash` method to map the `IFileKey` pointer data to a unique `DWORD` value for that data.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../web-development-reference\native-code-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and then writes the `IFileKey` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
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
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpCacheKey](../../web-development-reference\native-code-api-reference/ihttpcachekey-interface.md)  
  
 `IFileKey`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)