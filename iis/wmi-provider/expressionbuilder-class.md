---
title: "ExpressionBuilder Class"
ms.date: "10/07/2016"
ms.assetid: d5626c9b-c688-06c7-df5d-abe450a477a5
---
# ExpressionBuilder Class
Maps an expression prefix to an expression builder type.  
  
## Syntax  
  
```vbs  
class ExpressionBuilder : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `ExpressionBuilder` class.  
  
|Name|Description|  
|----------|-----------------|  
|`ExpressionPrefix`|A read-only `string` value that contains the prefix for the current expression builder object. The key property.|  
|`Type`|A read/write `string` value that contains a type associated with the prefix specified in the `ExpressionPrefix` property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `ExpressionBuilders` array property of the [ExpressionBuilderSettings](../wmi-provider/expressionbuildersettings-class.md) class.  
  
 Expression builders allow property values to be set and retrieved in a control during page parsing. When the page parser encounters an expression in the format `<%$ prefix:value %>`, it creates an expression builder based on `prefix` and passes the `value` to the expression builder for evaluation. The expression builder then returns the requested value to the page.  
  
 `ExpressionPrefix` values are associated with expression builders in the `<``expressionBuilders``>` section of a Web.config file, as the following example shows:  
  
 `<configuration>`  
  
 `<system.web>`  
  
 `<compilation>`  
  
 `<expressionBuilders>`  
  
 `<add expressionPrefix="TCO"`  
  
 `type="Contoso.Finance.TCOExpressionBuilder"/>`  
  
 `</expressionBuilders>`  
  
 `</compilation>`  
  
 `</system.web>`  
  
 `</configuration>`  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `ExpressionBuilder`  
  
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
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [CompilationSection Class](../wmi-provider/compilationsection-class.md)   
 [ExpressionBuilderSettings Class](../wmi-provider/expressionbuildersettings-class.md)