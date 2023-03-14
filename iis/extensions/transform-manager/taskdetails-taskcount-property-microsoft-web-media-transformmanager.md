---
title: TaskDetails.TaskCount Property (Microsoft.Web.Media.TransformManager)
Description: Learn how the TaskCount property gets or sets the task count.
TOCTitle: TaskCount Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDetails.TaskCount
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdetails.taskcount(v=VS.90)
ms:contentKeyID: 35520617
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskCount
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskCount
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskCount
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDetails.get_TaskCount
- Microsoft.Web.Media.TransformManager.TaskDetails.set_TaskCount
- Microsoft.Web.Media.TransformManager.TaskDetails.TaskCount
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskDetails.TaskCount Property

Gets or sets the task count.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property TaskCount As Integer
    Get
    Set
'Usage

  Dim instance As TaskDetails
Dim value As Integer

value = instance.TaskCount

instance.TaskCount = value
```

```csharp
  public int TaskCount { get; set; }
```

```cpp
  public:
property int TaskCount {
    int get ();
    void set (int value);
}
```

``` fsharp
  member TaskCount : int with get, set
```

```jscript
  function get TaskCount () : int
function set TaskCount (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The task count.  

## See Also

### Reference

[TaskDetails Structure](taskdetails-structure-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
