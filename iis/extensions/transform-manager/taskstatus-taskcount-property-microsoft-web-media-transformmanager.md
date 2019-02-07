---
title: TaskStatus.TaskCount Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskCount Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskStatus.TaskCount
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.taskcount(v=VS.90)
ms:contentKeyID: 35521127
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_TaskCount
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskCount
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.get_TaskCount
- Microsoft.Web.Media.TransformManager.TaskStatus.TaskCount
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskCount Property

Gets the task count.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property TaskCount As Integer
    Get
'Usage

  Dim instance As TaskStatus
Dim value As Integer

value = instance.TaskCount
```

``` csharp
  public int TaskCount { get; }
```

``` c++
  public:
property int TaskCount {
    int get ();
}
```

``` fsharp
  member TaskCount : int
```

``` jscript
  function get TaskCount () : int
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The task count.  

## See Also

#### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

