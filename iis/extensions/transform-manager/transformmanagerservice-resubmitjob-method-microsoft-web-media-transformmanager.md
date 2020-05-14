---
title: TransformManagerService.ResubmitJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: ResubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.ResubmitJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.resubmitjob(v=VS.90)
ms:contentKeyID: 35521168
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.ResubmitJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.ResubmitJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ResubmitJob Method

Moves a job to the configuring queue where it can be resubmitted.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub ResubmitJob ( _
    jobDetails As JobDetails _
)
'Usage

  Dim instance As TransformManagerService
Dim jobDetails As JobDetails

instance.ResubmitJob(jobDetails)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void ResubmitJob(
    JobDetails jobDetails
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void ResubmitJob(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract ResubmitJob :
        jobDetails:JobDetails -> unit
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override ResubmitJob :
        jobDetails:JobDetails -> unit
```

```jscript
  public final function ResubmitJob(
    jobDetails : JobDetails
)
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that is used to resubmit the job.  

### Implements

[IManagementService.ResubmitJob(JobDetails)](imanagementservice-resubmitjob-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
