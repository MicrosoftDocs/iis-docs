---
title: JobManifest.GetScheduler Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetScheduler Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.GetScheduler
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.getscheduler(v=VS.90)
ms:contentKeyID: 35520830
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.GetScheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.GetScheduler
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetScheduler Method

Creates and returns a new [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Function GetScheduler As Scheduler
'Usage

  Dim instance As JobManifest
Dim returnValue As Scheduler

returnValue = instance.GetScheduler()
```

```csharp
  public Scheduler GetScheduler()
```

```cpp
  public:
virtual Scheduler^ GetScheduler() sealed
```

``` fsharp
  abstract GetScheduler : unit -> Scheduler 
override GetScheduler : unit -> Scheduler 
```

```jscript
  public final function GetScheduler() : Scheduler
```

### Return Value

Type: [Microsoft.Web.Media.TransformManager.Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
A new job scheduler object.  

### Implements

[IJobManifest.GetScheduler() () () ()](ijobmanifest-getscheduler-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
