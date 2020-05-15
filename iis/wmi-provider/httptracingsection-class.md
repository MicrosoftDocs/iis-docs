---
title: "HttpTracingSection Class"
ms.date: "10/07/2016"
ms.assetid: 038d500a-3026-be97-4539-205311ac53c3
---
# HttpTracingSection Class

Represents an HTTP tracing configuration section.  
  
## Syntax  
  
```vbs  
class HttpTracingSection : ConfigurationSectionWithCollection  
```  
  
## Methods  

 The following table lists the methods exposed by the `HttpTracingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  

 The following table lists the properties exposed by the `HttpTracingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`TraceUrls`|A [TraceUrlSettings](../wmi-provider/traceurlsettings-class.md) value that specifies tracing for specific types of requests.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 This class corresponds to the `<httpTracing>` section in ApplicationHost.config and is used for Event Tracing for Windows (ETW) request-based tracing.  
  
## Example  

 The following code example displays the contents of the `TraceUrls` property.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the HTTP tracing section.  
Set oSection = oWebAdmin.Get( _  
    "HttpTracingSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]"  
  
' Display the path.  
WScript.Echo "Path: " & oSection.Path  
  
' Display the trace url values.  
For Each strElement In oSection.TraceUrls.TraceUrls  
    WScript.Echo strElement.Value  
Next  
  
```  
  
## Inheritance Hierarchy  

 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HttpTracingSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [Create a Tracing Rule for Failed Requests](https://go.microsoft.com/fwlink/?LinkId=64723)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [FailureDefinition Class](../wmi-provider/failuredefinition-class.md)   
 [TraceAreaElement Class](../wmi-provider/traceareaelement-class.md)   
 [TraceAreaDefinition Class](../wmi-provider/traceareadefinition-class.md)   
 [TraceFailedRequestsSection Class](../wmi-provider/tracefailedrequestssection-class.md)   
 [TraceProviderDefinition Class](../wmi-provider/traceproviderdefinition-class.md)   
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)   
 [TraceUrlSettings Class](../wmi-provider/traceurlsettings-class.md)
