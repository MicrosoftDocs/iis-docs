---
title: IMonitoringService.GetCumulativeJobCountByStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetCumulativeJobCountByStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetCumulativeJobCountByStatus(Microsoft.Web.Media.TransformManager.JobStatus)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imonitoringservice.getcumulativejobcountbystatus(v=VS.90)
ms:contentKeyID: 46408309
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetCumulativeJobCountByStatus
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetCumulativeJobCountByStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetCumulativeJobCountByStatus Method

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
FunctionGetCumulativeJobCountByStatus ( _
    statusAsJobStatus _
) AsInteger
'Usage
DiminstanceAsIMonitoringServiceDimstatusAsJobStatusDimreturnValueAsIntegerreturnValue = instance.GetCumulativeJobCountByStatus(status)
```

``` csharp
[OperationContractAttribute]
intGetCumulativeJobCountByStatus(
    JobStatusstatus
)
```

``` c++
[OperationContractAttribute]
intGetCumulativeJobCountByStatus(
    JobStatusstatus
)
```

``` fsharp
[<OperationContractAttribute>]
abstractGetCumulativeJobCountByStatus : 
        status:JobStatus->int
```

``` jscript
functionGetCumulativeJobCountByStatus(
    status : JobStatus
) : int
```

#### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

## See Also

#### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

