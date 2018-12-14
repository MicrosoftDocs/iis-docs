---
title: DeploymentObjectAttribute.CompareTo Method  (Microsoft.Web.Deployment)
TOCTitle: CompareTo Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttribute.CompareTo(Microsoft.Web.Deployment.DeploymentObjectAttribute)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute.compareto(v=VS.90)
ms:contentKeyID: 22753933
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.CompareTo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.CompareTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CompareTo Method

Compares a [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) against the current [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) instance to determine if they are equal.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCompareTo ( _
    otherAsDeploymentObjectAttribute _
) AsInteger
'Usage
DiminstanceAsDeploymentObjectAttributeDimotherAsDeploymentObjectAttributeDimreturnValueAsIntegerreturnValue = instance.CompareTo(other)
```

``` csharp
publicintCompareTo(
    DeploymentObjectAttributeother
)
```

``` c++
public:
virtualintCompareTo(
    DeploymentObjectAttribute^ other
) sealed
```

``` jscript
publicfinalfunctionCompareTo(
    other : DeploymentObjectAttribute
) : int
```

#### Parameters

  - other  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  
    A [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) instance to compare against the current instance.  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
An integer value that contains BUGBUG.  

#### Implements

[IComparable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .CompareTo(T)](https://msdn.microsoft.com/en-us/library/43hc6wht\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttribute Class](deploymentobjectattribute-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

