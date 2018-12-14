---
title: TransformManagerService.CancelJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CancelJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.CancelJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.canceljob(v=VS.90)
ms:contentKeyID: 35520797
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.CancelJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.CancelJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CancelJob Method

Cancels a job that is represented by the specified job ID and work queue name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionCancelJob ( _
    jobDetailsAsJobDetails _
) AsJobStatus
'Usage
DiminstanceAsTransformManagerServiceDimjobDetailsAsJobDetailsDimreturnValueAsJobStatusreturnValue = instance.CancelJob(jobDetails)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicJobStatusCancelJob(
    JobDetailsjobDetails
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualJobStatusCancelJob(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractCancelJob : 
        jobDetails:JobDetails->JobStatus 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideCancelJob : 
        jobDetails:JobDetails->JobStatus
```

``` jscript
publicfinalfunctionCancelJob(
    jobDetails : JobDetails
) : JobStatus
```

#### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job to cancel and the name of the work queue that the job is in.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
The [JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md) object that corresponds to the action.  

#### Implements

[IMonitoringService. . :: . .CancelJob(JobDetails)](imonitoringservice-canceljob-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

