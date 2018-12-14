---
title: DeploymentSkipDirective.Item Property  (Microsoft.Web.Deployment)
TOCTitle: Item Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSkipDirective.Item(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective.item(v=VS.90)
ms:contentKeyID: 20209313
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirective.Item
- Microsoft.Web.Deployment.DeploymentSkipDirective.get_Item
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirective.get_Item
- Microsoft.Web.Deployment.DeploymentSkipDirective.Item
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Item Property

Gets a single [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) from the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyDefaultPropertyItem ( _
    nameAsString _
) AsDeploymentSkipDirectiveEntry
'Usage
DiminstanceAsDeploymentSkipDirectiveDimnameAsStringDimvalueAsDeploymentSkipDirectiveEntryvalue = instance(name)
```

``` csharp
publicDeploymentSkipDirectiveEntrythis[
    stringname
] { get; }
```

``` c++
public:
propertyDeploymentSkipDirectiveEntry^ default[String^ name] {
    DeploymentSkipDirectiveEntry^ get (String^ name);
}
```

``` jscript
JScript does not support indexed properties.
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) to get.  

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md)  
An instance of a [DeploymentSkipDirectiveEntry](deploymentskipdirectiveentry-class-microsoft-web-deployment.md) with the specified name, if one exists.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirective Class](deploymentskipdirective-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

