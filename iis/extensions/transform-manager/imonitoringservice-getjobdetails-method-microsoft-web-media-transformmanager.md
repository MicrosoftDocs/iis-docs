---
title: IMonitoringService.GetJobDetails Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetails Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetails(Microsoft.Web.Media.TransformManager.JobStatus,Microsoft.Web.Media.TransformManager.JobDetailsField,System.Boolean,System.Int32,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imonitoringservice.getjobdetails(v=VS.90)
ms:contentKeyID: 35520869
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetails
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IMonitoringService.GetJobDetails
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobDetails Method

Returns a collection of job details based on the specified filter parameters.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetJobDetails ( _
    status As JobStatus, _
    sortField As JobDetailsField, _
    ascending As Boolean, _
    startIndex As Integer, _
    count As Integer _
) As Collection(Of JobDetails)
'Usage

  Dim instance As IMonitoringService
Dim status As JobStatus
Dim sortField As JobDetailsField
Dim ascending As Boolean
Dim startIndex As Integer
Dim count As Integer
Dim returnValue As Collection(Of JobDetails)

returnValue = instance.GetJobDetails(status, _
    sortField, ascending, startIndex, _
    count)
```

```csharp
[OperationContractAttribute]
Collection<JobDetails> GetJobDetails(
    JobStatus status,
    JobDetailsField sortField,
    bool ascending,
    int startIndex,
    int count
)
```

```cpp
[OperationContractAttribute]
Collection<JobDetails^>^ GetJobDetails(
    JobStatus status, 
    JobDetailsField sortField, 
    bool ascending, 
    int startIndex, 
    int count
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobDetails : 
        status:JobStatus * 
        sortField:JobDetailsField * 
        ascending:bool * 
        startIndex:int * 
        count:int -> Collection<JobDetails> 
```

```jscript
  function GetJobDetails(
    status : JobStatus, 
    sortField : JobDetailsField, 
    ascending : boolean, 
    startIndex : int, 
    count : int
) : Collection<JobDetails>
```

### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The job status that is used to filter job details.  

<!-- end list -->

  - sortField  
    Type: [Microsoft.Web.Media.TransformManager.JobDetailsField](jobdetailsfield-enumeration-microsoft-web-media-transformmanager.md)  
    The field that is used to sort job detail results by.  

<!-- end list -->

  - ascending  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to specify that the job detail results are returned in ascending order; false to specify that they are returned in descending order.  

<!-- end list -->

  - startIndex  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The index of the first record of sorted results to return.  

<!-- end list -->

  - count  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    The number of records to return.  

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details.  

## See Also

### Reference

[IMonitoringService Interface](imonitoringservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
