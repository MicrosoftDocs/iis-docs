---
title: "ModuleAction Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e00dbe6b-a97e-60a7-dd05-f4710e692b87
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# ModuleAction Class
Represents a module entry in the `<modules>` section of a configuration file.  
  
## Syntax  
  
```vbs  
class ModuleAction : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ModuleAction` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A required unique read/write `string` value that contains the name of the module. The key property.|  
|`PreCondition`|A read/write `string` value that contains a comma-delimited list of values that represent preconditions for the module to be loaded. The possible values are listed later in the Remarks section.|  
|`Type`|A read/write `string` value that specifies a managed module's type.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Modules` property of the [ModulesSection](../wmi-provider/modulessection-class.md) class.  
  
 The following table lists the possible values for the `PreCondition` property. The `integratedMode` and `ISAPIMode` settings are mutually exclusive. The default is `null`.  
  
|Value|Description|  
|-----------|-----------------|  
|`bitness32`|IIS loads the module in a 32-bit worker process. This setting applies only to 64-bit operating systems.|  
|`bitness64`|IIS loads the module in a 64-bit worker process. This setting applies only to 64-bit operating systems.|  
|`integratedMode`|IIS loads the module only for application pools that run in integrated mode.|  
|`ISAPIMode`|IIS loads the module only for application pools that run in ISAPI mode.|  
|`runtimeVersion`|IIS loads the module only for application pools that use the specified [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] version. To enable this precondition, append a string in the format v*MajorVersion*.*MinorVersion* to the string "runtimeVersion" (for example, "runtimeVersionv2.0").|  
|`managedHandler`|IIS loads the module only if the request is mapped to a managed handler. This setting can optimize performance by preventing static files from using managed modules for every request.|  
  
## Example  
 The following example adds a managed module to the root Web.config file.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the modules section.  
Set oModulesSection = _  
    oWebAdmin.Get("ModulesSection.Path=" & _  
        "'MACHINE/WEBROOT/APPHOST/Default Web Site',Location=''")  
  
' Get the ModuleAction class.  
Set oModuleAction = oWebAdmin.Get( "ModuleAction" )  
  
' Spawn a new instance of the ModuleAction class.  
Set oNewModule = oModuleAction.SpawnInstance_  
  
' Assign values to the new module's Name and Type properties.  
oNewModule.Name = "myNewModule2"  
oNewModule.Type = "System.Web.Profile.ProfileModule2"  
  
' Call the ModulesSection.Add method to add the new module.  
' If the module entry already exists, the error "Cannot create a file  
' when that file already exists." will be displayed.  
oModulesSection.Add "Modules", oNewModule  
  
' Alert user when done.  
WScript.Echo "Done!"  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ModuleAction`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [GlobalModuleElement Class](../wmi-provider/globalmoduleelement-class.md)   
 [GlobalModulesSection Class](../wmi-provider/globalmodulessection-class.md)   
 [ModulesSection Class](../wmi-provider/modulessection-class.md)