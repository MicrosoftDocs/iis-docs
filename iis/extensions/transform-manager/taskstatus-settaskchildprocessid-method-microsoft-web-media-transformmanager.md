---
title: TaskStatus.SetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskChildProcessId(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskstatus.settaskchildprocessid(v=VS.90)
ms:contentKeyID: 35520692
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskChildProcessId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskChildProcessId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetTaskChildProcessId Method

Sets the ID of the child process of the task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub SetTaskChildProcessId ( _
    childProcessId As Integer _
)
'Usage

  Dim instance As TaskStatus
Dim childProcessId As Integer

instance.SetTaskChildProcessId(childProcessId)
```

```csharp
  public void SetTaskChildProcessId(
    int childProcessId
)
```

```cpp
  public:
void SetTaskChildProcessId(
    int childProcessId
)
```

``` fsharp
  member SetTaskChildProcessId : 
        childProcessId:int -> unit 
```

```jscript
  public function SetTaskChildProcessId(
    childProcessId : int
)
```

### Parameters

  - childProcessId  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The ID of the child process.  

## See Also

### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
