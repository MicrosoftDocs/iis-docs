---
title: "CustomErrorsSection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e5dc46f2-d3ae-7978-93ba-9ee594b54e70
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# CustomErrorsSection Class
Configures [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] custom error messages.  
  
## Syntax  
  
```vbs  
class CustomErrorsSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `CustomErrorsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class1.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `CustomErrorsSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`CustomErrors`|An array of [CustomError](../wmi-provider/customerror-class.md) values that specify [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] custom errors.|  
|`DefaultRedirect`|A required, nonempty read/write `string` value that contains the default path of either an HTTP error message file or the URL of an error message. This value is inherited by the `Redirect` property of newly created [CustomError](../wmi-provider/customerror-class.md) objects.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Mode`|A read/write `sint32` enumeration that specifies whether custom or default error pages are shown locally or remotely. The possible values are listed later in the Remarks section.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The custom errors represented by the `CustomErrorsSection` class are specific to [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] and are in the `<system.web>` section of the Web.config file. Each of these errors is represented by an instance of the [CustomError](../wmi-provider/customerror-class.md) class.  
  
 The custom errors represented by the [HttpErrorsSection](../wmi-provider/httperrorssection-class.md) class are related to [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] and are in the `<system.webServer>` section of the ApplicationHost.config file. Each of these errors is represented by an instance of the [HttpErrorElement](../wmi-provider/httperrorelement-class.md) class. The integration of [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] with IIS in [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] made this name change necessary.  
  
 The following table lists the possible values for the `Mode` property. The default is 0 (`RemoteOnly`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`RemoteOnly`|The default [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] error page is shown to local users. Remote users will receive a custom error page if one is defined. If no custom error page is defined for the error received, an IIS error page is shown.|  
|1|`On`|A user-defined [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] custom error page is shown for both local and remote users.|  
|2|`Off`|The default [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] error page is shown for both local and remote users.|  
  
## Example  
 The following example sets the `DefaultRedirect` property to "CustomError.htm" and the `Mode` property to `On`.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the custom errors section for the default Web site.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "CustomErrorsSection", oSection  
  
' Set the default redirect page to CustomError.htm,  
' and set the Mode property to On.  
oSection.DefaultRedirect = "CustomError.htm"  
oSection.Mode = 1  
oSection.Put_  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class1.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `CustomErrorsSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [CustomError Class](../wmi-provider/customerror-class.md)   
 [HttpErrorElement Class](../wmi-provider/httperrorelement-class.md)   
 [HttpErrorsSection Class](../wmi-provider/httperrorssection-class.md)