---
title: "SoapExtensionReflectorTypesSettings Class"
ms.date: "10/07/2016"
ms.assetid: 1e8f1231-c816-4b11-8019-865b42870a26
---
# SoapExtensionReflectorTypesSettings Class
Contains SOAP extension information for Web services.  
  
## Syntax  
  
```vbs  
class SoapExtensionReflectorTypesSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SoapExtensionReflectorTypesSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`SoapExtensionReflectorTypes`|An array of [TypeElement](../wmi-provider/typeelement-class.md) values that specify the SOAP extensions to run when a service description is generated for all Web services in the scope of the configuration file.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `SoapExtensionReflectorTypes` array property of the [WebServicesSection](../wmi-provider/webservicessection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SoapExtensionReflectorTypesSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [TypeElement Class](../wmi-provider/typeelement-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)
