---
title: TaskStatus.SetTaskCount Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskCount Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskCount(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskstatus.settaskcount(v=VS.90)
ms:contentKeyID: 35520577
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskCount
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskStatus.SetTaskCount
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskCount Method

Sets the number of tasks to be performed by the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubSetTaskCount ( _
    taskCountAsInteger _
)
'Usage
DiminstanceAsTaskStatusDimtaskCountAsInteger

instance.SetTaskCount(taskCount)
```

``` csharp
publicvoidSetTaskCount(
    inttaskCount
)
```

``` c++
public:
voidSetTaskCount(
    inttaskCount
)
```

``` fsharp
memberSetTaskCount : 
        taskCount:int->unit
```

``` jscript
publicfunctionSetTaskCount(
    taskCount : int
)
```

#### Parameters

  - taskCount  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The number of tasks to perform.  

## See Also

#### Reference

[TaskStatus Class](taskstatus-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

