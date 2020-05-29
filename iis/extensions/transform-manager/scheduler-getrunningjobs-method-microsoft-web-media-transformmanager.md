---
title: Scheduler.GetRunningJobs Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetRunningJobs Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.GetRunningJobs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.getrunningjobs(v=VS.90)
ms:contentKeyID: 35520596
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.GetRunningJobs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.GetRunningJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetRunningJobs Method

Returns a list of job instance IDs for jobs that are running.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Function GetRunningJobs As ICollection(Of String)
'Usage

  Dim instance As Scheduler
Dim returnValue As ICollection(Of String)

returnValue = instance.GetRunningJobs()
```

```csharp
  public abstract ICollection<string> GetRunningJobs()
```

```cpp
  public:
virtual ICollection<String^>^ GetRunningJobs() abstract
```

``` fsharp
  abstract GetRunningJobs : unit -> ICollection<string> 
```

```jscript
  public abstract function GetRunningJobs() : ICollection<String>
```

### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
A list of job instance IDs.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
