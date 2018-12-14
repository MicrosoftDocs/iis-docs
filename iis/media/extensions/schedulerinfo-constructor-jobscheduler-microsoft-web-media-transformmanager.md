---
title: SchedulerInfo Constructor (JobScheduler) (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Constructor (JobScheduler)
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.#ctor(Microsoft.Web.Media.TransformManager.JobScheduler)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerinfo.schedulerinfo(v=VS.90)
ms:contentKeyID: 35520957
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerInfo Constructor (JobScheduler)

Initializes a new instance of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) class using the specified job scheduling information.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    schedulerAsJobScheduler _
)
'Usage
DimschedulerAsJobSchedulerDiminstanceAs NewSchedulerInfo(scheduler)
```

``` csharp
publicSchedulerInfo(
    JobSchedulerscheduler
)
```

``` c++
public:
SchedulerInfo(
    JobScheduler^ scheduler
)
```

``` fsharp
new : 
        scheduler:JobScheduler->SchedulerInfo
```

``` jscript
publicfunctionSchedulerInfo(
    scheduler : JobScheduler
)
```

#### Parameters

  - scheduler  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    A job scheduler that contains job details.  

## See Also

#### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[SchedulerInfo Overload](schedulerinfo-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

