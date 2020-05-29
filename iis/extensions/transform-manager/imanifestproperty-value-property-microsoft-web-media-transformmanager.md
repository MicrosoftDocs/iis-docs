---
title: IManifestProperty.Value Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IManifestProperty.Value
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanifestproperty.value(v=VS.90)
ms:contentKeyID: 31477619
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManifestProperty.get_Value
- Microsoft.Web.Media.TransformManager.IManifestProperty.Value
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManifestProperty.get_Value
- Microsoft.Web.Media.TransformManager.IManifestProperty.Value
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Value Property

Gets the manifest property value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property Value As String
    Get
'Usage

  Dim instance As IManifestProperty
Dim value As String

value = instance.Value
```

```csharp
  string Value { get; }
```

```cpp
  property String^ Value {
    String^ get ();
}
```

``` fsharp
  abstract Value : string
```

```jscript
  function get Value () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The property value.  

## See Also

### Reference

[IManifestProperty Interface](imanifestproperty-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
