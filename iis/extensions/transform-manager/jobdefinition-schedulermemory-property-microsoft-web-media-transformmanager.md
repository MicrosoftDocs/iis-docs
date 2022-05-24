---
title: JobDefinition.SchedulerMemory Property (Microsoft.Web.Media.TransformManager)
description: Describes the JobDefinition.SchedulerMemory property and details its syntax, property value, and remarks.
TOCTitle: SchedulerMemory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerMemory
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.schedulermemory(v=VS.90)
ms:contentKeyID: 35520997
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerMemory
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerMemory
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerMemory
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerMemory Property

Gets or sets a memory value based on the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property SchedulerMemory As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.SchedulerMemory

instance.SchedulerMemory = value
```

```csharp
[DataMemberAttribute]
public int SchedulerMemory { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int SchedulerMemory {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member SchedulerMemory : int with get, set
```

```jscript
  function get SchedulerMemory () : int
function set SchedulerMemory (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
A memory value.  

## Remarks

If the scheduler is an HPC scheduler, the SchedulerMemory property informs the head node to select compute nodes that have at least the amount of memory that is returned by this property. The memory value is measured in gigabytes.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
