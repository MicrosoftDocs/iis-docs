---
title: "IsapiCgiRestrictionElement Class"
description: Represents an ISAPI or Common Gateway Interface (CGI) restriction element.
ms.date: "10/07/2016"
ms.assetid: 73cb1f6b-b712-c837-845a-f1d7076b4143
---
# IsapiCgiRestrictionElement Class
Represents an ISAPI or Common Gateway Interface (CGI) restriction element.  
  
## Syntax  
  
```vbs  
class IsapiCgiRestrictionElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `IsapiCgiRestrictionElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Allowed`|A read/write `boolean` value. `true` if the restriction is allowed to run automatically; otherwise, `false`. The default is `false`.|  
|`Description`|A read/write `string` value that contains a description of the restriction.|  
|`GroupId`|An optional read/write `string` value that identifies a group to which a restriction belongs. This setting enables you to group restrictions for easier management.|  
|`Path`|A required nonempty read-only `string` value that contains the path of the .dll or .exe file for the restriction. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `IsapiCgiRestriction` array property of the [IsapiCgiRestrictionSection](../wmi-provider/isapicgirestrictionsection-class.md) class.  
  
 ISAPI and CGI restrictions are request handlers that enable dynamic content to execute on a server. These restrictions are either CGI files (.exe) or ISAPI extensions (.dll). By default, Asp.dll and Aspnet_isapi.dll are included. You can add custom ISAPI or CGI restrictions if the IIS configuration allows.  
  
 **Note** If you are running [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] in ISAPI mode, you can use ISAPI or CGI restrictions on your Web server. This feature is not available if you are running [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] in integrated mode.  
  
## Example  
 The following example lists all of the `IsapiCgiRestrictionElement` instances for the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = _  
    GetObject("winmgmts:root\WebAdministration")  
  
' Get the restriction section for the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "IsapiCgiRestrictionSection", oSection  
  
' Display the path.  
WScript.Echo "Path: " & oSection.Path  
WScript.Echo  
  
' Display all the ISAPI CGI restriction elements.  
WScript.Echo "ISAPI CGI Restriction Elements"  
WScript.Echo "------------------------------"  
For Each oIsapiCgiRestrictionElement In _  
        oSection.IsapiCgiRestriction  
    WScript.Echo  "GroupID: " & _  
        oIsapiCgiRestrictionElement.GroupID  
    WScript.Echo  "Description: " & _  
        oIsapiCgiRestrictionElement.Description  
    WScript.Echo  "Path: " & _  
        oIsapiCgiRestrictionElement.Path  
    WScript.Echo  "Allowed: " & _  
        oIsapiCgiRestrictionElement.Allowed  
    WScript.Echo  
Next  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `IsapiCgiRestrictionElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [IsapiCgiRestrictionSection Class](../wmi-provider/isapicgirestrictionsection-class.md)
