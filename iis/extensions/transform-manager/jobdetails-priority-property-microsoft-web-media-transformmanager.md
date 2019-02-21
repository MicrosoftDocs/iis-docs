---
title: JobDetails.Priority Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Priority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.Priority
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.priority(v=VS.90)
ms:contentKeyID: 35520884
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.Priority
- Microsoft.Web.Media.TransformManager.JobDetails.set_Priority
- Microsoft.Web.Media.TransformManager.JobDetails.get_Priority
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_Priority
- Microsoft.Web.Media.TransformManager.JobDetails.Priority
- Microsoft.Web.Media.TransformManager.JobDetails.set_Priority
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Priority Property

Gets or sets the priority of the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Priority As Integer
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As Integer

value = instance.Priority

instance.Priority = value
```

```csharp
[DataMemberAttribute]
public int Priority { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int Priority {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Priority : int with get, set
```

```jscript
  function get Priority () : int
function set Priority (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The priority of the job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

