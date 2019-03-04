---
title: JobDetails.TaskIndex Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskIndex Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.TaskIndex
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.taskindex(v=VS.90)
ms:contentKeyID: 35521118
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_TaskIndex
- Microsoft.Web.Media.TransformManager.JobDetails.TaskIndex
- Microsoft.Web.Media.TransformManager.JobDetails.set_TaskIndex
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_TaskIndex
- Microsoft.Web.Media.TransformManager.JobDetails.set_TaskIndex
- Microsoft.Web.Media.TransformManager.JobDetails.TaskIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskIndex Property

Gets or sets the index of the current task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property TaskIndex As Integer
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As Integer

value = instance.TaskIndex

instance.TaskIndex = value
```

```csharp
[DataMemberAttribute]
public int TaskIndex { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int TaskIndex {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member TaskIndex : int with get, set
```

```jscript
  function get TaskIndex () : int
function set TaskIndex (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The index of the current task within the sequence of tasks that are associated with this job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

