---
title: DeploymentRule.RuleHandler Property  (Microsoft.Web.Deployment)
TOCTitle: RuleHandler Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentRule.RuleHandler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrule.rulehandler(v=VS.90)
ms:contentKeyID: 20208842
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRule.RuleHandler
- Microsoft.Web.Deployment.DeploymentRule.get_RuleHandler
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRule.get_RuleHandler
- Microsoft.Web.Deployment.DeploymentRule.RuleHandler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RuleHandler Property

Gets the [DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md) for the current deployment rule.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRuleHandlerAsDeploymentRuleHandler
'Usage
DiminstanceAsDeploymentRuleDimvalueAsDeploymentRuleHandlervalue = instance.RuleHandler
```

``` csharp
publicDeploymentRuleHandlerRuleHandler { get; }
```

``` c++
public:
propertyDeploymentRuleHandler^ RuleHandler {
    DeploymentRuleHandler^ get ();
}
```

``` jscript
function getRuleHandler () : DeploymentRuleHandler
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md)  
An instance of a [DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRule Class](deploymentrule-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

