---
title: IMonitoringService.GetJobCountByStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobCountByStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobCountByStatus(Microsoft.Web.Media.TransformManager.JobStatus)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.getjobcountbystatus(v=VS.90)
ms:contentKeyID: 35520762
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobCountByStatus
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobCountByStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobCountByStatus Method

Returns the number of jobs in each job state.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
FunctionGetJobCountByStatus ( _
    statusAsJobStatus _
) AsInteger
'Usage
DiminstanceAsIMonitoringServiceDimstatusAsJobStatusDimreturnValueAsIntegerreturnValue = instance.GetJobCountByStatus(status)
```

``` csharp
[OperationContractAttribute]
intGetJobCountByStatus(
    JobStatusstatus
)
```

``` c++
[OperationContractAttribute]
intGetJobCountByStatus(
    JobStatusstatus
)
```

``` fsharp
[<OperationContractAttribute>]
abstractGetJobCountByStatus : 
        status:JobStatus->int
```

``` jscript
functionGetJobCountByStatus(
    status : JobStatus
) : int
```

#### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The state of the jobs to count.  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The number of jobs that correspond to the specified state.  

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

