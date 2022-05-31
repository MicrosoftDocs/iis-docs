---
title: Scheduler.SubmitJob Method  (Microsoft.Web.Media.TransformManager)
description: Learn how the SubmitJob method submits the job to the scheduler, as well as details about its syntax and property value.
TOCTitle: SubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.SubmitJob(Microsoft.Web.Media.TransformManager.JobManifest)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.submitjob(v=VS.90)
ms:contentKeyID: 35520711
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.SubmitJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.SubmitJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SubmitJob Method

Submits the job to the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Function SubmitJob ( _
    manifest As JobManifest _
) As JobStatus
'Usage

  Dim instance As Scheduler
Dim manifest As JobManifest
Dim returnValue As JobStatus

returnValue = instance.SubmitJob(manifest)
```

```csharp
  public abstract JobStatus SubmitJob(
    JobManifest manifest
)
```

```cpp
  public:
virtual JobStatus SubmitJob(
    JobManifest^ manifest
) abstract
```

``` fsharp
  abstract SubmitJob : 
        manifest:JobManifest -> JobStatus 
```

```jscript
  public abstract function SubmitJob(
    manifest : JobManifest
) : JobStatus
```

### Parameters

  - manifest  
    Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
    A [JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md) object that contains details about the job.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status information about the job.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
