---
title: DeploymentObjectResolver.GetFactoryInfo Method  (Microsoft.Web.Deployment)
TOCTitle: GetFactoryInfo Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectResolver.GetFactoryInfo(Microsoft.Web.Deployment.DeploymentObject,System.String@,System.String@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectresolver.getfactoryinfo(v=VS.90)
ms:contentKeyID: 20209143
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetFactoryInfo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetFactoryInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetFactoryInfo Method

Gets the factory information for a given [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubGetFactoryInfo ( _
    deploymentObjectAsDeploymentObject, _
    <OutAttribute> ByReffactoryNameAsString, _
    <OutAttribute> ByReffactoryPathAsString _
)
'Usage
DiminstanceAsDeploymentObjectResolverDimdeploymentObjectAsDeploymentObjectDimfactoryNameAsStringDimfactoryPathAsString

instance.GetFactoryInfo(deploymentObject, _
    factoryName, factoryPath)
```

``` csharp
publicvirtualvoidGetFactoryInfo(
    DeploymentObjectdeploymentObject,
    outstringfactoryName,
    outstringfactoryPath
)
```

``` c++
public:
virtualvoidGetFactoryInfo(
    DeploymentObject^ deploymentObject, 
    [OutAttribute] String^% factoryName, 
    [OutAttribute] String^% factoryPath
)
```

``` jscript
publicfunctionGetFactoryInfo(
    deploymentObject : DeploymentObject, 
    factoryName : String, 
    factoryPath : String
)
```

#### Parameters

  - deploymentObject  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    A [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance to use to resolve the factory information..  

<!-- end list -->

  - factoryName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))%  
    The name of the factory.  

<!-- end list -->

  - factoryPath  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))%  
    The path to the factory.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectResolver Class](deploymentobjectresolver-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

