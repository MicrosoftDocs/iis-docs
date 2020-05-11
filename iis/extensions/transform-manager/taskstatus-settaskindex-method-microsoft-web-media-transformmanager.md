---
title: TaskStatus.SetTaskIndex Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskIndex Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskIndex(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskstatus.settaskindex(v=VS.90)
ms:contentKeyID: 35521180
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskIndex
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskIndex
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetTaskIndex Method

Sets the index of the task to be performed by the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub SetTaskIndex ( _
    taskIndex As Integer _
)
'Usage

  Dim instance As TaskStatus
Dim taskIndex As Integer

instance.SetTaskIndex(taskIndex)
```

```csharp
  public void SetTaskIndex(
    int taskIndex
)
```

```cpp
  public:
void SetTaskIndex(
    int taskIndex
)
```

``` fsharp
  member SetTaskIndex : 
        taskIndex:int -> unit 
```

```jscript
  public function SetTaskIndex(
    taskIndex : int
)
```

### Parameters

  - taskIndex  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The index of the task.  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
