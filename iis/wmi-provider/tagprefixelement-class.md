---
title: "TagPrefixElement Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 194e106d-b30e-473b-92da-3aeccdfedd07
caps.latest.revision: 8
author: "shirhatti"
manager: "wpickett"
---
# TagPrefixElement Class
Contains configuration information for a custom or user control.  
  
## Syntax  
  
```vbs  
class TagPrefixElement : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `TagPrefixElement` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Assembly`|A read-only `string` value that specifies the name of the assembly in which a custom control implementation resides. This property applies only to custom controls and is not required if the control is in the application code directory. A key property.|  
|`Namespace`|A read-only `string` value that specifies the namespace in which the custom control resides. This property applies only to custom controls. A key property.|  
|`Src`|A read/write `string` value that specifies the name and path of the file that contains the implementation of a user control. This property applies only to user controls. The path may be relative to the application or the application root.|  
|`TagName`|A read-only `string` value that specifies the name of a user control. This property applies only to user controls. This is the value follows the tag prefix in the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] code (for example, "myControl" in \<myTag: myControl />). A key property.|  
|`TagPrefix`|A read-only `string` value that specifies the tag prefix that is associated with a source file (or namespace and assembly) where the control resides. This property applies to both user and custom controls. This is the value that precedes the tag name in the [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] code (for example, "myTag" in \<myTag: myControl />). The default is "/". A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class correspond to Register directives of the form `(<%@ Register %>)` on an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] page and enable you to specify tag prefixes for user controls.  
  
 Instances of this class are contained in the `Controls` array property of the [TagPrefixInfo](../wmi-provider/tagprefixinfo-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `TagPrefixElement`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [PagesSection Class](../wmi-provider/pagessection-class.md)   
 [TagPrefixInfo Class](../wmi-provider/tagprefixinfo-class.md)