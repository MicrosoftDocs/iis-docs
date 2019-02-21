---
title: "BufferModeElement Class"
ms.date: "10/07/2016"
ms.assetid: d8e3a0d7-bf72-473d-915a-0a7d9f714c23
---
# BufferModeElement Class
Configures the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] event-buffering settings for event providers.  
  
## Syntax  
  
```vbs  
class BufferModeElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `BufferModeElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`MaxBufferSize`|A required read/write `sint32` value that specifies the maximum number of events that can be buffered at the same time. The default is 2147483647. This property must have a value greater than 0. To make the value infinite, set it to `MaxValue`.|  
|`MaxBufferThreads`|A read/write `sint32` value that specifies the maximum number of flushing threads that can be active at the same time. The default is 1. This property must have a value greater than 0. To make the value infinite, set it to `MaxValue`.|  
|`MaxFlushSize`|A read/write `sint32` value that specifies the maximum number of events per flush. The default is 2147483647. This property cannot be greater than `MaxBufferSize` and must have a value greater than 0. To make the value infinite, set it to `MaxValue`.|  
|`Name`|A required unique read-only `string` value that specifies the name of the buffer mode setting. The key property.|  
|`RegularFlushInterval`|A read/write `datetime` value that specifies the amount of time between buffer flushes. The default is 1 second. This property must have a value greater than 0. To make the value infinite, set it to `MaxValue`.|  
|`UrgentFlushInterval`|A read/write `datetime` value that specifies the minimum amount of time that can pass between buffer flushes. This property must have a value greater than 0 and less than or equal to the value of the `RegularFlushInterval` property.|  
|`UrgentFlushThreshold`|A read/write `sint32` value that specifies the number of events that can be buffered before a flush is triggered. The default is 2147483647. This property value cannot be greater than `MaxBufferSize`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `BufferModes` array property of the [BufferModeSettings](../wmi-provider/buffermodesettings-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `BufferModeElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Management.BufferedWebEventProvider.BufferMode](/dotnet/api/system.web.management.bufferedwebeventprovider.buffermode)  
 [BufferModeSettings Class](../wmi-provider/buffermodesettings-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HealthMonitoringSection Class](../wmi-provider/healthmonitoringsection-class.md)   
 [CIM_DATETIME](http://go.microsoft.com/fwlink/?LinkId=57551)