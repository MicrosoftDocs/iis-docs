---
title: DeploymentAddLinkContext.CreateProvider Method (DeploymentProviderOptions) (Microsoft.Web.Deployment)
TOCTitle: CreateProvider Method (DeploymentProviderOptions)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAddLinkContext.CreateProvider(Microsoft.Web.Deployment.DeploymentProviderOptions)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentaddlinkcontext.createprovider(v=VS.90)
ms:contentKeyID: 20209121
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
- Microsoft.Web.Deployment.DeploymentAddLinkContext.CreateProvider
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateProvider Method (DeploymentProviderOptions)

Creates a new deployment object and adds it to the underlying collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCreateProvider ( _
    providerOptionsAsDeploymentProviderOptions _
) AsDeploymentObjectProvider
'Usage
DiminstanceAsDeploymentAddLinkContextDimproviderOptionsAsDeploymentProviderOptionsDimreturnValueAsDeploymentObjectProviderreturnValue = instance.CreateProvider(providerOptions)
```

``` csharp
publicDeploymentObjectProviderCreateProvider(
    DeploymentProviderOptionsproviderOptions
)
```

``` c++
public:
DeploymentObjectProvider^ CreateProvider(
    DeploymentProviderOptions^ providerOptions
)
```

``` jscript
publicfunctionCreateProvider(
    providerOptions : DeploymentProviderOptions
) : DeploymentObjectProvider
```

#### Parameters

  - providerOptions  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md)  
    The options that are passed to create the provider for the deployment object that this method creates.  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)  
The [DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md) object.  

## Remarks

This method creates a deployment object provider that is then used to create a deployment object. This method overload enables the caller to pass the provider options that are used to create the deployment object provider. After the new deployment object is created, it is added to the deployment object collection of this class.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAddLinkContext Class](deploymentaddlinkcontext-class-microsoft-web-deployment.md)

[CreateProvider Overload](deploymentaddlinkcontext-createprovider-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

