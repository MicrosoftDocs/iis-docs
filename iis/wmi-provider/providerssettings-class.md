---
title: "ProvidersSettings Class | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b333c163-5099-493a-b4ac-da50c029fd55
caps.latest.revision: 10
author: "shirhatti"
manager: "wpickett"
---
# ProvidersSettings Class
Specifies managed providers that manage membership or roles for an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application, or encrypt and decrypt configuration data.  
  
## Syntax  
  
```vbs  
class ProvidersSettings : EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ProvidersSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Providers`|An array of [NameTypeElement](../wmi-provider/nametypeelement-class.md) values that specify managed providers.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Providers` array property on the following classes:  
  
-   [ConfigProtectedDataSection](../wmi-provider/configprotecteddatasection-class.md)  
  
-   [MembershipSection](../wmi-provider/membershipsection-class.md)  
  
-   [RoleManagerSection](../wmi-provider/rolemanagersection-class.md)  
  
> [!NOTE]
>  Do not confuse this class with the ASP.NET-related [ProviderSettings](../wmi-provider/providersettings-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class1.md)  
  
 `ProvidersSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigProtectedDataSection Class](../wmi-provider/configprotecteddatasection-class.md)   
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class1.md)   
 [MembershipSection Class](../wmi-provider/membershipsection-class.md)   
 [NameTypeElement Class](../wmi-provider/nametypeelement-class.md)   
 [RoleManagerSection Class](../wmi-provider/rolemanagersection-class.md)