---
title: "ApplicationPool.RevertToParent Method1"
ms.date: "10/07/2016"
ms.assetid: 919397d4-8c16-4d0b-83d7-b4be7052e3c9
---
# ApplicationPool.RevertToParent Method1
Reverts an application pool's configuration value or values to the default.  
  
## Syntax  
  
```vbs  
ApplicationPool.RevertToParent(PropertyName)  
```  
  
```jscript#  
ApplicationPool.RevertToParent(PropertyName);  
```  
  
### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`PropertyName`|An optional `string` value that contains the name of the application pool property that is to be reverted to the default specified by [ApplicationPoolElementDefaults Class](../wmi-provider/applicationpoolelementdefaults-class.md). The property can be nested.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 When you call `RevertToParent` without parameters, all custom configuration values for the application pool will be removed. If this is not the behavior you want, revert specific properties by using separate parameterized calls to the method.  
  
## Example  
 The following example reverts the `AutoStart` property of the `ContosoAppPool` from its current value of `false` to the default value of `true`.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the application pools.  
Set oAppPools = oWebAdmin.InstancesOf("ApplicationPool")  
  
' Display the ContosoAppPool AutoStart property.  
For Each oAppPool In oAppPools  
    If oAppPool.Name = "ContosoAppPool" Then  
        WScript.Echo "Application pool name: " & oAppPool.Name  
        WScript.Echo "AutoStart mode before revert: " & _  
            oAppPool.AutoStart  
  
        ' Revert the AutoStart property.  
        oAppPool.RevertToParent("AutoStart")  
  
        ' Refresh the oAppPool object variable.  
        oAppPool.Refresh_  
  
        ' Display the changed property.  
        WScript.Echo "AutoStart mode after revert: " & _  
                oAppPool.AutoStart  
  
        Exit For  
    End If  
Next  
  
' Output:  
' Application pool name: ContosoAppPool  
' AutoStart mode before revert: False  
' AutoStart mode after revert: True  
  
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
 [ApplicationPoolElementDefaults Class](../wmi-provider/applicationpoolelementdefaults-class.md)