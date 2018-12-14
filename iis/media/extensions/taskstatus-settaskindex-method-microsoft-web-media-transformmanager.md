---
title: TaskStatus.SetTaskIndex Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskIndex Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskIndex(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.settaskindex(v=VS.90)
ms:contentKeyID: 35521180
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskIndex
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskIndex Method

Sets the index of the task to be performed by the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubSetTaskIndex ( _
    taskIndexAsInteger _
)
'Usage
DiminstanceAsTaskStatusDimtaskIndexAsInteger

instance.SetTaskIndex(taskIndex)
```

``` csharp
publicvoidSetTaskIndex(
    inttaskIndex
)
```

``` c++
public:
voidSetTaskIndex(
    inttaskIndex
)
```

``` fsharp
memberSetTaskIndex : 
        taskIndex:int->unit
```

``` jscript
publicfunctionSetTaskIndex(
    taskIndex : int
)
```

#### Parameters

  - taskIndex  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The index of the task.  

## See Also

#### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

