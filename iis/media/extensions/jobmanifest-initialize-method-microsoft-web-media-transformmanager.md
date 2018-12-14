---
title: JobManifest.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.Initialize(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.initialize(v=VS.90)
ms:contentKeyID: 35520756
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.Initialize
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.Initialize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Initialize Method

Initializes member variables for a manifest that is loaded from disk instead of created as part of job submission.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubInitialize ( _
    fileNameAsString _
)
'Usage
DiminstanceAsJobManifestDimfileNameAsString

instance.Initialize(fileName)
```

``` csharp
publicvoidInitialize(
    stringfileName
)
```

``` c++
public:
virtualvoidInitialize(
    String^ fileName
) sealed
```

``` fsharp
abstractInitialize : 
        fileName:string->unitoverrideInitialize : 
        fileName:string->unit
```

``` jscript
publicfinalfunctionInitialize(
    fileName : String
)
```

#### Parameters

  - fileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the manifest file.  

#### Implements

[IJobManifest. . :: . .Initialize(String)](ijobmanifest-initialize-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

