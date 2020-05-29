---
title: TaskDetails.TaskProgress Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskProgress Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDetails.TaskProgress
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdetails.taskprogress(v=VS.90)
ms:contentKeyID: 35520585
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskProgress
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskProgress
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskProgress
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskProgress Property

Gets or sets the progress of a task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property TaskProgress As Integer
    Get
    Set
'Usage

  Dim instance As TaskDetails
Dim value As Integer

value = instance.TaskProgress

instance.TaskProgress = value
```

```csharp
  public int TaskProgress { get; set; }
```

```cpp
  public:
property int TaskProgress {
    int get ();
    void set (int value);
}
```

``` fsharp
  member TaskProgress : int with get, set
```

```jscript
  function get TaskProgress () : int
function set TaskProgress (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The progress of a task.  

## See Also

### Reference

[TaskDetails Structure](taskdetails-structure-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
