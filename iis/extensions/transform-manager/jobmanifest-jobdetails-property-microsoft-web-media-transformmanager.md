---
title: JobManifest.JobDetails Property (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax for the JobManifest.JobDetails property, with links to reference materials.
TOCTitle: JobDetails Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.JobDetails
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.jobdetails(v=VS.90)
ms:contentKeyID: 35521082
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_JobDetails
- Microsoft.Web.Media.TransformManager.JobManifest.JobDetails
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_JobDetails
- Microsoft.Web.Media.TransformManager.JobManifest.JobDetails
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobDetails Property

Gets a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that is based on details from the job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property JobDetails As JobDetails
    Get
'Usage

  Dim instance As JobManifest
Dim value As JobDetails

value = instance.JobDetails
```

```csharp
  public JobDetails JobDetails { get; }
```

```cpp
  public:
property JobDetails^ JobDetails {
    JobDetails^ get ();
}
```

``` fsharp
  member JobDetails : JobDetails
```

```jscript
  function get JobDetails () : JobDetails
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that is based on details from the job manifest.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
