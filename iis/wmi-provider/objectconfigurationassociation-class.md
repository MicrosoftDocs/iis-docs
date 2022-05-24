---
title: "ObjectConfigurationAssociation Class"
description: "ObjectConfigurationAssociation class associates a configured object with its configuration section and describes a containment association between two namespace objects."
ms.date: "10/07/2016"
ms.assetid: c67f2a8d-efac-9e05-784d-82333e1017d5
---
# ObjectConfigurationAssociation Class
Associates a configured object with its configuration section.  
  
## Syntax  
  
```vbs  
class ObjectConfigurationAssociation  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ObjectConfigurationAssociation` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ConfigurationSection`|An `object ref` value that represents the configuration section for an object.|  
|`ConfiguredObject`|An `object ref` value that represents an object that is configured.|  
  
## Subclasses  
 The following table lists the subclasses exposed by the `ObjectConfigurationAssociation` class.  
  
|Name|Description|  
|----------|-----------------|  
|[ApplicationContainsConfigurationSection](../wmi-provider/applicationcontainsconfigurationsection-class.md)|Provides a relationship between an IIS Web application and a configuration section.|  
|[SiteContainsConfigurationSection](../wmi-provider/sitecontainsconfigurationsection-class.md)|Provides a relationship between a Web site and its configuration sections.|  
|[VirtualDirectoryContainsConfigurationSection](../wmi-provider/virtualdirectorycontainsconfigurationsection-class.md)|Provides a relationship between a virtual directory and a configuration section.|  
  
## Remarks  
 This abstract class describes a strict containment association between two different namespace objects. It is the base type from which all object–configuration section associations derive.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [WMI Provider](../wmi-provider/wmi-provider.md)   
 [ApplicationContainsConfigurationSection Class](../wmi-provider/applicationcontainsconfigurationsection-class.md)   
 [SiteContainsConfigurationSection Class](../wmi-provider/sitecontainsconfigurationsection-class.md)   
 [VirtualDirectoryContainsConfigurationSection Class](../wmi-provider/virtualdirectorycontainsconfigurationsection-class.md)
