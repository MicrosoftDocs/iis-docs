---
title: "SoapTransportImporterTypeElement Class"
description: Describes the syntax for the SoapTransportImporterTypeElement class. This class imports a SOAP transmission protocol into an XML Web service.
ms.date: "10/07/2016"
ms.assetid: 3b116efc-e40f-4c9e-a440-4854cb71daf5
---
# SoapTransportImporterTypeElement Class
Imports a SOAP transmission protocol into an XML Web service.  
  
## Syntax  
  
```vbs  
class SoapTransportImporterTypeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SoapTransportImporterTypeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Type`|A read-only `string` value that imports a SOAP transmission protocol into an XML Web service. A key property. **Note:**  The type reference is formed as follows (items in brackets are not required): *Namespace*.*Typename*, *Assemblyname*[,] [Version=*x*,] [Culture=*y*,] [PublicKeyToken=*z*] (for example, "ExampleNamespace.ExampleType, Example.Assembly, Version=%ASSEMBLY_VERSION%, Culture=neutral, PublicKeyToken=%MICROSOFT_PUBLICKEY%").|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `SoapTransportImporterTypes` array property of the [SoapTransportImporterTypesInfo](../wmi-provider/soaptransportimportertypesinfo-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/soapextensionreflectortypessettings-class.md)  
  
 `SoapTransportImporterTypeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [IIS 7.0: CollectionElement Class](../wmi-provider/soapextensionreflectortypessettings-class.md)   
 [SoapTransportImporterTypesInfo Class](../wmi-provider/soaptransportimportertypesinfo-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)
