---
title: DeploymentObject.KeyAttribute Property  (Microsoft.Web.Deployment)
TOCTitle: KeyAttribute Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.KeyAttribute
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.keyattribute(v=VS.90)
ms:contentKeyID: 20208967
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.KeyAttribute
- Microsoft.Web.Deployment.DeploymentObject.get_KeyAttribute
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.get_KeyAttribute
- Microsoft.Web.Deployment.DeploymentObject.KeyAttribute
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# KeyAttribute Property

Gets the DeploymentAttribute used as the key in the current deployment object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyKeyAttributeAsDeploymentObjectAttribute
'Usage
DiminstanceAsDeploymentObjectDimvalueAsDeploymentObjectAttributevalue = instance.KeyAttribute
```

``` csharp
publicDeploymentObjectAttributeKeyAttribute { get; }
```

``` c++
public:
propertyDeploymentObjectAttribute^ KeyAttribute {
    DeploymentObjectAttribute^ get ();
}
```

``` jscript
function getKeyAttribute () : DeploymentObjectAttribute
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttribute](deploymentobjectattribute-class-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

