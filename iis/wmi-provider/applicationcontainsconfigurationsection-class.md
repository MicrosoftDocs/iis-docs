---
title: ApplicationContainsConfigurationSection Class1
description: Describes the ApplicationContainsConfiguration Section class and provides the class' syntax, methods, properties, and requirements.
ms.date: 10/07/2016
ms.assetid: 437265a3-6c4a-f094-7afd-75a84fd6e982
---
# ApplicationContainsConfigurationSection Class1
Provides a relationship between an IIS Web application and a configuration section.  
  
## Syntax  
  
```vbs  
class ApplicationContainsConfigurationSection : ObjectConfigurationAssociation  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ApplicationContainsConfigurationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ConfigurationSection`|(Inherited from [ObjectConfigurationAssociation](../wmi-provider/objectconfigurationassociation-class.md).) A read-only [ConfigurationSection](../wmi-provider/configurationsection-class.md) value. A key property.|  
|`ConfiguredObject`|(Inherited from `ObjectConfigurationAssociation`.) A read-only [Application](../wmi-provider/application-class.md) value. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ObjectConfigurationAssociation](../wmi-provider/objectconfigurationassociation-class.md)  
  
 `ApplicationContainsConfigurationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Application Class](../wmi-provider/application-class.md)   
 [ObjectConfigurationAssociation Class](../wmi-provider/objectconfigurationassociation-class.md)
