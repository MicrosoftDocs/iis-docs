---
title: "IAppHostWritableAdminManager Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f1ca4d4d-b421-eba8-a50a-74305fa71944
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# IAppHostWritableAdminManager Interface
Provides read/write access to explicit data in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostWritableAdminManager : public IAppHostAdminManager  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostWritableAdminManager` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[CommitChanges](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostwritableadminmanager-commitchanges-method.md)|Commits configuration changes to the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostWritableAdminManager` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[CommitPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostwritableadminmanager-commitpath-property.md)|Gets or sets the configuration path where changes should be committed.|  
  
## Remarks  
 The `IAppHostWritableAdminManager` interface provides read/write access to explicit values in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system. The method return values of this interface represent the values of the explicitly requested configuration path.  
  
 To obtain access to the effective values of a merged configuration set in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system, use the [IAppHostAdminManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-interface.md) interface.  
  
## Inheritance Hierarchy  
 [IAppHostAdminManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-interface.md)  
  
 `IAppHostWritableAdminManager`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)   
 [IAppHostAdminManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-interface.md)