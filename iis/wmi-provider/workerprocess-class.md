---
title: "WorkerProcess Class2"
ms.date: "10/07/2016"
ms.assetid: dd8bf382-1523-1da8-f2b6-0cceb66fec82
---
# WorkerProcess Class2
Represents a Windows Process Activation Service (WAS) worker process (w3wp.exe).  
  
## Syntax  
  
```vbs  
class WorkerProcess : Object  
```  
  
## Methods  
 The following table lists the methods exposed by the `WorkerProcess` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetExecutingRequests](../wmi-provider/workerprocess-getexecutingrequests-method.md)|Gets the requests that are currently assigned to a worker process.|  
|[GetState](../wmi-provider/workerprocess-getstate-method.md)|Returns the run-time state of a worker process.|  
  
## Properties  
 The following table lists the properties exposed by the `WorkerProcess` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AppPoolName`|A read-only `string` that contains the name of the application pool to which the worker process belongs. The default is "DefaultAppPool".|  
|`GUID`|A read-only `string` that contains the GUID for the worker process.|  
|`ProcessID`|A read-only `uint32` that contains the worker process ID. The only key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Inheritance Hierarchy  
 [Object](../wmi-provider/object-class.md)  
  
 `WorkerProcess`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Object Class](../wmi-provider/object-class.md)