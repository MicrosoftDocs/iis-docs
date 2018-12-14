---
title: DeploymentObjectResolver.GetStreamRelativeFilePath Method  (Microsoft.Web.Deployment)
TOCTitle: GetStreamRelativeFilePath Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectResolver.GetStreamRelativeFilePath(Microsoft.Web.Deployment.DeploymentObject)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectresolver.getstreamrelativefilepath(v=VS.90)
ms:contentKeyID: 20209076
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetStreamRelativeFilePath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetStreamRelativeFilePath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetStreamRelativeFilePath Method

Gets the file path relative to the stream for a given [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetStreamRelativeFilePath ( _
    deploymentObjectAsDeploymentObject _
) AsString
'Usage
DiminstanceAsDeploymentObjectResolverDimdeploymentObjectAsDeploymentObjectDimreturnValueAsStringreturnValue = instance.GetStreamRelativeFilePath(deploymentObject)
```

``` csharp
publicvirtualstringGetStreamRelativeFilePath(
    DeploymentObjectdeploymentObject
)
```

``` c++
public:
virtualString^ GetStreamRelativeFilePath(
    DeploymentObject^ deploymentObject
)
```

``` jscript
publicfunctionGetStreamRelativeFilePath(
    deploymentObject : DeploymentObject
) : String
```

#### Parameters

  - deploymentObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    A [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance to use to resolve the file path relative to the stream.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the file path.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectResolver Class](deploymentobjectresolver-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

