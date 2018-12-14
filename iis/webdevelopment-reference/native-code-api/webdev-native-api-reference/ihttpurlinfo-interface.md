---
title: "IHttpUrlInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b167da0a-aa53-2848-82a9-4d741987defc
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpUrlInfo Interface
Provides URL-specific information within the current context.  
  
## Syntax  
  
```cpp  
class IHttpUrlInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpUrlInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)|Returns the context container for the URL-specific information.|  
|[IsFrequentlyHit](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-isfrequentlyhit-method.md)|Returns a Boolean value that indicates whether the URL is requested frequently.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 The `IHttpUrlInfo` interface provides information for a URL within the current context. For example, you can call the [IPreBeginRequestProvider::GetHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iprebeginrequestprovider-gethttpcontext-method.md) or [IGlobalTraceEventProvider::GetCurrentHttpRequestContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-getcurrenthttprequestcontext-method.md) method to retrieve an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) interface for the current context, and then call the [IHttpContext::GetUrlInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-geturlinfo-method.md) method to retrieve an `IHttpUrlInfo` interface in order to retrieve the URL-specific information for the current context.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)