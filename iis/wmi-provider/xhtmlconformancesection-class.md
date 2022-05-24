---
title: "XhtmlConformanceSection Class"
description: Specifies the XHTML rendering mode for applications.
ms.date: "10/07/2016"
ms.assetid: 05f20508-da93-46f6-3d93-a08cf6aa7b92
---
# XhtmlConformanceSection Class
Specifies the XHTML rendering mode for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications.  
  
## Syntax  
  
```vbs  
class XhtmlConformanceSection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `XhtmlConformanceSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `XhtmlConformanceSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Mode`|A read/write `sint32` value that specifies the XHTML rendering mode for [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] applications. The possible values are listed later in the Remarks section.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 By default, when you are working with browsers that support HTML 4.0 or later, [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] pages and controls render markup that is compatible with the XHTML 1.0 Transitional standard. However, under some circumstances, you might not want [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] to render XHTML markup. This is typically true when you have existing pages that rely on tags or attributes that would ordinarily be prohibited by XHTML.  
  
 The following table lists the possible values for the `Mode` property. The default is 0 (`Transitional`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Transitional`|XHTML markup is rendered as conforming to the XHTML 1.0 Transitional standard.|  
|1|`Legacy`|Reverts to their old behavior a number of rendering changes that are likely to break existing applications. There is no mechanism to revert all changes made to comply with the XHTML specification. **Note:**  Use this setting to maintain conformance with [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] 1.1 rendering.|  
|2|`Strict`|Specifies strict conformance with the XHTML 1.0 standard. The key change that occurs is that the name attribute is no longer rendered on the form tag.|  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 `XhtmlConformanceSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class.md)   
 [xhtmlConformance Element (ASP.NET Settings Schema)](https://go.microsoft.com/fwlink/?LinkId=67196)
