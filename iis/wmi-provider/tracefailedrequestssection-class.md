---
title: TraceFailedRequestsSection Class
description: Describes the TraceFailedRequestsSection class and provides the class' syntax, methods, properties, remarks, an example, and requirements.
ms.date: 10/07/2016
ms.assetid: 6730e6f8-fff8-8e3b-b50c-42e67b9cec62
---
# TraceFailedRequestsSection Class
Represents a failed-request tracing configuration section.  
  
## Syntax  
  
```vbs  
class TraceFailedRequestsSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `TraceFailedRequestsSection` class.  
  
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
 The following table lists the properties exposed by the `TraceFailedRequestsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`TraceFailedRequests`|A read/write array of [TraceUrl](../wmi-provider/traceurl-class.md) values that configure the tracing for specific request types (for example, *.aspx).|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class corresponds to the `<traceFailedRequests>` section in ApplicationHost.config.  
  
## Example  
 The following example lists the `Location`, `Path`, and `TraceFailedRequest` properties for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' Place the TraceFailedRequestsSection object into a variable by  
' using the GetSection method on the Site object.  
oSite.GetSection "TraceFailedRequestsSection", oTFRSection  
  
' Echo the path and location information.  
WScript.Echo "Path: " & oTFRSection.Path  
WScript.Echo "Location: " & oTFRSection.Location  
WScript.Echo vbCRLF  
  
' Retrieve and display the values for the TraceFailedRequests property.  
For Each oTFR In oTFRSection.TraceFailedRequests  
    WScript.Echo "Trace URL path: " & oTFR.Path  
    WScript.Echo String(16 + Len(oTFR.Path), "=")  
  
    Set oFD = oTFR.FailureDefinitions  
    WScript.Echo "Failure Definition Status Codes: " & oFD.StatusCodes  
    WScript.Echo "Failure Definition TimeTaken: " & oFD.TimeTaken  
    WScript.Echo "Failure Definition Verbosity Level: " & _  
            GetVerbosityText(oFD.Verbosity)  
    WScript.Echo   
  
    For Each oTA In oTFR.TraceAreas.TraceAreas  
        WScript.Echo "Trace Provider: " & oTA.Provider  
        WScript.Echo "Trace Verbosity Level: " & _  
            GetVerbosityText(oTA.Verbosity)  
        If Not (oTA.Provider = "ASP" Or _  
                oTA.Provider = "ISAPI Extension") Then  
            WScript.Echo "Trace Areas: " & oTA.Areas  
        End If  
        WScript.Echo   
    Next  
    WScript.Echo  
Next  
  
' Provide text for the verbosity enumeration values.  
Function GetVerbosityText(sint32Value)  
    Select Case sint32Value  
        Case 0  
            GetVerbosityText="General"  
        Case 1  
            GetVerbosityText="Critical Error"  
        Case 2  
            GetVerbosityText="Error"  
        Case 3  
            GetVerbosityText="Warning"  
        Case 4  
            GetVerbosityText="Information"  
        Case 5  
            GetVerbosityText="Verbose"  
        Case Else  
            GetVerbosityText ="Undefined Verbosity Level"  
    End Select  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `TraceFailedRequestsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [HttpTracingSection Class](../wmi-provider/httptracingsection-class.md)   
 [TraceAreaElement Class](../wmi-provider/traceareaelement-class.md)   
 [TraceAreaDefinition Class](../wmi-provider/traceareadefinition-class.md)   
 [TraceProviderDefinition Class](../wmi-provider/traceproviderdefinition-class.md)   
 [TraceProviderDefinitionsSection Class](../wmi-provider/traceproviderdefinitionssection-class.md)   
 [TraceUrl Class](../wmi-provider/traceurl-class.md)   
 [TraceUrlAreaSettings Class](../wmi-provider/traceurlareasettings-class.md)   
 [Create a Tracing Rule for Failed Requests](https://go.microsoft.com/fwlink/?LinkId=64723)
