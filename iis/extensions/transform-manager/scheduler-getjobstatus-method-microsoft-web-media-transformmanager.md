---
title: Scheduler.GetJobStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.GetJobStatus(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.getjobstatus(v=VS.90)
ms:contentKeyID: 35521000
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.GetJobStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.GetJobStatus
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobStatus Method

Returns the status of the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Function GetJobStatus ( _
    jobInstanceId As String _
) As JobStatus
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String
Dim returnValue As JobStatus

returnValue = instance.GetJobStatus(jobInstanceId)
```

```csharp
  public abstract JobStatus GetJobStatus(
    string jobInstanceId
)
```

```cpp
  public:
virtual JobStatus GetJobStatus(
    String^ jobInstanceId
) abstract
```

``` fsharp
  abstract GetJobStatus : 
        jobInstanceId:string -> JobStatus 
```

```jscript
  public abstract function GetJobStatus(
    jobInstanceId : String
) : JobStatus
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status of the job.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

