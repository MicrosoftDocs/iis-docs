---
title: "CACHE_OPERATION Enumeration"
ms.date: "10/07/2016"
ms.assetid: eac89782-7b9b-1fb3-c267-712522b7c96b
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
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes registering for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can then retrieve a `CACHE_OPERATION` enumeration value by calling the [ICacheProvider::GetCacheOperation](../../web-development-reference/native-code-api-reference/icacheprovider-getcacheoperation-method.md) method on the `ICacheProvider` pointer.  
  
 To determine which cache was affected by the cache operation, see the [IHttpCacheKey::GetCacheName](../../web-development-reference/native-code-api-reference/ihttpcachekey-getcachename-method.md) method.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `CACHE_OPERATION` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[Enumerations#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/Enumerations/cpp/CACHE_OPERATION.cpp#1)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md) .  
  
 The above code writes a new event to the Event Viewer, where the Data node holds a string similar to the following.  
  
```  
GetCacheOperation: CACHE_OPERATION_RETRIEVE  
```  
  
 You can optionally compile the code by using the `stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer::DoCacheOperation Method](../../web-development-reference/native-code-api-reference/ihttpserver-docacheoperation-method.md)
 [ICacheProvider::GetCacheOperation Method](../../web-development-reference/native-code-api-reference/icacheprovider-getcacheoperation-method.md)
 [CGlobalModule::OnGlobalCacheOperation Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)
