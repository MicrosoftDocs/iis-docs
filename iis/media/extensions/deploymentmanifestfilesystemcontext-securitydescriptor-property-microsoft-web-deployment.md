---
title: DeploymentManifestFileSystemContext.SecurityDescriptor Property  (Microsoft.Web.Deployment)
TOCTitle: SecurityDescriptor Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.SecurityDescriptor
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestfilesystemcontext.securitydescriptor(v=VS.90)
ms:contentKeyID: 20209130
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.SecurityDescriptor
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_SecurityDescriptor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.get_SecurityDescriptor
- Microsoft.Web.Deployment.DeploymentManifestFileSystemContext.SecurityDescriptor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SecurityDescriptor Property

Gets a security descriptor for an object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySecurityDescriptorAsString
'Usage
DiminstanceAsDeploymentManifestFileSystemContextDimvalueAsStringvalue = instance.SecurityDescriptor
```

``` csharp
publicstringSecurityDescriptor { get; }
```

``` c++
public:
propertyString^ SecurityDescriptor {
    String^ get ();
}
```

``` jscript
function getSecurityDescriptor () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestFileSystemContext Class](deploymentmanifestfilesystemcontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

