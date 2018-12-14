---
title: DeploymentPackageSerializationEventArgs Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentPackageSerializationEventArgs Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.#ctor(System.Int32,System.Int32,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentpackageserializationeventargs.deploymentpackageserializationeventargs(v=VS.90)
ms:contentKeyID: 20208736
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.DeploymentPackageSerializationEventArgs
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentPackageSerializationEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentPackageSerializationEventArgs Constructor

Creates in instance of a [DeploymentPackageSerializationEventArgs](deploymentpackageserializationeventargs-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    currentFileAsInteger, _
    fileCountAsInteger, _
    fileNameAsString _
)
'Usage
DimcurrentFileAsIntegerDimfileCountAsIntegerDimfileNameAsStringDiminstanceAs NewDeploymentPackageSerializationEventArgs(currentFile, _
    fileCount, fileName)
```

``` csharp
publicDeploymentPackageSerializationEventArgs(
    intcurrentFile,
    intfileCount,
    stringfileName
)
```

``` c++
public:
DeploymentPackageSerializationEventArgs(
    intcurrentFile, 
    intfileCount, 
    String^ fileName
)
```

``` jscript
publicfunctionDeploymentPackageSerializationEventArgs(
    currentFile : int, 
    fileCount : int, 
    fileName : String
)
```

#### Parameters

  - currentFile  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The current file number.  

<!-- end list -->

  - fileCount  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The total file count.  

<!-- end list -->

  - fileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the file.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentPackageSerializationEventArgs Class](deploymentpackageserializationeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

