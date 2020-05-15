---
title: "IHttpApplicationResolveModulesProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 25a6eaf7-468a-fba7-ac30-54cf1af989ec
---
# IHttpApplicationResolveModulesProvider Interface

Provides an interface for registering HTTP modules.  
  
## Syntax  
  
```cpp  
class IHttpApplicationResolveModulesProvider : public IHttpApplicationProvider  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpApplicationResolveModulesProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetApplication](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-getapplication-method.md)|(Inherited from [IHttpApplicationProvider](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md).)|  
|[RegisterModule](../../web-development-reference/native-code-api-reference/ihttpapplicationresolvemodulesprovider-registermodule-method.md)|Registers an HTTP module.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
|[SetPriorityForRequestNotification](../../web-development-reference/native-code-api-reference/ihttpapplicationresolvemodulesprovider-setpriorityforrequestnotification-method.md)|Sets the request-level priority for a specific module.|  
  
## Derived Classes  

 This interface contains no derived classes.  
  
## Remarks  

 An `IHttpApplicationResolveModulesProvider` interface is created and passed to a module's [CGlobalModule::OnGlobalApplicationResolveModules](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationresolvemodules-method.md) method when the module has registered for the [GL_APPLICATION_RESOLVE_MODULES](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  

 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 [IHttpApplicationProvider](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md)  
  
 `IHttpApplicationResolveModulesProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpApplicationProvider Interface](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-interface.md)   
 [IHttpEventProvider Interface](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)
