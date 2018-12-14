---
title: DeploymentSyncOptions.DeclaredParameters Property  (Microsoft.Web.Deployment)
TOCTitle: DeclaredParameters Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncOptions.DeclaredParameters
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncoptions.declaredparameters(v=VS.90)
ms:contentKeyID: 20209031
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncOptions.DeclaredParameters
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_DeclaredParameters
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncOptions.DeclaredParameters
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_DeclaredParameters
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeclaredParameters Property

A collection of [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) objects associated with the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDeclaredParametersAsDeploymentSyncParameterCollection
'Usage
DiminstanceAsDeploymentSyncOptionsDimvalueAsDeploymentSyncParameterCollectionvalue = instance.DeclaredParameters
```

``` csharp
publicDeploymentSyncParameterCollectionDeclaredParameters { get; }
```

``` c++
public:
propertyDeploymentSyncParameterCollection^ DeclaredParameters {
    DeploymentSyncParameterCollection^ get ();
}
```

``` jscript
function getDeclaredParameters () : DeploymentSyncParameterCollection
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterCollection](deploymentsyncparametercollection-class-microsoft-web-deployment.md)  
A [DeploymentSyncParameterCollection](deploymentsyncparametercollection-class-microsoft-web-deployment.md) that contains [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) objects associated with the current object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncOptions Class](deploymentsyncoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

