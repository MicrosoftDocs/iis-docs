---
title: DeploymentPackageSerializationEventArgs.FileCount Property  (Microsoft.Web.Deployment)
TOCTitle: FileCount Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.FileCount
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentpackageserializationeventargs.filecount(v=VS.90)
ms:contentKeyID: 20208961
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.FileCount
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.get_FileCount
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.FileCount
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.get_FileCount
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FileCount Property

Gets the total file count.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFileCountAsInteger
'Usage
DiminstanceAsDeploymentPackageSerializationEventArgsDimvalueAsIntegervalue = instance.FileCount
```

``` csharp
publicintFileCount { get; }
```

``` c++
public:
propertyintFileCount {
    intget ();
}
```

``` jscript
function getFileCount () : int
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The total file count.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentPackageSerializationEventArgs Class](deploymentpackageserializationeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

