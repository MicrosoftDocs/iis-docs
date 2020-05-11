---
title: ManifestProperty.CultureInfoMoniker Property (Microsoft.Web.Media.TransformManager)
TOCTitle: CultureInfoMoniker Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfoMoniker
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.manifestproperty.cultureinfomoniker(v=VS.90)
ms:contentKeyID: 35521031
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_CultureInfoMoniker
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_CultureInfoMoniker
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_CultureInfoMoniker
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CultureInfoMoniker Property

Gets or sets a value that represents the culture language.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property CultureInfoMoniker As String
    Get
    Set
'Usage

  Dim instance As ManifestProperty
Dim value As String

value = instance.CultureInfoMoniker

instance.CultureInfoMoniker = value
```

```csharp
[DataMemberAttribute]
public string CultureInfoMoniker { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ CultureInfoMoniker {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member CultureInfoMoniker : string with get, set
```

```jscript
  function get CultureInfoMoniker () : String
function set CultureInfoMoniker (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The culture language.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
