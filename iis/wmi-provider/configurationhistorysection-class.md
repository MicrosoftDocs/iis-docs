---
title: ConfigurationHistorySection Class
description: Describes the ConfigurationHistorySection class and provides the class' syntax, properties, remarks, examples, and requirements.
ms.date: 10/07/2016
ms.assetid: a512b40b-5c31-4970-ba68-0a723fb9e5a5
---
# ConfigurationHistorySection Class
Configures the configuration history settings of the ApplicationHost Helper Service.  
  
## Syntax  
  
```vbs  
class ConfigurationHistorySection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `ConfigurationHistorySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `ConfigurationHistorySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Enabled`|A read/write `boolean` value. `true` if the ApplicationHost Helper Service checks for changes in the ApplicationHost.config file by using the time interval specified by the `Period` property; `false` if the service does not check for changes. The default is `true`. If the configuration changes and is still valid, the helper service saves the ApplicationHost.config file in a versioned subdirectory inside the directory specified by the `HistoryPath` property.|  
|`HistoryPath`|A read/write `string` value that specifies the path of the directory that contains the configuration history subdirectories. The default is "*%systemdrive%*\inetpub\history". **Note:**  The ApplicationHost Helper Service saves one copy of the ApplicationHost.config file in each configuration history subdirectory. The configuration history subdirectories have the naming format CFGHISTORY_*\<serial number>*. The serial number is a 10-digit sequential number (zero padded).|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`MaxHistories`|A read/write `uint32` value that specifies the maximum number of configuration history subdirectories. The default is 10. If the number of configuration history subdirectories reaches the number specified, the subdirectory with the lowest version number is deleted.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Period`|A read/write `datetime` value that specifies the frequency with which the ApplicationHost Helper Service checks for changes in the ApplicationHost.config file. The default is 2 minutes. If the configuration changes and is still valid, the helper service saves the files in the directory specified by the `HistoryPath` property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class provides a configuration history feature that enables you to go back to a former configuration state if you no longer want the current state.  
  
 The ApplicationHost Helper Service enables the configuration history functionality by saving the ApplicationHost.config file to separate configuration history subdirectories at set intervals specified by the `Period` property. The subdirectories reside in the directory specified by the `HistoryPath` property.  
  
 If you make a mistake when you modify the ApplicationHost.config file, you can restore an earlier version of the file from a configuration history subdirectory by copying the earlier version into the *%windir%*\system32\inetsrv\config directory.  
  
> [!NOTE]
>  The configuration history files do not require separate access control list (ACL) configuration. They inherit their ACL values from the parent directory, to which only administrators have access.  
  
 The configuration history feature depends on the ApplicationHost Helper Service. The ApplicationHost Helper Service is a runtime-independent service that does not require the Windows Process Activation Service (WAS) or the World Wide Web Publishing Service (WWW service) to operate. It does not depend on any other service and its startup type is `Automatic`.  
  
> [!NOTE]
> If the ApplicationHost Helper Service is stopped, the configuration history feature will not work.  
  
## Example  
 The following code example sets the maxiumum number of history subdirectories to 20 and specifies that the ApplicationHost.config file be checked for changes every 4 minutes. A helper function displays the `ConfigurationHistorySection` values before and after the change.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the configuration history section.  
Set oSection = oWebAdmin.Get( _  
    "ConfigurationHistorySection.Path=" & _  
    "'MACHINE/WEBROOT/APPHOST',Location=''")  
  
' Display the class name of the section.  
WScript.Echo "[ " & oSection.Path_.Class & " ]" & vbCrLf  
  
' Display the initial settings.  
Call DisplaySettings("Initial Values", oSection)  
  
' Set the maximum number of history subdirectories to 20.  
oSection.MaxHistories = 20  
  
' Check ApplicationHost.config for changes every 4 minutes.  
oSection.Period = "00000000000400.000000:000"  
  
' Save the values to configuration.  
oSection.Put_  
  
' Refresh the oSection object variable with the new values.  
oSection.Refresh_  
  
' Show the changed settings.  
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
    WScript.Echo "History Path: " & oSection.HistoryPath  
    WScript.Echo "Period: " & oSection.Period  
    WScript.Echo "MaxHistories: " & oSection.MaxHistories  
    WScript.Echo  
End Function  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `ConfigurationHistorySection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)
