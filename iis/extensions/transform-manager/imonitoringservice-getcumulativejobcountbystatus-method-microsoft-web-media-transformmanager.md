---
title: IMonitoringService.GetCumulativeJobCountByStatus Method  (Microsoft.Web.Media.TransformManager)
description: Describes the GetCumulativeJobCountByStatus method and provides the method's namespace, assembly, syntax, and parameters.
TOCTitle: GetCumulativeJobCountByStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetCumulativeJobCountByStatus(Microsoft.Web.Media.TransformManager.JobStatus)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.getcumulativejobcountbystatus(v=VS.90)
ms:contentKeyID: 46408309
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetCumulativeJobCountByStatus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetCumulativeJobCountByStatus
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetCumulativeJobCountByStatus Method

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetCumulativeJobCountByStatus ( _
    status As JobStatus _
) As Integer
'Usage

  Dim instance As IMonitoringService
Dim status As JobStatus
Dim returnValue As Integer

returnValue = instance.GetCumulativeJobCountByStatus(status)
```

```csharp
[OperationContractAttribute]
int GetCumulativeJobCountByStatus(
    JobStatus status
)
```

```cpp
[OperationContractAttribute]
int GetCumulativeJobCountByStatus(
    JobStatus status
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetCumulativeJobCountByStatus : 
        status:JobStatus -> int 
```

```jscript
  function GetCumulativeJobCountByStatus(
    status : JobStatus
) : int
```

### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  

### Return Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
