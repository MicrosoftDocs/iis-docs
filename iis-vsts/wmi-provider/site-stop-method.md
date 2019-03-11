---
title: "Site.Stop Method1"
ms.date: "10/07/2016"
ms.assetid: 3364b705-8777-3927-4016-d35a36d3c433
---
# Site.Stop Method1
Stops a currently running Web site.  
  
## Syntax  
  
```vbs  
oSite.Stop  
```  
  
```jscript#  
oSite.Stop();  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 This method is new to the [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] WMI provider and has no counterpart in IIS 6.0.  
  
## Example  
 The following example stops the Web site named `IISWebSite`.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Specify the Web site name.  
Set oSite = oWebAdmin.Get("Site.Name='IISWebSite'")  
  
' Stop the Web site.  
oSite.Stop  
```  
  
 To check the state of the Web site after you call the `Stop` method, use the [GetState](../wmi-provider/site-getstate-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Site Class](../wmi-provider/site-class.md)   
 [Site.GetState Method](../wmi-provider/site-getstate-method.md)   
 [Site.Start Method](../wmi-provider/site-start-method.md)