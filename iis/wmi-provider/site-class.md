---
title: "Site Class1"
ms.date: "10/07/2016"
ms.assetid: 1d576513-006e-e5ac-1356-7afad97a7787
---
# Site Class1
Represents an IIS Web site.  
  
## Syntax  
  
```vbs  
class Site : ConfiguredObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `Site` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Create](../wmi-provider/site-create-method.md)|Creates a new Web site.|  
|[GetAllSections](../wmi-provider/configuredobject-getallsections-method.md)|(Inherited from [ConfiguredObject](../wmi-provider/configuredobject-class.md).)|  
|[GetSection](../wmi-provider/configuredobject-getsection-method.md)|(Inherited from [ConfiguredObject](../wmi-provider/configuredobject-class.md).)|  
|[GetState](../wmi-provider/site-getstate-method.md)|Returns the run-time state of a Web site.|  
|[RevertToParent](../wmi-provider/site-reverttoparent-method.md)|Reverts a Web site configuration value or values to those of its parent site.|  
|[Start](../wmi-provider/site-start-method.md)|Starts an existing Web site.|  
|[Stop](../wmi-provider/site-stop-method.md)|Stops a currently running Web site.|  
  
> [!NOTE]
>  The IIS 6.0 WMI [IIsWebServer](https://msdn.microsoft.com/af1a277b-e67a-41b3-9947-91c9304f8ec7) class supported the [Continue](https://msdn.microsoft.com/c782a5b1-d6d3-40ae-bb7b-519867753be8) and [Pause](https://msdn.microsoft.com/82980194-3146-4252-b458-77538f781ca6) methods for a Web site. This functionality is no longer supported in [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)].  
  
## Properties  
 The following table lists the properties exposed by the `Site` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ApplicationDefaults`|An [ApplicationElementDefaults](../wmi-provider/applicationelementdefaults-class.md) object whose read/write properties contain the default values for applications within a Web site. Individual application settings will override these defaults.|  
|`Bindings`|A read/write array of [BindingElement](../wmi-provider/bindingelement-class.md) objects.|  
|`Id`|A read/write `uint32` value that contains the site ID. Site IDs must be unique. **Note:**  To avoid binding conflicts, a site that is already running will stop if you change its site ID.|  
|`Limits`|A read/write [SiteLimits](../wmi-provider/sitelimits-class.md) object that exposes connection-related limits for a site.|  
|`LogFile`|A read/write [SiteLogFile](../wmi-provider/sitelogfile-class.md) object that configures logging for a Web site.|  
|`Name`|A read-only `string` value that contains the name of the Web site. Site names must be unique. This is the only key property for the `Site` class.|  
|`ServerAutoStart`|A read/write `boolean` value. `true` if the Web site will start when the World Wide Web Publishing Service (WWW service) starts; otherwise, `false`. The default is `true`.|  
|`TraceFailedRequestsLogging`|A [TraceFailedRequestsLogging](../wmi-provider/tracefailedrequestslogging-class.md) object that exposes read/write logging properties for the Web site.|  
|`VirtualDirectoryDefaults`|A read-only [VirtualDirectoryElementDefaults](../wmi-provider/virtualdirectoryelementdefaults-class.md) object that contains the default values for virtual directories in a site. Individual virtual directory settings will override these defaults.|  
  
## Remarks  
 You cannot set the physical path for a Web site by using the `Site` class. Use the `PhysicalPath` property of the root [VirtualDirectory](../wmi-provider/virtualdirectory-class.md) object instead.  
  
> [!NOTE]
> You must set the `ApplicationPool` property on the root [Application](../wmi-provider/application-class.md) object, not on the `Site` object.  
  
## Example  
 The following example sets the physical path for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
' Get the root virtual directory for the default Web site.  
Set oVDir = oWebAdmin.Get(_   
"VirtualDirectory.SiteName='Default Web Site',ApplicationPath='/',Path='/'")  
  
' Set the physical path for the default Web site.  
oVDir.PhysicalPath = "C:\MyContent"  
oVDir.Put_  
  
```  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [ConfiguredObject](../wmi-provider/configuredobject-class.md)  
  
 `Site`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Application Class](../wmi-provider/application-class.md)   
 [ApplicationElementDefaults Class](../wmi-provider/applicationelementdefaults-class.md)   
 [ApplicationPool Class](../wmi-provider/applicationpool-class.md)   
 [BindingElement Class](../wmi-provider/bindingelement-class.md)   
 [ConfiguredObject Class](../wmi-provider/configuredobject-class.md)   
 [ServerContainsSite Class](../wmi-provider/servercontainssite-class.md)   
 [SiteContainsApplication Class](../wmi-provider/sitecontainsapplication-class.md)   
 [SiteContainsConfigurationSection Class](../wmi-provider/sitecontainsconfigurationsection-class.md)   
 [SiteElementDefaults Class](../wmi-provider/siteelementdefaults-class.md)   
 [SiteLimits Class](../wmi-provider/sitelimits-class.md)   
 [SiteLogFile Class](../wmi-provider/sitelogfile-class.md)   
 [TraceFailedRequestsLogging Class](../wmi-provider/tracefailedrequestslogging-class.md)   
 [VirtualDirectory Class](../wmi-provider/virtualdirectory-class.md)   
 [VirtualDirectoryElementDefaults Class](../wmi-provider/virtualdirectoryelementdefaults-class.md)
