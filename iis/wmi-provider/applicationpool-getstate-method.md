---
title: "ApplicationPool.GetState Method2"
ms.date: "10/07/2016"
ms.assetid: b6fb2e50-98c5-d549-a770-867aa248317a
---
# ApplicationPool.GetState Method2
Returns the run-time state of an application pool.  
  
## Syntax  
  
```vbs  
objAppPool.GetState  
```  
  
```jscript#  
var appPoolState = appPool.GetState();  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `uint32` that identifies the application pool state. The return values are shown in the following table.  
  
|Return value|Description|  
|------------------|-----------------|  
|0|Indicates that the application pool is starting.|  
|1|Indicates that the application pool has started.|  
|2|Indicates that the application pool is stopping.|  
|3|Indicates that the application pool has stopped.|  
|4|Indicates that the application pool state is unknown.|  
  
## Remarks  
 This method is new to the [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] WMI provider and has no direct counterpart in IIS 6.0.  
  
## Example  
 The following example gets the state of an application pool and returns it to the user.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Specify the application pool.  
Set oAppPool = oWebAdmin.Get("ApplicationPool.Name='DefaultAppPool'")  
  
' Get the application pool's state and return it to the user by  
' calling a helper function.  
WScript.Echo oAppPool.Name & " is " & GetStateDescription(oAppPool.GetState) & "."  
  
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
 [ApplicationPool Class](../wmi-provider/applicationpool-class.md)
