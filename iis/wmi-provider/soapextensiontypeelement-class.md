---
title: "SoapExtensionTypeElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c8acd16b-2eb2-4dae-a2a2-feb9f41a1ddb
caps.latest.revision: 9
author: "shirhatti"
manager: "wpickett"
---
# SoapExtensionTypeElement Class
Specifies a SOAP extension used to inspect or modify a SOAP message during processing on the Web service or client.  
  
## Syntax  
  
```vbs  
class SoapExtensionTypeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `SoapExtensionTypeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Group`|A read-only `sint32` value that, together with the `Priority` property, specifies the relative order in which a SOAP extension runs when multiple SOAP extensions are configured to run. The possible values are listed later in the Remarks section. A key property.|  
|`Priority`|A read-only `sint32` value that, together with the `Group` property, specifies the relative order in which a SOAP extension runs when multiple SOAP extensions are configured to run. Within each group, the priority attribute distinguishes the overall relative priority of the SOAP extension. A lower priority number indicates a higher priority for the SOAP extension. The lowest possible value for the priority attribute is 1. The maximum value is 2147483647. A key property.|  
|`Type`|A read-only `string` value that specifies the fully qualified type name of a SOAP extension class. When the assembly is put in the global assembly cache, the string must also include the version, culture, and public key token of the signed assembly. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `SoapExtensionTypes` array property of the [SoapExtensionTypesInfo](../wmi-provider/soapextensiontypesinfo-class.md) class.  
  
 The following table lists the possible values for the `Group` property. The default is 1 (`Low`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`High`|The SOAP extension runs in the group of SOAP extensions with the highest priority.|  
|1|`Low`|The SOAP extension runs in the group of SOAP extensions with the lowest priority.|  
  
## Inheritance Hierarchy  
 [CollectionElement](2476947b-5036-a2f4-440a-2074a7dfeb290cca8529-7424-62d9-301c-e3c44fd1cd4b)  
  
 `SoapExtensionTypeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [SoapExtensionTypesInfo Class](../wmi-provider/soapextensiontypesinfo-class.md)   
 [WebServicesSection Class](../wmi-provider/webservicessection-class.md)