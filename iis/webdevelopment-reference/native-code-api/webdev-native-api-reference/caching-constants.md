---
title: "Caching Constants | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8dd0b80e-62df-49fe-9ed7-dde4322ea324
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# Caching Constants
This topic describes the constants that are defined in the Httpcach.h header file.  
  
## Cache Name Constants  
 The following constants are used for returning values from the [IHttpCacheKey::GetCacheName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-getcachename-method.md) method for interfaces defined in the Httpcach.h file.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|FILE_CACHE_NAME|L"FILE"|The [IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md) pointer may be safely downcast to an [IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md) pointer.|  
|TOKEN_CACHE_NAME|L"TOKEN"|The `IHttpCacheKey` pointer may be safely downcast to an [IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md) pointer.|  
|URI_CACHE_NAME|L"URI"|The `IHttpCacheKey` pointer may be safely downcast to an [IUriKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iurikey-interface.md) pointer.|  
  
## Remarks  
 Before you perform any downcast operation, always verify that the cast is correct to guarantee correct program behavior. Consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [Web Server Core Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-constants.md)   
 [Creating Native-Code HTTP Modules](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/creating-native-code-http-modules.md)