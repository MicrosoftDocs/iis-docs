---
title: DeploymentFileSerializationEventArgs.FileName Property  (Microsoft.Web.Deployment)
TOCTitle: FileName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.FileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentfileserializationeventargs.filename(v=VS.90)
ms:contentKeyID: 20209250
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.FileName
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.get_FileName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.FileName
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.get_FileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FileName Property

Gets the name of the file being serialized.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFileNameAsString
'Usage
DiminstanceAsDeploymentFileSerializationEventArgsDimvalueAsStringvalue = instance.FileName
```

``` csharp
publicstringFileName { get; }
```

``` c++
public:
propertyString^ FileName {
    String^ get ();
}
```

``` jscript
function getFileName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name of the file being serialized.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentFileSerializationEventArgs Class](deploymentfileserializationeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

