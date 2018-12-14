---
title: DeploymentManifestObject.KeyAttribute Property  (Microsoft.Web.Deployment)
TOCTitle: KeyAttribute Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestObject.KeyAttribute
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.keyattribute(v=VS.90)
ms:contentKeyID: 20209196
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObject.KeyAttribute
- Microsoft.Web.Deployment.DeploymentManifestObject.get_KeyAttribute
- Microsoft.Web.Deployment.DeploymentManifestObject.set_KeyAttribute
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject.get_KeyAttribute
- Microsoft.Web.Deployment.DeploymentManifestObject.KeyAttribute
- Microsoft.Web.Deployment.DeploymentManifestObject.set_KeyAttribute
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# KeyAttribute Property

Gets or sets the attribute that represents the key for the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyKeyAttributeAsDeploymentObjectAttributeData
'Usage
DiminstanceAsDeploymentManifestObjectDimvalueAsDeploymentObjectAttributeDatavalue = instance.KeyAttribute

instance.KeyAttribute = value
```

``` csharp
publicDeploymentObjectAttributeDataKeyAttribute { get; set; }
```

``` c++
public:
propertyDeploymentObjectAttributeData^ KeyAttribute {
    DeploymentObjectAttributeData^ get ();
    voidset (DeploymentObjectAttributeData^ value);
}
```

``` jscript
function getKeyAttribute () : DeploymentObjectAttributeDatafunction setKeyAttribute (value : DeploymentObjectAttributeData)
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeData](deploymentobjectattributedata-class-microsoft-web-deployment.md)  
A DeploymentAttribute instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

