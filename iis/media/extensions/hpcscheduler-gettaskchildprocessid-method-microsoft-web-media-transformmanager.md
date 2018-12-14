---
title: HpcScheduler.GetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.GetTaskChildProcessId(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.gettaskchildprocessid(v=VS.90)
ms:contentKeyID: 35520917
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.GetTaskChildProcessId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.GetTaskChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetTaskChildProcessId Method

Returns the child process ID of a task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionGetTaskChildProcessId ( _
    jobInstanceIdAsString _
) AsInteger
'Usage
DiminstanceAsHpcSchedulerDimjobInstanceIdAsStringDimreturnValueAsIntegerreturnValue = instance.GetTaskChildProcessId(jobInstanceId)
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
The ID of the child process of a task that is an executable program.  

## See Also

#### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

