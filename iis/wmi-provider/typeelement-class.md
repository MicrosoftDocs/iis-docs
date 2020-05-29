---
title: "TypeElement Class"
ms.date: "10/07/2016"
ms.assetid: 8103c618-5040-16d7-3708-0b5a74b3b95e
---
# TypeElement Class
Specifies a type in an array property on a Web-service-related WMI class.  
  
## Syntax  
  
```vbs  
class TypeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TypeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Type`|A required unique read/write `string` value that contains type information. The key property. **Note:**  The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the following array properties of the classes listed.  
  
|Class|Property|  
|-----------|--------------|  
|[ServiceDescriptionFormatSettings](../wmi-provider/servicedescriptionformatsettings-class.md)|`ServiceDescriptionFormatExtensionTypes`|  
|[SoapExtensionImporterTypesSettings](../wmi-provider/soapextensionimportertypessettings-class.md)|`SoapExtensionImporterTypes`|  
|[SoapExtensionReflectorTypesSettings](../wmi-provider/soapextensionreflectortypessettings-class.md)|`SoapExtensionReflectorTypesSettings`|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TypeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ServiceDescriptionFormatSettings Class](../wmi-provider/servicedescriptionformatsettings-class.md)   
 [SoapExtensionImporterTypesSettings Class](../wmi-provider/soapextensionimportertypessettings-class.md)   
 [IIS 7.0: SoapExtensionReflectorTypesSettings Class](../wmi-provider/soapextensionreflectortypessettings-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)
