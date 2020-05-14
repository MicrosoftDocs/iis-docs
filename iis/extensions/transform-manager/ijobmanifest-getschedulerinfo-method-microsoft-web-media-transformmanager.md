---
title: IJobManifest.GetSchedulerInfo Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetSchedulerInfo Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IJobManifest.GetSchedulerInfo
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ijobmanifest.getschedulerinfo(v=VS.90)
ms:contentKeyID: 35520768
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobManifest.GetSchedulerInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobManifest.GetSchedulerInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetSchedulerInfo Method

Returns scheduler information by searching the job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Function GetSchedulerInfo As SchedulerInfo
'Usage

  Dim instance As IJobManifest
Dim returnValue As SchedulerInfo

returnValue = instance.GetSchedulerInfo()
```

```csharp
  SchedulerInfo GetSchedulerInfo()
```

```cpp
  SchedulerInfo^ GetSchedulerInfo()
```

``` fsharp
  abstract GetSchedulerInfo : unit -> SchedulerInfo
```

```jscript
  function GetSchedulerInfo() : SchedulerInfo
```

### Return Value

Type: [Microsoft.Web.Media.TransformManager.SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)  
The scheduler information.  

## See Also

### Reference

[IJobManifest Interface](ijobmanifest-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
