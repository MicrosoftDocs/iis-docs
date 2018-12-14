---
title: DeploymentManifestFileSystemContext.Attributes Property  (Microsoft.Web.Deployment)
TOCTitle: Attributes Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.Attributes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestfilesystemcontext.attributes(v=VS.90)
ms:contentKeyID: 20208978
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.Attributes
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_Attributes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.Attributes
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_Attributes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Attributes Property

Gets the file attribute flags for a file.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAttributesAsFileAttributes
'Usage
DiminstanceAsDeploymentManifestFileSystemContextDimvalueAsFileAttributesvalue = instance.Attributes
```

``` csharp
publicFileAttributesAttributes { get; }
```

``` c++
public:
propertyFileAttributesAttributes {
    FileAttributesget ();
}
```

``` jscript
function getAttributes () : FileAttributes
```

#### Property Value

Type: [System.IO. . :: . .FileAttributes](https://msdn.microsoft.com/en-us/library/9f93fa06\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestFileSystemContext Class](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

