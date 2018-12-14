---
title: DeploymentObjectResolver.GetSummary Method  (Microsoft.Web.Deployment)
TOCTitle: GetSummary Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectResolver.GetSummary(Microsoft.Web.Deployment.DeploymentObject)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectresolver.getsummary(v=VS.90)
ms:contentKeyID: 20208691
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetSummary
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetSummary
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetSummary Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetSummary ( _
    deploymentObjectAsDeploymentObject _
) AsString
'Usage
DiminstanceAsDeploymentObjectResolverDimdeploymentObjectAsDeploymentObjectDimreturnValueAsStringreturnValue = instance.GetSummary(deploymentObject)
```

``` csharp
publicvirtualstringGetSummary(
    DeploymentObjectdeploymentObject
)
```

``` c++
public:
virtualString^ GetSummary(
    DeploymentObject^ deploymentObject
)
```

``` jscript
publicfunctionGetSummary(
    deploymentObject : DeploymentObject
) : String
```

#### Parameters

  - deploymentObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectResolver Class](deploymentobjectresolver-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

