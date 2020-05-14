---
title: "DirectoryBrowseSection Class"
ms.date: "10/07/2016"
ms.assetid: 9bb4e71c-9b3c-7539-a6a1-33808d7698ce
---
# DirectoryBrowseSection Class
Configures directory browsing in IIS.  
  
## Syntax  
  
```vbs  
class DirectoryBrowseSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `DirectoryBrowseSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `DirectoryBrowseSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Enabled`|A read/write `boolean` value. `true` if directory browsing will be enabled for a directory in IIS; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`ShowFlags`|A `sint32` value containing a mask that configures the display of file information in a browsed directory. The possible values are listed later in the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 If directory browsing is enabled for a directory in IIS, users receive a page that lists the contents of the directory when the following are true:  
  
- The user does not specify a file in the URL (for example, the user goes to http://www.contoso.com/ instead of http://www.contoso.com/default.htm).  
  
- Default documents are disabled in IIS, or IIS is unable to locate a file in the directory that matches a name specified in the IIS default document list.  
  
> [!NOTE]
>  By default, directory browsing is disabled in IIS so that users cannot see the contents of directories. To enhance security, you should leave directory browsing disabled unless you have a specific reason to enable it—for example, to share files over HTTP using Web Distributed Authoring and Versioning (WebDAV). If you enable directory browsing, ensure that you enable it only on the particular directory or directories that you want to share.  
  
 The following table lists the possible values for the `ShowFlags` property. The default values are 2 (`Date`), 4 (`Time`), 8 (`Size`), and 16 (`Extension`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|Displays file names without extensions. This flag has no effect when other flags are already specified.|  
|2|`Date`|The last modified date for each file.|  
|4|`Time`|The last modified time for each file.|  
|8|`Size`|The size of each file.|  
|16|`Extension`|The file extension after the file name.|  
|32|`LongDate`|The last modified date in extended format for each file.|  
  
## Example  
 The following example displays the properties of the `DirectoryBrowseSection` class for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
Set oService = GetObject("winmgmts:root\WebAdministration")  
  
' Get the directory browse section of the default Web site.  
Set oSite = oService.Get("Site.Name='Default Web Site'")  
oSite.GetSection "DirectoryBrowseSection", oSection  
  
' Display the properties.  
WScript.Echo "DirectoryBrowseSection Properties"  
WScript.Echo "---------------------------------"  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo "Location: " & oSection.Location  
WScript.Echo "Enabled: " & oSection.Enabled  
WScript.Echo "ShowFlags: " & oSection.ShowFlags  
WScript.Echo
WScript.Echo "DirectoryBrowseSection.SectionInformation"  
WScript.Echo "-----------------------------------------"  
WScript.Echo "OverrideMode: " & oSection.SectionInformation.OverrideMode  
WScript.Echo "EffectiveOverrideMode: " & oSection.SectionInformation.EffectiveOverrideMode  
WScript.Echo "IsLocked: " & _  
    oSection.SectionInformation.IsLocked  
WScript.Echo "LockItem: " & _  
    oSection.SectionInformation.LockItem  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `DirectoryBrowseSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)
 [Configure Directory Browsing](https://go.microsoft.com/fwlink/?LinkId=64345)
