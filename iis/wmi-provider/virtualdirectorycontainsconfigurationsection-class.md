---
title: VirtualDirectoryContainsConfigurationSection Class2
description: Describes the VirtualDirectoryContainsConfigurationSection Class and provides the class' syntax, properties, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 8d6f5aa5-9c66-24d3-ad57-b7e368a9a218
---
# VirtualDirectoryContainsConfigurationSection Class2
Provides a relationship between a virtual directory and a configuration section.  
  
## Syntax  
  
```vbs  
class VirtualDirectoryContainsConfigurationSection : ObjectConfigurationAssociation  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties for the `VirtualDirectoryContainsConfigurationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|A read-only [VirtualDirectory](../wmi-provider/virtualdirectory-class.md) object that represents an IIS virtual directory.|  
|`Element`|A read-only [ConfigurationSection](../wmi-provider/configurationsection-class.md) object that exposes the configuration section for a virtual directory.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ObjectConfigurationAssociation](../wmi-provider/objectconfigurationassociation-class.md)  
  
 `VirtualDirectoryContainsConfigurationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [ObjectConfigurationAssociation Class](../wmi-provider/objectconfigurationassociation-class.md)   
 [VirtualDirectory Class](../wmi-provider/virtualdirectory-class.md)
