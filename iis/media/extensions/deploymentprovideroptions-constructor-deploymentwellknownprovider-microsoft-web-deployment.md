---
title: DeploymentProviderOptions Constructor (DeploymentWellKnownProvider) (Microsoft.Web.Deployment)
TOCTitle: DeploymentProviderOptions Constructor (DeploymentWellKnownProvider)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderOptions.#ctor(Microsoft.Web.Deployment.DeploymentWellKnownProvider)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovideroptions.deploymentprovideroptions(v=VS.90)
ms:contentKeyID: 20208875
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
- Microsoft.Web.Deployment.DeploymentProviderOptions..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentProviderOptions Constructor (DeploymentWellKnownProvider)

Creates an instance of a [DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md) object

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    wellKnownProviderAsDeploymentWellKnownProvider _
)
'Usage
DimwellKnownProviderAsDeploymentWellKnownProviderDiminstanceAs NewDeploymentProviderOptions(wellKnownProvider)
```

``` csharp
publicDeploymentProviderOptions(
    DeploymentWellKnownProviderwellKnownProvider
)
```

``` c++
public:
DeploymentProviderOptions(
    DeploymentWellKnownProviderwellKnownProvider
)
```

``` jscript
publicfunctionDeploymentProviderOptions(
    wellKnownProvider : DeploymentWellKnownProvider
)
```

#### Parameters

  - wellKnownProvider  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentWellKnownProvider](deploymentwellknownprovider-enumeration-microsoft-web-deployment.md)  
    A valid value from the [DeploymentWellKnownProvider](deploymentwellknownprovider-enumeration-microsoft-web-deployment.md) enumeration.  

## Remarks

Well known deployment object providers are defined in the [DeploymentWellKnownProvider](deploymentwellknownprovider-enumeration-microsoft-web-deployment.md) enumeration. This method searches for the factory specified by the wellKnownProvider parameter. If the factory is not found, this method throws a DeploymentException.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderOptions Class](deploymentprovideroptions-class-microsoft-web-deployment.md)

[DeploymentProviderOptions Overload](deploymentprovideroptions-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

