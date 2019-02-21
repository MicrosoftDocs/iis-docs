---
title: SchedulerProvider.LoadSchedulerInfoObjects Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: LoadSchedulerInfoObjects Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerProvider.LoadSchedulerInfoObjects(System.Collections.ObjectModel.Collection{Microsoft.Web.Media.TransformManager.JobScheduler})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerprovider.loadschedulerinfoobjects(v=VS.90)
ms:contentKeyID: 35520995
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerProvider.LoadSchedulerInfoObjects
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerProvider.LoadSchedulerInfoObjects
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LoadSchedulerInfoObjects Method

Loads a collection of [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) objects based on the specified collection of [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub LoadSchedulerInfoObjects ( _
    schedulers As Collection(Of JobScheduler) _
)
'Usage

  Dim schedulers As Collection(Of JobScheduler)

SchedulerProvider.LoadSchedulerInfoObjects(schedulers)
```

```csharp
  public static void LoadSchedulerInfoObjects(
    Collection<JobScheduler> schedulers
)
```

```cpp
  public:
static void LoadSchedulerInfoObjects(
    Collection<JobScheduler^>^ schedulers
)
```

``` fsharp
  static member LoadSchedulerInfoObjects : 
        schedulers:Collection<JobScheduler> -> unit 
```

```jscript
  public static function LoadSchedulerInfoObjects(
    schedulers : Collection<JobScheduler>
)
```

### Parameters

  - schedulers  
    Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    A collection of [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|schedulers is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|


## See Also

### Reference

[SchedulerProvider Class](schedulerprovider-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

