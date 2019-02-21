---
title: "Site.GetState Method1"
ms.date: "10/07/2016"
ms.assetid: c645f4bb-5ba5-9bcd-1edb-b64867b8663a
---
# Site.GetState Method1
Returns the run-time state of a Web site.  
  
## Syntax  
  
```vbs  
objSite.GetState  
```  
  
```jscript#  
var siteState = objSite.GetState();  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `uint32` that identifies the Web site state. The return values are shown in the following table.  
  
|Return value|Description|  
|------------------|-----------------|  
|0|Indicates that the Web site is starting.|  
|1|Indicates that the Web site has started.|  
|2|Indicates that the Web site is stopping.|  
|3|Indicates that the Web site has stopped.|  
|4|Indicates that the Web site state is unknown.|  
  
## Example  
 The following example gets the state of a Web site and returns it to the user.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Specify the Web site.  
Set oSite = oWebAdmin.Get("Site.Name='IISWebSite'")  
  
' Get the Web site's state and return it to the user by  
' calling a helper function.  
WScript.Echo oSite.Name & " is " & GetStateDescription(oSite.GetState) & "."  
  
' The helper function translates the return value into text.  
Function GetStateDescription(StateCode)  
    Select Case StateCode  
        Case 0  
            GetStateDescription = "Starting"  
        Case 1  
            GetStateDescription = "Started"  
        Case 2  
            GetStateDescription = "Stopping"  
        Case 3  
            GetStateDescription = "Stopped"  
        Case 4  
            GetStateDescription = "Unknown"  
        Case Else  
            GetStateDescription = "Attempt to retrieve state failed."  
    End Select  
End Function  
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