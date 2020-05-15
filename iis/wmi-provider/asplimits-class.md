---
title: "AspLimits Class"
ms.date: "10/07/2016"
ms.assetid: 7e2263ab-ad01-26b5-3846-fdf08a65f7bb
---
# AspLimits Class

Configures properties related to ASP limits.  
  
## Syntax  
  
```vbs  
class AspLimits : EmbeddedObject  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `AspLimits` class.  
  
|Name|Description|  
|----------|-----------------|  
|`BufferingLimit`|A read/write `uint32` value that sets the maximum size of the ASP buffer. The default is 4194304. If response buffering is turned on, this property controls the maximum number of bytes that an ASP page can write to the response buffer before a flush occurs.|  
|`MaxRequestEntityAllowed`|A read/write `uint32` value that specifies the maximum number of bytes that are allowed in the entity body of an ASP request. The default is 200000.|  
|`ProcessorThreadMax`|A read/write `uint32` value that specifies the maximum number of worker threads per processor that IIS may create. The default is 25.|  
|`QueueConnectionTestTime`|A read/write `datetime` value that specifies the amount of time ASP waits before checking whether the client that is associated with a queued request is still connected. The default is 3 seconds. If the client is no longer connected, the request is not processed and is deleted from the queue.|  
|`QueueTimeout`|A read/write `datetime` value that specifies the amount of time that an ASP script request is allowed to wait in the queue. The default is 0 seconds.|  
|`RequestQueueMax`|A read/write `uint32` value that specifies the maximum number of concurrent ASP requests that are permitted into the queue. The default is 3000.|  
|`ScriptTimeout`|A read/write `datetime` value that specifies the default length of time that ASP pages allow a script to run before terminating the script and writing an event to the Windows event log. The default is 1 minute 30 seconds.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `Limits` property of the [AspSection](../wmi-provider/aspsection-class.md) class.  
  
## Inheritance Hierarchy  

 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `AspLimits`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [AspCache Class](../wmi-provider/aspcache-class.md)   
 [AspComPlus Class](../wmi-provider/aspcomplus-class.md)   
 [AspSection Class](../wmi-provider/aspsection-class.md)   
 [AspSession Class](../wmi-provider/aspsession-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [CIM_DATETIME](https://go.microsoft.com/fwlink/?LinkId=57551)
