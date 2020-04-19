---
title: "ProviderSettings Class"
ms.date: "10/07/2016"
ms.assetid: a55acfd1-a520-a50d-c75e-488c090f1c6c
---
# ProviderSettings Class
Specifies the name and type of [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)]-related providers.  
  
## Syntax  
  
```vbs  
class ProviderSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ProviderSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Providers`|An array of [ProviderElement](../wmi-provider/providerelement-class.md) values that specify [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)]-related providers.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Providers` property of the [HealthMonitoringSection](../wmi-provider/healthmonitoringsection-class.md), [SessionStateSection](../wmi-provider/sessionstatesection-class.md), and [SiteMapSection](../wmi-provider/sitemapsection-class.md) classes.  
  
> [!NOTE]
>  Do not confuse this class with the [!INCLUDE[dnprdnshort](../wmi-provider/includes/dnprdnshort-md.md)]–related [ProvidersSettings](../wmi-provider/providerssettings-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ProviderSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [ProviderElement Class](../wmi-provider/providerelement-class.md)   
 [ProvidersSettings Class](../wmi-provider/providerssettings-class.md)   
 [SessionStateSection Class](../wmi-provider/sessionstatesection-class.md)   
 [SiteMapSection Class](../wmi-provider/sitemapsection-class.md)
