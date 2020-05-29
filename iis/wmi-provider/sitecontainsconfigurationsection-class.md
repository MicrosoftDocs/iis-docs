---
title: "SiteContainsConfigurationSection Class1"
ms.date: "10/07/2016"
ms.assetid: 41e78754-a0bb-4800-aaad-4c6ed9392d4d
---
# SiteContainsConfigurationSection Class1
Provides a relationship between a Web site and its configuration sections.  
  
## Syntax  
  
```vbs  
class SiteContainsConfigurationSection : ObjectConfigurationAssociation  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties for the `SiteContainsConfigurationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|A read-only [Site](../wmi-provider/site-class.md) object that represents an IIS Web site.|  
|`Element`|A read-only [ConfigurationSection](../wmi-provider/configurationsection-class.md) object that exposes the configuration section for a Web site.|  
  
## Subclasses  
 This class has no subclasses.  
  
## Remarks  
 Associations return only instances of the object that are defined at the level of the object. For example, if the `<authentication>` section is the only section defined in the Web.config file at the site level, only the [AuthenticationSection](../wmi-provider/authenticationsection-class.md) instance of the `ConfigurationSection` object will be returned.  
  
 To get all available sections, you should use the [GetAllSections](../wmi-provider/configuredobject-getallsections-method.md) method of the [ConfiguredObject](../wmi-provider/configuredobject-class.md) class.  
  
## Example  
 The following example lists all configuration sections that are defined at the Web.config level for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' List the configuration sections present in the Web.config file  
' of the default Web site.  
Set oSections = oSite.Associators_("SiteContainsConfigurationSection")  
For Each oSection In oSections  
    WScript.Echo oSection.Path_.Class  
Next  
```  
  
## Inheritance Hierarchy  
 [ObjectConfigurationAssociation](../wmi-provider/objectconfigurationassociation-class.md)  
  
 `SiteContainsConfigurationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfiguredObject.GetAllSections Method](../wmi-provider/configuredobject-getallsections-method.md)   
 [ObjectConfigurationAssociation Class](../wmi-provider/objectconfigurationassociation-class.md)   
 [Site Class](../wmi-provider/site-class.md)   
 [VirtualDirectoryContainsConfigurationSection Class](../wmi-provider/virtualdirectorycontainsconfigurationsection-class.md)
