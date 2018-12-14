---
title: DeploymentObject.StreamRelativeFilePath Property  (Microsoft.Web.Deployment)
TOCTitle: StreamRelativeFilePath Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObject.StreamRelativeFilePath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobject.streamrelativefilepath(v=VS.90)
ms:contentKeyID: 20209181
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObject.StreamRelativeFilePath
- Microsoft.Web.Deployment.DeploymentObject.get_StreamRelativeFilePath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObject.get_StreamRelativeFilePath
- Microsoft.Web.Deployment.DeploymentObject.StreamRelativeFilePath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamRelativeFilePath Property

Gets a string that contains the stream relative file path associated with the current object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyStreamRelativeFilePathAsString
'Usage
DiminstanceAsDeploymentObjectDimvalueAsStringvalue = instance.StreamRelativeFilePath
```

``` csharp
publicstringStreamRelativeFilePath { get; }
```

``` c++
public:
propertyString^ StreamRelativeFilePath {
    String^ get ();
}
```

``` jscript
function getStreamRelativeFilePath () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObject Class](deploymentobject-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

