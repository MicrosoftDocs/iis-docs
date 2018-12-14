---
title: "IHttpSite Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3cd41621-c5a7-d717-2138-b5c34abbb539
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpSite Interface
Provides site-specific information within the current context.  
  
## Syntax  
  
```cpp  
class IHttpSite  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpSite` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-getmodulecontextcontainer-method.md)|Returns the context container for a site.|  
|[GetPerfCounterInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-getperfcounterinfo-method.md)|Retrieves an [IHttpPerfCounterInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpperfcounterinfo-interface.md) interface.|  
|[GetSiteId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-getsiteid-method.md)|Retrieves the unique ID for the Web site.|  
|[GetSiteName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-getsitename-method.md)|Retrieves the name for the Web site.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 The `IHttpSite` interface provides information for the Web site within the current context. For example, you can call the [IPreBeginRequestProvider::GetHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprebeginrequestprovider-gethttpcontext-method.md) or [IGlobalTraceEventProvider::GetCurrentHttpRequestContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-getcurrenthttprequestcontext-method.md) methods to retrieve an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) interface for the current context, and then call the [IHttpContext::GetSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getsite-method.md) method to retrieve an `IHttpSite` interface in order to retrieve the site-specific information for the current context.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)