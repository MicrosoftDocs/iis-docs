---
title: "CustomError Class"
description: Specifies an custom error message for an HTTP status code error.  
ms.date: "10/07/2016"
ms.assetid: ab3c0555-268b-4148-bdcf-622be2a4c4f7
---
# CustomError Class
Specifies an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] custom error message for an HTTP status code error.  
  
## Syntax  
  
```vbs  
class CustomError : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `CustomError` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Redirect`|A required nonempty read/write `string` value that contains the path of a file or URL that contains a custom error message.|  
|`StatusCode`|A required unique read/write `sint32` value that specifies an HTTP error status code. Valid values are from 100 through 999. The key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `CustomErrors` property of the [CustomErrorsSection](../wmi-provider/customerrorssection-class.md) class.  
  
 The custom errors represented by the `CustomError` class are specific to [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and are in the `<system.web>` section of the Web.config file. The custom errors represented by the [HttpErrorElement](../wmi-provider/httperrorelement-class.md) class are specific to [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] and are in the `<system.webServer>` section of the ApplicationHost.config file.  
  
## Example  
 The following example adds a custom error to the custom errors section of the default Web site.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the CustomError class object.  
Set oCustomError = oWebAdmin.Get("CustomError")  
  
' Create a new instance of the CustomError class.  
Set oNewCustomError = oCustomError.SpawnInstance_  
  
' Assign values to the StatusCode and Redirect properties.  
oNewCustomError.StatusCode = 404  
oNewCustomError.Redirect ="CustomPageNotFoundError.htm"  
  
' Get the custom errors section for the default Web site.   
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "CustomErrorsSection", oCustomErrorsSection  
  
' Call the CustomErrorsSection.Add method to add the custom error.  
oCustomErrorsSection.Add "CustomErrors", oNewCustomError  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `CustomError`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [CustomErrorsSection Class](../wmi-provider/customerrorssection-class.md)   
 [HttpErrorElement Class](../wmi-provider/httperrorelement-class.md)   
 [HttpErrorsSection Class](../wmi-provider/httperrorssection-class.md)
