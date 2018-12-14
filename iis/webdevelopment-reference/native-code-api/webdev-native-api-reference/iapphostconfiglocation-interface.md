---
title: "IAppHostConfigLocation Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 561b9314-d818-d465-9445-209aa61c44f9
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConfigLocation Interface
Represents a configuration location in the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] configuration system.  
  
## Syntax  
  
```cpp  
interface IAppHostConfigLocation : IUnknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IAppHostConfigLocation` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[AddConfigSection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-addconfigsection-method.md)|Adds a configuration section to the current configuration location.|  
|[DeleteConfigSection](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-deleteconfigsection-method.md)|Removes a configuration section from the current configuration location.|  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostConfigLocation` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[Count](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-count-property.md)|Gets the number of configuration sections that are configured for the current configuration location.|  
|[Item](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-item-property.md)|Gets the requested configuration section from the current location.|  
|[Path](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfiglocation-path-property.md)|Gets the path of the current configuration location.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostConfigLocation`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)