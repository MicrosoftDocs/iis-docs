---
title: "IAppHostAdminManager Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2e02f13e-9999-28dd-304d-507b041f9b5b
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# IAppHostAdminManager Interface
Provides read-only access to effective data in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
IAppHostAdminManager : public IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostAdminManager` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetAdminSection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-getadminsection-method.md)|Gets an [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration section that has the requested name and configuration path.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-getmetadata-method.md)|Gets metadata values from the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
|[SetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-setmetadata-method.md)|Sets metadata values in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostAdminManager` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[ConfigManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostadminmanager-configmanager-property.md)|Gets an [IAppHostConfigManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigmanager-interface.md) interface that provides access to the physical files in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.|  
  
## Remarks  
 The `IAppHostAdminManager` interface provides read-only access to the effective values of a merged configuration set in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system. For a specified configuration path, the return values of this method represent the values in the hierarchically merged configuration set.  
  
 For access to set explicit values in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system, use the [IAppHostWritableAdminManager](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostwritableadminmanager-interface.md) interface.  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostAdminManager`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostWritableAdminManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostwritableadminmanager-interface.md)   
 [Application Host Administration API Reference](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-api-reference.md)