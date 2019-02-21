---
title: "TraceProviderDefinition Class"
ms.date: "10/07/2016"
ms.assetid: d800efb0-c7af-4e21-f3ad-336536b5604d
---
# TraceProviderDefinition Class
Specifies a trace provider's name, GUID, and trace area enumeration.  
  
## Syntax  
  
```vbs  
class TraceProviderDefinition : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TraceProviderDefinition` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Areas`|A [TraceAreaSettings](../wmi-provider/traceareasettings-class.md) value that optionally specifies an enumeration of filter flags or trace areas for a trace provider.|  
|`Guid`|A required read/write `string` value that identifies the trace provider for Event Tracing for Windows (ETW) support. You can list this GUID by running `logman query providers` at a command prompt.|  
|`Name`|A required unique read/write `string` value that contains the friendly name of the trace provider. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `TraceProviderDefinitions` property of the [TraceProviderDefinitionsSection](../wmi-provider/traceproviderdefinitionssection-class.md) class.  
  
 Common trace providers are "ASP", "ASPNET", "ISAPI Extension", and "WWW Server". These are included by default in the ApplicationHost.config file.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TraceProviderDefinition`  
  
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
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)   
 [Logman](http://go.microsoft.com/fwlink/?LinkId=64802)