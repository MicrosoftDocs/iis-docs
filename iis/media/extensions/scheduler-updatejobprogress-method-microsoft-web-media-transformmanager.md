---
title: Scheduler.UpdateJobProgress Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobProgress Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.UpdateJobProgress(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.updatejobprogress(v=VS.90)
ms:contentKeyID: 35521091
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.UpdateJobProgress
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.UpdateJobProgress
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateJobProgress Method

Updates the progress of the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubUpdateJobProgress ( _
    jobInstanceIdAsString, _
    percentCompleteAsInteger _
)
'Usage
DiminstanceAsSchedulerDimjobInstanceIdAsStringDimpercentCompleteAsInteger

instance.UpdateJobProgress(jobInstanceId, _
    percentComplete)
```

``` csharp
publicabstractvoidUpdateJobProgress(
    stringjobInstanceId,
    intpercentComplete
)
```

``` c++
public:
virtualvoidUpdateJobProgress(
    String^ jobInstanceId, 
    intpercentComplete
) abstract
```

``` fsharp
abstractUpdateJobProgress : 
        jobInstanceId:string * 
        percentComplete:int->unit
```

``` jscript
publicabstractfunctionUpdateJobProgress(
    jobInstanceId : String, 
    percentComplete : int
)
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

<!-- end list -->

  - percentComplete  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    A value that specifies the percentage complete of a job.  

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

