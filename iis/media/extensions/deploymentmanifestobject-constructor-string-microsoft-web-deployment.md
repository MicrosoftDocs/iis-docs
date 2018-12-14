---
title: DeploymentManifestObject Constructor (String) (Microsoft.Web.Deployment)
TOCTitle: DeploymentManifestObject Constructor (String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManifestObject.#ctor(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.deploymentmanifestobject(v=VS.90)
ms:contentKeyID: 20208808
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentManifestObject Constructor (String)

Creates an instance of the [DeploymentManifestObject](deploymentmanifestobject-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString _
)
'Usage
DimnameAsStringDiminstanceAs NewDeploymentManifestObject(name)
```

``` csharp
publicDeploymentManifestObject(
    stringname
)
```

``` c++
public:
DeploymentManifestObject(
    String^ name
)
```

``` jscript
publicfunctionDeploymentManifestObject(
    name : String
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name to assign to the current object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[DeploymentManifestObject Overload](deploymentmanifestobject-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

