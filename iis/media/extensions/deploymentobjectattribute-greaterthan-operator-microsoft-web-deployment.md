---
title: DeploymentObjectAttribute.GreaterThan Operator  (Microsoft.Web.Deployment)
TOCTitle: GreaterThan Operator
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttribute.op_GreaterThan(Microsoft.Web.Deployment.DeploymentObjectAttribute,Microsoft.Web.Deployment.DeploymentObjectAttribute)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute.op_greaterthan(v=VS.90)
ms:contentKeyID: 22753917
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.GreaterThan
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.GreaterThan
- Microsoft.Web.Deployment.DeploymentObjectAttribute.op_GreaterThan
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GreaterThan Operator

Indicates whether a specified [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md) is greater than another specified [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedOperator> ( _
    attribute1AsDeploymentObjectAttribute, _
    attribute2AsDeploymentObjectAttribute _
) AsBoolean
'Usage
Dimattribute1AsDeploymentObjectAttributeDimattribute2AsDeploymentObjectAttributeDimreturnValueAsBooleanreturnValue = (attribute1>attribute2)
```

``` csharp
publicstaticbooloperator>(
    DeploymentObjectAttributeattribute1,
    DeploymentObjectAttributeattribute2
)
```

``` c++
public:
staticbooloperator>(
    DeploymentObjectAttribute^ attribute1, 
    DeploymentObjectAttribute^ attribute2
)
```

``` jscript
JScript does not support overloaded operators.
```

#### Parameters

  - attribute1  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  
    A [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md).  

<!-- end list -->

  - attribute2  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  
    A [DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md).  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if attribute1 is greater than attribute2; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttribute Class](deploymentobjectattribute-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

