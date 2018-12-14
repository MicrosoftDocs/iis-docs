---
title: DeploymentManifestObject.LinkName Property  (Microsoft.Web.Deployment)
TOCTitle: LinkName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestObject.LinkName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.linkname(v=VS.90)
ms:contentKeyID: 20209037
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObject.LinkName
- Microsoft.Web.Deployment.DeploymentManifestObject.get_LinkName
- Microsoft.Web.Deployment.DeploymentManifestObject.set_LinkName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject.get_LinkName
- Microsoft.Web.Deployment.DeploymentManifestObject.LinkName
- Microsoft.Web.Deployment.DeploymentManifestObject.set_LinkName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LinkName Property

Gets or sets the name used to link a child object to the parent.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLinkNameAsString
'Usage
DiminstanceAsDeploymentManifestObjectDimvalueAsStringvalue = instance.LinkName

instance.LinkName = value
```

``` csharp
publicstringLinkName { get; set; }
```

``` c++
public:
propertyString^ LinkName {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getLinkName () : Stringfunction setLinkName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the link name.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

