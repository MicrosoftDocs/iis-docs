---
title: "IAppHostConfigFile Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 4b03fb70-e66d-226a-1bfe-5a5cd863e439
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConfigFile Interface
Represents a configuration file in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostConfigFile: IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostConfigFile` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[ClearInvalidSections](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-clearinvalidsections-method.md)|Removes invalid configuration sections from a configuration file.|  
|[GetAdminSection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-getadminsection-method.md)|Gets a configuration section for a given configuration section and configuration path.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-getmetadata-method.md)|Gets metadata from the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[SetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-setmetadata-method.md)|Sets metadata in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration file.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostConfigFile` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ConfigPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-configpath-property.md)|Gets the configuration system path of the configuration file that this `IAppHostConfigFile` interface represents.|  
|[FilePath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-filepath-property.md)|Gets the file system path of the configuration file that this `IAppHostConfigFile` interface represents.|  
|[Locations](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-locations-property.md)|Returns a collection of [IAppHostConfigLocation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-interface.md) interfaces that represent location tags defined for the current configuration file.|  
|[RootSectionGroup](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigfile-rootsectiongroup-property.md)|Returns the root configuration section group for the current configuration file.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigFile`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostConfigManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigmanager-interface.md)