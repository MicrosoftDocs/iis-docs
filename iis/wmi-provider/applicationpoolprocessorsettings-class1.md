---
title: "ApplicationPoolProcessorSettings Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6e61a326-16df-fe3c-d9f5-0face443ef71
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# ApplicationPoolProcessorSettings Class1
Configures the CPU settings for an application pool.  
  
## Syntax  
  
```vbs  
class ApplicationPoolProcessorSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ApplicationPoolProcessorSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Action`|A read/write `sint32` value that specifies the actions that IIS takes when an application pool exceeds the CPU limit specified by the `Limit` property. The possible values are listed later in the Remarks section.|  
|`Limit`|A read/write `uint32` value that indicates the percentage of CPU time to which worker processes are restricted during the interval specified by the `ResetInterval` property. The default is 0, which disables CPU usage restrictions on worker processes. If the value in the `Limit` property is exceeded, an event is written to the event log and the action specified by the `Action` property is taken.|  
|`ResetInterval`|A read/write `datetime` value that represents the reset interval for the `Limit` property. When the time elapsed since the last reset equals the value specified in the `ResetInterval` property, IIS will reset the CPU timers for `Limit`. Setting `ResetInterval` to 0 will disable CPU monitoring. The default is 5.|  
|`SmpAffinitized`|A read/write `boolean` value. `true` if the `SmpProcessorAffinityMask` property will be allowed to assign a worker process to a particular processor; otherwise, `false`. The default is `false`.|  
|`SmpProcessorAffinityMask`|A read/write `uint32` value that contains a hexadecimal mask that indicates which CPU the worker processes in an application pool should be bound to. This setting is for the first 32 processors on a multiprocessor server. To enable the `SmpProcessorAffinityMask` property, first set the `SmpAffinitized` property to `true`. **Note:**  Although the IIS_Schema.xml file specifies 4294967295 (unlimited) as the default for this property, the default returned by the WMI provider is -1. Setting this property to 0 will cause an error condition because no SMP affinity will be configured.|  
|`SmpProcessorAffinityMask2`|A read/write `uint32` value that contains a hexadecimal mask that indicates which CPU the worker processes in an application pool should be bound to. This setting is for the second set of 32 processors on a multiprocessor server. To enable the `SmpProcessorAffinityMask` property, first set the `SmpAffinitized` property to `true`. **Note:**  Although the IIS_Schema.xml file specifies 4294967295 (unlimited) as the default for this property, the default returned by the WMI provider is -1. Setting this property to 0 will cause an error condition because no SMP affinity will be configured.|  
  
## Remarks  
 Instances of this class are contained in the `Cpu` property of the [ApplicationPool](../wmi-provider/applicationpool-class1.md) class.  
  
 The following table lists the possible values and the associated keywords and actions for the `Action` property. The default is 0 (`NoAction`).  
  
|Value|Keyword|Action|  
|-----------|-------------|------------|  
|0|`NoAction`|Writes a warning to the event log, but takes no other action.|  
|1|`KillW3WP`|Shuts down the application pool worker processes when the value of the `Limit` property is exceeded.|  
  
 For more information on date/time values in Windows Management Instrumentation (WMI), see [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551).  
  
 For more information on setting processor affinity, see [Set Processor Affinity](http://go.microsoft.com/fwlink/?LinkId=57554).  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class1.md)  
  
 `ApplicationPoolProcessorSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ApplicationPool Class](../wmi-provider/applicationpool-class1.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class1.md)   
 [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551)