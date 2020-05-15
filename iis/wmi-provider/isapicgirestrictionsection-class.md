---
title: "IsapiCgiRestrictionSection Class"
ms.date: "10/07/2016"
ms.assetid: c774177c-4c4b-8d8b-bfb4-b7b7cd985b65
---
# IsapiCgiRestrictionSection Class

Configures ISAPI and Common Gateway Interface (CGI) restrictions for a Web server that runs in ISAPI mode.  
  
## Syntax  
  
```vbs  
class IsapiCgiRestrictionSection : ConfigurationSectionWithCollection  
```  
  
## Methods  

 The following table lists the methods exposed by the `IsapiCgiRestrictionSection` class.  
  
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

 The following table lists the properties exposed by the `IsapiCgiRestrictionSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`IsapiCgiRestriction`|An array of [IsapiCgiRestrictionElement](../wmi-provider/isapicgirestrictionelement-class.md) values that contain ISAPI or CGI restrictions.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`NotListedCgisAllowed`|A read/write `boolean` value. `true` if CGI restrictions that are not listed are allowed; otherwise, `false`. The default is `false`.|  
|`NotListedIsapisAllowed`|A read/write `boolean` value. `true` if ISAPI restrictions that are not listed are allowed; otherwise, `false`. The default is `false`.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 ISAPI and CGI restrictions are request handlers that allow dynamic content to execute on a server. These restrictions are either CGI files (.exe) or ISAPI extensions (.dll). The Asp.dll and Aspnet_isapi.dll files are included by default. You can add custom ISAPI or CGI restrictions if the IIS configuration permits.  
  
> [!NOTE]
>  If you are running [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] in ISAPI mode, you can use ISAPI or CGI restrictions on your Web server. This feature is not available if you are running [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] in integrated mode.  
  
## Example  

 The following example shows the values for the `NotListedCgisAllowed`, `NotListedIsapisAllowed`, and `Path` properties, and it lists the contents of the `IsapiCgiRestriction` array property.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' Get the ISAPI-CGI restriction section.  
oSite.GetSection "IsapiCgiRestrictionSection", oSection  
  
' Display the non-array IsapiCgiRestrictionSection properties.  
WScript.Echo "ISAPI CGI Restriction Section"  
WScript.Echo "-----------------------------"  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo "NotListedCgisAllowed: " & _  
    oSection.NotListedCgisAllowed  
WScript.Echo "NotListedIsapisAllowed: " & _  
    oSection.NotListedIsapisAllowed  
WScript.Echo   
  
' Display the contents of the IsapiCgiRestriction array property.  
WScript.Echo vbTab & "ISAPI CGI Restriction Elements"  
WScript.Echo vbtab & "------------------------------"  
For Each oIsapiCgiRestrictionElement In oSection.IsapiCgiRestriction  
    WScript.Echo  vbtab & "GroupID: " & _  
        oIsapiCgiRestrictionElement.GroupID  
    WScript.Echo  vbtab & "Description: " & _  
        oIsapiCgiRestrictionElement.Description  
    WScript.Echo  vbtab & "Path: " & _  
        oIsapiCgiRestrictionElement.Path  
    WScript.Echo  vbtab & "Allowed: " & _  
        oIsapiCgiRestrictionElement.Allowed  
    WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  

 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `IsapiCgiRestrictionSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [IsapiCgiRestrictionElement Class](../wmi-provider/isapicgirestrictionelement-class.md)
