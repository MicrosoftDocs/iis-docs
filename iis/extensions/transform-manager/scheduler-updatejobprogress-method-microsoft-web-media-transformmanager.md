---
title: Scheduler.UpdateJobProgress Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobProgress Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.UpdateJobProgress(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.updatejobprogress(v=VS.90)
ms:contentKeyID: 35521091
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.UpdateJobProgress
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.UpdateJobProgress
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UpdateJobProgress Method

Updates the progress of the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub UpdateJobProgress ( _
    jobInstanceId As String, _
    percentComplete As Integer _
)
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String
Dim percentComplete As Integer

instance.UpdateJobProgress(jobInstanceId, _
    percentComplete)
```

```csharp
  public abstract void UpdateJobProgress(
    string jobInstanceId,
    int percentComplete
)
```

```cpp
  public:
virtual void UpdateJobProgress(
    String^ jobInstanceId, 
    int percentComplete
) abstract
```

``` fsharp
  abstract UpdateJobProgress : 
        jobInstanceId:string * 
        percentComplete:int -> unit 
```

```jscript
  public abstract function UpdateJobProgress(
    jobInstanceId : String, 
    percentComplete : int
)
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

<!-- end list -->

  - percentComplete  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    A value that specifies the percentage complete of a job.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
