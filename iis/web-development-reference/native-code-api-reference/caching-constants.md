---
title: "Caching Constants"
description: This topic describes the constants that are defined in the Httpcach.h header file, with links to reference materials.
ms.date: "10/07/2016"
ms.assetid: 8dd0b80e-62df-49fe-9ed7-dde4322ea324
---
# Caching Constants
This topic describes the constants that are defined in the Httpcach.h header file.  
  
## Cache Name Constants  
 The following constants are used for returning values from the [IHttpCacheKey::GetCacheName](../../web-development-reference/native-code-api-reference/ihttpcachekey-getcachename-method.md) method for interfaces defined in the Httpcach.h file.  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|FILE_CACHE_NAME|L"FILE"|The [IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md) pointer may be safely downcast to an [IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md) pointer.|  
|TOKEN_CACHE_NAME|L"TOKEN"|The `IHttpCacheKey` pointer may be safely downcast to an [IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md) pointer.|  
|URI_CACHE_NAME|L"URI"|The `IHttpCacheKey` pointer may be safely downcast to an [IUriKey](../../web-development-reference/native-code-api-reference/iurikey-interface.md) pointer.|  
  
## Remarks  
 Before you perform any downcast operation, always verify that the cast is correct to guarantee correct program behavior. Consider using the [dynamic_cast](https://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible when you perform a downcast operation.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [Web Server Core Constants](../../web-development-reference/native-code-api-reference/web-server-core-constants.md)   
 [Creating Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/creating-native-code-http-modules.md)
