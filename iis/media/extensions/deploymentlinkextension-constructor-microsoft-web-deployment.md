---
title: DeploymentLinkExtension Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentLinkExtension Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentLinkExtension.#ctor(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentlinkextension.deploymentlinkextension(v=VS.90)
ms:contentKeyID: 22753954
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentLinkExtension.DeploymentLinkExtension
- Microsoft.Web.Deployment.DeploymentLinkExtension.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentLinkExtension..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentLinkExtension Constructor

Creates an instance of a deployment link extension.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    enabledByDefaultAsBoolean _
)
'Usage
DimenabledByDefaultAsBooleanDiminstanceAs NewDeploymentLinkExtension(enabledByDefault)
```

``` csharp
protectedDeploymentLinkExtension(
    boolenabledByDefault
)
```

``` c++
protected:
DeploymentLinkExtension(
    boolenabledByDefault
)
```

``` jscript
protectedfunctionDeploymentLinkExtension(
    enabledByDefault : boolean
)
```

#### Parameters

  - enabledByDefault  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    **true** if the deployment link extension is enabled by default; otherwise, **false**.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentLinkExtension Class](deploymentlinkextension-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

