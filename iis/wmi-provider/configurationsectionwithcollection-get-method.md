---
title: "ConfigurationSectionWithCollection.Get Method"
description: "The ConfigurationSectionWithCollection.Get Method retrieves the specified member of a collection from a configuration section. This article details syntax, parameters, return value, code example, and system requirements."
ms.date: "10/07/2016"
ms.assetid: 76e3b93f-8701-4c83-aa0c-08a662bcb258
---
# ConfigurationSectionWithCollection.Get Method
Retrieves the specified member of a collection from a configuration section.  
  
## Syntax  
  
```jscript#  
ConfigurationSectionWithCollection.Get   
   CollectionName,   
   ElementIdentifier,   
   CollectionElement;  
```  
  
```vbs  
ConfigurationSectionWithCollection.Get   
CollectionName,   
ElementIdentifier,   
CollectionElement  
```  
  
### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`CollectionName`|A `string` value that contains the name of the collection that will be retrieved (for example, "Modules"). The collection name can represent a nested collection and can use indexes. The index can be either a zero-based integer index or a string (for example, [9] or "*KeyProperty*='*Value*'"). For more information, see the Remarks section. **Note:**  The `CollectionName` is the name of the section as it is found in the configuration file, not the name of the corresponding WMI class (for example, "Modules", not "ModulesSection").|  
|`ElementIdentifier`|A `string` value that specifies a key property and value of the collection element to be retrieved. The string must be in the format "*KeyProperty1*='*Value1*',*KeyProperty2*='*Value2*',…" (for example, "Name='RoleManager'").|  
|`CollectionElement`|A [CollectionElement](../wmi-provider/collectionelement-class.md) object variable into which the retrieved collection element will be put (for example, `oModule`).|  
  
## Return Value  
 `void`.  
  
## Remarks  
 This method is useful when you want to retrieve only one member of a collection.  
  
 The following examples demonstrate syntax variations for the `CollectionName` parameter.  
  
 The following syntax shows a `CollectionName` parameter that uses a string-based "*KeyProperty*='*Value*'" index and specifies a nested collection:  
  
 `traceFailedRequests[path='Rule_2'].TraceAreas.TraceAreas`  
  
 You can specify the same value with a zero-based index:  
  
 `traceFailedRequests[1].TraceAreas.TraceAreas`  
  
 If the `ElementIdentifier` parameter is `"provider='ASP'"` and the `CollectionElement` output variable is `oTraceAreaElement`, the complete call to the `Get` method might look like the following syntax:  
  
 `oSection.Get _`  
  
 `"traceFailedRequests[path='Rule_2'].TraceAreas.TraceAreas", _`  
  
 `"provider='ASP'", oTraceAreaElement`  
  
 The following syntax shows the complete call with a zero-based index:  
  
 `oSection.Get _`  
  
 `"traceFailedRequests[1].TraceAreas.TraceAreas", _`  
  
 `"provider='ASP'", oTraceAreaElement`  
  
## Example  
 The following example retrieves the name and type of the `RoleManager` module from the `<modules>` section of the ApplicationHost.config file.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' First, get the <modules> section by using the inherited   
' WMI Get method on the WMI class name of the section  
' (that is, "ModulesSection").  
Set oSection = oWebAdmin.Get( _  
    "ModulesSection.Path='MACHINE/WEBROOT/APPHOST/'," & _  
    "Location=''")  
  
' Display the path.   
WScript.Echo "Path: " & oSection.Path_.RelPath  
  
' Retrieve the RoleManager member of the collection.  
' This is the ConfigurationSectionWithCollection.Get method,  
' so use the collection name found in the configuration file  
' (that is, "Modules").  
oSection.Get "Modules", "Name='RoleManager'", oModule  
  
' Display the module name and type.  
WScript.Echo "Module Name: " & oModule.Name  
WScript.Echo "Module Type: " & oModule.Type  
  
' Output:  
' Path: ModulesSection.Location="",Path="MACHINE/WEBROOT/APPHOST/"  
' Module Name: RoleManager  
' Module Type: System.Web.Security.RoleManagerModule  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [ModuleAction Class](../wmi-provider/moduleaction-class.md)   
 [ModulesSection Class](../wmi-provider/modulessection-class.md)   
 [TraceAreaElement Class](../wmi-provider/traceareaelement-class.md)   
 [TraceFailedRequestsSection Class](../wmi-provider/tracefailedrequestssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)   
 [TraceUrlAreaSettings Class](../wmi-provider/traceurlareasettings-class.md)
