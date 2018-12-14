---
title: DeploymentSkipDirectiveCollection.CopyTo Method  (Microsoft.Web.Deployment)
TOCTitle: CopyTo Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.CopyTo(Microsoft.Web.Deployment.DeploymentSkipDirective[],System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection.copyto(v=VS.90)
ms:contentKeyID: 20208872
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.CopyTo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.CopyTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CopyTo Method

Copies the skip directives from the current collection into the specified array, starting at the specified index.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubCopyTo ( _
    arrayAsDeploymentSkipDirective(), _
    arrayIndexAsInteger _
)
'Usage
DiminstanceAsDeploymentSkipDirectiveCollectionDimarrayAsDeploymentSkipDirective()
DimarrayIndexAsInteger

instance.CopyTo(array, arrayIndex)
```

``` csharp
publicvoidCopyTo(
    DeploymentSkipDirective[] array,
    intarrayIndex
)
```

``` c++
public:
virtualvoidCopyTo(
    array<DeploymentSkipDirective^>^ array, 
    intarrayIndex
) sealed
```

``` jscript
publicfinalfunctionCopyTo(
    array : DeploymentSkipDirective[], 
    arrayIndex : int
)
```

#### Parameters

  - array  
    Type: array\<[Microsoft.Web.Deployment. . :: . .DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md)\> \[\] () \[\] \[\]  

<!-- end list -->

  - arrayIndex  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

#### Implements

[ICollection\< (Of \< ( \<'T\> ) \> ) \>. . :: . .CopyTo(array\<T\> \[\] () \[\] \[\], Int32)](https://msdn.microsoft.com/en-us/library/0efx51xw\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveCollection Class](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

