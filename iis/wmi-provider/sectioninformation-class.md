---
title: "SectionInformation Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 60972c6f-9cc6-142f-8889-8ceb6548b21c
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# SectionInformation Class
Specifies override-mode and control-locking settings for a configuration section.  
  
## Syntax  
  
```vbs  
class SectionInformation : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SectionInformation` class.  
  
|Name|Description|  
|----------|-----------------|  
|`EffectiveOverrideMode`|A read-only `string` value that specifies whether the current configuration section can effectively override its inherited settings. The possible values are listed later in the Remarks section.<br /><br /> To determine the value of `EffectiveOverrideMode`, IIS traverses up the inheritance hierarchy of configuration sections from the current section. It successively examines the `OverrideMode` property of each parent section until it reaches the `overrideModeDefault` attribute in the section schema definition. IIS calculates the `EffectiveOverrideMode` by logically combining the values that it encounters and considering their hierarchical ranking. **Note:**  `overrideModeDefault` is an optional attribute that contains the default lockdown state of a configuration section. The `overrideModeDefault` attribute for each configuration section is located in the corresponding section definition under `<configSections>` in the ApplicationHost.config file. If `overrideModeDefault` is missing, its value is "Allow". If "Allow" is specified, lower level Web.config files can override settings for the section; if "Deny" is specified, they cannot. The `overrideModeDefault` default for most IIS Web server sections is "Deny". The default for most [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] sections is "Allow", because these sections contain application-level settings. The `overrideModeDefault` attribute has no corresponding property in WMI. If you have appropriate permissions, you can edit the ApplicationHost.config file directly or access it programatically by using XML parsing or file access APIs.|  
|`IsLocked`|A read-only `boolean` value. `true` if the current configuration section and its child elements cannot be modified; otherwise, `false`.|  
|`LockItem`|A read/write `boolean` value. `true` if the current configuration section and its child elements are locked; otherwise, `false`. The default is `false`. **Note:**  Although the default is `false`, this property will return `null` when it is initially read. If you explicitly set this initial value to `false`, the property will still return `null`. However, if you set the initial value to `true`, the property will return `true`; if you then set the value to `false`, the property will explicitly return `false`. This behavior is due to a limitation in the WMI provider.|  
|`OverrideMode`|A read/write `string` value that specifies whether lower level configuration files can override the settings in the current configuration section. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `SectionInformation` property of the [ConfigurationSection](../wmi-provider/configurationsection-class.md) class. All configuration section classes inherit the `SectionInformation` class as one of their properties.  
  
 The following table lists the possible values for the `EffectiveOverrideMode` property.  
  
|Keyword|Description|  
|-------------|-----------------|  
|`Allow`|Lower level configuration files can override the settings in the current configuration section.|  
|`Deny`|Lower level configuration files cannot override the settings in the current configuration section.|  
  
 The following table lists the possible values for the `OverrideMode` property. The default is "Inherit".  
  
|Keyword|Description|  
|-------------|-----------------|  
|`Inherit`|Lower level configuration files can or cannot override the settings in the current configuration section, depending on the combination of `OverrideMode` values that they inherit.|  
|`Allow`|Lower level configuration files can override the settings in the current configuration section.|  
|`Deny`|Lower level configuration files cannot override the settings in the current configuration section.|  
  
> [!NOTE]
>  The `EffectiveOverrideMode` property is useful in determining what the effective override mode for a configuration section is when the `OverrideMode` property is set to "Inherit".  
  
## Example  
 The following example retrieves the `SectionInformation` properties for all configuration sections.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Retrieve configuration sections.  
Set oConfigSections = oWebAdmin.ExecQuery( _  
    "SELECT * FROM ConfigurationSection")  
  
' Loop through the configuration sections.  
For Each oConfigSection In oConfigSections  
    iCounter = iCounter + 1  
  
    ' Display the name of each configuration section and its location.  
    WScript.Echo "[" & iCounter & "] " & oConfigSection.Path_.Class  
    WScript.Echo "Location: " & oConfigSection.Location  
  
    ' Display the SectionInformation property values.  
    Set oConfigSectionInfo = oConfigSection.SectionInformation  
    WScript.Echo "Effective Override Mode: " & _  
        oConfigSectionInfo.EffectiveOverrideMode  
    WScript.Echo "Is Locked: " & oConfigSectionInfo.IsLocked  
    WScript.Echo "Is Present: " & oConfigSectionInfo.IsPresent          
    WScript.Echo "Lock Item: " & oConfigSectionInfo.LockItem              
    WScript.Echo "Override Mode: " & oConfigSectionInfo.OverrideMode  
    WScript.Echo "------------------------------------------"  
Next  
  
```  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SectionInformation`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)