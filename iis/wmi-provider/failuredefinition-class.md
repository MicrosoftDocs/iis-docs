---
title: "FailureDefinition Class"
description: This article contains information about syntax, methods, properties, subclasses, inheritance hierarchy, and requirements for the FailureDefinition class.
ms.date: "10/07/2016"
ms.assetid: f563801a-d5fd-0f69-74bd-4be0b05c6871
---
# FailureDefinition Class
Specifies the conditions under which a request trace is generated.  
  
## Syntax  
  
```vbs  
class FailureDefinition : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `FailureDefinition` class.  
  
|Name|Description|  
|----------|-----------------|  
|`StatusCodes`|A read/write `string` value that contains a comma-delimited list, without spaces, of HTTP status codes that cause a request to be traced. If you do not specify substatus codes, all substatus codes for the given status code will be traced. For example, if you specify "404", traces for 404.1, 404.2 and 404.5 will also be returned. Status codes must be from 100 to 999, and substatus codes must be from 1 to 999. **Note:**  You can specify a range of status codes (for example, "400-599"). The second number must be greater than or equal to the first number. The range cannot include substatus values.|  
|`TimeTaken`|A read-only `datetime` value that specifies the amount of time that a request may spend in processing before it is marked as failed and then traced. The default is 0. A key property.|  
|`Verbosity`|A read/write `sint32` enumeration value that specifies the threshold for trace events. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `FailureDefinitions` property of the [TraceUrl](../wmi-provider/traceurl-class.md) class.  
  
 A request will have its events traced if it lasts beyond the value of the `TimeTaken` property or if its status code is in the list contained by the `StatusCodes` property. If both `StatusCodes` and `TimeTaken` are specified, the first condition that evaluates to `true` will cause the request trace to be generated.  
  
 The following table lists the possible values for the `Verbosity` property. The default is 0 (`Ignore`).  
  
 For a request to be marked as failed, the events raised must have a level less than or equal to the value in `Verbosity`.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Ignore`|Provides no information about the request activity.|  
|1|`CriticalError`|Provides information about actions that can cause a process to exit or that are about to cause a process to exit.|  
|2|`Error`|Provides information about components that experience an error and cannot continue to process requests. These errors usually indicate a server-side problem. The default.|  
|3|`Warning`|Provides information about components that experience an error but can continue processing requests.|  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `FailureDefinition`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [Create a Tracing Rule for Failed Requests](https://go.microsoft.com/fwlink/?LinkId=64723)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)   
 [TraceAreaElement Class](../wmi-provider/traceareaelement-class.md)   
 [TraceAreaDefinition Class](../wmi-provider/traceareadefinition-class.md)   
 [TraceFailedRequestsSection Class](../wmi-provider/tracefailedrequestssection-class.md)   
 [TraceProviderDefinition Class](../wmi-provider/traceproviderdefinition-class.md)   
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)
