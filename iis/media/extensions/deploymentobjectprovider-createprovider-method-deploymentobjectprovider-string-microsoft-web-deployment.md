---
title: DeploymentObjectProvider.CreateProvider Method (DeploymentObjectProvider, String) (Microsoft.Web.Deployment)
TOCTitle: CreateProvider Method (DeploymentObjectProvider, String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectProvider.CreateProvider(Microsoft.Web.Deployment.DeploymentObjectProvider,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.createprovider(v=VS.90)
ms:contentKeyID: 20208896
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
- Microsoft.Web.Deployment.DeploymentObjectProvider.CreateProvider
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateProvider Method (DeploymentObjectProvider, String)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCreateProvider ( _
    providerAsDeploymentObjectProvider, _
    linkNameAsString _
) AsDeploymentObjectProvider
'Usage
DiminstanceAsDeploymentObjectProviderDimproviderAsDeploymentObjectProviderDimlinkNameAsStringDimreturnValueAsDeploymentObjectProviderreturnValue = instance.CreateProvider(provider, _
    linkName)
```

``` csharp
publicDeploymentObjectProviderCreateProvider(
    DeploymentObjectProviderprovider,
    stringlinkName
)
```

``` c++
public:
DeploymentObjectProvider^ CreateProvider(
    DeploymentObjectProvider^ provider, 
    String^ linkName
)
```

``` jscript
publicfunctionCreateProvider(
    provider : DeploymentObjectProvider, 
    linkName : String
) : DeploymentObjectProvider
```

#### Parameters

  - provider  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)  

<!-- end list -->

  - linkName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[CreateProvider Overload](deploymentobjectprovider-createprovider-method-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

