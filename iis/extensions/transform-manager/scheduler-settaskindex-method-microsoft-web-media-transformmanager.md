---
title: Scheduler.SetTaskIndex Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskIndex Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.SetTaskIndex(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.settaskindex(v=VS.90)
ms:contentKeyID: 35520675
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.SetTaskIndex
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.SetTaskIndex
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetTaskIndex Method

Sets the index of a task for the scheduler by using the specified job and task index.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub SetTaskIndex ( _
    jobInstanceId As String, _
    taskIndex As Integer _
)
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String
Dim taskIndex As Integer

instance.SetTaskIndex(jobInstanceId, _
    taskIndex)
```

```csharp
  public abstract void SetTaskIndex(
    string jobInstanceId,
    int taskIndex
)
```

```cpp
  public:
virtual void SetTaskIndex(
    String^ jobInstanceId, 
    int taskIndex
) abstract
```

``` fsharp
  abstract SetTaskIndex : 
        jobInstanceId:string * 
        taskIndex:int -> unit 
```

```jscript
  public abstract function SetTaskIndex(
    jobInstanceId : String, 
    taskIndex : int
)
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

<!-- end list -->

  - taskIndex  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The task index.  

## Remarks

The task index is used to calculate overall job progress.

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
