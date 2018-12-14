---
title: Scheduler.SetTaskIndex Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskIndex Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.SetTaskIndex(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.settaskindex(v=VS.90)
ms:contentKeyID: 35520675
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.SetTaskIndex
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.SetTaskIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskIndex Method

Sets the index of a task for the scheduler by using the specified job and task index.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubSetTaskIndex ( _
    jobInstanceIdAsString, _
    taskIndexAsInteger _
)
'Usage
DiminstanceAsSchedulerDimjobInstanceIdAsStringDimtaskIndexAsInteger

instance.SetTaskIndex(jobInstanceId, _
    taskIndex)
```

``` csharp
publicabstractvoidSetTaskIndex(
    stringjobInstanceId,
    inttaskIndex
)
```

``` c++
public:
virtualvoidSetTaskIndex(
    String^ jobInstanceId, 
    inttaskIndex
) abstract
```

``` fsharp
abstractSetTaskIndex : 
        jobInstanceId:string * 
        taskIndex:int->unit
```

``` jscript
publicabstractfunctionSetTaskIndex(
    jobInstanceId : String, 
    taskIndex : int
)
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

<!-- end list -->

  - taskIndex  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The task index.  

## Remarks

The task index is used to calculate overall job progress.

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

