---
title: "ApplicationContainsVirtualDirectory Class2"
ms.date: "10/07/2016"
ms.assetid: f0d66fa9-7661-4f48-99e1-c14e72d3c045
---
# ApplicationContainsVirtualDirectory Class2

Provides a relationship between an IIS application and its virtual directories.  
  
## Syntax  
  
```vbs  
class ApplicationContainsVirtualDirectory : ObjectContainerAssociation  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ApplicationContainsVirtualDirectory` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Container`|(Inherited from [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md).) A read-only [Application](../wmi-provider/application-class.md) object that represents an IIS application. A key property.|  
|`Element`|(Inherited from `ObjectContainerAssociation`.) A read-only [VirtualDirectory](../wmi-provider/virtualdirectory-class.md) object that represents an IIS virtual directory. A key property.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 This association enumerates the virtual directories for a given application.  
  
## Example  

 The following example lists the virtual directory paths and physical paths for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the application for the default Web site.  
Set oApp = oWebAdmin.Get("Application.SiteName='Default Web Site',Path='/'")  
  
' Return the set of virtual directory instances in the application.  
Set oVDirs = oApp.Associators_("ApplicationContainsVirtualDirectory")  
  
' Print out the virtual directories and their physical paths.  
For Each oVDir In oVDirs  
    WScript.Echo "Virtual Path: " & oVDir.Path  
    WScript.Echo "PhysicalPath: " & oVDir.PhysicalPath  
    WScript.Echo  
Next  
```  
  
 Note the following syntax from the preceding code example.  
  
 `Set oVDirs = oApp.Associators_("ApplicationContainsVirtualDirectory")`  
  
 To simplify your code, you can instead use the following syntax, which enables you to use the association without having to remember its exact name.  
  
 `Set oVDirs = oApp.Associators_(, "VirtualDirectory")`  
  
## Inheritance Hierarchy  

 [ObjectContainerAssociation](../wmi-provider/objectcontainerassociation-class.md)  
  
 `ApplicationContainsVirtualDirectory`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [Application Class](../wmi-provider/application-class.md)   
 [ObjectContainerAssociation Class](../wmi-provider/objectcontainerassociation-class.md)   
 [VirtualDirectory Class](../wmi-provider/virtualdirectory-class.md)
