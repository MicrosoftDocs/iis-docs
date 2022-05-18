---
title: LocalScheduler.StartJob Method  (Microsoft.Web.Media.TransformManager)
description: This article contains syntax for the StartJob Method, as well as links to additional reference materials. 
TOCTitle: StartJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.StartJob(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.localscheduler.startjob(v=VS.90)
ms:contentKeyID: 35520955
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.StartJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.StartJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StartJob Method

Starts the specified job using the local scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Function StartJob ( _
    jobInstanceId As String _
) As JobStatus
'Usage

  Dim instance As LocalScheduler
Dim jobInstanceId As String
Dim returnValue As JobStatus

returnValue = instance.StartJob(jobInstanceId)
```

```csharp
  public override JobStatus StartJob(
    string jobInstanceId
)
```

```cpp
  public:
virtual JobStatus StartJob(
    String^ jobInstanceId
) override
```

``` fsharp
  abstract StartJob : 
        jobInstanceId:string -> JobStatus 
override StartJob : 
        jobInstanceId:string -> JobStatus 
```

```jscript
  public override function StartJob(
    jobInstanceId : String
) : JobStatus
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The status information about the job.  

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
