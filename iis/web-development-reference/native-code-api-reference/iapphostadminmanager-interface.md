---
title: "IAppHostAdminManager Interface"
ms.date: "10/07/2016"
ms.assetid: 2e02f13e-9999-28dd-304d-507b041f9b5b
---
# IAppHostAdminManager Interface
Provides read-only access to effective data in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostAdminManager : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostAdminManager` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetAdminSection](../../web-development-reference\native-code-api-reference/iapphostadminmanager-getadminsection-method.md)|Gets an [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration section that has the requested name and configuration path.|  
|[GetMetadata](../../web-development-reference\native-code-api-reference/iapphostadminmanager-getmetadata-method.md)|Gets metadata values from the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[SetMetadata](../../web-development-reference\native-code-api-reference/iapphostadminmanager-setmetadata-method.md)|Sets metadata values in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostAdminManager` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ConfigManager](../../web-development-reference\native-code-api-reference/iapphostadminmanager-configmanager-property.md)|Gets an [IAppHostConfigManager](../../web-development-reference\native-code-api-reference/iapphostconfigmanager-interface.md) interface that provides access to the physical files in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
## Remarks  
 The `IAppHostAdminManager` interface provides read-only access to the effective values of a merged configuration set in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system. For a specified configuration path, the return values of this method represent the values in the hierarchically merged configuration set.  
  
 For access to set explicit values in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system, use the [IAppHostWritableAdminManager](../../web-development-reference\native-code-api-reference/iapphostwritableadminmanager-interface.md) interface.  
  
## Inheritance Hierarchy  
 [IUnknown](https://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostAdminManager`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostWritableAdminManager Interface](../../web-development-reference\native-code-api-reference/iapphostwritableadminmanager-interface.md)   
 [Application Host Administration API Reference](../../web-development-reference\native-code-api-reference/application-host-administration-api-reference.md)