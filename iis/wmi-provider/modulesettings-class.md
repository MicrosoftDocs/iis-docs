---
title: "ModuleSettings Class"
ms.date: "10/07/2016"
ms.assetid: 760f4adf-3e89-4a5d-9648-ca4753f5eb65
---
# ModuleSettings Class
Represents the type information for a custom [System.Net.IWebProxy](https://go.microsoft.com/fwlink/?LinkId=70961) module.  
  
## Syntax  
  
```vbs  
class ModuleSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ModuleSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Type`|A read/write `string` value that specifies the type and assembly information for the current instance.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Module` property of the [DefaultProxySection](../wmi-provider/defaultproxysection-class.md) class.  
  
 This class specifies a Web proxy that handles requests made with the [System.Net.WebRequest](https://go.microsoft.com/fwlink/?LinkId=70962) and [System.Net.WebClient](https://go.microsoft.com/fwlink/?LinkId=70963) classes.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ModuleSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [DefaultProxySection Class](../wmi-provider/defaultproxysection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [System.Net.IWebProxy Interface](https://go.microsoft.com/fwlink/?LinkId=70961)   
 [System.Net.WebRequest Class](https://go.microsoft.com/fwlink/?LinkId=70962)   
 [System.Net.WebClient Class](https://go.microsoft.com/fwlink/?LinkId=70963)
