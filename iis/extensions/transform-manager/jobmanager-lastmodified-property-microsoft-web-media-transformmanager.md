---
title: JobManager.LastModified Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LastModified Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.LastModified
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.lastmodified(v=VS.90)
ms:contentKeyID: 35520601
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_LastModified
- Microsoft.Web.Media.TransformManager.JobManager.LastModified
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_LastModified
- Microsoft.Web.Media.TransformManager.JobManager.LastModified
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LastModified Property

Gets the date and time when the IIS Transform Manager configuration was last modified.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property LastModified As DateTime
    Get
'Usage

  Dim instance As JobManager
Dim value As DateTime

value = instance.LastModified
```

```csharp
  public DateTime LastModified { get; }
```

```cpp
  public:
property DateTime LastModified {
    DateTime get ();
}
```

``` fsharp
  member LastModified : DateTime
```

```jscript
  function get LastModified () : DateTime
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
The date and time when the IIS Transform Manager configuration was last modified.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
