---
title: "AuthorizationRule Class"
ms.date: "10/07/2016"
ms.assetid: f334ec89-73af-4b83-5c45-0fc379b053fe
---
# AuthorizationRule Class

Represents a rule in the authorization section of a configuration file.  
  
## Syntax  
  
```vbs  
class AuthorizationRule : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `AuthorizationRule` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AccessType`|A read/write `sint32` enumeration that specifies whether access to a URL resource is granted based on the combination of values specified by the `Roles`, `Users`, and `Verbs` properties. The possible values are listed later in the Remarks section. **Note:**  At run time, the authorization module iterates through `AuthorizationRule` elements until it finds the first rule that fits a particular user. It then grants or denies access to a URL resource depending on the value of the `AccessType` property.|  
|`Roles`|A required unique read/write `string` value that contains a comma-delimited list of roles for which access to a URL resource is granted or denied. A key property. **Note:**  There must be at least one value in either the `Users` property or the `Roles` property, or both.|  
|`Users`|A required unique read/write `string` value that contains a comma-delimited list of users for whom access to a URL resource is granted or denied. The default is "\*". A key property. **Note:**  There must be at least one value in either the `Users` property or the `Roles` property, or both.|  
|`Verbs`|A required unique read/write `string` value that contains a comma-delimited list of HTTP transmission methods for which access to a URL resource is granted or denied. A key property.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are contained in the `Authorization` property of the [AuthorizationSection](../wmi-provider/authorizationsection-class.md) class.  
  
 The following table lists the possible values for the `AccessType` property.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`Allow`|Grants access to a URL resource for the combination of values you specify in the `Roles`, `Users`, and `Verbs` properties.|  
|1|`Deny`|Denies access to a URL resource for the combination of values you specify in the `Roles`, `Users`, and `Verbs` properties.|  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `AuthorizationRule`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [System.Web.Configuration.AuthorizationRule](/dotnet/api/system.web.configuration.authorizationrule)
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)
