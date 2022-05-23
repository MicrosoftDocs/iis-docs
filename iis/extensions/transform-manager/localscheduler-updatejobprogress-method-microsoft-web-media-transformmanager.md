---
title: LocalScheduler.UpdateJobProgress Method  (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax and parameters for the LocalScheduler.UpdateJobProgress, with links to reference materials.
TOCTitle: UpdateJobProgress Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.UpdateJobProgress(System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.localscheduler.updatejobprogress(v=VS.90)
ms:contentKeyID: 35521052
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.UpdateJobProgress
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.UpdateJobProgress
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UpdateJobProgress Method

Updates the percentage complete of the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub UpdateJobProgress ( _
    jobInstanceId As String, _
    percentComplete As Integer _
)
'Usage

  Dim instance As LocalScheduler
Dim jobInstanceId As String
Dim percentComplete As Integer

instance.UpdateJobProgress(jobInstanceId, _
    percentComplete)
```

```csharp
  public override void UpdateJobProgress(
    string jobInstanceId,
    int percentComplete
)
```

```cpp
  public:
virtual void UpdateJobProgress(
    String^ jobInstanceId, 
    int percentComplete
) override
```

``` fsharp
  abstract UpdateJobProgress : 
        jobInstanceId:string * 
        percentComplete:int -> unit 
override UpdateJobProgress : 
        jobInstanceId:string * 
        percentComplete:int -> unit 
```

```jscript
  public override function UpdateJobProgress(
    jobInstanceId : String, 
    percentComplete : int
)
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

<!-- end list -->

  - percentComplete  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The percentage complete of the job.  

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
