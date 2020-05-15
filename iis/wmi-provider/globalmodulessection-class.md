---
title: "GlobalModulesSection Class"
ms.date: "10/07/2016"
ms.assetid: 33de2b19-45d0-5b8d-da62-cc95a314d8d4
---
# GlobalModulesSection Class

Exposes configuration settings for IIS global modules.  
  
## Syntax  
  
```vbs  
class GlobalModulesSection : ConfigurationSectionWithCollection  
```  
  
## Methods  

 The following table lists the methods exposed by the `GlobalModulesSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  

 The following table lists the properties exposed by the `GlobalModulesSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`GlobalModules`|An array of [GlobalModuleElement](../wmi-provider/globalmoduleelement-class.md) objects.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 The `<globalModules>` section in the ApplicationHost.config file specifies the native modules at the server level. You can enable these modules by adding their names to the `<modules>` section at the desired configuration level in ApplicationHost.config or in a Web.config file. In WMI, you can do this by using the `Add` method of the [ModulesSection](../wmi-provider/modulessection-class.md) class.  
  
## Example  

 The following example lists the modules in the `<globalModules>` section.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the ApplicationHost.config <globalModules> section.  
Set oSection = oWebAdmin.Get( _  
    "GlobalModulesSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST/',Location=''")  
  
' Display the path.  
WScript.Echo  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo  
  
' Display the global modules.  
WScript.Echo "Global Modules"  
WScript.Echo "--------------"  
For Each oGMElement In oSection.GlobalModules  
     WScript.Echo "Module: " & oGMElement.Name  
     WScript.Echo "Image: " & oGMElement.Image  
     WScript.Echo "PreCondition: " & oGMElement.PreCondition  
     WScript.Echo  
Next  
```  
  
## Inheritance Hierarchy  

 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `GlobalModulesSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [GlobalModuleElement Class](../wmi-provider/globalmoduleelement-class.md)   
 [ModulesSection Class](../wmi-provider/modulessection-class.md)
