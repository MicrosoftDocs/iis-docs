---
title: LocalScheduler.GetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.GetTaskChildProcessId(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.gettaskchildprocessid(v=VS.90)
ms:contentKeyID: 35521170
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetTaskChildProcessId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetTaskChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetTaskChildProcessId Method

Returns the ID of the child process of a task that is an executable, using the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionGetTaskChildProcessId ( _
    jobInstanceIdAsString _
) AsInteger
'Usage
DiminstanceAsLocalSchedulerDimjobInstanceIdAsStringDimreturnValueAsIntegerreturnValue = instance.GetTaskChildProcessId(jobInstanceId)
```

``` csharp
publicoverrideintGetTaskChildProcessId(
    stringjobInstanceId
)
```

``` c++
public:
virtualintGetTaskChildProcessId(
    String^ jobInstanceId
) override
```

``` fsharp
abstractGetTaskChildProcessId : 
        jobInstanceId:string->intoverrideGetTaskChildProcessId : 
        jobInstanceId:string->int
```

``` jscript
publicoverridefunctionGetTaskChildProcessId(
    jobInstanceId : String
) : int
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The ID of a child process of a command-line task.  

## Remarks

If the current task is a command-line executable, the task engine creates a process to invoke the command. The ID of the child task is written into a user data store that is kept for all tasks.

## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

