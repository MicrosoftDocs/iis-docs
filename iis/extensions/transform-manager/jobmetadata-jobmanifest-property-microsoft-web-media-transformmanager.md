---
title: JobMetadata.JobManifest Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.JobManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.jobmanifest(v=VS.90)
ms:contentKeyID: 35520747
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.JobManifest
- Microsoft.Web.Media.TransformManager.JobMetadata.get_JobManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_JobManifest
- Microsoft.Web.Media.TransformManager.JobMetadata.JobManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManifest Property

Gets the job-specific metadata from the [JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property JobManifest As JobManifest
    Get
'Usage

  Dim instance As JobMetadata
Dim value As JobManifest

value = instance.JobManifest
```

```csharp
  public JobManifest JobManifest { get; }
```

```cpp
  public:
property JobManifest^ JobManifest {
    JobManifest^ get ();
}
```

``` fsharp
  member JobManifest : JobManifest
```

```jscript
  function get JobManifest () : JobManifest
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
The job manifest metadata.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

