---
title: DeploymentManifestFileSystemContext.LastWriteTime Property  (Microsoft.Web.Deployment)
TOCTitle: LastWriteTime Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.LastWriteTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestfilesystemcontext.lastwritetime(v=VS.90)
ms:contentKeyID: 20209105
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.LastWriteTime
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_LastWriteTime
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_LastWriteTime
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.LastWriteTime
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LastWriteTime Property

Gets a DateTime object that represents the last time the file was written to.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLastWriteTimeAsDateTime
'Usage
DiminstanceAsDeploymentManifestFileSystemContextDimvalueAsDateTimevalue = instance.LastWriteTime
```

``` csharp
publicDateTimeLastWriteTime { get; }
```

``` c++
public:
propertyDateTimeLastWriteTime {
    DateTimeget ();
}
```

``` jscript
function getLastWriteTime () : DateTime
```

#### Property Value

Type: [System. . :: . .DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestFileSystemContext Class](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

