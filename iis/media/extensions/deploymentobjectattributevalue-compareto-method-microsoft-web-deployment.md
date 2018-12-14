---
title: DeploymentObjectAttributeValue.CompareTo Method  (Microsoft.Web.Deployment)
TOCTitle: CompareTo Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.CompareTo(Microsoft.Web.Deployment.DeploymentObjectAttributeValue)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributevalue.compareto(v=VS.90)
ms:contentKeyID: 22753871
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.CompareTo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.CompareTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CompareTo Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionCompareTo ( _
    otherAsDeploymentObjectAttributeValue _
) AsInteger
'Usage
DiminstanceAsDeploymentObjectAttributeValueDimotherAsDeploymentObjectAttributeValueDimreturnValueAsIntegerreturnValue = instance.CompareTo(other)
```

``` csharp
publicabstractintCompareTo(
    DeploymentObjectAttributeValueother
)
```

``` c++
public:
virtualintCompareTo(
    DeploymentObjectAttributeValue^ other
) abstract
```

``` jscript
publicabstractfunctionCompareTo(
    other : DeploymentObjectAttributeValue
) : int
```

#### Parameters

  - other  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md)  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
Returns [Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\)).  

#### Implements

[IComparable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .CompareTo(T)](https://msdn.microsoft.com/en-us/library/43hc6wht\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

