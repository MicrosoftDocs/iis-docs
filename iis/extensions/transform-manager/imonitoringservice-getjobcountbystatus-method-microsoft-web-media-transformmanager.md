---
title: IMonitoringService.GetJobCountByStatus Method  (Microsoft.Web.Media.TransformManager)
description: Describes the GetJobCountByStatus method and provides the method's namespace, assembly, syntax, parameters, and return value.
TOCTitle: GetJobCountByStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobCountByStatus(Microsoft.Web.Media.TransformManager.JobStatus)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.getjobcountbystatus(v=VS.90)
ms:contentKeyID: 35520762
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobCountByStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobCountByStatus
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobCountByStatus Method

Returns the number of jobs in each job state.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetJobCountByStatus ( _
    status As JobStatus _
) As Integer
'Usage

  Dim instance As IMonitoringService
Dim status As JobStatus
Dim returnValue As Integer

returnValue = instance.GetJobCountByStatus(status)
```

```csharp
[OperationContractAttribute]
int GetJobCountByStatus(
    JobStatus status
)
```

```cpp
[OperationContractAttribute]
int GetJobCountByStatus(
    JobStatus status
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobCountByStatus : 
        status:JobStatus -> int 
```

```jscript
  function GetJobCountByStatus(
    status : JobStatus
) : int
```

### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The state of the jobs to count.  

### Return Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of jobs that correspond to the specified state.  

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
