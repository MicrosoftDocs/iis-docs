---
title: "IAppHostConfigFile Interface"
ms.date: "10/07/2016"
ms.assetid: 4b03fb70-e66d-226a-1bfe-5a5cd863e439
---
# IAppHostConfigFile Interface

Represents a configuration file in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostConfigFile: IUnknown  
```  
  
## Methods  

 The following table lists the methods exposed by the `IAppHostConfigFile` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[ClearInvalidSections](../../web-development-reference/native-code-api-reference/iapphostconfigfile-clearinvalidsections-method.md)|Removes invalid configuration sections from a configuration file.|  
|[GetAdminSection](../../web-development-reference/native-code-api-reference/iapphostconfigfile-getadminsection-method.md)|Gets a configuration section for a given configuration section and configuration path.|  
|[GetMetadata](../../web-development-reference/native-code-api-reference/iapphostconfigfile-getmetadata-method.md)|Gets metadata from the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[SetMetadata](../../web-development-reference/native-code-api-reference/iapphostconfigfile-setmetadata-method.md)|Sets metadata in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration file.|  
  
## Properties  

 The following table lists the properties exposed by the `IAppHostConfigFile` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ConfigPath](../../web-development-reference/native-code-api-reference/iapphostconfigfile-configpath-property.md)|Gets the configuration system path of the configuration file that this `IAppHostConfigFile` interface represents.|  
|[FilePath](../../web-development-reference/native-code-api-reference/iapphostconfigfile-filepath-property.md)|Gets the file system path of the configuration file that this `IAppHostConfigFile` interface represents.|  
|[Locations](../../web-development-reference/native-code-api-reference/iapphostconfigfile-locations-property.md)|Returns a collection of [IAppHostConfigLocation](../../web-development-reference/native-code-api-reference/iapphostconfiglocation-interface.md) interfaces that represent location tags defined for the current configuration file.|  
|[RootSectionGroup](../../web-development-reference/native-code-api-reference/iapphostconfigfile-rootsectiongroup-property.md)|Returns the root configuration section group for the current configuration file.|  
  
## Inheritance Hierarchy  

 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigFile`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  

 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)   
 [IAppHostConfigManager Interface](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-interface.md)
