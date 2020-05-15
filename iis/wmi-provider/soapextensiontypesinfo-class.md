---
title: "SoapExtensionTypesInfo Class"
ms.date: "10/07/2016"
ms.assetid: 7a8dcc50-3f03-9c7c-23f3-a7682dbaacbc
---
# SoapExtensionTypesInfo Class

Specifies SOAP extensions that inspect or modify SOAP messages.  
  
## Syntax  
  
```vbs  
class SoapExtensionTypesInfo : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `SoapExtensionTypesInfo` class.  
  
|Name|Description|  
|----------|-----------------|  
|`SoapExtensionTypes`|An array of [SoapExtensionTypeElement](../wmi-provider/soapextensiontypeelement-class.md) values that specify SOAP extensions that inspect or modify a SOAP message during processing on the Web service or client.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are exposed as members of the `SoapExtensionTypes` property on the [WebServicesSection](../wmi-provider/webservicessection-class.md) class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `SoapExtensionTypesInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [SoapExtensionTypeElement Class](../wmi-provider/soapextensiontypeelement-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)
