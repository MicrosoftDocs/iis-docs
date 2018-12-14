---
title: DeploymentSkipDirectiveCollection.IsReadOnly Property  (Microsoft.Web.Deployment)
TOCTitle: IsReadOnly Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.IsReadOnly
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection.isreadonly(v=VS.90)
ms:contentKeyID: 20209071
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.IsReadOnly
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.get_IsReadOnly
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.get_IsReadOnly
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.IsReadOnly
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsReadOnly Property

Gets a value indicating whether the collection is read-only.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyIsReadOnlyAsBoolean
'Usage
DiminstanceAsDeploymentSkipDirectiveCollectionDimvalueAsBooleanvalue = instance.IsReadOnly
```

``` csharp
publicboolIsReadOnly { get; }
```

``` c++
public:
virtualpropertyboolIsReadOnly {
    boolget () sealed;
}
```

``` jscript
finalfunction getIsReadOnly () : boolean
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the collection is read-only, otherwise false.  

#### Implements

[ICollection\< (Of \< ( \<'T\> ) \> ) \>. . :: . .IsReadOnly](https://msdn.microsoft.com/en-us/library/0cfatk9t\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveCollection Class](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

