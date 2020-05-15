---
title: "ApplicationElementDefaults Class2"
ms.date: "10/07/2016"
ms.assetid: a07c6d97-5338-8e18-a96e-ece01b6b7738
---
# ApplicationElementDefaults Class2
Specifies the default application pool and enabled protocols for new applications.  
  
## Syntax  
  
```vbs  
class ApplicationElementDefaults : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ApplicationElementDefaults` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ApplicationPool`|A read/write `string` value that specifies the default application pool for new applications. The default is "DefaultAppPool".|  
|`EnabledProtocols`|A read/write array of `string` values that contains the protocols that are enabled by default for new applications.|  
|`Path`|A read-only `string` value that specifies the default virtual path of the application after the host header. For example, if you have an application at `http://www.alpineskihouse.com/Skis/Downhill`, the value of the `Path` property is "/Skis/Downhill". A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class is exposed as the `ApplicationDefaults` property on the [Server](../wmi-provider/server-class.md) class and on the [Site](../wmi-provider/site-class.md) class, and corresponds to the `<applicationDefaults>` element in the ApplicationHost.config file.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ApplicationElementDefaults`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Application Class](../wmi-provider/application-class.md)   
 [ApplicationPool Class](../wmi-provider/applicationpool-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
