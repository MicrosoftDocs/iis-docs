---
title: "TraceAreaElement Class"
ms.date: "10/07/2016"
ms.assetid: 886766c8-3b3c-14f3-9633-0443a6497a9c
---
# TraceAreaElement Class
Specifies criteria for generating trace events and configures the content of log file entries.  
  
## Syntax  
  
```vbs  
class TraceAreaElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TraceAreaElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Areas`|A read/write `string` value that has a comma-delimited list, without spaces, of areas whose requests are traced when the `Provider` property is set to "ASPNET" or "WWW server". When `Provider` is set to "ASPNET," the possible values are "Infrastructure", "Module", "Page", and "AppServices". When `Provider` is set to "WWW server", the possible values are "Authentication", "Security", "Filter", "StaticFile", "CGI", "Compression", "Cache", "RequestNotifications", and "All".|  
|`Provider`|A required unique read/write `string` value that contains the name of the provider whose failed requests are traced. The possible values are "ASP", "ASPNET", "ISAPI Extension", and "WWW Server". The key property.|  
|`Verbosity`|A read/write `sint32` value that specifies the level of verbosity when failed requests are logged. The possible values are listed in the Remarks section below.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `TraceAreas` array property of the [TraceUrlAreaSettings](../wmi-provider/traceurlareasettings-class.md) class.  
  
 The following table lists the possible values for the `Verbosity` property. The default is 3 (`Warning`).  
  
 For a request to be marked as failed, the events raised must have a level less than or equal to the value in `Verbosity`. `General` events are excluded from this calculation.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`General`|Provides information about the context of the request activity, such as the URL and verb for the request.|  
|1|`CriticalError`|Provides information about actions that can cause a process to exit or that are about to cause a process to exit.|  
|2|`Error`|Provides information about components that experience an error and cannot continue to process requests. These errors usually indicate a server-side problem.|  
|3|`Warning`|Provides information about components that experience an error but can continue processing requests. The default.|  
|4|`Information`|Provides general information about requests.|  
|5|`Verbose`|Provides detailed information about requests.|  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TraceAreaElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HttpTracingSection Class](../wmi-provider/httptracingsection-class.md)   
 [TraceAreaDefinition Class](../wmi-provider/traceareadefinition-class.md)   
 [TraceAreaSettings Class](../wmi-provider/traceareasettings-class.md)   
 [TraceFailedRequestsSection Class](../wmi-provider/tracefailedrequestssection-class.md)   
 [TraceProviderDefinition Class](../wmi-provider/traceproviderdefinition-class.md)   
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)   
 [TraceUrlAreaSettings Class](../wmi-provider/traceurlareasettings-class.md)   
 [Create a Tracing Rule for Failed Requests](http://go.microsoft.com/fwlink/?LinkId=64723)