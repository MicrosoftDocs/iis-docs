---
title: DeploymentProviderContext.Factory Property  (Microsoft.Web.Deployment)
TOCTitle: Factory Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderContext.Factory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidercontext.factory(v=VS.90)
ms:contentKeyID: 20209017
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderContext.Factory
- Microsoft.Web.Deployment.DeploymentProviderContext.get_Factory
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderContext.Factory
- Microsoft.Web.Deployment.DeploymentProviderContext.get_Factory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Factory Property

Gets the [DeploymentProviderFactory](deploymentproviderfactory-class-microsoft-web-deployment.md) associated with the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFactoryAsDeploymentProviderFactory
'Usage
DiminstanceAsDeploymentProviderContextDimvalueAsDeploymentProviderFactoryvalue = instance.Factory
```

``` csharp
publicDeploymentProviderFactoryFactory { get; }
```

``` c++
public:
propertyDeploymentProviderFactory^ Factory {
    DeploymentProviderFactory^ get ();
}
```

``` jscript
function getFactory () : DeploymentProviderFactory
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderFactory](deploymentproviderfactory-class-microsoft-web-deployment.md)  
The [DeploymentProviderFactory](deploymentproviderfactory-class-microsoft-web-deployment.md) associated with the current object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderContext Class](deploymentprovidercontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

