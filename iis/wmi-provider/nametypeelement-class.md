---
title: "NameTypeElement Class"
ms.date: "10/07/2016"
ms.assetid: ee410798-43e4-96dc-a07c-a823804e7822
---
# NameTypeElement Class
Associates a name and a managed type.  
  
## Syntax  
  
```vbs  
class NameTypeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `NameTypeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A required unique read/write `string` value that specifies a name. The key property.|  
|`Type`|A read/write `string` value that specifies a managed type associated with the value in the `Name` property. **Note:**  The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Providers` array property of the [ProvidersSettings](../wmi-provider/providerssettings-class.md) class, in the `Switches` array property of the [SwitchSettings](../wmi-provider/switchsettings-class.md) class, and in the `SchemaImporterExtensions` array property of the [SchemaImporterExtensionsSection](../wmi-provider/schemaimporterextensionssection-class.md) class.  
  
> [!NOTE]
>  If you update the `Name` property in a collection of providers, only the `Name` and `Type` attributes of the provider will be saved to the configuration file. Other previously saved provider attributes will no longer appear in the configuration file.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `NameTypeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ConfigProtectedDataSection Class](../wmi-provider/configprotecteddatasection-class.md)   
 [MembershipSection Class](../wmi-provider/membershipsection-class.md)   
 [ProvidersSettings Class](../wmi-provider/providerssettings-class.md)   
 [RoleManagerSection Class](../wmi-provider/rolemanagersection-class.md)   
 [SchemaImporterExtensionsSection Class](../wmi-provider/schemaimporterextensionssection-class.md)   
 [SwitchSettings Class](../wmi-provider/switchsettings-class.md)
