---
title: DeploymentObjectAttributeData.LessThan Operator  (Microsoft.Web.Deployment)
TOCTitle: LessThan Operator
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectAttributeData.op_LessThan(Microsoft.Web.Deployment.DeploymentObjectAttributeData,Microsoft.Web.Deployment.DeploymentObjectAttributeData)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattributedata.op_lessthan(v=VS.90)
ms:contentKeyID: 22753886
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.LessThan
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.LessThan
- Microsoft.Web.Deployment.DeploymentObjectAttributeData.op_LessThan
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LessThan Operator

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedOperator< ( _
    attribute1AsDeploymentObjectAttributeData, _
    attribute2AsDeploymentObjectAttributeData _
) AsBoolean
'Usage
Dimattribute1AsDeploymentObjectAttributeDataDimattribute2AsDeploymentObjectAttributeDataDimreturnValueAsBooleanreturnValue = (attribute1<attribute2)
```

``` csharp
publicstaticbooloperator<(
    DeploymentObjectAttributeDataattribute1,
    DeploymentObjectAttributeDataattribute2
)
```

``` c++
public:
staticbooloperator<(
    DeploymentObjectAttributeData^ attribute1, 
    DeploymentObjectAttributeData^ attribute2
)
```

``` jscript
JScript does not support overloaded operators.
```

#### Parameters

  - attribute1  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md)  

<!-- end list -->

  - attribute2  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md)  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
Returns [Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\)).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttributeData Class](deploymentobjectattributedata-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

