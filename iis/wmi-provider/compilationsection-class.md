---
title: "CompilationSection Class"
ms.date: "10/07/2016"
ms.assetid: c3a136d5-a102-8b61-8fa2-1b6864423c35
---
# CompilationSection Class
Configures compilation settings for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.  
  
## Syntax  
  
```vbs  
class CompilationSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `CompilationSection` class.  
  
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
 The following table lists the properties exposed by the `CompilationSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Assemblies`|An [AssemblySettings](../wmi-provider/assemblysettings-class.md) value that contains assembly references that are used during compilation of an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application. [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] automatically links these assemblies to the resource when it compiles each code module. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`AssemblyPostProcessorType`|A read/write `string` value that specifies a post-process compilation step for an assembly. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Batch`|A read/write `boolean` value. `true` if [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] precompiles all the uncompiled files in batch mode; otherwise, `false`. The default is `true`.<br /><br /> Set this attribute to `true` to change the delay caused by the required compilation when you access an uncompiled file. A delay occurs when the files are first compiled; however, after the files are compiled, the delay is eliminated. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`BatchTimeout`|A read/write `datetime` value that specifies the time, in seconds, granted for batch compilation to occur. The default is 900.<br /><br /> If the compilation cannot be completed in the time-out period, the compiler reverts to single-compilation mode for the current page. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`BuildProviders`|A [BuildProviderSettings](../wmi-provider/buildprovidersettings-class.md) value that compiles custom resource files of a particular file type and generates code during compilation. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`CodeSubdirectories`|A [DirectorySettings](../wmi-provider/directorysettings-class.md) value that specifies subdirectories that contain files to compile at run time. Subdirectory names are relative to the App_Code directory. The build order is inferred from the top-down order of the `CodeSubDirectories` collection. The App_Code directory is built last. However, there are no build order dependencies, which means that the build order is not significant. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Debug`|A read/write `boolean` value. `true` if binaries that are created from compilation are debug binaries; `false` if release binaries are used for compilation. The default is `false`. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`DefaultLanguage`|A read/write `string` value that specifies the default programming language, such as C# or [!INCLUDE[vbprvb](../wmi-provider/includes/vbprvb-md.md)], to use in dynamic-compilation files. The default is "vb", which specifies [!INCLUDE[vbprvb](../wmi-provider/includes/vbprvb-md.md)].<br /><br /> Language names are defined in the `<system.codedom>` section of the Machine.config file. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Explicit`|A read/write `boolean` value. `true` if the [!INCLUDE[vbprvb](../wmi-provider/includes/vbprvb-md.md)] explicit compile option is enabled; otherwise, `false`. The default is `true`. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`ExpressionBuilders`|An [ExpressionBuilderSettings](../wmi-provider/expressionbuildersettings-class.md) value that specifies resource strings to use during compilation. The resource strings associate prefixes with expression builders. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaxBatchGeneratedFileSize`|A read/write `sint32` value that specifies the maximum combined size, in kilobytes, of the generated source files per batched compilation. The default is 1000. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`MaxBatchSize`|A read/write `sint32` value that specifies the maximum number of pages that are compiled into a single batch. The default is 1000. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`NumRecompilesBeforeAppRestart`|A read/write `sint32` value that specifies the number of dynamic recompiles of resources that can occur before the application restarts. The default is 15.<br /><br /> This property is supported at the global and application configuration levels, but not at the directory configuration level. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`Strict`|A read/write `boolean` value. `true` if the [!INCLUDE[vbprvb](../wmi-provider/includes/vbprvb-md.md)] strict compile option is used; otherwise, `false`. The default is `false`.<br /><br /> When `true`, compilation explicitly disallows any data-type conversions in which data loss would occur, or any conversion between numeric types and strings. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`TempDirectory`|A read/write `string` value that specifies the directory to use for temporary file storage during compilation. The default is an empty string.<br /><br /> If the string is empty and the current process identity has the required permissions to the %FrameworkInstallLocation%\ Temporary ASP.NET Files directory, that directory is used. If the string is empty and the current process identity does not have the required permissions to the Temporary ASP.NET Files directory, the system either throws an exception or writes to a directory to which it does have permissions, such as the Temp directory in the user profile. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
|`UrlLinePragmas`|A read/write `boolean` value. `true` if instructions to the compiler use URLs; `false` if instructions to the compiler use physical paths. The default is `false`. **Note:**  This property is new in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `CompilationSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Compilation.BuildProvider](/dotnet/api/system.web.compilation.buildprovider)
 [System.Web.Configuration.CompilationSection](/dotnet/api/system.web.configuration.compilationsection)
 [AssemblySettings Class](../wmi-provider/assemblysettings-class.md)
 [BuildProviderSettings Class](../wmi-provider/buildprovidersettings-class.md)
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)
 [DirectorySettings Class](../wmi-provider/directorysettings-class.md)
 [ExpressionBuilderSettings Class](../wmi-provider/expressionbuildersettings-class.md)
 [\<system.codedom> Element](https://go.microsoft.com/fwlink/?LinkId=69315)
