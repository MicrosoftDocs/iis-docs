---
title: JobMetadata.TaskCode Property (Microsoft.Web.Media.TransformManager)
description: 
TOCTitle: TaskCode Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.TaskCode
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmetadata.taskcode(v=VS.90)
ms:contentKeyID: 35520684
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskCode
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskCode
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskCode
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskCode
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskCode Property

Gets the task code from the task element that is contained in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property TaskCode As String
    Get
'Usage

  Dim instance As JobMetadata
Dim value As String

value = instance.TaskCode
```

```csharp
  public string TaskCode { get; }
```

```cpp
  public:
property String^ TaskCode {
    String^ get ();
}
```

``` fsharp
  member TaskCode : string
```

```jscript
  function get TaskCode () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The task code.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
