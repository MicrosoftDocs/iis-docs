---
title: DeploymentObjectAttribute.Kind Property  (Microsoft.Web.Deployment)
TOCTitle: Kind Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectAttribute.Kind
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute.kind(v=VS.90)
ms:contentKeyID: 22754034
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.Kind
- Microsoft.Web.Deployment.DeploymentObjectAttribute.get_Kind
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute.get_Kind
- Microsoft.Web.Deployment.DeploymentObjectAttribute.Kind
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Kind Property

Gets the [DeploymentObjectAttributeKind](deploymentobjectattributekind-enumeration-microsoft-web-deployment.md) of the deployment attribute.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyKindAsDeploymentObjectAttributeKind
'Usage
DiminstanceAsDeploymentObjectAttributeDimvalueAsDeploymentObjectAttributeKindvalue = instance.Kind
```

``` csharp
publicDeploymentObjectAttributeKindKind { get; }
```

``` c++
public:
propertyDeploymentObjectAttributeKindKind {
    DeploymentObjectAttributeKindget ();
}
```

``` jscript
function getKind () : DeploymentObjectAttributeKind
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentObjectAttributeKind](deploymentobjectattributekind-enumeration-microsoft-web-deployment.md)  
A [DeploymentObjectAttributeKind](deploymentobjectattributekind-enumeration-microsoft-web-deployment.md) object for the deployment attribute.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectAttribute Class](deploymentobjectattribute-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

