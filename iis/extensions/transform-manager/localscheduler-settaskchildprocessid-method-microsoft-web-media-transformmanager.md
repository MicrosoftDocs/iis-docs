---
title: LocalScheduler.SetTaskChildProcessId Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetTaskChildProcessId Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskChildProcessId(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.settaskchildprocessid(v=VS.90)
ms:contentKeyID: 35520854
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskChildProcessId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.SetTaskChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetTaskChildProcessId Method

Sets the ID of the child process for a task that is an executable by using the specified job and child process.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Overrides Sub SetTaskChildProcessId ( _
    jobInstanceId As String, _
    childProcessId As Integer _
)
'Usage

  Dim instance As LocalScheduler
Dim jobInstanceId As String
Dim childProcessId As Integer

instance.SetTaskChildProcessId(jobInstanceId, _
    childProcessId)
```

``` csharp
  public override void SetTaskChildProcessId(
    string jobInstanceId,
    int childProcessId
)
```

``` c++
  public:
virtual void SetTaskChildProcessId(
    String^ jobInstanceId, 
    int childProcessId
) override
```

``` fsharp
  abstract SetTaskChildProcessId : 
        jobInstanceId:string * 
        childProcessId:int -> unit 
override SetTaskChildProcessId : 
        jobInstanceId:string * 
        childProcessId:int -> unit 
```

``` jscript
  public override function SetTaskChildProcessId(
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

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

