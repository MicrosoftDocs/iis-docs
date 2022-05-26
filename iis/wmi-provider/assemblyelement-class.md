---
title: "AssemblyElement Class"
description: "AssemblyElement class specifies an assembly reference that is used during compilation of a vstecasp Web application."
ms.date: "10/07/2016"
ms.assetid: 186c51f7-3822-cf30-8793-1f7afd934f45
---
# AssemblyElement Class
Specifies an assembly reference that is used during compilation of an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] Web application.  
  
## Syntax  
  
```vbs  
class AssemblyElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `AssemblyElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Assembly`|A required unique read/write `string` value that specifies an assembly reference that is used during compilation of an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] Web application. The key property. **Note:**  The assembly name is a comma-delimited Unicode string in the following format: *Name* \<,Culture *= CultureInfo*> \<,Version *= Major.Minor.Build.Revision*> \<,*StrongName*> \<,*PublicKeyToken*>.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are exposed as members of the `Assemblies` property on the [AssemblySettings](../wmi-provider/assemblysettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `AssemblyElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AssemblySettings Class](../wmi-provider/assemblysettings-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)
