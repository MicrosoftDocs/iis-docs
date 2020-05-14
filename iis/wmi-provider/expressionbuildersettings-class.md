---
title: "ExpressionBuilderSettings Class"
ms.date: "10/07/2016"
ms.assetid: 706dd237-4fa5-433c-8e21-5c929bdf1136
---
# ExpressionBuilderSettings Class
Contains resource strings that associate prefixes with expression builder types during compilation.  
  
## Syntax  
  
```vbs  
class ExpressionBuilderSettings: EmbeddedObject  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ExpressionBuilderSettings` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ExpressionBuilders`|An array of [ExpressionBuilder](../wmi-provider/expressionbuilder-class.md) values that associate prefixes with expression builder types.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ExpressionBuilders` array property of the [CompilationSection](../wmi-provider/compilationsection-class.md) class.  
  
## Inheritance Hierarchy  
 [EmbeddedObject](../wmi-provider/embeddedobject-class.md)  
  
 `ExpressionBuilderSettings`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [System.Web.Compilation.ExpressionPrefixAttribute](/dotnet/api/system.web.compilation.expressionprefixattribute)  
 [System.Web.Configuration.CompilationSection.ExpressionBuilders](/dotnet/api/system.web.configuration.compilationsection.expressionbuilders)
 [CompilationSection Class](../wmi-provider/compilationsection-class.md)
 [EmbeddedObject Class](../wmi-provider/embeddedobject-class.md)
 [ExpressionBuilder Class](../wmi-provider/expressionbuilder-class.md)
