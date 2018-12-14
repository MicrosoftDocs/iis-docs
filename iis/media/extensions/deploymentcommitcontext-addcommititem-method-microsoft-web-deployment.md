---
title: DeploymentCommitContext.AddCommitItem Method  (Microsoft.Web.Deployment)
TOCTitle: AddCommitItem Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentCommitContext.AddCommitItem(Microsoft.Web.Deployment.IDeploymentCommitItem)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentcommitcontext.addcommititem(v=VS.90)
ms:contentKeyID: 20208876
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentCommitContext.AddCommitItem
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentCommitContext.AddCommitItem
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AddCommitItem Method

Adds a new commit item to the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAddCommitItem ( _
    commitItemAsIDeploymentCommitItem _
)
'Usage
DiminstanceAsDeploymentCommitContextDimcommitItemAsIDeploymentCommitItem

instance.AddCommitItem(commitItem)
```

``` csharp
publicvoidAddCommitItem(
    IDeploymentCommitItemcommitItem
)
```

``` c++
public:
voidAddCommitItem(
    IDeploymentCommitItem^ commitItem
)
```

``` jscript
publicfunctionAddCommitItem(
    commitItem : IDeploymentCommitItem
)
```

#### Parameters

  - commitItem  
    Type: [Microsoft.Web.Deployment. . :: . .IDeploymentCommitItem](ideploymentcommititem-interface-microsoft-web-deployment.md)  
    The item to add to the collection.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentCommitContext Class](deploymentcommitcontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

