---
title: "GroupDependency Class"
description: The GroupDependency class represents a Web service extension upon which one or more Web applications depend.
ms.date: "10/07/2016"
ms.assetid: c02f56d9-441f-b303-142c-dd8c4508586d
---
# GroupDependency Class
Represents a Web service extension upon which one or more Web applications depend.  
  
## Syntax  
  
```vbs  
class GroupDependency : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `GroupDependency` class.  
  
|Name|Description|  
|----------|-----------------|  
|`GroupId`|A read-only `string` value that contains the group ID of a Web service extension upon which one or more Web applications depend. **Note:**  By default, [!INCLUDE[iisver](../wmi-provider/includes/iisver-md.md)] supports the group IDs "ASP" and "ASP.NET".|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Application` property of the [ApplicationDependency](../wmi-provider/applicationdependency-class.md) class.  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `GroupDependency`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ApplicationDependenciesSection Class](../wmi-provider/applicationdependenciessection-class.md)   
 [ApplicationDependency Class](../wmi-provider/applicationdependency-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [IsapiCgiRestrictionElement Class](../wmi-provider/isapicgirestrictionelement-class.md)   
 [IsapiCgiRestrictionSection Class](../wmi-provider/isapicgirestrictionsection-class.md)
