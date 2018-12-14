---
title: DeploymentRuleHandler.Description Property  (Microsoft.Web.Deployment)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentRuleHandler.Description
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.description(v=VS.90)
ms:contentKeyID: 20208733
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Description
- Microsoft.Web.Deployment.DeploymentRuleHandler.get_Description
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Description
- Microsoft.Web.Deployment.DeploymentRuleHandler.get_Description
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Description Property

Gets the description of the [DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyDescriptionAsString
'Usage
DiminstanceAsDeploymentRuleHandlerDimvalueAsStringvalue = instance.Description
```

``` csharp
publicabstractstringDescription { get; }
```

``` c++
public:
virtualpropertyString^ Description {
    String^ get () abstract;
}
```

``` jscript
abstractfunction getDescription () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the description of the [DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md) object.  

#### Implements

[IDeploymentNameDescription. . :: . .Description](ideploymentnamedescription-description-property-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

