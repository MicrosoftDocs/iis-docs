---
title: JobDefinition.ConcurrentJobs Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConcurrentJobs Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.ConcurrentJobs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.concurrentjobs(v=VS.90)
ms:contentKeyID: 35520819
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.ConcurrentJobs
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ConcurrentJobs
- Microsoft.Web.Media.TransformManager.JobDefinition.set_ConcurrentJobs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.ConcurrentJobs
- Microsoft.Web.Media.TransformManager.JobDefinition.set_ConcurrentJobs
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ConcurrentJobs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConcurrentJobs Property

Gets or sets the number of concurrent jobs that the job manager can start when it uses this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property ConcurrentJobs As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.ConcurrentJobs

instance.ConcurrentJobs = value
```

```csharp
[DataMemberAttribute]
public int ConcurrentJobs { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int ConcurrentJobs {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member ConcurrentJobs : int with get, set
```

```jscript
  function get ConcurrentJobs () : int
function set ConcurrentJobs (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of concurrent jobs that the job manager can start when it uses this job definition.  

## Remarks

A job scheduler can have a global limit on the number of concurrent jobs that it will create. Any job definition can also have a limit so that overall job throughput can be managed using the ConcurrentJobs property.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
