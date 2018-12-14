---
title: TransformManagerService.UpdateJobScheduler Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobScheduler Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateJobScheduler(Microsoft.Web.Media.TransformManager.JobScheduler)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.updatejobscheduler(v=VS.90)
ms:contentKeyID: 35520769
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateJobScheduler
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.UpdateJobScheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateJobScheduler Method

Adds or updates the specified [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicSubUpdateJobScheduler ( _
    schedulerAsJobScheduler _
)
'Usage
DiminstanceAsTransformManagerServiceDimschedulerAsJobScheduler

instance.UpdateJobScheduler(scheduler)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicvoidUpdateJobScheduler(
    JobSchedulerscheduler
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualvoidUpdateJobScheduler(
    JobScheduler^ scheduler
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractUpdateJobScheduler : 
        scheduler:JobScheduler->unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideUpdateJobScheduler : 
        scheduler:JobScheduler->unit
```

``` jscript
publicfinalfunctionUpdateJobScheduler(
    scheduler : JobScheduler
)
```

#### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    A new or updated [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object to add or update.  

#### Implements

[IManagementService. . :: . .UpdateJobScheduler(JobScheduler)](imanagementservice-updatejobscheduler-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

