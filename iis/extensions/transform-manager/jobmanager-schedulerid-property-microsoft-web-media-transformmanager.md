---
title: JobManager.SchedulerId Property (Microsoft.Web.Media.TransformManager)
description: This article contains information about syntax and property value for the SchedulerId property, as well as links to additional resources.
TOCTitle: SchedulerId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.SchedulerId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.schedulerid(v=VS.90)
ms:contentKeyID: 35520933
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.SchedulerId
- Microsoft.Web.Media.TransformManager.JobManager.get_SchedulerId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_SchedulerId
- Microsoft.Web.Media.TransformManager.JobManager.SchedulerId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerId Property

Gets the ID of the scheduler that is associated with this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property SchedulerId As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.SchedulerId
```

```csharp
  public string SchedulerId { get; }
```

```cpp
  public:
property String^ SchedulerId {
    String^ get ();
}
```

``` fsharp
  member SchedulerId : string
```

```jscript
  function get SchedulerId () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the scheduler that is associated with this job definition.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
