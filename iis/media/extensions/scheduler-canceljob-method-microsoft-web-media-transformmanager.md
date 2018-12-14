---
title: Scheduler.CancelJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CancelJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.CancelJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.canceljob(v=VS.90)
ms:contentKeyID: 35521085
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.CancelJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.CancelJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CancelJob Method

Cancels the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionCancelJob ( _
    jobInstanceIdAsString _
) AsJobStatus
'Usage
DiminstanceAsSchedulerDimjobInstanceIdAsStringDimreturnValueAsJobStatusreturnValue = instance.CancelJob(jobInstanceId)
```

``` csharp
publicabstractJobStatusCancelJob(
    stringjobInstanceId
)
```

``` c++
public:
virtualJobStatusCancelJob(
    String^ jobInstanceId
) abstract
```

``` fsharp
abstractCancelJob : 
        jobInstanceId:string->JobStatus
```

``` jscript
publicabstractfunctionCancelJob(
    jobInstanceId : String
) : JobStatus
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status of the job.  

## Remarks

The CancelJob(String) method can return "Canceled", "Finished", "Failed", or "Unknown".

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

