---
title: JobManifest.TaskIndex Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskIndex Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.TaskIndex
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.taskindex(v=VS.90)
ms:contentKeyID: 35521060
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.set_TaskIndex
- Microsoft.Web.Media.TransformManager.JobManifest.TaskIndex
- Microsoft.Web.Media.TransformManager.JobManifest.get_TaskIndex
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_TaskIndex
- Microsoft.Web.Media.TransformManager.JobManifest.set_TaskIndex
- Microsoft.Web.Media.TransformManager.JobManifest.TaskIndex
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskIndex Property

Gets or sets the task index value from the task index element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property TaskIndex As Integer
    Get
    Set
'Usage

  Dim instance As JobManifest
Dim value As Integer

value = instance.TaskIndex

instance.TaskIndex = value
```

```csharp
  public int TaskIndex { get; set; }
```

```cpp
  public:
property int TaskIndex {
    int get ();
    void set (int value);
}
```

``` fsharp
  member TaskIndex : int with get, set
```

```jscript
  function get TaskIndex () : int
function set TaskIndex (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The task index value.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
