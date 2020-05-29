---
title: Scheduler.CleanupJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.CleanupJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.cleanupjob(v=VS.90)
ms:contentKeyID: 35520639
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.CleanupJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.CleanupJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CleanupJob Method

Removes scheduler artifacts for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub CleanupJob ( _
    jobInstanceId As String _
)
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String

instance.CleanupJob(jobInstanceId)
```

```csharp
  public abstract void CleanupJob(
    string jobInstanceId
)
```

```cpp
  public:
virtual void CleanupJob(
    String^ jobInstanceId
) abstract
```

``` fsharp
  abstract CleanupJob : 
        jobInstanceId:string -> unit 
```

```jscript
  public abstract function CleanupJob(
    jobInstanceId : String
)
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

## Remarks

This method removes intrinsic job objects for jobs that are finished and removes any log information that might have been created.

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
