---
title: TaskDetails.TaskIndex Property (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax for the TaskDetails.TaskIndex property, with links to reference materials.
TOCTitle: TaskIndex Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDetails.TaskIndex
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdetails.taskindex(v=VS.90)
ms:contentKeyID: 35520663
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskIndex
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskIndex
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskIndex
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskIndex
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskIndex
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskIndex
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskIndex Property

Gets or sets the index of a task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property TaskIndex As Integer
    Get
    Set
'Usage

  Dim instance As TaskDetails
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
The index of a task.  

## See Also

### Reference

[TaskDetails Structure](taskdetails-structure-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
