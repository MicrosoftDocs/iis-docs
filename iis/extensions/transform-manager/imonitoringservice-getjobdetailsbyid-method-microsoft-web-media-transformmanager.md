---
title: IMonitoringService.GetJobDetailsById Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetailsById Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetailsById(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.getjobdetailsbyid(v=VS.90)
ms:contentKeyID: 35521121
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetailsById
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetailsById
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobDetailsById Method

Returns a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object for a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetJobDetailsById ( _
    jobId As String _
) As JobDetails
'Usage

  Dim instance As IMonitoringService
Dim jobId As String
Dim returnValue As JobDetails

returnValue = instance.GetJobDetailsById(jobId)
```

```csharp
[OperationContractAttribute]
JobDetails GetJobDetailsById(
    string jobId
)
```

```cpp
[OperationContractAttribute]
JobDetails^ GetJobDetailsById(
    String^ jobId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobDetailsById : 
        jobId:string -> JobDetails 
```

```jscript
  function GetJobDetailsById(
    jobId : String
) : JobDetails
```

### Parameters

  - jobId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job to return details for.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
