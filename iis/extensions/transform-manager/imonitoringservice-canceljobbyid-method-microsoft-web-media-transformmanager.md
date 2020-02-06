---
title: IMonitoringService.CancelJobById Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CancelJobById Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.CancelJobById(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.canceljobbyid(v=VS.90)
ms:contentKeyID: 35521145
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.CancelJobById
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.CancelJobById
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CancelJobById Method

Cancels a job that is represented by the specified job ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function CancelJobById ( _
    jobId As String _
) As JobStatus
'Usage

  Dim instance As IMonitoringService
Dim jobId As String
Dim returnValue As JobStatus

returnValue = instance.CancelJobById(jobId)
```

```csharp
[OperationContractAttribute]
JobStatus CancelJobById(
    string jobId
)
```

```cpp
[OperationContractAttribute]
JobStatus CancelJobById(
    String^ jobId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract CancelJobById : 
        jobId:string -> JobStatus 
```

```jscript
  function CancelJobById(
    jobId : String
) : JobStatus
```

### Parameters

  - jobId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job to cancel.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the action.  

## Remarks

The job can be canceled when it is either running or queued (submitted but not yet started). The method will usually return "Cancelled", but other possible values are "Finished" and "Failed". These other return values can occur if the job reaches these states before the cancel command reaches the scheduler.

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

