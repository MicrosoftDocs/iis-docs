---
title: DeploymentSyncContext.Rules Property  (Microsoft.Web.Deployment)
TOCTitle: Rules Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncContext.Rules
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsynccontext.rules(v=VS.90)
ms:contentKeyID: 20209030
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncContext.Rules
- Microsoft.Web.Deployment.DeploymentSyncContext.get_Rules
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncContext.get_Rules
- Microsoft.Web.Deployment.DeploymentSyncContext.Rules
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Rules Property

Gets a collection of [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) objects associated with the current context.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRulesAsDeploymentRuleCollection
'Usage
DiminstanceAsDeploymentSyncContextDimvalueAsDeploymentRuleCollectionvalue = instance.Rules
```

``` csharp
publicDeploymentRuleCollectionRules { get; }
```

``` c++
public:
propertyDeploymentRuleCollection^ Rules {
    DeploymentRuleCollection^ get ();
}
```

``` jscript
function getRules () : DeploymentRuleCollection
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentRuleCollection](deploymentrulecollection-class-microsoft-web-deployment.md)  
A [DeploymentRuleCollection](deploymentrulecollection-class-microsoft-web-deployment.md) that contains [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) objects associated with the current context.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncContext Class](deploymentsynccontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

