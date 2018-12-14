---
title: DeploymentManifestObject.StreamRelativeFilePath Property  (Microsoft.Web.Deployment)
TOCTitle: StreamRelativeFilePath Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentManifestObject.StreamRelativeFilePath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentmanifestobject.streamrelativefilepath(v=VS.90)
ms:contentKeyID: 20208998
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentManifestObject.StreamRelativeFilePath
- Microsoft.Web.Deployment.DeploymentManifestObject.get_StreamRelativeFilePath
- Microsoft.Web.Deployment.DeploymentManifestObject.set_StreamRelativeFilePath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentManifestObject.get_StreamRelativeFilePath
- Microsoft.Web.Deployment.DeploymentManifestObject.set_StreamRelativeFilePath
- Microsoft.Web.Deployment.DeploymentManifestObject.StreamRelativeFilePath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamRelativeFilePath Property

Gets or sets the path to the stream relative file path.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyStreamRelativeFilePathAsString
'Usage
DiminstanceAsDeploymentManifestObjectDimvalueAsStringvalue = instance.StreamRelativeFilePath

instance.StreamRelativeFilePath = value
```

``` csharp
publicstringStreamRelativeFilePath { get; set; }
```

``` c++
public:
propertyString^ StreamRelativeFilePath {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getStreamRelativeFilePath () : Stringfunction setStreamRelativeFilePath (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the relative file path of the stream.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentManifestObject Class](deploymentmanifestobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

