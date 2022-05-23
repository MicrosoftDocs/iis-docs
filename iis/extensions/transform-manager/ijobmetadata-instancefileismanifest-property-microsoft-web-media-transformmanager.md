---
title: IJobMetadata.InstanceFileIsManifest Property (Microsoft.Web.Media.TransformManager)
description: Describes the InstanceFileIsManifest property and provides the property's namespace, assembly, syntax, property value, and additional references.
TOCTitle: InstanceFileIsManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.InstanceFileIsManifest
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ijobmetadata.instancefileismanifest(v=VS.90)
ms:contentKeyID: 35520946
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.InstanceFileIsManifest
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_InstanceFileIsManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_InstanceFileIsManifest
- Microsoft.Web.Media.TransformManager.IJobMetadata.InstanceFileIsManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InstanceFileIsManifest Property

Gets a value that indicates whether the instance file is a manifest file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property InstanceFileIsManifest As Boolean
    Get
'Usage

  Dim instance As IJobMetadata
Dim value As Boolean

value = instance.InstanceFileIsManifest
```

```csharp
  bool InstanceFileIsManifest { get; }
```

```cpp
  property bool InstanceFileIsManifest {
    bool get ();
}
```

``` fsharp
  abstract InstanceFileIsManifest : bool
```

```jscript
  function get InstanceFileIsManifest () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the instance file is a manifest file; otherwise, false.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
