---
title: JobManager.LocalFileWatcherFilter Property (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax and property value for the JobManager.LocalFileWatcherFilter property.
TOCTitle: LocalFileWatcherFilter Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.LocalFileWatcherFilter
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.localfilewatcherfilter(v=VS.90)
ms:contentKeyID: 35521087
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.LocalFileWatcherFilter
- Microsoft.Web.Media.TransformManager.JobManager.get_LocalFileWatcherFilter
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_LocalFileWatcherFilter
- Microsoft.Web.Media.TransformManager.JobManager.LocalFileWatcherFilter
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LocalFileWatcherFilter Property

Gets a file filter value that is used to initiate job creation.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property LocalFileWatcherFilter As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.LocalFileWatcherFilter
```

```csharp
  public string LocalFileWatcherFilter { get; }
```

```cpp
  public:
property String^ LocalFileWatcherFilter {
    String^ get ();
}
```

``` fsharp
  member LocalFileWatcherFilter : string
```

```jscript
  function get LocalFileWatcherFilter () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A file filter value that is used to initiate job creation.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
