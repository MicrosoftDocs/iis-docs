---
title: "CACHE_OPERATION Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: eac89782-7b9b-1fb3-c267-712522b7c96b
caps.latest.revision: 34
author: "shirhatti"
manager: "wpickett"
---
# CACHE_OPERATION Enumeration
Defines the enumeration values for cache operations.  
  
## Syntax  
  
```cpp  
typedef enum CACHE_OPERATION {  
   CACHE_OPERATION_RETRIEVE,  
   CACHE_OPERATION_ADD,  
   CACHE_OPERATION_DELETE,  
   CACHE_OPERATION_FLUSH_PREFIX,  
   CACHE_OPERATION_ENUM  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`CACHE_OPERATION_RETRIEVE`|Indicates that data is being retrieved from the cache.|  
|`CACHE_OPERATION_ADD`|Indicates that data is being added to the cache.|  
|`CACHE_OPERATION_DELETE`|Indicates that data is being deleted from the cache.|  
|`CACHE_OPERATION_FLUSH_PREFIX`|Indicates that all data entries whose keys have a given prefix are being removed from the cache.|  
|`CACHE_OPERATION_ENUM`|Indicates that the cache is being enumerated.|  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes registering for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can then retrieve a `CACHE_OPERATION` enumeration value by calling the [ICacheProvider::GetCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacheoperation-method.md) method on the `ICacheProvider` pointer.  
  
 To determine which cache was affected by the cache operation, see the [IHttpCacheKey::GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getcachename-method.md) method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `CACHE_OPERATION` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [Enumerations#1](Enumerations#1)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md) .  
  
 The above code writes a new event to the Event Viewer, where the Data node holds a string similar to the following.  
  
```  
GetCacheOperation: CACHE_OPERATION_RETRIEVE  
```  
  
 You can optionally compile the code by using the `stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer::DoCacheOperation Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-docacheoperation-method.md)   
 [ICacheProvider::GetCacheOperation Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacheoperation-method.md)   
 [CGlobalModule::OnGlobalCacheOperation Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)