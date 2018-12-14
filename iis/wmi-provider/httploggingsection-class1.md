---
title: "HttpLoggingSection Class1 | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 28d7825f-54f6-d715-c32b-13d911e6763d
caps.latest.revision: 29
author: "shirhatti"
manager: "wpickett"
---
# HttpLoggingSection Class1
Configures the logging of HTTP requests.  
  
## Syntax  
  
```vbs  
class HttpLoggingSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HttpLoggingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class1.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `HttpLoggingSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`DontLog`|A read/write `boolean` value. `true` if logging is disabled for successful requests; `false` if successful requests are logged. A request is considered successful if its status code is less than 400. The default is `false`. **Note:**  This property is the same as the [DontLog](http://go.microsoft.com/fwlink/?LinkId=73544) metabase property in IIS 6.0.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`SelectiveLogging`|A `sint32` enumeration that specifies the events to log. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class corresponds to the `<system.webServer/httpLogging>` section in the ApplicationHost.config file.  
  
 The following table lists the possible values for the `SelectiveLogging` property. The default is 0 (`LogAll`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`LogAll`|All requests are logged.|  
|1|`LogSuccessful`|Only successful requests are logged. A request is considered successful if its status code is less than 400.|  
|2|`LogError`|Only failed requests are logged. A request is considered failed if its status code is greater than or equal to 400.|  
  
## Example  
 The following code example sets the `SelectiveLogging` property to `LogError`.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject( _  
    "winmgmts:root\WebAdministration")  
  
' Get the HTTP logging section.  
Set oSection = oWebAdmin.Get( _  
    "HttpLoggingSection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]" & vbCrLf  
  
' Display the initial settings.  
Call DisplaySettings("Initial Values", oSection)  
  
' Set the SelectiveLogging property to LogError.  
    oSection.SelectiveLogging = 2  
  
' Save new values to configuration.  
oSection.Put_  
  
' Refresh the oSection object variable with new values.  
oSection.Refresh_  
  
' Show changed settings.  
Call DisplaySettings("New Values", oSection)  
  
' ==== DisplaySettings helper function. ====  
Function DisplaySettings(HeadingText, oSection)  
  
    ' Display a heading.  
    WScript.Echo String(Len(HeadingText), "-")  
    WScript.Echo HeadingText  
    WScript.Echo String(Len(HeadingText), "-")  
  
    ' Display configuration history section properties.  
    WScript.Echo "Path: " & oSection.Path  
    WScript.Echo "Location: " & oSection.Location  
    WScript.Echo "DontLog: " & oSection.DontLog  
    WScript.Echo "SelectiveLogging: " & _  
        oSection.SelectiveLogging  
    WScript.Echo  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class1.md)  
  
 `HttpLoggingSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CentralBinaryLogFile Class](../wmi-provider/centralbinarylogfile-class1.md)   
 [CentralW3CLogFile Class](../wmi-provider/centralw3clogfile-class1.md)   
 [ConfigurationSection Class](../wmi-provider/configurationsection-class1.md)   
 [OdbcLoggingSection Class](../wmi-provider/odbcloggingsection-class1.md)   
 [LogSection Class](../wmi-provider/logsection-class1.md)   
 [SiteLogFile Class](../wmi-provider/sitelogfile-class1.md)   
 [DontLog Metabase Property (IIS 6.0)](http://go.microsoft.com/fwlink/?LinkId=73544)