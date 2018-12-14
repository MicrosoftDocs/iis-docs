---
title: "IHttpApplication Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: faa76e4c-9d1e-ad2c-185f-52ec4aab7c5f
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IHttpApplication Interface
Retrieves application-specific configuration information.  
  
## Syntax  
  
```cpp  
class IHttpApplication  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpApplication` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAppConfigPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-getappconfigpath-method.md)|Retrieves the application configuration path.|  
|[GetApplicationId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-getapplicationid-method.md)|Retrieves the identifying application path for the current request.|  
|[GetApplicationPhysicalPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-getapplicationphysicalpath-method.md)|Retrieves the physical path of the application for the current request.|  
|[GetModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-getmodulecontextcontainer-method.md)|Returns the module context container for the application.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IGlobalApplicationPreloadProvider2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalapplicationpreloadprovider2-interface.md)|Provides information about whether an application’s worker process is recycled.|  
  
## Remarks  
 HTTP modules can use the `IHttpApplication` interface to retrieve configuration information for an application. Specifically, the `GetAppConfigPath` method returns the configuration path for an application, the `GetApplicationId` method returns the unique identity path for an application, and the `GetApplicationPhysicalPath` method returns the physical path for the root folder of an application.  
  
 HTTP modules can retrieve an `IHttpApplication` interface by using the [IGlobalThreadCleanupProvider::GetApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalthreadcleanupprovider-getapplication.md), [IHttpApplicationProvider::GetApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationprovider-getapplication-method.md), and [IHttpContext::GetApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getapplication-method.md) methods.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IGlobalThreadCleanupProvider::GetApplication](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalthreadcleanupprovider-getapplication.md)   
 [IHttpApplicationProvider::GetApplication Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplicationprovider-getapplication-method.md)   
 [IHttpContext::GetApplication Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getapplication-method.md)