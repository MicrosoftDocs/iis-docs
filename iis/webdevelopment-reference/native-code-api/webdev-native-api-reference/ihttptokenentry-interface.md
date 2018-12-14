---
title: "IHttpTokenEntry Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a7244321-a081-c31a-69fc-c78ce0380226
caps.latest.revision: 34
author: "shirhatti"
manager: "wpickett"
---
# IHttpTokenEntry Interface
Extends the [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) interface by adding token-specific information for tokens that are cached on a server.  
  
## Syntax  
  
```cpp  
class IHttpTokenEntry : public IHttpCacheSpecificData  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpTokenEntry` class.  
  
|Name|Description|  
|----------|-----------------|  
|[DecrementTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-decrementttl-method.md)|(Inherited from [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md).)|  
|[DereferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-getcachekey-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetFlushed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-getflushed-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[GetImpersonationToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-getimpersonationtoken-method.md)|Returns the impersonation token for a user.|  
|[GetPrimaryToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-getprimarytoken-method.md)|Returns the primary token for the process that is servicing a request.|  
|[GetSid](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-getsid-method.md)|Returns the security identifier for a user.|  
|[ReferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-referencecachedata-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[ResetTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-resetttl-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
|[SetFlushed](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-setflushed-method.md)|(Inherited from `IHttpCacheSpecificData`.)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) pointer by calling the [ICacheProvider::GetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacherecord-method.md) method and, in some cases, you can downcast this `IHttpCacheSpecificData` pointer to an `IHttpTokenEntry` pointer.  
  
 For more information on downcast rules, see [ICacheProvider::GetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacherecord-method.md).  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_CACHE_OPERATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) and [GL_CACHE_CLEANUP](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) events and then writes the `IHttpTokenEntry` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpTokenEntry#1](IHttpTokenEntry#1)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box holds XML similar to the following.  
  
```  
<cacheProvider>  
    <tokenEntry   
        impersonationToken="valid"   
        primaryToken="valid"   
        sid="true"/>  
</cacheProvider>  
```  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  
 [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)  
  
 `IHttpTokenEntry`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)