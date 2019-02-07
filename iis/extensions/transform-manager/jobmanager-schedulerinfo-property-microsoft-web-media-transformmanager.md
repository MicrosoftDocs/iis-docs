---
title: JobManager.SchedulerInfo Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.SchedulerInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.schedulerinfo(v=VS.90)
ms:contentKeyID: 35521100
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_SchedulerInfo
- Microsoft.Web.Media.TransformManager.JobManager.SchedulerInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_SchedulerInfo
- Microsoft.Web.Media.TransformManager.JobManager.SchedulerInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerInfo Property

Gets scheduling information about the IIS Transform Manager job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property SchedulerInfo As SchedulerInfo
    Get
'Usage

  Dim instance As JobManager
Dim value As SchedulerInfo

value = instance.SchedulerInfo
```

``` csharp
  public SchedulerInfo SchedulerInfo { get; }
```

``` c++
  public:
property SchedulerInfo^ SchedulerInfo {
    SchedulerInfo^ get ();
}
```

``` fsharp
  member SchedulerInfo : SchedulerInfo
```

``` jscript
  function get SchedulerInfo () : SchedulerInfo
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)  
The scheduling information about the IIS Transform Manager job.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

