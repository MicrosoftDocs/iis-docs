---
title: JobDefinition.SchedulerMemory Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerMemory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerMemory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.schedulermemory(v=VS.90)
ms:contentKeyID: 35520997
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerMemory
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerMemory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerMemory Property

Gets or sets a memory value based on the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertySchedulerMemoryAsIntegerGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsIntegervalue = instance.SchedulerMemory

instance.SchedulerMemory = value
```

``` csharp
[DataMemberAttribute]
publicintSchedulerMemory { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintSchedulerMemory {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberSchedulerMemory : intwithget, set
```

``` jscript
function getSchedulerMemory () : intfunction setSchedulerMemory (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
A memory value.  

## Remarks

If the scheduler is an HPC scheduler, the SchedulerMemory property informs the head node to select compute nodes that have at least the amount of memory that is returned by this property. The memory value is measured in gigabytes.

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

