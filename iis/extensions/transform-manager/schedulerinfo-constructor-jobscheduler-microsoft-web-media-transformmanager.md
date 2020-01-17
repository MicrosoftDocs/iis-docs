---
title: SchedulerInfo Constructor (JobScheduler) (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Constructor (JobScheduler)
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.#ctor(Microsoft.Web.Media.TransformManager.JobScheduler)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.schedulerinfo(v=VS.90)
ms:contentKeyID: 35520957
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerInfo Constructor (JobScheduler)

Initializes a new instance of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) class using the specified job scheduling information.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    scheduler As JobScheduler _
)
'Usage

  Dim scheduler As JobScheduler

Dim instance As New SchedulerInfo(scheduler)
```

```csharp
  public SchedulerInfo(
    JobScheduler scheduler
)
```

```cpp
  public:
SchedulerInfo(
    JobScheduler^ scheduler
)
```

``` fsharp
  new : 
        scheduler:JobScheduler -> SchedulerInfo
```

```jscript
  public function SchedulerInfo(
    scheduler : JobScheduler
)
```

### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager.JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    A job scheduler that contains job details.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[SchedulerInfo Overload](schedulerinfo-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

