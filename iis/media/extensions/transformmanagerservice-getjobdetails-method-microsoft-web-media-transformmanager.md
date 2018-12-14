---
title: TransformManagerService.GetJobDetails Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDetails Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetails(Microsoft.Web.Media.TransformManager.JobStatus,Microsoft.Web.Media.TransformManager.JobDetailsField,System.Boolean,System.Int32,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobdetails(v=VS.90)
ms:contentKeyID: 35521029
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetails
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobDetails
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobDetails Method

Returns a collection of job details based on the specified filter parameters.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobDetails ( _
    statusAsJobStatus, _
    sortFieldAsJobDetailsField, _
    ascendingAsBoolean, _
    startIndexAsInteger, _
    countAsInteger _
) AsCollection(OfJobDetails)
'Usage
DiminstanceAsTransformManagerServiceDimstatusAsJobStatusDimsortFieldAsJobDetailsFieldDimascendingAsBooleanDimstartIndexAsIntegerDimcountAsIntegerDimreturnValueAsCollection(OfJobDetails)

returnValue = instance.GetJobDetails(status, _
    sortField, ascending, startIndex, _
    count)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCollection<JobDetails> GetJobDetails(
    JobStatusstatus,
    JobDetailsFieldsortField,
    boolascending,
    intstartIndex,
    intcount
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCollection<JobDetails^>^ GetJobDetails(
    JobStatusstatus, 
    JobDetailsFieldsortField, 
    boolascending, 
    intstartIndex, 
    intcount
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobDetails : 
        status:JobStatus * 
        sortField:JobDetailsField * 
        ascending:bool * 
        startIndex:int * 
        count:int->Collection<JobDetails> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobDetails : 
        status:JobStatus * 
        sortField:JobDetailsField * 
        ascending:bool * 
        startIndex:int * 
        count:int->Collection<JobDetails> 
```

``` jscript
publicfinalfunctionGetJobDetails(
    status : JobStatus, 
    sortField : JobDetailsField, 
    ascending : boolean, 
    startIndex : int, 
    count : int
) : Collection<JobDetails>
```

#### Parameters

  - status  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The job status that is used to filter job details.  

<!-- end list -->

  - sortField  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetailsField](jobdetailsfield-enumeration-microsoft-web-media-transformmanager.md)  
    The field that is used to sort job detail results by.  

<!-- end list -->

  - ascending  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    true to specify that the job detail results are returned in ascending order; false to specify that they are returned in descending order.  

<!-- end list -->

  - startIndex  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The index of the first record of sorted results to return.  

<!-- end list -->

  - count  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The number of records to return.  

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of job details.  

#### Implements

[IMonitoringService. . :: . .GetJobDetails(JobStatus, JobDetailsField, Boolean, Int32, Int32)](imonitoringservice-getjobdetails-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

