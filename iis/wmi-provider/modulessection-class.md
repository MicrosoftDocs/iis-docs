---
title: "ModulesSection Class"
ms.date: "10/07/2016"
ms.assetid: b3dd0504-bf13-b108-ecce-65a96fc1d014
---
# ModulesSection Class
Represents the modules section in a configuration file.  
  
## Syntax  
  
```vbs  
class ModulesSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `ModulesSection` class.  
  
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
 The following table lists the properties exposed by the `ModulesSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Modules`|An array of read/write [ModuleAction](../wmi-provider/moduleaction-class.md) values.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`RunAllManagedModulesForAllRequests`|A read/write `boolean` value. `true` if all managed modules are run for every request; otherwise, `false`. The default is `false`.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class contains global modules that are enabled at a particular level on a Web server, and managed modules that also perform request work at the same level.  
  
## Example  
 The following example displays the native and managed modules in the `<modules>` section of the ApplicationHost.config file.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the <modules> section.  
Set oSection = oWebAdmin.Get( _  
    "ModulesSection.Path='MACHINE/WEBROOT/APPHOST/',Location=''")  
  
' Display the native modules.  
WScript.Echo "---------- Native -------------"  
For Each oModule In oSection.Modules  
    If oModule.Type = "" Then  
        WScript.Echo "   " & oModule.Name  
    End If  
Next  
WScript.Echo   
  
' Display the managed modules.  
WScript.Echo "---------- Managed ----------"  
For Each oModule In oSection.Modules  
    If oModule.Type <> "" Then  
        If Len(oModule.Name) < 12 Then  
            WScript.Echo "   " & oModule.Name & _  
                vbTab & vbTab & vbTab & "[" & oModule.Type & "]"  
        ElseIf Len(oModule.Name) < 20 Then  
            WScript.Echo "   " & oModule.Name & _  
                vbTab & vbTab & "[" & oModule.Type & "]"  
        Else   
            WScript.Echo "   " & oModule.Name & _  
                vbTab & "[" & oModule.Type & "]"  
        End If  
    End If  
Next  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `ModulesSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [GlobalModuleElement Class](../wmi-provider/globalmoduleelement-class.md)   
 [GlobalModulesSection Class](../wmi-provider/globalmodulessection-class.md)   
 [ModuleAction Class](../wmi-provider/moduleaction-class.md)