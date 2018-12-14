---
title: LocalScheduler.SetTaskIndex Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskIndex Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskIndex(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.settaskindex(v=VS.90)
ms:contentKeyID: 35520966
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskIndex
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskIndex Method

Sets the index of a task for the local scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubSetTaskIndex ( _
    jobInstanceIdAsString, _
    taskIndexAsInteger _
)
'Usage
DiminstanceAsLocalSchedulerDimjobInstanceIdAsStringDimtaskIndexAsInteger

instance.SetTaskIndex(jobInstanceId, _
    taskIndex)
```

``` csharp
publicoverridevoidSetTaskIndex(
    stringjobInstanceId,
    inttaskIndex
)
```

``` c++
public:
virtualvoidSetTaskIndex(
    String^ jobInstanceId, 
    inttaskIndex
) override
```

``` fsharp
abstractSetTaskIndex : 
        jobInstanceId:string * 
        taskIndex:int->unitoverrideSetTaskIndex : 
        jobInstanceId:string * 
        taskIndex:int->unit
```

``` jscript
publicoverridefunctionSetTaskIndex(
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

## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

