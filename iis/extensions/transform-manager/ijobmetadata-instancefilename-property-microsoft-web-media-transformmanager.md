---
title: IJobMetadata.InstanceFileName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.InstanceFileName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ijobmetadata.instancefilename(v=VS.90)
ms:contentKeyID: 35520765
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.InstanceFileName
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_InstanceFileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.IJobMetadata.InstanceFileName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InstanceFileName Property

Gets the instance file name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property InstanceFileName As String
    Get
'Usage

  Dim instance As IJobMetadata
Dim value As String

value = instance.InstanceFileName
```

```csharp
  string InstanceFileName { get; }
```

```cpp
  property String^ InstanceFileName {
    String^ get ();
}
```

``` fsharp
  abstract InstanceFileName : string
```

```jscript
  function get InstanceFileName () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The instance file name.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
