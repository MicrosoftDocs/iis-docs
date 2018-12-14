---
title: DeploymentObjectProvider Constructor (DeploymentProviderContext, DeploymentBaseContext) (Microsoft.Web.Deployment)
TOCTitle: DeploymentObjectProvider Constructor (DeploymentProviderContext, DeploymentBaseContext)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectProvider.#ctor(Microsoft.Web.Deployment.DeploymentProviderContext,Microsoft.Web.Deployment.DeploymentBaseContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.deploymentobjectprovider(v=VS.90)
ms:contentKeyID: 20208824
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
- Microsoft.Web.Deployment.DeploymentObjectProvider..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentObjectProvider Constructor (DeploymentProviderContext, DeploymentBaseContext)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    providerContextAsDeploymentProviderContext, _
    baseContextAsDeploymentBaseContext _
)
'Usage
DimproviderContextAsDeploymentProviderContextDimbaseContextAsDeploymentBaseContextDiminstanceAs NewDeploymentObjectProvider(providerContext, _
    baseContext)
```

``` csharp
protectedDeploymentObjectProvider(
    DeploymentProviderContextproviderContext,
    DeploymentBaseContextbaseContext
)
```

``` c++
protected:
DeploymentObjectProvider(
    DeploymentProviderContext^ providerContext, 
    DeploymentBaseContext^ baseContext
)
```

``` jscript
protectedfunctionDeploymentObjectProvider(
    providerContext : DeploymentProviderContext, 
    baseContext : DeploymentBaseContext
)
```

#### Parameters

  - providerContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderContext](deploymentprovidercontext-class-microsoft-web-deployment.md)  

<!-- end list -->

  - baseContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentBaseContext](deploymentbasecontext-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[DeploymentObjectProvider Overload](deploymentobjectprovider-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

