---
title: IJobMetadata.Manifest Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Manifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.Manifest
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ijobmetadata.manifest(v=VS.90)
ms:contentKeyID: 35520732
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_Manifest
- Microsoft.Web.Media.TransformManager.IJobMetadata.Manifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_Manifest
- Microsoft.Web.Media.TransformManager.IJobMetadata.Manifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Manifest Property

Gets the full job manifest from the synchronized multimedia interface language (SMIL) manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property Manifest As XElement
    Get
'Usage

  Dim instance As IJobMetadata
Dim value As XElement

value = instance.Manifest
```

```csharp
  XElement Manifest { get; }
```

```cpp
  property XElement^ Manifest {
    XElement^ get ();
}
```

``` fsharp
  abstract Manifest : XElement
```

```jscript
  function get Manifest () : XElement
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The job manifest.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
