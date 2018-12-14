---
title: "IdentitySection Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8b530f31-4cb9-0def-a2d7-b21228f0a35c
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IdentitySection Class
Specifies whether an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application should run as the application pool identity (the default), the IIS-authenticated user identity, or a custom configured identity.  
  
## Syntax  
  
```vbs  
class IdentitySection : ConfigurationSection  
```  
  
## Methods  
 The following table lists the methods exposed by the `IdentitySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class1.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `IdentitySection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Impersonate`|A required read/write `boolean` value. `true` if client impersonation is used on each request; otherwise, `false`. The default is `false`.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Password`|An optional read/write `string` value that specifies the password for a Web application if the `Impersonate` property is set to `true`. For more information, see the Remarks section.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
|`UserName`|An optional read/write `string` value that specifies the user name for a Web application if the `Impersonate` property is set to `true`. For more information, see the Remarks section.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 The `Password` and `UserName` properties are stored in clear text in the configuration file. Although IIS does not transmit .config files in response to a user agent request, users who have proper credentials on the domain that contains the server can read .config files. For information about storing the `UserName` and `Password` values in encrypted form in the registry, see [identity Element (ASP.NET Settings Schema)](http://go.microsoft.com/fwlink/?LinkId=67195).  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class1.md)  
  
 `IdentitySection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSection Class](../wmi-provider/configurationsection-class1.md)   
 [identity Element (ASP.NET Settings Schema)](http://go.microsoft.com/fwlink/?LinkId=67195)