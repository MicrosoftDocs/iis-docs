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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# LoadSchedulerInfoObjects Method

Loads a collection of [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) objects based on the specified collection of [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubLoadSchedulerInfoObjects ( _
    schedulersAsCollection(OfJobScheduler) _
)
'Usage
DimschedulersAsCollection(OfJobScheduler)

SchedulerProvider.LoadSchedulerInfoObjects(schedulers)
```

``` csharp
publicstaticvoidLoadSchedulerInfoObjects(
    Collection<JobScheduler> schedulers
)
```

``` c++
public:
staticvoidLoadSchedulerInfoObjects(
    Collection<JobScheduler^>^ schedulers
)
```

``` fsharp
staticmemberLoadSchedulerInfoObjects : 
        schedulers:Collection<JobScheduler> ->unit
```

``` jscript
publicstaticfunctionLoadSchedulerInfoObjects(
    schedulers : Collection<JobScheduler>
)
```

#### Parameters

  - schedulers  
    Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    A collection of [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) objects.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>schedulers is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[SchedulerProvider Class](schedulerprovider-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

