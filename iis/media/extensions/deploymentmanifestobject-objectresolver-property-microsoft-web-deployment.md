---
title: DeploymentManifestObject.ObjectResolver Property  (Microsoft.Web.Deployment)
TOCTitle: ObjectResolver Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestObject.ObjectResolver
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.objectresolver(v=VS.90)
ms:contentKeyID: 20208751
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObject.ObjectResolver
- Microsoft.Web.Deployment.DeploymentManifestObject.get_ObjectResolver
- Microsoft.Web.Deployment.DeploymentManifestObject.set_ObjectResolver
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject.get_ObjectResolver
- Microsoft.Web.Deployment.DeploymentManifestObject.ObjectResolver
- Microsoft.Web.Deployment.DeploymentManifestObject.set_ObjectResolver
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ObjectResolver Property

Gets or sets a [DeploymentObjectResolver](deploymentobjectresolver-class-microsoft-web-deployment.md) used by this manifest object to

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyObjectResolverAsDeploymentObjectResolver
'Usage
DiminstanceAsDeploymentManifestObjectDimvalueAsDeploymentObjectResolvervalue = instance.ObjectResolver

instance.ObjectResolver = value
```

``` csharp
publicDeploymentObjectResolverObjectResolver { get; set; }
```

``` c++
public:
propertyDeploymentObjectResolver^ ObjectResolver {
    DeploymentObjectResolver^ get ();
    voidset (DeploymentObjectResolver^ value);
}
```

``` jscript
function getObjectResolver () : DeploymentObjectResolverfunction setObjectResolver (value : DeploymentObjectResolver)
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectResolver](deploymentobjectresolver-class-microsoft-web-deployment.md)  
A [DeploymentObjectResolver](deploymentobjectresolver-class-microsoft-web-deployment.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

