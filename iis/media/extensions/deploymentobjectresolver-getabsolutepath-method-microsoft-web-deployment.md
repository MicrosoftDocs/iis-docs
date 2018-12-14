---
title: DeploymentObjectResolver.GetAbsolutePath Method  (Microsoft.Web.Deployment)
TOCTitle: GetAbsolutePath Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectResolver.GetAbsolutePath(Microsoft.Web.Deployment.DeploymentObject)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectresolver.getabsolutepath(v=VS.90)
ms:contentKeyID: 20208685
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetAbsolutePath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetAbsolutePath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetAbsolutePath Method

Gets the absolute path of a deployment object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetAbsolutePath ( _
    deploymentObjectAsDeploymentObject _
) AsString
'Usage
DiminstanceAsDeploymentObjectResolverDimdeploymentObjectAsDeploymentObjectDimreturnValueAsStringreturnValue = instance.GetAbsolutePath(deploymentObject)
```

``` csharp
publicvirtualstringGetAbsolutePath(
    DeploymentObjectdeploymentObject
)
```

``` c++
public:
virtualString^ GetAbsolutePath(
    DeploymentObject^ deploymentObject
)
```

``` jscript
publicfunctionGetAbsolutePath(
    deploymentObject : DeploymentObject
) : String
```

#### Parameters

  - deploymentObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    A [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance to use to resolve the absolute path..  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the absolute path for the supplied [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectResolver Class](deploymentobjectresolver-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

