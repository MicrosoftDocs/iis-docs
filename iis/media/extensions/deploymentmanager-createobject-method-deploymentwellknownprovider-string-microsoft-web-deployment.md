---
title: DeploymentManager.CreateObject Method (DeploymentWellKnownProvider, String) (Microsoft.Web.Deployment)
TOCTitle: CreateObject Method (DeploymentWellKnownProvider, String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManager.CreateObject(Microsoft.Web.Deployment.DeploymentWellKnownProvider,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanager.createobject(v=VS.90)
ms:contentKeyID: 20208662
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

# CreateObject Method (DeploymentWellKnownProvider, String)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionCreateObject ( _
    providerAsDeploymentWellKnownProvider, _
    pathAsString _
) AsDeploymentObject
'Usage
DimproviderAsDeploymentWellKnownProviderDimpathAsStringDimreturnValueAsDeploymentObjectreturnValue = DeploymentManager.CreateObject(provider, _
    path)
```

``` csharp
publicstaticDeploymentObjectCreateObject(
    DeploymentWellKnownProviderprovider,
    stringpath
)
```

``` c++
public:
staticDeploymentObject^ CreateObject(
    DeploymentWellKnownProviderprovider, 
    String^ path
)
```

``` jscript
publicstaticfunctionCreateObject(
    provider : DeploymentWellKnownProvider, 
    path : String
) : DeploymentObject
```

#### Parameters

  - provider  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentWellKnownProvider](deploymentwellknownprovider-enumeration-microsoft-web-deployment.md)  

<!-- end list -->

  - path  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

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

