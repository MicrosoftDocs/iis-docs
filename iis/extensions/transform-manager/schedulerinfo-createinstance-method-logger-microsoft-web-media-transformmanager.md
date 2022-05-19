---
title: SchedulerInfo.CreateInstance Method (Logger) (Microsoft.Web.Media.TransformManager)
description: Describes the CreateInstance method and provides the method's namespace, assembly, syntax, parameters, and return value.
TOCTitle: CreateInstance Method (Logger)
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.CreateInstance(Microsoft.Web.Media.TransformManager.Logger)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.createinstance(v=VS.90)
ms:contentKeyID: 35520897
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

# CreateInstance Method (Logger)

Creates a new instance of a [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object by using logger object to log details.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Function CreateInstance ( _
    logger As Logger _
) As Scheduler
'Usage

  Dim instance As SchedulerInfo
Dim logger As Logger
Dim returnValue As Scheduler

returnValue = instance.CreateInstance(logger)
```

```csharp
  public Scheduler CreateInstance(
    Logger logger
)
```

```cpp
  public:
Scheduler^ CreateInstance(
    Logger^ logger
)
```

``` fsharp
  member CreateInstance : 
        logger:Logger -> Scheduler 
```

```jscript
  public function CreateInstance(
    logger : Logger
) : Scheduler
```

### Parameters

  - logger  
    Type: [Microsoft.Web.Media.TransformManager.Logger](logger-class-microsoft-web-media-transformmanager.md)  
    The [Logger](logger-class-microsoft-web-media-transformmanager.md) object that is used to log scheduler details.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.Scheduler](scheduler-class-microsoft-web-media-transformmanager.md)  
A [Scheduler](scheduler-class-microsoft-web-media-transformmanager.md) object that can be used to schedule a new job.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[CreateInstance Overload](schedulerinfo-createinstance-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
