---
title: "CompilerElement Class"
ms.date: "10/07/2016"
ms.assetid: d2f44e2f-ae63-421b-9071-ddf9809fc21c
---
# CompilerElement Class

Specifies a compiler that is used for Web applications.  
  
## Syntax  
  
```vbs  
class CompilerElement : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `CompilerElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CompilerOptions`|A read/write `string` value that specifies compiler-specific options to use during compilation. Overrides any previously defined values.|  
|`Extensions`|A required unique read/write `string` value that contains a semicolon-delimited list of file name extensions used for dynamic code-behind files, files in the code directory, and other referenced files. A key property.|  
|`Language`|A required unique read/write `string` value that contains a semicolon-delimited list of programming languages to use in dynamic compilation files. A key property.|  
|`Type`|A read/write `string` value that specifies the type name of the language compiler to use for dynamic compilation files. **Note:**  The `Type` property specifies the type name of the language provider, including the name of the assembly that contains the provider implementation.|  
|`WarningLevel`|A read/write `sint32` value that specifies the compiler warning level. **Note:**  The compiler warning level determines the level at which the language provider treats compilation warnings as errors.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `Compilers` array property of the [CompilerSettings](../wmi-provider/compilersettings-class.md) class.  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `CompilerElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [CompilerSettings Class](../wmi-provider/compilersettings-class.md)
