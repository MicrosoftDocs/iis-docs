---
title: IManifestProperty.CultureInfo Property (Microsoft.Web.Media.TransformManager)
TOCTitle: CultureInfo Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IManifestProperty.CultureInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanifestproperty.cultureinfo(v=VS.90)
ms:contentKeyID: 31477630
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManifestProperty.CultureInfo
- Microsoft.Web.Media.TransformManager.IManifestProperty.get_CultureInfo
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManifestProperty.CultureInfo
- Microsoft.Web.Media.TransformManager.IManifestProperty.get_CultureInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CultureInfo Property

Gets information about a specific culture.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property CultureInfo As CultureInfo
    Get
'Usage

  Dim instance As IManifestProperty
Dim value As CultureInfo

value = instance.CultureInfo
```

```csharp
  CultureInfo CultureInfo { get; }
```

```cpp
  property CultureInfo^ CultureInfo {
    CultureInfo^ get ();
}
```

``` fsharp
  abstract CultureInfo : CultureInfo
```

```jscript
  function get CultureInfo () : CultureInfo
```

### Property Value

Type: [System.Globalization.CultureInfo](https://msdn.microsoft.com/library/kx54z3k7)  
Information about a specific culture.  

## See Also

### Reference

[IManifestProperty Interface](imanifestproperty-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

