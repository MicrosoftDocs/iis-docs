---
title: "ConfiguredObject.GetSection Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 31cf1e5c-75cd-6fc6-ac1e-1fdf1da1061d
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# ConfiguredObject.GetSection Method
Retrieves the contents of a configuration section for a configured object.  
  
## Syntax  
  
```jscript#  
ConfiguredObject.GetSection(SectionName, Section);  
```  
  
```vbs  
ConfiguredObject.GetSection SectionName, Section  
```  
  
#### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`SectionName`|A `string` variable that contains the name of the configuration section to be retrieved (for example, "BasicAuthenticationSection").|  
|`Section`|A [ConfigurationSection](../wmi-provider/configurationsection-class.md) variable into which the contents of the configuration section are placed.|  
  
## Return Value  
 This method does not return a value.  
  
## Remarks  
 You can use the `GetSection` method to retrieve the contents of a desired configuration section and set its configurable properties.  
  
> [!NOTE]
>  The `GetSection` method signature contains an `[IN]` parameter for the section name and an `[OUT]` parameter for the section object that the method returns.  
  
## Example  
 The following example gets the HTTP errors section for the default Web site and displays both its array and non-array properties.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
' Get the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' Get the HTTP errors section by using the GetSection method.  
oSite.GetSection "HttpErrorsSection", oSection  
  
' Display a heading.  
WScript.Echo "=============================="  
WScript.Echo "Http Errors Section Properties"  
WScript.Echo "=============================="  
  
' Display the HttpErrorsSection non-array properties.  
For Each vProp In oSection.Properties_  
    If (vProp.Name <> "HttpErrors") And _  
        (vProp.Name <> "SectionInformation") Then  
        WScript.Echo vProp.Name & ": " & vProp.Value  
    End If  
Next  
WScript.Echo   
  
' Display the HttpErrorsSection SectionInformation properties.  
WScript.Echo "HttpErrorsSection.SectionInformation"  
WScript.Echo "------------------------------------"  
For Each vProp In oSection.SectionInformation.Properties_  
    WScript.Echo vProp.Name & ": " & vProp.Value  
Next  
WScript.Echo  
  
' Display the contents of the HttpErrors array property.  
WScript.Echo "HttpErrorsSection.HttpErrors"  
WScript.Echo "----------------------------"  
For Each oHttpErrorElement In oSection.HttpErrors  
    For Each vProp In oHttpErrorElement.Properties_  
        WScript.Echo vProp.Name & ": " & vProp.Value  
    Next  
    WScript.Echo  
Next  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [ConfiguredObject Class](../wmi-provider/configuredobject-class.md)   
 [HttpErrorElement Class](../wmi-provider/httperrorelement-class.md)   
 [HttpErrorsSection Class](../wmi-provider/httperrorssection-class.md)