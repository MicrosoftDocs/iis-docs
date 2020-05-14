---
title: "TraceUrl Class"
ms.date: "10/07/2016"
ms.assetid: c3e5f869-317e-ae63-b882-2f194e4c665a
---
# TraceUrl Class
Configures the failed-request tracing for a specific request path.  
  
## Syntax  
  
```vbs  
class TraceUrl : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TraceUrl` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CustomActionExe`|A read/write `string` value that specifies an executable file to run when a failure condition is reached (for example, to run a VBScript file, specify "cscript.exe"). All command-line variables will be expanded. For example, "%windir%" will be expanded to the path of the Windows directory. **Note:**  The executable file will run only if the limit specified in the `CustomActionTriggerLimit` property has not been reached in the worker process.|  
|`CustomActionParams`|A read/write `string` value that contains parameters to pass to the executable file specified in the `CustomActionExe` property. Command-line variables such as "%windir%" will be expanded. You may also use parameter variables such as "%1" and "%2" in the string that you specify (for example, "MyScript.vbs %1 %2").|  
|`CustomActionTriggerLimit`|A read/write `uint32` value that specifies the maximum number of times the program specified by the `CustomActionExe` property will execute during the lifetime of the worker process for the failed-request definition. This value resets every time that the worker process recycles. Permissible values are from 0 through 10000. The default is 1. This feature can be used, for example, to create a memory dump after the next failure but not after subsequent failures. **Note:**  If the `CustomActionTriggerLimit` value that you specify is reached during the run time of the worker process, subsequent failed requests will be logged, but the program specified in `CustomActionExe` will not run. The entries in the failed-requests log will indicate that the `CustomActionTriggerLimit` value has been reached.|  
|`FailureDefinitions`|A read/write [FailureDefinition](../wmi-provider/failuredefinition-class.md) object that specifies the conditions under which a request trace is generated.|  
|`Path`|A required unique read/write `string` value that contains the path of the request to be traced (for example, "*.aspx"). This path is relative to the virtual directory, does not allow subpaths, and can contain only one wildcard (\*). The `Path` property is similar to the `path` attribute in the `<handlers>` section of the ApplicationHost.config file. The key property.|  
|`TraceAreas`|A [TraceUrlAreaSettings](../wmi-provider/traceurlareasettings-class.md) value that specifies areas whose requests are traced.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `TraceFailedRequests` array property of the [TraceFailedRequestsSection](../wmi-provider/tracefailedrequestssection-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TraceUrl`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)
 [FailureDefinition Class](../wmi-provider/failuredefinition-class.md)
 [HttpTracingSection Class](../wmi-provider/httptracingsection-class.md)
 [TraceAreaDefinition Class](../wmi-provider/traceareadefinition-class.md)
 [TraceAreaSettings Class](../wmi-provider/traceareasettings-class.md)
 [TraceFailedRequestsSection Class](../wmi-provider/tracefailedrequestssection-class.md)
 [TraceProviderDefinition Class](../wmi-provider/traceproviderdefinition-class.md)
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)
 [TraceUrlAreaSettings Class](../wmi-provider/traceurlareasettings-class.md)
 [Create a Tracing Rule for Failed Requests](https://go.microsoft.com/fwlink/?LinkId=64723)
