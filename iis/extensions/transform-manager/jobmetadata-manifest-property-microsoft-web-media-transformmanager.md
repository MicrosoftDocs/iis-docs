---
title: JobMetadata.Manifest Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Manifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.Manifest
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmetadata.manifest(v=VS.90)
ms:contentKeyID: 35521159
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.Manifest
- Microsoft.Web.Media.TransformManager.JobMetadata.get_Manifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_Manifest
- Microsoft.Web.Media.TransformManager.JobMetadata.Manifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Manifest Property

Gets the manifest metadata from the synchronized multimedia interface language (SMIL) manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Manifest As XElement
    Get
'Usage

  Dim instance As JobMetadata
Dim value As XElement

value = instance.Manifest
```

```csharp
  public XElement Manifest { get; }
```

```cpp
  public:
virtual property XElement^ Manifest {
    XElement^ get () sealed;
}
```

``` fsharp
  abstract Manifest : XElement
override Manifest : XElement
```

```jscript
  final function get Manifest () : XElement
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The manifest metadata.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

