---
title: DeploymentBaseOptions.SkipDirectives Property  (Microsoft.Web.Deployment)
TOCTitle: SkipDirectives Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.SkipDirectives
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.skipdirectives(v=VS.90)
ms:contentKeyID: 20208717
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.SkipDirectives
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_SkipDirectives
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_SkipDirectives
- Microsoft.Web.Deployment.DeploymentBaseOptions.SkipDirectives
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SkipDirectives Property

Gets a collection of [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) objects.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySkipDirectivesAsDeploymentSkipDirectiveCollection
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsDeploymentSkipDirectiveCollectionvalue = instance.SkipDirectives
```

``` csharp
publicDeploymentSkipDirectiveCollectionSkipDirectives { get; }
```

``` c++
public:
propertyDeploymentSkipDirectiveCollection^ SkipDirectives {
    DeploymentSkipDirectiveCollection^ get ();
}
```

``` jscript
function getSkipDirectives () : DeploymentSkipDirectiveCollection
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSkipDirectiveCollection](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)  
A collection of [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

