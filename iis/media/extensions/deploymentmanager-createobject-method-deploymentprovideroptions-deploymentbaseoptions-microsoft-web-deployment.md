---
title: DeploymentManager.CreateObject Method (DeploymentProviderOptions, DeploymentBaseOptions) (Microsoft.Web.Deployment)
TOCTitle: CreateObject Method (DeploymentProviderOptions, DeploymentBaseOptions)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManager.CreateObject(Microsoft.Web.Deployment.DeploymentProviderOptions,Microsoft.Web.Deployment.DeploymentBaseOptions)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanager.createobject(v=VS.90)
ms:contentKeyID: 20209207
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

# CreateObject Method (DeploymentProviderOptions, DeploymentBaseOptions)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionCreateObject ( _
    providerOptionsAsDeploymentProviderOptions, _
    baseOptionsAsDeploymentBaseOptions _
) AsDeploymentObject
'Usage
DimproviderOptionsAsDeploymentProviderOptionsDimbaseOptionsAsDeploymentBaseOptionsDimreturnValueAsDeploymentObjectreturnValue = DeploymentManager.CreateObject(providerOptions, _
    baseOptions)
```

``` csharp
publicstaticDeploymentObjectCreateObject(
    DeploymentProviderOptionsproviderOptions,
    DeploymentBaseOptionsbaseOptions
)
```

``` c++
public:
staticDeploymentObject^ CreateObject(
    DeploymentProviderOptions^ providerOptions, 
    DeploymentBaseOptions^ baseOptions
)
```

``` jscript
publicstaticfunctionCreateObject(
    providerOptions : DeploymentProviderOptions, 
    baseOptions : DeploymentBaseOptions
) : DeploymentObject
```

#### Parameters

  - providerOptions  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderOptions](deploymentprovideroptions-class-microsoft-web-deployment.md)  

<!-- end list -->

  - baseOptions  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentBaseOptions](deploymentbaseoptions-class-microsoft-web-deployment.md)  

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

