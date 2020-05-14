---
title: "PeriodicRestartSettings Class"
ms.date: "10/07/2016"
ms.assetid: dfb46d88-0d13-f66b-440b-dd7eeef10582
---
# PeriodicRestartSettings Class
Specifies the conditions under which worker processes will be recycled.  
  
## Syntax  
  
```vbs  
class PeriodicRestartSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `PeriodicRestartSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Memory`|A read/write `uint32` value that specifies the amount of virtual memory, in kilobytes, that a worker process can use before the worker process recycles. The maximum value is 4,294,967. The default is 0 kilobytes, which means that the amount of virtual memory that a worker process uses will not be a condition for recycling the worker process.|  
|`PrivateMemory`|A read/write `uint32` value that specifies the amount of private memory, in kilobytes, that a worker process can use before the worker process recycles. The maximum value is 4,294,967. The default is 0 kilobytes, which means that the amount of private memory that a worker process uses will not be a condition for recycling the worker process.|  
|`Requests`|A read/write `uint32` value that indicates the number of requests an out-of-process application should process before it is recycled. The default is 0, which means that the number of requests an out-of-process application handles will not be a condition for recycling it.|  
|`Schedule`|An array of [ScheduleElement](../wmi-provider/scheduleelement-class.md) values that specify the local times at which an application will be recycled.|  
|`Time`|A read/write `datetime` value that specifies the amount of time before IIS recycles an isolated out-of-process application. The default value is 0, which disables the recycling.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `PeriodicRestart` property of the [RecyclingSettings](../wmi-provider/recyclingsettings-class.md) class.  
  
 For more information about the Windows Management Instrumentation (WMI) date/time format, see [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551).  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `PeriodicRestartSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
 [RecyclingSettings Class](../wmi-provider/recyclingsettings-class.md)
 [ScheduleElement Class](../wmi-provider/scheduleelement-class.md)
