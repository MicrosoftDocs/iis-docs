---
title: "BuildProvider Class"
ms.date: "10/07/2016"
ms.assetid: 86c97635-9cea-7ced-e217-276667534258
---
# BuildProvider Class
Represents a build provider that compiles custom resource files of a particular file type and generates code during compilation.  
  
## Syntax  
  
```vbs  
class BuildProvider : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `BuildProvider` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Extension`|A read-only `string` value that specifies a resource file extension (such as ".aspx" or ".ascx") that is compiled by the build provider specified in the `Type` property. The key property.|  
|`Type`|A read/write `string` value that contains the type of the build provider that compiles resource files that have the file extension specified in the `Extension` property. The string is a comma-delimited list that contains the fully qualified type name followed by the assembly information (for example, Corp.Net.Provider, Corp, Version=1.0.5000.0, Culture=neutral, PublicKeyToken="00000000000000000"). If you do not specify a string value, the property will contain a null reference.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `BuildProviders` array property of the [BuildProviderSettings](../wmi-provider/buildprovidersettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `BuildProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.CompilationSection.BuildProviders](/dotnet/api/system.web.configuration.compilationsection.buildproviders)  
 [BuildProviderSettings Class](../wmi-provider/buildprovidersettings-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [CompilationSection Class](../wmi-provider/compilationsection-class.md)