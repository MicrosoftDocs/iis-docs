---
title: "TraceAreaDefinition Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2e7a5f92-c545-bddf-e717-433ae9baa574
caps.latest.revision: 26
author: "shirhatti"
manager: "wpickett"
---
# TraceAreaDefinition Class
Specifies trace area names and their corresponding enumeration values for a trace provider.  
  
## Syntax  
  
```vbs  
class TraceAreaDefinition : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TraceAreaDefinition` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Name`|A required unique read/write `string` value that specifies the name of the trace area. The key property.|  
|`Value`|A read/write `uint32` value that maps to a trace area or areas. You can define one or more trace areas by specifying the flag number. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Areas` array property of the [TraceAreaSettings](../wmi-provider/traceareasettings-class.md) class.  
  
 The failed-request tracing feature of [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] uses the `TraceAreaDefinition` class. The property values of this class map to the same values for the areas used by the Event Tracing for Windows (ETW) providers. Trace areas are defined by default for the "WWW Server" and "ASPNET" trace providers in the ApplicationHost.config file.  
  
 The following table lists the possible values for the `Value` property.  
  
|Value|Keyword|  
|-----------|-------------|  
|2|`Authentication`|  
|4|`Security`|  
|8|`Filter`|  
|16|`StaticFile`|  
|32|`CGI`|  
|64|`Compression`|  
|128|`Cache`|  
|256|`RequestNotifications`|  
|512|`Module`|  
  
> [!NOTE]
>  There is no `UrlFilter` area as there is in ETW for Windows Server 2003 SP1.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TraceAreaDefinition`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [Create a Tracing Rule for Failed Requests](http://go.microsoft.com/fwlink/?LinkId=64723)   
 [FailureDefinition Class](../wmi-provider/failuredefinition-class.md)   
 [HttpTracingSection Class](../wmi-provider/httptracingsection-class.md)   
 [TraceAreaElement Class](../wmi-provider/traceareaelement-class.md)   
 [TraceAreaSettings Class](../wmi-provider/traceareasettings-class.md)   
 [TraceFailedRequestsSection Class](../wmi-provider/tracefailedrequestssection-class.md)   
 [TraceProviderDefinition Class](../wmi-provider/traceproviderdefinition-class.md)   
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)