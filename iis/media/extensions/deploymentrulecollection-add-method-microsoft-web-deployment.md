---
title: DeploymentRuleCollection.Add Method  (Microsoft.Web.Deployment)
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleCollection.Add(Microsoft.Web.Deployment.DeploymentRule)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulecollection.add(v=VS.90)
ms:contentKeyID: 20208680
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleCollection.Add
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleCollection.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method

Adds the specified [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) to the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    ruleAsDeploymentRule _
)
'Usage
DiminstanceAsDeploymentRuleCollectionDimruleAsDeploymentRule

instance.Add(rule)
```

``` csharp
publicvoidAdd(
    DeploymentRulerule
)
```

``` c++
public:
voidAdd(
    DeploymentRule^ rule
)
```

``` jscript
publicfunctionAdd(
    rule : DeploymentRule
)
```

#### Parameters

  - rule  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentRule](deploymentrule-class-microsoft-web-deployment.md)  
    The rule to add to the specified collection.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleCollection Class](deploymentrulecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

