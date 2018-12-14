---
title: DeploymentManifestObjectProviderContext.CreateManifestObject Method  (Microsoft.Web.Deployment)
TOCTitle: CreateManifestObject Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManifestObjectProviderContext.CreateManifestObject(Microsoft.Web.Deployment.DeploymentProviderOptions)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobjectprovidercontext.createmanifestobject(v=VS.90)
ms:contentKeyID: 20209252
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObjectProviderContext.CreateManifestObject
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObjectProviderContext.CreateManifestObject
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateManifestObject Method

Creates a manifest object given the specified [DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCreateManifestObject ( _
    optionsAsDeploymentProviderOptions _
) AsDeploymentManifestObject
'Usage
DiminstanceAsDeploymentManifestObjectProviderContextDimoptionsAsDeploymentProviderOptionsDimreturnValueAsDeploymentManifestObjectreturnValue = instance.CreateManifestObject(options)
```

``` csharp
publicDeploymentManifestObjectCreateManifestObject(
    DeploymentProviderOptionsoptions
)
```

``` c++
public:
DeploymentManifestObject^ CreateManifestObject(
    DeploymentProviderOptions^ options
)
```

``` jscript
publicfunctionCreateManifestObject(
    options : DeploymentProviderOptions
) : DeploymentManifestObject
```

#### Parameters

  - options  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md)  
    The [DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md) used to make decisions about the object to create.  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentManifestObject](deploymentmanifestobject-class-microsoft-web-deployment.md)  
A [DeploymentManifestObject](deploymentmanifestobject-class-microsoft-web-deployment.md) created based on the options provided.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObjectProviderContext Class](deploymentmanifestobjectprovidercontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

