---
title: DeploymentObjectProvider.GetAttributes Method  (Microsoft.Web.Deployment)
TOCTitle: GetAttributes Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectProvider.GetAttributes(Microsoft.Web.Deployment.DeploymentAddAttributeContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.getattributes(v=VS.90)
ms:contentKeyID: 20208885
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectProvider.GetAttributes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectProvider.GetAttributes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetAttributes Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubGetAttributes ( _
    addContextAsDeploymentAddAttributeContext _
)
'Usage
DiminstanceAsDeploymentObjectProviderDimaddContextAsDeploymentAddAttributeContext

instance.GetAttributes(addContext)
```

``` csharp
publicvirtualvoidGetAttributes(
    DeploymentAddAttributeContextaddContext
)
```

``` c++
public:
virtualvoidGetAttributes(
    DeploymentAddAttributeContext^ addContext
)
```

``` jscript
publicfunctionGetAttributes(
    addContext : DeploymentAddAttributeContext
)
```

#### Parameters

  - addContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentAddAttributeContext](deploymentaddattributecontext-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

