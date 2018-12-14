---
title: DeploymentObjectProvider.CommitContext Property  (Microsoft.Web.Deployment)
TOCTitle: CommitContext Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectProvider.CommitContext
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.commitcontext(v=VS.90)
ms:contentKeyID: 20209283
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectProvider.CommitContext
- Microsoft.Web.Deployment.DeploymentObjectProvider.get_CommitContext
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectProvider.CommitContext
- Microsoft.Web.Deployment.DeploymentObjectProvider.get_CommitContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CommitContext Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCommitContextAsDeploymentCommitContext
'Usage
DiminstanceAsDeploymentObjectProviderDimvalueAsDeploymentCommitContextvalue = instance.CommitContext
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

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

