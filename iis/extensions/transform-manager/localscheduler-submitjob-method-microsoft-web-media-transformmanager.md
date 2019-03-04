---
title: LocalScheduler.SubmitJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.SubmitJob(Microsoft.Web.Media.TransformManager.JobManifest)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.submitjob(v=VS.90)
ms:contentKeyID: 35521165
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SubmitJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SubmitJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SubmitJob Method

Submits a job manifest to the local scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Function SubmitJob ( _
    manifest As JobManifest _
) As JobStatus
'Usage

  Dim instance As LocalScheduler
Dim manifest As JobManifest
Dim returnValue As JobStatus

returnValue = instance.SubmitJob(manifest)
```

```csharp
  public override JobStatus SubmitJob(
    JobManifest manifest
)
```

```cpp
  public:
virtual JobStatus SubmitJob(
    JobManifest^ manifest
) override
```

``` fsharp
  abstract SubmitJob : 
        manifest:JobManifest -> JobStatus 
override SubmitJob : 
        manifest:JobManifest -> JobStatus 
```

```jscript
  public override function SubmitJob(
    manifest : JobManifest
) : JobStatus
```

### Parameters

  - manifest  
    Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
    A [JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md) object that contains details of the job.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status information about the job.  

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

