---
title: DeploymentFileSerializationEventArgs.CurrentFile Property  (Microsoft.Web.Deployment)
TOCTitle: CurrentFile Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.CurrentFile
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentfileserializationeventargs.currentfile(v=VS.90)
ms:contentKeyID: 20208928
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.CurrentFile
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.get_CurrentFile
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.CurrentFile
- Microsoft.Web.Deployment.DeploymentFileSerializationEventArgs.get_CurrentFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CurrentFile Property

Gets the index of the file that this event argument represents.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyCurrentFileAsInteger
'Usage
DiminstanceAsDeploymentFileSerializationEventArgsDimvalueAsIntegervalue = instance.CurrentFile
```

``` csharp
publicintCurrentFile { get; }
```

``` c++
public:
propertyintCurrentFile {
    intget ();
}
```

``` jscript
function getCurrentFile () : int
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
An integer that indicates the index of the file that this event argument represents.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentFileSerializationEventArgs Class](deploymentfileserializationeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

