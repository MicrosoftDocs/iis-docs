---
title: DeploymentManifestObject.ChildObjects Property  (Microsoft.Web.Deployment)
TOCTitle: ChildObjects Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestObject.ChildObjects
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.childobjects(v=VS.90)
ms:contentKeyID: 20209274
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObject.ChildObjects
- Microsoft.Web.Deployment.DeploymentManifestObject.get_ChildObjects
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject.ChildObjects
- Microsoft.Web.Deployment.DeploymentManifestObject.get_ChildObjects
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChildObjects Property

Getss the collection of child [DeploymentManifestObject](deploymentmanifestobject-class-microsoft-web-deployment.md) instances for the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyChildObjectsAsICollection(OfDeploymentManifestObject)
'Usage
DiminstanceAsDeploymentManifestObjectDimvalueAsICollection(OfDeploymentManifestObject)

value = instance.ChildObjects
```

``` csharp
publicICollection<DeploymentManifestObject> ChildObjects { get; }
```

``` c++
public:
propertyICollection<DeploymentManifestObject^>^ ChildObjects {
    ICollection<DeploymentManifestObject^>^ get ();
}
```

``` jscript
function getChildObjects () : ICollection<DeploymentManifestObject>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\< (Of \< ( \<'[DeploymentManifestObject](deploymentmanifestobject-class-microsoft-web-deployment.md)\> ) \> ) \>  
An ICollection\<DeploymentManifestObject\> interface.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

