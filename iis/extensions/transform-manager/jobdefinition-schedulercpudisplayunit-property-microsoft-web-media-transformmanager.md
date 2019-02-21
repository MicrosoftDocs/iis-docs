---
title: JobDefinition.SchedulerCpuDisplayUnit Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerCpuDisplayUnit Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerCpuDisplayUnit
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.schedulercpudisplayunit(v=VS.90)
ms:contentKeyID: 35520836
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerCpuDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerCpuDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerCpuDisplayUnit
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerCpuDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerCpuDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerCpuDisplayUnit
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SchedulerCpuDisplayUnit Property

Gets or sets an HPC CPU unit value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property SchedulerCpuDisplayUnit As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.SchedulerCpuDisplayUnit

instance.SchedulerCpuDisplayUnit = value
```

```csharp
[DataMemberAttribute]
public string SchedulerCpuDisplayUnit { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ SchedulerCpuDisplayUnit {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member SchedulerCpuDisplayUnit : string with get, set
```

```jscript
  function get SchedulerCpuDisplayUnit () : String
function set SchedulerCpuDisplayUnit (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
An HPC CPU unit value.  

## Remarks

Possible CPU units in HPC are "cores", "nodes", and "sockets".

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

