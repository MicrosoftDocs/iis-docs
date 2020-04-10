---
title: SchedulerInfo.ConcurrentJobs Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConcurrentJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.SchedulerInfo.ConcurrentJobs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.concurrentjobs(v=VS.90)
ms:contentKeyID: 35520572
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_ConcurrentJobs
- Microsoft.Web.Media.TransformManager.SchedulerInfo.ConcurrentJobs
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_ConcurrentJobs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.ConcurrentJobs
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_ConcurrentJobs
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_ConcurrentJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConcurrentJobs Property

Gets or sets the number of concurrent jobs that a job manager can start.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property ConcurrentJobs As Integer
    Get
    Set
'Usage

  Dim instance As SchedulerInfo
Dim value As Integer

value = instance.ConcurrentJobs

instance.ConcurrentJobs = value
```

```csharp
  public int ConcurrentJobs { get; set; }
```

```cpp
  public:
property int ConcurrentJobs {
    int get ();
    void set (int value);
}
```

``` fsharp
  member ConcurrentJobs : int with get, set
```

```jscript
  function get ConcurrentJobs () : int
function set ConcurrentJobs (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of concurrent jobs.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
