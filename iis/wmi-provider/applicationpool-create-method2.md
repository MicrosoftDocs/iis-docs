---
title: "ApplicationPool.Create Method2 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cc7d3c44-23df-cec7-c2b6-614a151011bb
caps.latest.revision: 16
author: "shirhatti"
manager: "wpickett"
---
# ApplicationPool.Create Method2
Creates an application pool.  
  
## Syntax  
  
```vbs  
oWebAdmin.Get("ApplicationPool").Create(  
   AppPoolName,  
   AutoStart  
)  
```  
  
```jscript#  
var apppool = oWebAdmin.Get("Application").Create(  
   AppPoolName,  
   AutoStart  
);  
```  
  
#### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`AppPoolName`|[IN] A `string` value that specifies the name of the new application pool.|  
|`AutoStart`|[IN] An optional `boolean` value. `true` if the World Wide Web Publishing Service (WWW service) will start an application pool automatically either when the application pool is created or when IIS is started; otherwise, `false`. If you disable automatic startup of an application pool, you must start the application pool manually. Disabling automatic startup is useful when you want to make configuration or content changes to an application in the application pool before the application pool starts.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 The `Create` method supplants previous methods of creating IIS application pools. To create an application pool in IIS 6.0, you called `SpawnInstance_` on the [IIsApplicationPoolSetting](http://msdn.microsoft.com/en-us/10d03bfa-e2e9-46c1-abee-dbfc8c1c9079) class, assigned a name to the new application pool, and then called `Put_` to save the result to the metabase. Although this procedure will still work in [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)], the new `Create` method performs the same task in one step.  
  
## Example  
 The following example creates a new application pool.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Create the new application pool.  
oWebAdmin.Get("ApplicationPool").Create("NewAppPool")  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ApplicationPool Class](../wmi-provider/applicationpool-class1.md)