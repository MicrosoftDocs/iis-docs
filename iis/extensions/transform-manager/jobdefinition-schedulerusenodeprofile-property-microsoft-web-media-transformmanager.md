---
title: JobDefinition.SchedulerUseNodeProfile Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerUseNodeProfile Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerUseNodeProfile
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.schedulerusenodeprofile(v=VS.90)
ms:contentKeyID: 35521135
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerUseNodeProfile
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerUseNodeProfile
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerUseNodeProfile
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerUseNodeProfile
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerUseNodeProfile
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerUseNodeProfile
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerUseNodeProfile Property

Gets or sets a value that determines whether the HPC scheduler should use the [SchedulerCpus](jobdefinition-schedulercpus-property-microsoft-web-media-transformmanager.md), [SchedulerMemory](jobdefinition-schedulermemory-property-microsoft-web-media-transformmanager.md), and [SchedulerNodeGroups](jobdefinition-schedulernodegroups-property-microsoft-web-media-transformmanager.md) properties when a job is transformed.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property SchedulerUseNodeProfile As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.SchedulerUseNodeProfile

instance.SchedulerUseNodeProfile = value
```

```csharp
[DataMemberAttribute]
public bool SchedulerUseNodeProfile { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool SchedulerUseNodeProfile {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member SchedulerUseNodeProfile : bool with get, set
```

```jscript
  function get SchedulerUseNodeProfile () : boolean
function set SchedulerUseNodeProfile (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the HPC scheduler should use the [SchedulerCpus](jobdefinition-schedulercpus-property-microsoft-web-media-transformmanager.md), [SchedulerMemory](jobdefinition-schedulermemory-property-microsoft-web-media-transformmanager.md) and [SchedulerNodeGroups](jobdefinition-schedulernodegroups-property-microsoft-web-media-transformmanager.md) properties when a job is transformed; otherwise, false.  

## Remarks

On an HPC cluster, compute nodes can have different resources. For instance, some nodes might have many CPUs and others might have more memory. If a job scheduled on HPC requires more memory, the profile should be passed to HPC so that the job is not scheduled on an under-resourced computer.

HPC also enables compute nodes to be collected into node groups. If a node group is a collection of computers that all have enough memory for a set of jobs, that node group can be specified.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

