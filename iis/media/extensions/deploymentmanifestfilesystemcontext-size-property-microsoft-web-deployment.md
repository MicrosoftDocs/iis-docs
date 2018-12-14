---
title: DeploymentManifestFileSystemContext.Size Property  (Microsoft.Web.Deployment)
TOCTitle: Size Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.Size
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestfilesystemcontext.size(v=VS.90)
ms:contentKeyID: 20208944
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.Size
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_Size
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_Size
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.Size
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Size Property

Gets the size (in bytes) of the current file.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySizeAsLong
'Usage
DiminstanceAsDeploymentManifestFileSystemContextDimvalueAsLongvalue = instance.Size
```

``` csharp
publiclongSize { get; }
```

``` c++
public:
propertylong longSize {
    long longget ();
}
```

``` jscript
function getSize () : long
```

#### Property Value

Type: [System. . :: . .Int64](https://msdn.microsoft.com/en-us/library/6yy583ek\(v=vs.90\))  
A long that contains the number of byte sin the file this object represents.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestFileSystemContext Class](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

