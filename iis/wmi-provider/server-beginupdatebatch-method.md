---
title: "Server.BeginUpdateBatch Method"
ms.date: "10/07/2016"
ms.assetid: 6a748c8c-c7a4-4adc-846b-5388f8064b2f
---
# Server.BeginUpdateBatch Method
Begins a batch of configuration changes for the specified path.  
  
## Syntax  
  
```vbs  
oServer.BeginUpdateBatch  
```  
  
```jscript#  
oServer.BeginUpdateBatch();  
```  
  
### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`Path`|A `string` value that specifies the path to which the configuration changes will be applied.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 This method sets a flag in the provider after which incoming change notifications and calls to commit changes are ignored.  
  
 The configuration changes that are made will be stored in memory until the [EndUpdateBatch](../wmi-provider/server-endupdatebatch-method.md) method of the [Server](../wmi-provider/server-class.md) object is called.  
  
 Batch updates should be done between calls to the `BeginUpdateBatch` method and the `EndUpdateBatch` method. All updates should be made to the same commit path.  
  
> [!NOTE]
>  The `BeginUpdateBatch` and `EndUpdateBatch` methods work only while the current WMI worker process is running. If the process is shut down by WMI due to idle timeout (normally after 30 seconds), any changes that have been made will be lost.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Server Class](../wmi-provider/server-class.md)   
 [Server.EndUpdateBatch Method](../wmi-provider/server-endupdatebatch-method.md)