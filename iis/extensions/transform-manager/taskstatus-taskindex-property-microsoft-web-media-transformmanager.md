---
title: TaskStatus.TaskIndex Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskIndex Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskStatus.TaskIndex
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.taskindex(v=VS.90)
ms:contentKeyID: 35520954
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_TaskIndex
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskIndex
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_TaskIndex
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskIndex Property

Gets the task index.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property TaskIndex As Integer
    Get
'Usage

  Dim instance As TaskStatus
Dim value As Integer

value = instance.TaskIndex
```

```csharp
  public int TaskIndex { get; }
```

```cpp
  public:
property int TaskIndex {
    int get ();
}
```

``` fsharp
  member TaskIndex : int
```

```jscript
  function get TaskIndex () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The task index.  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

