---
title: DeploymentSkipDirectiveCollection.Add Method (DeploymentSkipDirective) (Microsoft.Web.Deployment)
TOCTitle: Add Method (DeploymentSkipDirective)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Add(Microsoft.Web.Deployment.DeploymentSkipDirective)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection.add(v=VS.90)
ms:contentKeyID: 20208969
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method (DeploymentSkipDirective)

Adds the specified [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) instance to the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    itemAsDeploymentSkipDirective _
)
'Usage
DiminstanceAsDeploymentSkipDirectiveCollectionDimitemAsDeploymentSkipDirective

instance.Add(item)
```

``` csharp
publicvoidAdd(
    DeploymentSkipDirectiveitem
)
```

``` c++
public:
virtualvoidAdd(
    DeploymentSkipDirective^ item
) sealed
```

``` jscript
publicfinalfunctionAdd(
    item : DeploymentSkipDirective
)
```

#### Parameters

  - item  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md)  

#### Implements

[ICollection\< (Of \< ( \<'T\> ) \> ) \>. . :: . .Add(T)](https://msdn.microsoft.com/en-us/library/63ywd54z\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveCollection Class](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)

[Add Overload](deploymentskipdirectivecollection-add-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

