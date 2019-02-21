---
title: TransformManagerService.DeleteJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJob(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.deletejob(v=VS.90)
ms:contentKeyID: 35521080
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJob
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DeleteJob Method

Deletes all input files, output files, and work item details for the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub DeleteJob ( _
    jobDetails As JobDetails _
)
'Usage

  Dim instance As TransformManagerService
Dim jobDetails As JobDetails

instance.DeleteJob(jobDetails)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void DeleteJob(
    JobDetails jobDetails
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void DeleteJob(
    JobDetails^ jobDetails
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract DeleteJob : 
        jobDetails:JobDetails -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override DeleteJob : 
        jobDetails:JobDetails -> unit 
```

```jscript
  public final function DeleteJob(
    jobDetails : JobDetails
)
```

### Parameters

  - jobDetails  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    An object that contains the ID of the job to delete.  

### Implements

[IMonitoringService.DeleteJob(JobDetails)](imonitoringservice-deletejob-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

