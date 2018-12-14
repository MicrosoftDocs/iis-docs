---
title: DeploymentObjectAttributeValue.GreaterThan Operator  (Microsoft.Web.Deployment)
TOCTitle: GreaterThan Operator
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeValue.op_GreaterThan(Microsoft.Web.Deployment.DeploymentObjectAttributeValue,Microsoft.Web.Deployment.DeploymentObjectAttributeValue)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributevalue.op_greaterthan(v=VS.90)
ms:contentKeyID: 22754028
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.GreaterThan
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.GreaterThan
- Microsoft.Web.Deployment.DeploymentObjectAttributeValue.op_GreaterThan
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GreaterThan Operator

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedOperator> ( _
    attribute1AsDeploymentObjectAttributeValue, _
    attribute2AsDeploymentObjectAttributeValue _
) AsBoolean
'Usage
Dimattribute1AsDeploymentObjectAttributeValueDimattribute2AsDeploymentObjectAttributeValueDimreturnValueAsBooleanreturnValue = (attribute1>attribute2)
```

``` csharp
publicstaticbooloperator>(
    DeploymentObjectAttributeValueattribute1,
    DeploymentObjectAttributeValueattribute2
)
```

``` c++
public:
staticbooloperator>(
    DeploymentObjectAttributeValue^ attribute1, 
    DeploymentObjectAttributeValue^ attribute2
)
```

``` jscript
JScript does not support overloaded operators.
```

#### Parameters

  - attribute1  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md)  

<!-- end list -->

  - attribute2  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeValue](deploymentobjectattributevalue-class-microsoft-web-deployment.md)  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
Returns [Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeValue Class](deploymentobjectattributevalue-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

