---
title: DeploymentObject.LinkName Property  (Microsoft.Web.Deployment)
TOCTitle: LinkName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.LinkName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.linkname(v=VS.90)
ms:contentKeyID: 20209253
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.LinkName
- Microsoft.Web.Deployment.DeploymentObject.get_LinkName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.get_LinkName
- Microsoft.Web.Deployment.DeploymentObject.LinkName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LinkName Property

Gets the link name of the current [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLinkNameAsString
'Usage
DiminstanceAsDeploymentObjectDimvalueAsStringvalue = instance.LinkName
```

``` csharp
publicstringLinkName { get; }
```

``` c++
public:
propertyString^ LinkName {
    String^ get ();
}
```

``` jscript
function getLinkName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name of the current [DeploymentObject](deploymentobject-class-microsoft-web-deployment.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

