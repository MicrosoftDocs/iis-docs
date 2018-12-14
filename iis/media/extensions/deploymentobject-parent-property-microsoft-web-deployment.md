---
title: DeploymentObject.Parent Property  (Microsoft.Web.Deployment)
TOCTitle: Parent Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.Parent
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.parent(v=VS.90)
ms:contentKeyID: 20209326
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.Parent
- Microsoft.Web.Deployment.DeploymentObject.get_Parent
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.get_Parent
- Microsoft.Web.Deployment.DeploymentObject.Parent
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Parent Property

Gets the parent [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) of the current [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyParentAsDeploymentObject
'Usage
DiminstanceAsDeploymentObjectDimvalueAsDeploymentObjectvalue = instance.Parent
```

``` csharp
publicDeploymentObjectParent { get; }
```

``` c++
public:
propertyDeploymentObject^ Parent {
    DeploymentObject^ get ();
}
```

``` jscript
function getParent () : DeploymentObject
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
A [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) if the current object is the child of another object, otherwise nullNothingnullptrunita null reference (Nothing in Visual Basic).  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

