---
title: "HttpModuleAction Class"
ms.date: "10/07/2016"
ms.assetid: 74ccab52-cc4b-a564-29be-dc629671b13c
---
# HttpModuleAction Class
Represents an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] module.  
  
## Syntax  
  
```vbs  
class HttpModuleAction : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HttpModuleAction` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A read-only `string` value that specifies the name of an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] module. The key property.|  
|`Type`|A read/write `string` value that specifies the type for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] module. **Note:**  The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `HttpModules` property of the [HttpModulesSection](../wmi-provider/httpmodulessection-class.md) class.  
  
 The modules represented by the `HttpModuleAction` class are specific to [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and are in the `<system.web>` section of the Web.config file. These modules are contained in the `Modules` array property of the [HttpModulesSection](../wmi-provider/httpmodulessection-class.md) class.  
  
 The modules represented by the [ModuleAction](../wmi-provider/moduleaction-class.md) class are [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] related and are in the `<system.webServer>` section of the ApplicationHost.config file. These modules are contained in the [ModulesSection](../wmi-provider/modulessection-class.md) class.  
  
## Example  
 The following example displays the `HttpModuleAction` values that are in the `HttpModules` property of the `HttpModulesSection` class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the HttpModulesSection.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HttpModulesSection", oSection  
  
' Display the HttpModuleAction instances.   
WScript.Echo "------[ Http Modules ]------"  
For Each oHttpModule In oSection.HttpModules  
     WScript.Echo "Name: " & oHttpModule.Name  
     WScript.Echo "Type: " & oHttpModule.Type  
     WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `HttpModuleAction`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HttpModulesSection Class](../wmi-provider/httpmodulessection-class.md)   
 [ModulesSection Class](../wmi-provider/modulessection-class.md)   
 [ModuleAction Class](../wmi-provider/moduleaction-class.md)