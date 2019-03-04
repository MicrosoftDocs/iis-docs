---
title: LocalScheduler.GetJobStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobStatus(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.getjobstatus(v=VS.90)
ms:contentKeyID: 35521193
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobStatus Method

Returns the status of the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Function GetJobStatus ( _
    jobInstanceId As String _
) As JobStatus
'Usage

  Dim instance As LocalScheduler
Dim jobInstanceId As String
Dim returnValue As JobStatus

returnValue = instance.GetJobStatus(jobInstanceId)
```

```csharp
  public override JobStatus GetJobStatus(
    string jobInstanceId
)
```

```cpp
  public:
virtual JobStatus GetJobStatus(
    String^ jobInstanceId
) override
```

``` fsharp
  abstract GetJobStatus : 
        jobInstanceId:string -> JobStatus 
override GetJobStatus : 
        jobInstanceId:string -> JobStatus 
```

```jscript
  public override function GetJobStatus(
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

## Exceptions

|Exception|Condition|
|--- |--- |
|[FileNotFoundException](https://msdn.microsoft.com/library/dzyy5k3x)|The method was unable to find a job file.|
|[FileLoadException](https://msdn.microsoft.com/library/99akez90)|The method was unable to load a file that was created by the task scheduler when a job was submitted.|
|[COMException](https://msdn.microsoft.com/library/02hkayhc)|The method was unable to complete the transaction that was originated by the task scheduler.|

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

