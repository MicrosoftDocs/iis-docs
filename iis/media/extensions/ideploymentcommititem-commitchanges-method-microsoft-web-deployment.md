---
title: IDeploymentCommitItem.CommitChanges Method  (Microsoft.Web.Deployment)
TOCTitle: CommitChanges Method
ms:assetid: M:Microsoft.Web.Deployment.IDeploymentCommitItem.CommitChanges(Microsoft.Web.Deployment.DeploymentCommitContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.ideploymentcommititem.commitchanges(v=VS.90)
ms:contentKeyID: 20209075
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.IDeploymentCommitItem.CommitChanges
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.IDeploymentCommitItem.CommitChanges
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CommitChanges Method

Commits changes that were made during a deployment action.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
SubCommitChanges ( _
    commitContextAsDeploymentCommitContext _
)
'Usage
DiminstanceAsIDeploymentCommitItemDimcommitContextAsDeploymentCommitContext

instance.CommitChanges(commitContext)
```

``` csharp
voidCommitChanges(
    DeploymentCommitContextcommitContext
)
```

``` c++
voidCommitChanges(
    DeploymentCommitContext^ commitContext
)
```

``` jscript
functionCommitChanges(
    commitContext : DeploymentCommitContext
)
```

#### Parameters

  - commitContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentCommitContext](deploymentcommitcontext-class-microsoft-web-deployment.md)  
    The [DeploymentCommitContext](deploymentcommitcontext-class-microsoft-web-deployment.md) used to commit changes.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[IDeploymentCommitItem Interface](ideploymentcommititem-interface-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

