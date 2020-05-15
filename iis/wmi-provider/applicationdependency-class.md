---
title: "ApplicationDependency Class"
ms.date: "10/07/2016"
ms.assetid: a2b235cd-4d10-8d8a-648c-311f6c9465d4
---
# ApplicationDependency Class

Represents a dependency between a Web application and one or more Web service extensions.  
  
## Syntax  
  
```vbs  
class ApplicationDependency : CollectionElement  
```  
  
## Methods  

 This class contains no methods.  
  
## Properties  

 The following table lists the properties exposed by the `ApplicationDependency` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Application`|An array of [GroupDependency](../wmi-provider/groupdependency-class.md) values that contains the group IDs of Web service extensions on which the application specified in the `Name` property depends.|  
|`GroupId`|A read/write `string` value that contains the primary group ID of the application specified in the `Name` property. This property is used to link a dependency with an entry in the `<isapiCgiRestriction>` configuration section. **Note:**  By default, [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] supports the group IDs "ASP" and "ASP.NET".|  
|`Name`|A read-only `string` value that specifies the friendly name of an application that depends on the Web service extensions specified in the `GroupDependency` property. The key property.|  
  
## Subclasses  

 This class contains no subclasses.  
  
## Remarks  

 Instances of this class are exposed as members of the `ApplicationDependencies` property on the [ApplicationDependenciesSection](../wmi-provider/applicationdependenciessection-class.md) class.  
  
> [!NOTE]
>  In IIS 6.0, Web service extension settings were serverwide. In [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)], you can configure these settings at a global or application pool level.  
  
## Inheritance Hierarchy  

 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ApplicationDependency`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [ApplicationDependenciesSection Class](../wmi-provider/applicationdependenciessection-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [GroupDependency Class](../wmi-provider/groupdependency-class.md)   
 [IsapiCgiRestrictionElement Class](../wmi-provider/isapicgirestrictionelement-class.md)   
 [IsapiCgiRestrictionSection Class](../wmi-provider/isapicgirestrictionsection-class.md)
