---
title: DeploymentProviderFactory.CreateProvider Method  (Microsoft.Web.Deployment)
TOCTitle: CreateProvider Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderFactory.CreateProvider(Microsoft.Web.Deployment.DeploymentProviderContext,Microsoft.Web.Deployment.DeploymentBaseContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentproviderfactory.createprovider(v=VS.90)
ms:contentKeyID: 20208773
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderFactory.CreateProvider
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderFactory.CreateProvider
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateProvider Method

Creates an instance of a deployment provider factory.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCreateProvider ( _
    providerContextAsDeploymentProviderContext, _
    baseContextAsDeploymentBaseContext _
) AsDeploymentObjectProvider
'Usage
DiminstanceAsDeploymentProviderFactoryDimproviderContextAsDeploymentProviderContextDimbaseContextAsDeploymentBaseContextDimreturnValueAsDeploymentObjectProviderreturnValue = instance.CreateProvider(providerContext, _
    baseContext)
```

``` csharp
publicDeploymentObjectProviderCreateProvider(
    DeploymentProviderContextproviderContext,
    DeploymentBaseContextbaseContext
)
```

``` c++
public:
DeploymentObjectProvider^ CreateProvider(
    DeploymentProviderContext^ providerContext, 
    DeploymentBaseContext^ baseContext
)
```

``` jscript
publicfunctionCreateProvider(
    providerContext : DeploymentProviderContext, 
    baseContext : DeploymentBaseContext
) : DeploymentObjectProvider
```

#### Parameters

  - providerContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderContext](deploymentprovidercontext-class-microsoft-web-deployment.md)  
    The [DeploymentProviderContext](deploymentprovidercontext-class-microsoft-web-deployment.md) that is used to provide information to the deployment provider this method creates.  

<!-- end list -->

  - baseContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentBaseContext](deploymentbasecontext-class-microsoft-web-deployment.md)  
    The deployment base context for the newly created deployment provider.  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)  

## Remarks

This method is marked as abstract (MustInherit in Visual Basic). Base classes must override this method.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderFactory Class](deploymentproviderfactory-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

