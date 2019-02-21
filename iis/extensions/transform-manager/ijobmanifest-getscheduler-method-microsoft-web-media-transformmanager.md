---
title: IJobManifest.GetScheduler Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetScheduler Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IJobManifest.GetScheduler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmanifest.getscheduler(v=VS.90)
ms:contentKeyID: 35520741
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobManifest.GetScheduler
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobManifest.GetScheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetScheduler Method

Returns a job scheduler object by searching the job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Function GetScheduler As Scheduler
'Usage

  Dim instance As IJobManifest
Dim returnValue As Scheduler

returnValue = instance.GetScheduler()
```

```csharp
  Scheduler GetScheduler()
```

```cpp
  Scheduler^ GetScheduler()
```

``` fsharp
  abstract GetScheduler : unit -> Scheduler 
```

```jscript
  function GetScheduler() : Scheduler
```

### Return Value

Type: [Microsoft.Web.Media.TransformManager.Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
The job scheduler object.  

## See Also

### Reference

[IJobManifest Interface](ijobmanifest-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

