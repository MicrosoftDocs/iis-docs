---
title: "Site.RevertToParent Method1"
ms.date: "10/07/2016"
ms.assetid: 8bf5c02f-2b11-458a-830a-4cb6d255a4d5
---
# Site.RevertToParent Method1
Reverts a Web site configuration value or values to the default.  
  
## Syntax  
  
```vbs  
Site.RevertToParent(PropertyName)  
```  
  
```jscript#  
Site.RevertToParent(PropertyName);  
```  
  
### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`PropertyName`|An optional `string` value that contains the name of the Web site property that is to be reverted to the default specified by [SiteElementDefaults](../wmi-provider/siteelementdefaults-class.md). The property can be nested (for example, "LogFile.Directory").|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 When you call `RevertToParent` without parameters, all custom configuration values for the Web site will be removed. If this is not the behavior you want, revert specific properties by using parameterized calls to the method.  
  
## Example  
 The following example reverts the default Web site's log file directory from %SystemDrive%\MySiteLogFiles to %SystemDrive%\inetpub\logs\LogFiles. The example makes this change in the `<logFile>` section for the default Web site in the ApplicationHost.config file.  
  
> [!NOTE]
>  The `LogFile` property of the [Site](../wmi-provider/site-class.md) class contains an instance of the [SiteLogFile](../wmi-provider/sitelogfile-class.md) class. The `SiteLogFile` instance has a `Directory` property. You specify this nested property by using `oSite.RevertToParent("LogFile.Directory")`.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Retrieve the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' Display the Web site name, ID, and log file directory.  
WScript.Echo "Web site name: " & oSite.Name  
WScript.Echo "Site ID: " & oSite.ID      
WScript.Echo "Log file directory before revert: " & _  
    oSite.LogFile.Directory  
  
' Revert the log file directory to the default.  
oSite.RevertToParent("LogFile.Directory")  
  
' Update the contents of the oSite object variable.  
oSite.Refresh_  
  
' Display the change.  
WScript.Echo _  
    "Log file directory after revert: " & _  
        oSite.LogFile.Directory  
  
' Example output:  
' Web site name: Default Web Site  
' Site ID: 1  
' Log file directory before revert: %SystemDrive%\MySiteLogFiles  
' Log file directory after revert: %SystemDrive%\inetpub\logs\LogFiles  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Site Class](../wmi-provider/site-class.md)   
 [SiteLogFile Class](../wmi-provider/sitelogfile-class.md)   
 [SiteElementDefaults Class](../wmi-provider/siteelementdefaults-class.md)
