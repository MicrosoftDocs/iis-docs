---
title: "ConformanceWarning Class"
description: The ConformanceWarning class exposes a Web Services Interoperability (WS-I) specification to which a Web service declares that it conforms.
ms.date: "10/07/2016"
ms.assetid: 6143dc15-7a1d-c00b-94ed-a446964cb705
---
# ConformanceWarning Class
Exposes a Web Services Interoperability (WS-I) specification to which a Web service declares that it conforms.  
  
## Syntax  
  
```vbs  
class ConformanceWarning : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ConformanceWarning` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A read-only `sint32` enumeration that represents the Web Services Interoperability (WS-I) specification to which a Web service declares that it conforms. The possible values are listed later in the Remarks section. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ConformanceWarnings` array property of the [ConformanceWarningSettings](../wmi-provider/conformancewarningsettings-class.md) class.  
  
 The following table lists the possible values for the `Name` property. Currently, the only WS-I profile supported in the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)] is Basic Profile Version 1.1 (BasicProfile 1_1).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|The Web service claims no conformance to a WS-I specification.|  
|1|`BasicProfile1_1`|The Web service claims conformance with the WS-I Basic Profile 1.1 set of nonproprietary Web service specifications.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ConformanceWarning`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ConformanceWarningSettings Class](../wmi-provider/conformancewarningsettings-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)   
 [Basic Profile Version 1.1 (WS-I)](https://go.microsoft.com/fwlink/?LinkId=69313)
