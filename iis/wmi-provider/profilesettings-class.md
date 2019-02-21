---
title: "ProfileSettings Class"
ms.date: "10/07/2016"
ms.assetid: d8c0627e-0259-7d81-fc26-709f82ef2d18
---
# ProfileSettings Class
Configures an event profile that determines how an event is collected by [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and raised to providers.  
  
## Syntax  
  
```vbs  
class ProfileSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ProfileSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Profiles`|An array of [ProfileElement](../wmi-provider/profileelement-class.md) objects that configures event profiles that determine how events are collected by [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and raised to providers.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Profiles` property of the [HealthMonitoringSection](../wmi-provider/healthmonitoringsection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ProfileSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Configuration.ProfileSettings](/dotnet/api/system.web.configuration.profilesettings)
 [System.Web.Management.IWebEventCustomEvaluator](/dotnet/api/system.web.management.iwebeventcustomevaluator)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [ProfileElement Class](../wmi-provider/profileelement-class.md)   
 [System.Int32.MaxValue Field](http://go.microsoft.com/fwlink/?LinkId=69329)   
 [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551)