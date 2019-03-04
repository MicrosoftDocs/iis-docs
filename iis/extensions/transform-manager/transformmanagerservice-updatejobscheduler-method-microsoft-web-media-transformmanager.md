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
- csharp
- jscript
- vb
- FSharp
- cpp
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

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub UpdateJobScheduler ( _
    scheduler As JobScheduler _
)
'Usage

  Dim instance As TransformManagerService
Dim scheduler As JobScheduler

instance.UpdateJobScheduler(scheduler)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void UpdateJobScheduler(
    JobScheduler scheduler
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void UpdateJobScheduler(
    JobScheduler^ scheduler
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract UpdateJobScheduler : 
        scheduler:JobScheduler -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override UpdateJobScheduler : 
        scheduler:JobScheduler -> unit 
```

```jscript
  public final function UpdateJobScheduler(
    scheduler : JobScheduler
)
```

### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager.JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    A new or updated [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object to add or update.  

### Implements

[IManagementService.UpdateJobScheduler(JobScheduler)](imanagementservice-updatejobscheduler-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

