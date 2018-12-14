---
title: HpcScheduler.StartJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: StartJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.StartJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.startjob(v=VS.90)
ms:contentKeyID: 35520573
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.StartJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.StartJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartJob Method

Starts the specified job using the HPC scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionStartJob ( _
    jobInstanceIdAsString _
) AsJobStatus
'Usage
DiminstanceAsHpcSchedulerDimjobInstanceIdAsStringDimreturnValueAsJobStatusreturnValue = instance.StartJob(jobInstanceId)
```

``` csharp
publicoverrideJobStatusStartJob(
    stringjobInstanceId
)
```

``` c++
public:
virtualJobStatusStartJob(
    String^ jobInstanceId
) override
```

``` fsharp
abstractStartJob : 
        jobInstanceId:string->JobStatusoverrideStartJob : 
        jobInstanceId:string->JobStatus
```

``` jscript
publicoverridefunctionStartJob(
    jobInstanceId : String
) : JobStatus
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status information about the job.  

## See Also

#### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

