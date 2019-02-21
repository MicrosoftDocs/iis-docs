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
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
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
---

# SetTaskChildProcessId Method

Sets the ID of the child process of an executable program by using the specified job instance ID and child process ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub SetTaskChildProcessId ( _
    jobInstanceId As String, _
    childProcessId As Integer _
)
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String
Dim childProcessId As Integer

instance.SetTaskChildProcessId(jobInstanceId, _
    childProcessId)
```

```csharp
  public abstract void SetTaskChildProcessId(
    string jobInstanceId,
    int childProcessId
)
```

```cpp
  public:
virtual void SetTaskChildProcessId(
    String^ jobInstanceId, 
    int childProcessId
) abstract
```

``` fsharp
  abstract SetTaskChildProcessId : 
        jobInstanceId:string * 
        childProcessId:int -> unit 
```

```jscript
  public abstract function SetTaskChildProcessId(
    jobInstanceId : String, 
    childProcessId : int
)
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

<!-- end list -->

  - childProcessId  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The ID of the child process.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

