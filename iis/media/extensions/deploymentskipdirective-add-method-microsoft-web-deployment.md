---
title: DeploymentSkipDirective.Add Method  (Microsoft.Web.Deployment)
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirective.Add(Microsoft.Web.Deployment.DeploymentSkipDirectiveEntry)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective.add(v=VS.90)
ms:contentKeyID: 20209273
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirective.Add
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirective.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method

Adds a [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) to the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    entryAsDeploymentSkipDirectiveEntry _
)
'Usage
DiminstanceAsDeploymentSkipDirectiveDimentryAsDeploymentSkipDirectiveEntry

instance.Add(entry)
```

``` csharp
publicvoidAdd(
    DeploymentSkipDirectiveEntryentry
)
```

``` c++
public:
voidAdd(
    DeploymentSkipDirectiveEntry^ entry
)
```

``` jscript
publicfunctionAdd(
    entry : DeploymentSkipDirectiveEntry
)
```

#### Parameters

  - entry  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md)  
    A [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirective Class](deploymentskipdirective-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

