---
title: JobManifest.GetSchedulerInfo Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetSchedulerInfo Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.GetSchedulerInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.getschedulerinfo(v=VS.90)
ms:contentKeyID: 35520989
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.GetSchedulerInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.GetSchedulerInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetSchedulerInfo Method

Returns scheduling information about a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Function GetSchedulerInfo As SchedulerInfo
'Usage

  Dim instance As JobManifest
Dim returnValue As SchedulerInfo

returnValue = instance.GetSchedulerInfo()
```

```csharp
  public SchedulerInfo GetSchedulerInfo()
```

```cpp
  public:
virtual SchedulerInfo^ GetSchedulerInfo() sealed
```

``` fsharp
  abstract GetSchedulerInfo : unit -> SchedulerInfo 
override GetSchedulerInfo : unit -> SchedulerInfo 
```

```jscript
  public final function GetSchedulerInfo() : SchedulerInfo
```

### Return Value

Type: [Microsoft.Web.Media.TransformManager.SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)  
A job scheduler object that provides scheduling information about a job.  

### Implements

[IJobManifest.GetSchedulerInfo() () () ()](ijobmanifest-getschedulerinfo-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

