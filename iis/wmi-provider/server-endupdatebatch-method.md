---
title: "Server.EndUpdateBatch Method"
ms.date: "10/07/2016"
ms.assetid: 49d4a5bc-0c8e-4e51-9ab6-60285a97257b
---
# Server.EndUpdateBatch Method

Ends a batch of configuration changes.  
  
## Syntax  
  
```vbs  
oServer.EndUpdateBatch  
```  
  
```jscript#  
oServer.EndUpdateBatch();  
```  
  
### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`DoCommitChanges`|An optional `boolean` value. `true` if the batch changes of configuration changes that have been made will be committed; otherwise, `false`.|  
  
## Return Value  

 This method does not return a value.  
  
## Remarks  

 Batch updates should be done between calls to the [BeginUpdateBatch](../wmi-provider/server-beginupdatebatch-method.md) method of the [Server](../wmi-provider/server-class.md) class and this method. All updates should be made to the same commit path that you specify in the `Path` parameter of the `BeginUpdateBatch` method. If you want to discard the changes that have been made in memory, set the `DoCommitChanges` parameter to `false`.  
  
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
 [Server.BeginUpdateBatch Method](../wmi-provider/server-beginupdatebatch-method.md)
