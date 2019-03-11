---
title: JobMetadata.TaskElement Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.TaskElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.taskelement(v=VS.90)
ms:contentKeyID: 35520696
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskElement
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_TaskElement
- Microsoft.Web.Media.TransformManager.JobMetadata.TaskElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskElement Property

Gets the task element from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property TaskElement As XElement
    Get
'Usage

  Dim instance As JobMetadata
Dim value As XElement

value = instance.TaskElement
```

```csharp
  public XElement TaskElement { get; }
```

```cpp
  public:
virtual property XElement^ TaskElement {
    XElement^ get () sealed;
}
```

``` fsharp
  abstract TaskElement : XElement
override TaskElement : XElement
```

```jscript
  final function get TaskElement () : XElement
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The task element.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

