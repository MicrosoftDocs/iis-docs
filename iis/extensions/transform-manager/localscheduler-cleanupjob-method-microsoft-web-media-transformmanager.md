---
title: LocalScheduler.CleanupJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.cleanupjob(v=VS.90)
ms:contentKeyID: 35520620
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupJob
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CleanupJob Method

Removes scheduler artifacts for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub CleanupJob ( _
    jobInstanceId As String _
)
'Usage

  Dim instance As LocalScheduler
Dim jobInstanceId As String

instance.CleanupJob(jobInstanceId)
```

```csharp
  public override void CleanupJob(
    string jobInstanceId
)
```

```cpp
  public:
virtual void CleanupJob(
    String^ jobInstanceId
) override
```

``` fsharp
  abstract CleanupJob : 
        jobInstanceId:string -> unit 
override CleanupJob : 
        jobInstanceId:string -> unit 
```

```jscript
  public override function CleanupJob(
    jobInstanceId : String
)
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[FileLoadException](https://msdn.microsoft.com/library/99akez90)|The method was unable to load a file that was created by the task scheduler when a job was submitted.|
|[COMException](https://msdn.microsoft.com/library/02hkayhc)|The method was unable to complete the transaction that was originated by the task scheduler.|


## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

