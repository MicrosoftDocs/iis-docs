---
title: JobMetadata.TaskMetadata Property (Microsoft.Web.Media.TransformManager)
description: Describes the TaskMetadata property and provides the property's namespace, assembly, syntax, and property value.
TOCTitle: TaskMetadata Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.TaskMetadata
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmetadata.taskmetadata(v=VS.90)
ms:contentKeyID: 35520931
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskMetadata
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskMetadata
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskMetadata
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskMetadata
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskMetadata Property

Gets the task metadata from the task element that is contained in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property TaskMetadata As XElement
    Get
'Usage

  Dim instance As JobMetadata
Dim value As XElement

value = instance.TaskMetadata
```

```csharp
  public XElement TaskMetadata { get; }
```

```cpp
  public:
property XElement^ TaskMetadata {
    XElement^ get ();
}
```

``` fsharp
  member TaskMetadata : XElement
```

```jscript
  function get TaskMetadata () : XElement
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The task metadata.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
