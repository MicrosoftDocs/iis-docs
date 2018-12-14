---
title: DeploymentBaseContext.CommitContext Property  (Microsoft.Web.Deployment)
TOCTitle: CommitContext Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.CommitContext
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.commitcontext(v=VS.90)
ms:contentKeyID: 20208843
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.CommitContext
- Microsoft.Web.Deployment.DeploymentBaseContext.get_CommitContext
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.CommitContext
- Microsoft.Web.Deployment.DeploymentBaseContext.get_CommitContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CommitContext Property

Gets the context of a deployment commit operation.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCommitContextAsDeploymentCommitContext
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsDeploymentCommitContextvalue = instance.CommitContext
```

``` csharp
publicDeploymentCommitContextCommitContext { get; }
```

``` c++
public:
propertyDeploymentCommitContext^ CommitContext {
    DeploymentCommitContext^ get ();
}
```

``` jscript
function getCommitContext () : DeploymentCommitContext
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentCommitContext](deploymentcommitcontext-class-microsoft-web-deployment.md)  
A [DeploymentCommitContext](deploymentcommitcontext-class-microsoft-web-deployment.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

