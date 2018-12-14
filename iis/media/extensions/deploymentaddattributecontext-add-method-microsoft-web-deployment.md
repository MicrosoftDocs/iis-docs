---
title: DeploymentAddAttributeContext.Add Method  (Microsoft.Web.Deployment)
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAddAttributeContext.Add(Microsoft.Web.Deployment.DeploymentObjectAttributeData)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentaddattributecontext.add(v=VS.90)
ms:contentKeyID: 22753862
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAddAttributeContext.Add
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAddAttributeContext.Add
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Add Method

Adds a deployment attribute data object to the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAdd ( _
    attributeAsDeploymentObjectAttributeData _
)
'Usage
DiminstanceAsDeploymentAddAttributeContextDimattributeAsDeploymentObjectAttributeData

instance.Add(attribute)
```

``` csharp
publicvoidAdd(
    DeploymentObjectAttributeDataattribute
)
```

``` c++
public:
voidAdd(
    DeploymentObjectAttributeData^ attribute
)
```

``` jscript
publicfunctionAdd(
    attribute : DeploymentObjectAttributeData
)
```

#### Parameters

  - attribute  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md)  
    The [DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md) object to add to the current object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAddAttributeContext Class](deploymentaddattributecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

