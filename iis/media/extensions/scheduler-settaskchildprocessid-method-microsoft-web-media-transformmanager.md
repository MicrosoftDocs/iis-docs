---
title: Scheduler.SetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.SetTaskChildProcessId(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.settaskchildprocessid(v=VS.90)
ms:contentKeyID: 35521137
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.SetTaskChildProcessId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.SetTaskChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskChildProcessId Method

Sets the ID of the child process of an executable program by using the specified job instance ID and child process ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubSetTaskChildProcessId ( _
    jobInstanceIdAsString, _
    childProcessIdAsInteger _
)
'Usage
DiminstanceAsSchedulerDimjobInstanceIdAsStringDimchildProcessIdAsInteger

instance.SetTaskChildProcessId(jobInstanceId, _
    childProcessId)
```

``` csharp
publicabstractvoidSetTaskChildProcessId(
    stringjobInstanceId,
    intchildProcessId
)
```

``` c++
public:
virtualvoidSetTaskChildProcessId(
    String^ jobInstanceId, 
    intchildProcessId
) abstract
```

``` fsharp
abstractSetTaskChildProcessId : 
        jobInstanceId:string * 
        childProcessId:int->unit
```

``` jscript
publicabstractfunctionSetTaskChildProcessId(
    jobInstanceId : String, 
    childProcessId : int
)
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

<!-- end list -->

  - childProcessId  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The ID of the child process.  

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

