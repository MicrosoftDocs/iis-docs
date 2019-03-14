---
title: "IGlobalConfigurationChangeProvider Interface"
ms.date: "10/07/2016"
ms.assetid: c919ff1f-d592-f8ec-f2a5-f644eb0f7e7a
---
# IGlobalConfigurationChangeProvider Interface
Provides a global-level interface for [GL_CONFIGURATION_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.  
  
## Syntax  
  
```cpp  
class IGlobalConfigurationChangeProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalConfigurationChangeProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetChangePath](../../web-development-reference/native-code-api-reference/iglobalconfigurationchangeprovider-getchangepath-method.md)|Returns the path of a configuration change.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 An `IGlobalConfigurationChangeProvider` interface is created and passed to a module's [CGlobalModule::OnGlobalConfigurationChange](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalconfigurationchange-method.md) method when the module has registered for the [GL_CONFIGURATION_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalConfigurationChangeProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [CGlobalModule::OnGlobalConfigurationChange Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalconfigurationchange-method.md)   
 [IHttpEventProvider Interface](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)