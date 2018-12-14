---
title: DeploymentManifestObjectProviderContext.GetFileSystemContext Method  (Microsoft.Web.Deployment)
TOCTitle: GetFileSystemContext Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentManifestObjectProviderContext.GetFileSystemContext(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobjectprovidercontext.getfilesystemcontext(v=VS.90)
ms:contentKeyID: 20209189
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObjectProviderContext.GetFileSystemContext
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObjectProviderContext.GetFileSystemContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetFileSystemContext Method

Gets the [DeploymentManifestFileSystemContext](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md) associated with the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetFileSystemContext ( _
    pathAsString _
) AsDeploymentManifestFileSystemContext
'Usage
DiminstanceAsDeploymentManifestObjectProviderContextDimpathAsStringDimreturnValueAsDeploymentManifestFileSystemContextreturnValue = instance.GetFileSystemContext(path)
```

``` csharp
publicDeploymentManifestFileSystemContextGetFileSystemContext(
    stringpath
)
```

``` c++
public:
DeploymentManifestFileSystemContext^ GetFileSystemContext(
    String^ path
)
```

``` jscript
publicfunctionGetFileSystemContext(
    path : String
) : DeploymentManifestFileSystemContext
```

#### Parameters

  - path  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The path to which file system context pertains.  

#### Return Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentManifestFileSystemContext](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md)  
A [DeploymentManifestFileSystemContext](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObjectProviderContext Class](deploymentmanifestobjectprovidercontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

