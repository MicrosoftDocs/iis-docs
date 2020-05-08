---
title: "ProtocolElement Class"
ms.date: "10/07/2016"
ms.assetid: 15acc98e-38a6-578d-a854-3c949c8d242b
---
# ProtocolElement Class
Specifies a transmission protocol that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] can use to decrypt data sent in the HTTP request from a client browser.  
  
## Syntax  
  
```vbs  
class ProtocolElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ProtocolElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AppDomainHandlerType`|A read/write `string` value that contains the common language runtime (CLR) type of the application domain protocol handler for the protocol specified in the `Name` property.|  
|`Name`|A unique nonempty read-only `string` value that specifies the name of a transmission protocol that [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] can use to decrypt data sent in the HTTP request from a client browser. The key property.|  
|`ProcessHandlerType`|A read/write `string` value that specifies the CLR type of the process protocol handler for the protocol specified in the `Name` property. If you do not specify this property, the protocol does not require a process protocol handler.|  
|`Validate`|A read/write `boolean` value. `true` if the types specified in the `AppDomainHandlerType` and `ProcessHandlerType` properties should be validated when the section is parsed; otherwise, `false`. The default is `false`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Protocols` property of the [ProtocolsSection](../wmi-provider/protocolssection-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ProtocolElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ProtocolsSection Class](../wmi-provider/protocolssection-class.md)   
 [WebServicesProtocolElement Class](../wmi-provider/webservicesprotocolelement-class.md)
