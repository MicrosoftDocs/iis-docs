---
title: DeploymentProviderFactory.Create Method  (Microsoft.Web.Deployment)
TOCTitle: Create Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderFactory.Create(Microsoft.Web.Deployment.DeploymentProviderContext,Microsoft.Web.Deployment.DeploymentBaseContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentproviderfactory.create(v=VS.90)
ms:contentKeyID: 20579891
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderFactory.Create
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderFactory.Create
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Create Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedMustOverrideFunctionCreate ( _
    providerContextAsDeploymentProviderContext, _
    baseContextAsDeploymentBaseContext _
) AsDeploymentObjectProvider
'Usage
DimproviderContextAsDeploymentProviderContextDimbaseContextAsDeploymentBaseContextDimreturnValueAsDeploymentObjectProviderreturnValue = Me.Create(providerContext, _
    baseContext)
```

``` csharp
protectedabstractDeploymentObjectProviderCreate(
    DeploymentProviderContextproviderContext,
    DeploymentBaseContextbaseContext
)
```

``` c++
protected:
virtualDeploymentObjectProvider^ Create(
    DeploymentProviderContext^ providerContext, 
    DeploymentBaseContext^ baseContext
) abstract
```

``` jscript
protectedabstractfunctionCreate(
    providerContext : DeploymentProviderContext, 
    baseContext : DeploymentBaseContext
) : DeploymentObjectProvider
```

#### Parameters

  - providerContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderContext](deploymentprovidercontext-class-microsoft-web-deployment.md)  

<!-- end list -->

  - baseContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentBaseContext](deploymentbasecontext-class-microsoft-web-deployment.md)  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderFactory Class](deploymentproviderfactory-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

