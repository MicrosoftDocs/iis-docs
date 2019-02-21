---
title: JobDefinition.SchedulerCpus Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerCpus Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerCpus
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.schedulercpus(v=VS.90)
ms:contentKeyID: 35520835
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerCpus
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerCpus
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerCpus
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerCpus
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerCpus
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerCpus
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerCpus Property

Gets or sets a CPU value based on the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property SchedulerCpus As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.SchedulerCpus

instance.SchedulerCpus = value
```

```csharp
[DataMemberAttribute]
public int SchedulerCpus { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int SchedulerCpus {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member SchedulerCpus : int with get, set
```

```jscript
  function get SchedulerCpus () : int
function set SchedulerCpus (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
A CPU value.  

## Remarks

If the scheduler is an HPC scheduler, the SchedulerCpus property informs the head node to select compute nodes that have at least the number of CPUs that is returned from this property.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

