---
title: "IHttpApplicationProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 3aae3259-655e-382f-8fb4-6bfa24b1e3f9
---
# IHttpApplicationProvider Interface

Provides an interface for application startup notifications.  
  
## Syntax  
  
```cpp  
class IHttpApplicationProvider : public IHttpEventProvider  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpApplicationProvider` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetApplication](../../web-development-reference/native-code-api-reference/ihttpapplicationprovider-getapplication-method.md)|Retrieves an [IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md) interface.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  

 The following table lists the derived classes exposed by the `IHttpApplicationProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpApplicationResolveModulesProvider](../../web-development-reference/native-code-api-reference/ihttpapplicationresolvemodulesprovider-interface.md)|Provides an interface for registering HTTP modules.|  
  
## Remarks  

 IIS creates and passes an `IHttpApplicationProvider` interface to a module's [CGlobalModule::OnGlobalApplicationStart](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationstart-method.md) method when the module has registered for the [GL_APPLICATION_START](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  

 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IHttpApplicationProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [CGlobalModule::OnGlobalApplicationStart Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalapplicationstart-method.md)
