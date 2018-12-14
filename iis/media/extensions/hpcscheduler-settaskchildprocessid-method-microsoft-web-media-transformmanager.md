---
title: HpcScheduler.SetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.SetTaskChildProcessId(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.settaskchildprocessid(v=VS.90)
ms:contentKeyID: 35521140
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.SetTaskChildProcessId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.SetTaskChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskChildProcessId Method

Sets the child process ID of a child task that is an executable program for the HPC scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubSetTaskChildProcessId ( _
    jobInstanceIdAsString, _
    childProcessIdAsInteger _
)
'Usage
DiminstanceAsHpcSchedulerDimjobInstanceIdAsStringDimchildProcessIdAsInteger

instance.SetTaskChildProcessId(jobInstanceId, _
    childProcessId)
```

``` csharp
publicoverridevoidSetTaskChildProcessId(
    stringjobInstanceId,
    intchildProcessId
)
```

``` c++
public:
virtualvoidSetTaskChildProcessId(
    String^ jobInstanceId, 
    intchildProcessId
) override
```

``` fsharp
abstractSetTaskChildProcessId : 
        jobInstanceId:string * 
        childProcessId:int->unitoverrideSetTaskChildProcessId : 
        jobInstanceId:string * 
        childProcessId:int->unit
```

``` jscript
publicoverridefunctionSetTaskChildProcessId(
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

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

