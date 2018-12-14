---
title: HpcScheduler.CleanupJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.cleanupjob(v=VS.90)
ms:contentKeyID: 35520837
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CleanupJob Method

Cleans up scheduler data structure artifacts.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubCleanupJob ( _
    jobInstanceIdAsString _
)
'Usage
DiminstanceAsHpcSchedulerDimjobInstanceIdAsString

instance.CleanupJob(jobInstanceId)
```

``` csharp
publicoverridevoidCleanupJob(
    stringjobInstanceId
)
```

``` c++
public:
virtualvoidCleanupJob(
    String^ jobInstanceId
) override
```

``` fsharp
abstractCleanupJob : 
        jobInstanceId:string->unitoverrideCleanupJob : 
        jobInstanceId:string->unit
```

``` jscript
publicoverridefunctionCleanupJob(
    jobInstanceId : String
)
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

## Remarks

The CleanupJob(String) method is used by the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) base class.

## See Also

#### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

