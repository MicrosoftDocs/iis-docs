---
title: Scheduler.GetTaskProgress Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetTaskProgress Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.GetTaskProgress(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.gettaskprogress(v=VS.90)
ms:contentKeyID: 35520595
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.GetTaskProgress
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.GetTaskProgress
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetTaskProgress Method

Returns task progress for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Function GetTaskProgress ( _
    jobInstanceId As String _
) As TaskDetails
'Usage

  Dim instance As Scheduler
Dim jobInstanceId As String
Dim returnValue As TaskDetails

returnValue = instance.GetTaskProgress(jobInstanceId)
```

```csharp
  public abstract TaskDetails GetTaskProgress(
    string jobInstanceId
)
```

```cpp
  public:
virtual TaskDetails GetTaskProgress(
    String^ jobInstanceId
) abstract
```

``` fsharp
  abstract GetTaskProgress : 
        jobInstanceId:string -> TaskDetails 
```

```jscript
  public abstract function GetTaskProgress(
    jobInstanceId : String
) : TaskDetails
```

### Parameters

  - jobInstanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.TaskDetails](taskdetails-structure-microsoft-web-media-transformmanager.md)  
The task progress.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

