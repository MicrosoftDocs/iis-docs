---
title: Scheduler.GetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.GetTaskChildProcessId(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.gettaskchildprocessid(v=VS.90)
ms:contentKeyID: 35521061
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.GetTaskChildProcessId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.GetTaskChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetTaskChildProcessId Method

Returns the ID of the child process of an executable program by using the specified job instance ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionGetTaskChildProcessId ( _
    jobInstanceIdAsString _
) AsInteger
'Usage
DiminstanceAsSchedulerDimjobInstanceIdAsStringDimreturnValueAsIntegerreturnValue = instance.GetTaskChildProcessId(jobInstanceId)
```

``` csharp
publicabstractintGetTaskChildProcessId(
    stringjobInstanceId
)
```

``` c++
public:
virtualintGetTaskChildProcessId(
    String^ jobInstanceId
) abstract
```

``` fsharp
abstractGetTaskChildProcessId : 
        jobInstanceId:string->int
```

``` jscript
publicabstractfunctionGetTaskChildProcessId(
    jobInstanceId : String
) : int
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The ID of a child process of a task.  

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

