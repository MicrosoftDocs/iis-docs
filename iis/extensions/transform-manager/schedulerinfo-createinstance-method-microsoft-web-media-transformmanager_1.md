---
title: SchedulerInfo.CreateInstance Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreateInstance Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.CreateInstance
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.createinstance(v=VS.90)
ms:contentKeyID: 35520615
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
- Microsoft.Web.Media.TransformManager.SchedulerInfo.CreateInstance
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CreateInstance Method

Creates a new instance of a [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Function CreateInstance As Scheduler
'Usage

  Dim instance As SchedulerInfo
Dim returnValue As Scheduler

returnValue = instance.CreateInstance()
```

```csharp
  public Scheduler CreateInstance()
```

```cpp
  public:
Scheduler^ CreateInstance()
```

``` fsharp
  member CreateInstance : unit -> Scheduler 
```

```jscript
  public function CreateInstance() : Scheduler
```

### Return Value

Type: [Microsoft.Web.Media.TransformManager.Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
A local scheduler.  

## Remarks

If you call this method overload, no information will be logged with the scheduler.

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[CreateInstance Overload](schedulerinfo-createinstance-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

