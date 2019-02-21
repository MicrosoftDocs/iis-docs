---
title: JobManager.Priority Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Priority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.Priority
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.priority(v=VS.90)
ms:contentKeyID: 35520708
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_Priority
- Microsoft.Web.Media.TransformManager.JobManager.Priority
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_Priority
- Microsoft.Web.Media.TransformManager.JobManager.Priority
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Priority Property

Gets the priority of a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Priority As Integer
    Get
'Usage

  Dim instance As JobManager
Dim value As Integer

value = instance.Priority
```

```csharp
  public int Priority { get; }
```

```cpp
  public:
property int Priority {
    int get ();
}
```

``` fsharp
  member Priority : int
```

```jscript
  function get Priority () : int
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The priority of a job.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

