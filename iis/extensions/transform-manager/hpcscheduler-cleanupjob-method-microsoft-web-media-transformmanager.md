---
title: HpcScheduler.CleanupJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.cleanupjob(v=VS.90)
ms:contentKeyID: 35520837
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupJob
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CleanupJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CleanupJob Method

Cleans up scheduler data structure artifacts.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub CleanupJob ( _
    jobInstanceId As String _
)
'Usage

  Dim instance As HpcScheduler
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

## Remarks

The CleanupJob(String) method is used by the [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) base class.

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

