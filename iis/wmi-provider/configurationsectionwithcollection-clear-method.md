---
title: "ConfigurationSectionWithCollection.Clear Method"
description: "The ConfigurationSectionWithCollection.Clear method clears all elements from a collection in a configuration section."
ms.date: "10/07/2016"
ms.assetid: f37e0c33-fc7d-b3ce-32b4-e980b4ffff06
---
# ConfigurationSectionWithCollection.Clear Method
Clears all elements from a collection in a configuration section.  
  
## Syntax  
  
```jscript#  
ConfigurationSectionWithCollection.Clear(collectionName);  
```  
  
```vbs  
ConfigurationSectionWithCollection.Clear(collectionName)  
```  
  
### Parameters  
  
|Name|Definition|  
|----------|----------------|  
|`collectionName`|A `string` value that contains the name of the collection to be removed.|  
  
## Return Value  
 This method does not return a value.  
  
## Example  
 The following example clears the default documents, including all inherited default documents, for the default Web site. The code will cause the following XML to be added to the `<system.webServer>` section of the Web.config file for the default Web site:  
  
 `<defaultDocument>`  
  
 `<files>`  
  
 `<clear />`  
  
 `</files>`  
  
 `</defaultDocument>`  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the default Web site.  
Set oSite= oWebAdmin.Get("Site.Name='Default Web Site'")  
  
' Get the default documents section.  
oSite.GetSection "DefaultDocumentSection", oDefaultDocumentSection  
  
' Clear the default documents that are listed in the  
' DefaultDocumentSection.Files.Files property.  
oDefaultDocumentSection.Clear("Files.Files")  
  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [DefaultDocumentSection Class](../wmi-provider/defaultdocumentsection-class.md)   
 [FileSettings Class](../wmi-provider/filesettings-class.md)
