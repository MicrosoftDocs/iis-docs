---
title: JobMetadata.ProcessPriority Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ProcessPriority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.ProcessPriority
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmetadata.processpriority(v=VS.90)
ms:contentKeyID: 36868656
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_ProcessPriority
- Microsoft.Web.Media.TransformManager.JobMetadata.ProcessPriority
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_ProcessPriority
- Microsoft.Web.Media.TransformManager.JobMetadata.ProcessPriority
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ProcessPriority Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ProcessPriority As ProcessPriorityClass
    Get
'Usage

  Dim instance As JobMetadata
Dim value As ProcessPriorityClass

value = instance.ProcessPriority
```

```csharp
  public ProcessPriorityClass ProcessPriority { get; }
```

```cpp
  public:
virtual property ProcessPriorityClass ProcessPriority {
    ProcessPriorityClass get () sealed;
}
```

``` fsharp
  abstract ProcessPriority : ProcessPriorityClass
override ProcessPriority : ProcessPriorityClass
```

```jscript
  final function get ProcessPriority () : ProcessPriorityClass
```

### Property Value

Type: ProcessPriorityClass  

### Implements

[IJobMetadata.ProcessPriority](ijobmetadata-processpriority-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
