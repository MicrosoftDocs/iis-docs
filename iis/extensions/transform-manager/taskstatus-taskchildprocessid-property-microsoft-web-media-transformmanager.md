---
title: TaskStatus.TaskChildProcessId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskChildProcessId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskStatus.TaskChildProcessId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.taskchildprocessid(v=VS.90)
ms:contentKeyID: 35520774
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskChildProcessId
- Microsoft.Web.Media.TransformManager.TaskStatus.get_TaskChildProcessId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_TaskChildProcessId
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskChildProcessId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskChildProcessId Property

Gets the ID of the child process of the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property TaskChildProcessId As Integer
    Get
'Usage

  Dim instance As TaskStatus
Dim value As Integer

value = instance.TaskChildProcessId
```

```csharp
  public int TaskChildProcessId { get; }
```

```cpp
  public:
property int TaskChildProcessId {
    int get ();
}
```

``` fsharp
  member TaskChildProcessId : int
```

```jscript
  function get TaskChildProcessId () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The ID of the child process of the task.  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

