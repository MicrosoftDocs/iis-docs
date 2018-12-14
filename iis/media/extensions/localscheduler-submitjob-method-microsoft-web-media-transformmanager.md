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
- CSharp
- JScript
- VB
- FSharp
- c++
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

``` vb
'Declaration
PublicOverridesFunctionSubmitJob ( _
    manifestAsJobManifest _
) AsJobStatus
'Usage
DiminstanceAsLocalSchedulerDimmanifestAsJobManifestDimreturnValueAsJobStatusreturnValue = instance.SubmitJob(manifest)
```

``` csharp
publicoverrideJobStatusSubmitJob(
    JobManifestmanifest
)
```

``` c++
public:
virtualJobStatusSubmitJob(
    JobManifest^ manifest
) override
```

``` fsharp
abstractSubmitJob : 
        manifest:JobManifest->JobStatusoverrideSubmitJob : 
        manifest:JobManifest->JobStatus
```

``` jscript
publicoverridefunctionSubmitJob(
    manifest : JobManifest
) : JobStatus
```

#### Parameters

  - manifest  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
    A [JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md) object that contains details of the job.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status information about the job.  

## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

