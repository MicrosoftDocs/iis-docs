---
title: TaskStatus.SetTaskCount Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskCount Method
description: "The TaskStatus.SetTaskCount method sets the number of tasks to be performed by the scheduler. This article describes its syntax and parameters."
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskCount(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskstatus.settaskcount(v=VS.90)
ms:contentKeyID: 35520577
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskCount
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskCount
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetTaskCount Method

Sets the number of tasks to be performed by the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub SetTaskCount ( _
    taskCount As Integer _
)
'Usage

  Dim instance As TaskStatus
Dim taskCount As Integer

instance.SetTaskCount(taskCount)
```

```csharp
  public void SetTaskCount(
    int taskCount
)
```

```cpp
  public:
void SetTaskCount(
    int taskCount
)
```

``` fsharp
  member SetTaskCount : 
        taskCount:int -> unit 
```

```jscript
  public function SetTaskCount(
    taskCount : int
)
```

### Parameters

  - taskCount  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The number of tasks to perform.  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
