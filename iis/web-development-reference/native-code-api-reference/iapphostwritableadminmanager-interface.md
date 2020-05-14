---
title: "IAppHostWritableAdminManager Interface"
ms.date: "10/07/2016"
ms.assetid: f1ca4d4d-b421-eba8-a50a-74305fa71944
---
# IAppHostWritableAdminManager Interface
Provides read/write access to explicit data in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostWritableAdminManager : public IAppHostAdminManager  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostWritableAdminManager` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[CommitChanges](../../web-development-reference/native-code-api-reference/iapphostwritableadminmanager-commitchanges-method.md)|Commits configuration changes to the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostWritableAdminManager` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[CommitPath](../../web-development-reference/native-code-api-reference/iapphostwritableadminmanager-commitpath-property.md)|Gets or sets the configuration path where changes should be committed.|  
  
## Remarks  
 The `IAppHostWritableAdminManager` interface provides read/write access to explicit values in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system. The method return values of this interface represent the values of the explicitly requested configuration path.  
  
 To obtain access to the effective values of a merged configuration set in the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration system, use the [IAppHostAdminManager](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md) interface.  
  
## Inheritance Hierarchy  
 [IAppHostAdminManager](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)  
  
 `IAppHostWritableAdminManager`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../web-development-reference/native-code-api-reference/application-host-administration-interfaces.md)
 [IAppHostAdminManager Interface](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)
