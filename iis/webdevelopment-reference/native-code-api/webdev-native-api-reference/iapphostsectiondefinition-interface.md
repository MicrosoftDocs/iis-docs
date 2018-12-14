---
title: "IAppHostSectionDefinition Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 429518b6-f1be-413b-a98c-4cad57b3aaa4
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# IAppHostSectionDefinition Interface
Provides access to the attributes that define the behavior of a configuration section.  
  
## Syntax  
  
```cpp  
IAppHostSectionDefinition : public IUnknown  
```  
  
## Methods  
 This interface contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IAppHostSectionDefinition` interface.  
  
|Property|Description|  
|--------------|-----------------|  
|[AllowDefinition](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-allowdefinition-property.md)|Gets or sets a value that indicates valid configuration path locations for the configuration section.|  
|[AllowLocation](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-allowlocation-property.md)|Gets or sets a value that indicates whether the configuration section allows the location attribute.|  
|[Name](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-name-property.md)|Gets the name of the current configuration section definition.|  
|[OverrideModeDefault](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-overridemodedefault-property.md)|Gets or sets the default override behavior for the current configuration section.|  
|[Type](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-type-property.md)|Gets the type name of a class that represents the current configuration section.|  
  
## Inheritance Hierarchy  
 [IUnknown](http://go.microsoft.com/fwlink/?LinkId=55951)  
  
 `IAppHostSectionDefinition`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [Application Host Administration Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/application-host-administration-interfaces.md)