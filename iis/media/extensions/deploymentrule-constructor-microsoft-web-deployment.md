---
title: DeploymentRule Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentRule Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRule.#ctor(System.String,Microsoft.Web.Deployment.DeploymentRuleHandler)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrule.deploymentrule(v=VS.90)
ms:contentKeyID: 20208702
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRule.DeploymentRule
- Microsoft.Web.Deployment.DeploymentRule.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRule..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentRule Constructor

Initializes a new instance of a deployment rule with the specified name and rule handler.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    handlerAsDeploymentRuleHandler _
)
'Usage
DimnameAsStringDimhandlerAsDeploymentRuleHandlerDiminstanceAs NewDeploymentRule(name, handler)
```

``` csharp
publicDeploymentRule(
    stringname,
    DeploymentRuleHandlerhandler
)
```

``` c++
public:
DeploymentRule(
    String^ name, 
    DeploymentRuleHandler^ handler
)
```

``` jscript
publicfunctionDeploymentRule(
    name : String, 
    handler : DeploymentRuleHandler
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name for the deployment rule.  

<!-- end list -->

  - handler  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md)  
    The deployment rule handler.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRule Class](deploymentrule-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

