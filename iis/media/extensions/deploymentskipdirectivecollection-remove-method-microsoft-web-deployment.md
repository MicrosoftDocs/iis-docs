---
title: DeploymentSkipDirectiveCollection.Remove Method  (Microsoft.Web.Deployment)
TOCTitle: Remove Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Remove(Microsoft.Web.Deployment.DeploymentSkipDirective)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection.remove(v=VS.90)
ms:contentKeyID: 20208888
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Remove
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.Remove
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Remove Method

Removes the specified skip directive from the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionRemove ( _
    itemAsDeploymentSkipDirective _
) AsBoolean
'Usage
DiminstanceAsDeploymentSkipDirectiveCollectionDimitemAsDeploymentSkipDirectiveDimreturnValueAsBooleanreturnValue = instance.Remove(item)
```

``` csharp
publicboolRemove(
    DeploymentSkipDirectiveitem
)
```

``` c++
public:
virtualboolRemove(
    DeploymentSkipDirective^ item
) sealed
```

``` jscript
publicfinalfunctionRemove(
    item : DeploymentSkipDirective
) : boolean
```

#### Parameters

  - item  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md)  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the skip directive was moved, otherwise false.  

#### Implements

[ICollection\< (Of \< ( \<'T\> ) \> ) \>. . :: . .Remove(T)](https://msdn.microsoft.com/en-us/library/bye7h94w\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveCollection Class](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

