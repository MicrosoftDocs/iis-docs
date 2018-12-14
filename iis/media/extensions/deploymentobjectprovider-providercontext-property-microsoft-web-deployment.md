---
title: DeploymentObjectProvider.ProviderContext Property  (Microsoft.Web.Deployment)
TOCTitle: ProviderContext Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectProvider.ProviderContext
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.providercontext(v=VS.90)
ms:contentKeyID: 20208651
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectProvider.ProviderContext
- Microsoft.Web.Deployment.DeploymentObjectProvider.get_ProviderContext
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectProvider.get_ProviderContext
- Microsoft.Web.Deployment.DeploymentObjectProvider.ProviderContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProviderContext Property

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProviderContextAsDeploymentProviderContext
'Usage
DiminstanceAsDeploymentObjectProviderDimvalueAsDeploymentProviderContextvalue = instance.ProviderContext
```

``` csharp
publicDeploymentProviderContextProviderContext { get; }
```

``` c++
public:
propertyDeploymentProviderContext^ ProviderContext {
    DeploymentProviderContext^ get ();
}
```

``` jscript
function getProviderContext () : DeploymentProviderContext
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderContext](deploymentprovidercontext-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

