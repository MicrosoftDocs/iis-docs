---
title: DeploymentObjectAttribute.GetHashCode Method  (Microsoft.Web.Deployment)
TOCTitle: GetHashCode Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttribute.GetHashCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute.gethashcode(v=VS.90)
ms:contentKeyID: 22754000
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.GetHashCode
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.GetHashCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetHashCode Method

Returns the hash code for this [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionGetHashCodeAsInteger
'Usage
DiminstanceAsDeploymentObjectAttributeDimreturnValueAsIntegerreturnValue = instance.GetHashCode()
```

``` csharp
publicoverrideintGetHashCode()
```

``` c++
public:
virtualintGetHashCode() override
```

``` jscript
publicoverridefunctionGetHashCode() : int
```

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
A 32-bit signed integer hash code.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttribute Class](deploymentobjectattribute-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

