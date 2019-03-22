---
title: JobMetadata Constructor  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobMetadata Constructor
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobMetadata.#ctor(Microsoft.Web.Media.TransformManager.JobManifest,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.jobmetadata(v=VS.90)
ms:contentKeyID: 35521149
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.#ctor
- Microsoft.Web.Media.TransformManager.JobMetadata.JobMetadata
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobMetadata Constructor

Initializes a new instance of the [JobMetadata](jobmetadata-class-microsoft-web-media-transformmanager.md) class by using the specified manifest and task index.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    manifest As JobManifest, _
    taskIndex As Integer _
)
'Usage

  Dim manifest As JobManifest
Dim taskIndex As Integer

Dim instance As New JobMetadata(manifest, _
    taskIndex)
```

```csharp
  public JobMetadata(
    JobManifest manifest,
    int taskIndex
)
```

```cpp
  public:
JobMetadata(
    JobManifest^ manifest, 
    int taskIndex
)
```

``` fsharp
  new : 
        manifest:JobManifest * 
        taskIndex:int -> JobMetadata
```

```jscript
  public function JobMetadata(
    manifest : JobManifest, 
    taskIndex : int
)
```

### Parameters

  - manifest  
    Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
    The job manifest.  

<!-- end list -->

  - taskIndex  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The task index.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

