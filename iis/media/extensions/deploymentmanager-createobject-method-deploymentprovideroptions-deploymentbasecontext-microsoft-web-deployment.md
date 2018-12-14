---
title: DeploymentManager.CreateObject Method (DeploymentProviderOptions, DeploymentBaseContext) (Microsoft.Web.Deployment)
TOCTitle: CreateObject Method (DeploymentProviderOptions, DeploymentBaseContext)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManager.CreateObject(Microsoft.Web.Deployment.DeploymentProviderOptions,Microsoft.Web.Deployment.DeploymentBaseContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanager.createobject(v=VS.90)
ms:contentKeyID: 20208715
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManager.CreateObject
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateObject Method (DeploymentProviderOptions, DeploymentBaseContext)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionCreateObject ( _
    providerOptionsAsDeploymentProviderOptions, _
    baseContextAsDeploymentBaseContext _
) AsDeploymentObject
'Usage
DimproviderOptionsAsDeploymentProviderOptionsDimbaseContextAsDeploymentBaseContextDimreturnValueAsDeploymentObjectreturnValue = DeploymentManager.CreateObject(providerOptions, _
    baseContext)
```

``` csharp
publicstaticDeploymentObjectCreateObject(
    DeploymentProviderOptionsproviderOptions,
    DeploymentBaseContextbaseContext
)
```

``` c++
public:
staticDeploymentObject^ CreateObject(
    DeploymentProviderOptions^ providerOptions, 
    DeploymentBaseContext^ baseContext
)
```

``` jscript
publicstaticfunctionCreateObject(
    providerOptions : DeploymentProviderOptions, 
    baseContext : DeploymentBaseContext
) : DeploymentObject
```

#### Parameters

  - providerOptions  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md)  

<!-- end list -->

  - baseContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentBaseContext](deploymentbasecontext-class-microsoft-web-deployment.md)  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
Returns [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManager Class](deploymentmanager-class-microsoft-web-deployment.md)

[CreateObject Overload](deploymentmanager-createobject-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

