---
title: LocalScheduler.SetTaskCount Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskCount Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskCount(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.settaskcount(v=VS.90)
ms:contentKeyID: 35521094
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskCount
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskCount
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskCount Method

Sets the task count for the local scheduler by using the specified job and task count.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubSetTaskCount ( _
    jobInstanceIdAsString, _
    taskCountAsInteger _
)
'Usage
DiminstanceAsLocalSchedulerDimjobInstanceIdAsStringDimtaskCountAsInteger

instance.SetTaskCount(jobInstanceId, _
    taskCount)
```

``` csharp
publicoverridevoidSetTaskCount(
    stringjobInstanceId,
    inttaskCount
)
```

``` c++
public:
virtualvoidSetTaskCount(
    String^ jobInstanceId, 
    inttaskCount
) override
```

``` fsharp
abstractSetTaskCount : 
        jobInstanceId:string * 
        taskCount:int->unitoverrideSetTaskCount : 
        jobInstanceId:string * 
        taskCount:int->unit
```

``` jscript
publicoverridefunctionSetTaskCount(
    jobInstanceId : String, 
    taskCount : int
)
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

<!-- end list -->

  - taskCount  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The number of tasks.  

## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

