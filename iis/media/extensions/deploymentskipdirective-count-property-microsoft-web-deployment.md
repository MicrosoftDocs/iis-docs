---
title: DeploymentSkipDirective.Count Property  (Microsoft.Web.Deployment)
TOCTitle: Count Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSkipDirective.Count
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective.count(v=VS.90)
ms:contentKeyID: 20208930
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirective.Count
- Microsoft.Web.Deployment.DeploymentSkipDirective.get_Count
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirective.Count
- Microsoft.Web.Deployment.DeploymentSkipDirective.get_Count
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Count Property

Gets the number of [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) objects in the current [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCountAsInteger
'Usage
DiminstanceAsDeploymentSkipDirectiveDimvalueAsIntegervalue = instance.Count
```

``` csharp
publicintCount { get; }
```

``` c++
public:
propertyintCount {
    intget ();
}
```

``` jscript
function getCount () : int
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
An integer that indicates the number of [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) objects in the current [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirective Class](deploymentskipdirective-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

