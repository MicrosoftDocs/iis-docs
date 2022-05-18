---
title: "ClientTarget Class"
description: This article describes syntax, methods, properties, subclasses, inheritance hierarchy, and requirements for the ClientTarget class. 
ms.date: "10/07/2016"
ms.assetid: 987b6112-75ff-8330-f1d0-4314881e0883
---
# ClientTarget Class
Represents the mapping of a user agent to an alias.  
  
## Syntax  
  
```vbs  
class ClientTarget : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ClientTarget` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Alias`|A read-only `string` value that contains an alias that is mapped to the user agent specified in the `UserAgent` property. The key property.|  
|`UserAgent`|A read/write `string` value that identifies a specific user agent.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ClientTarget` property of the [ClientTargetSection](../wmi-provider/clienttargetsection-class.md) class.  
  
 The following `ClientTarget` values are configured in the root Web.config file in the [!INCLUDE[dnprdnlong](../wmi-provider/includes/dnprdnlong-md.md)].  
  
|Alias|User Agent|  
|-----------|----------------|  
|"ie5"|"Mozilla/4.0 (compatible; MSIE 5.5; Windows NT 4.0)"|  
|"ie4"|"Mozilla/4.0 (compatible; MSIE 4.0; Windows NT 4.0)"|  
|"uplevel"|"Mozilla/4.0 (compatible; MSIE 5.5; Windows NT 5.1)"|  
|"downlevel"|"Generic Downlevel"|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ClientTarget`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.ClientTarget](/dotnet/api/system.web.configuration.clienttarget) 
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)
