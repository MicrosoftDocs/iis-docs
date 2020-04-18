---
title: HpcScheduler.CancelJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CancelJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.CancelJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.hpcscheduler.canceljob(v=VS.90)
ms:contentKeyID: 35520570
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CancelJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.CancelJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CancelJob Method

Cancels the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Function CancelJob ( _
    jobInstanceId As String _
) As JobStatus
'Usage

  Dim instance As HpcScheduler
Dim jobInstanceId As String
Dim returnValue As JobStatus

returnValue = instance.CancelJob(jobInstanceId)
```

```csharp
  public override JobStatus CancelJob(
    string jobInstanceId
)
```

```cpp
  public:
virtual JobStatus CancelJob(
    String^ jobInstanceId
) override
```

``` fsharp
  abstract CancelJob : 
        jobInstanceId:string -> JobStatus 
override CancelJob : 
        jobInstanceId:string -> JobStatus 
```

```jscript
  public override function CancelJob(
    jobInstanceId : String
) : JobStatus
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job to cancel.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The job status.  

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
