---
title: "IHttpApplication Interface"
ms.date: "10/07/2016"
ms.assetid: faa76e4c-9d1e-ad2c-185f-52ec4aab7c5f
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
|[GetAppConfigPath](../../web-development-reference/native-code-api-reference/ihttpapplication-getappconfigpath-method.md)|Retrieves the application configuration path.|  
|[GetApplicationId](../../web-development-reference/native-code-api-reference/ihttpapplication-getapplicationid-method.md)|Retrieves the identifying application path for the current request.|  
|[GetApplicationPhysicalPath](../../web-development-reference/native-code-api-reference/ihttpapplication-getapplicationphysicalpath-method.md)|Retrieves the physical path of the application for the current request.|  
|[GetModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpapplication-getmodulecontextcontainer-method.md)|Returns the module context container for the application.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IGlobalApplicationPreloadProvider2](../../web-development-reference/native-code-api-reference/iglobalapplicationpreloadprovider2-interface.md)|Provides information about whether an application’s worker process is recycled.|  
  
## Remarks  
 HTTP modules can use the `IHttpApplication` interface to retrieve configuration information for an application. Specifically, the `GetAppConfigPath` method returns the configuration path for an application, the `GetApplicationId` method returns the unique identity path for an application, and the `GetApplicationPhysicalPath` method returns the physical path for the root folder of an application.  
  
 HTTP modules can retrieve an `IHttpApplication` interface by using the [IGlobalThreadCleanupProvider::GetApplication](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-getapplication.md), [IHttpApplicationProvider::GetApplication](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-getapplication-method.md), and [IHttpContext::GetApplication](../../web-development-reference/native-code-api-reference/ihttpcontext-getapplication-method.md) methods.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
 [IGlobalThreadCleanupProvider::GetApplication](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-getapplication.md)
 [IHttpApplicationProvider::GetApplication Method](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-getapplication-method.md)
 [IHttpContext::GetApplication Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getapplication-method.md)
