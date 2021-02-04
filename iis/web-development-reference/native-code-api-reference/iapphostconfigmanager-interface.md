---
title: "IAppHostConfigManager Interface"
ms.date: "10/07/2016"
ms.assetid: 8b12b98d-1f40-32f8-9451-50b8330166fe
---
# IAppHostConfigManager Interface
Provides access to the physical configuration files in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostConfigManager : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostConfigManager` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetConfigFile](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-getconfigfile-method.md)|Gets a configuration file that is represented by the requested configuration path.|  
|[GetUniqueConfigPath](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-getuniqueconfigpath-method.md)|Gets a unique configuration path that represents the deepest path where configuration is defined.|  
  
## Properties  
 This interface contains no properties.  
  
## Inheritance Hierarchy  
 [IUnknown](/windows/win32/api/unknwn/nn-unknwn-iunknown)  
  
 `IAppHostConfigManager`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostConfigFile Interface](../../web-development-reference/native-code-api-reference/iapphostconfigfile-interface.md)
