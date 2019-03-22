---
title: ManifestProperty.Value Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.value(v=VS.90)
ms:contentKeyID: 35521030
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.Value
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.Value
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Value
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Value Property

Gets or sets the manifest property value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Value As String
    Get
    Set
'Usage

  Dim instance As ManifestProperty
Dim value As String

value = instance.Value

instance.Value = value
```

```csharp
[DataMemberAttribute]
public string Value { get; set; }
```

```cpp
[DataMemberAttribute]
public:
virtual property String^ Value {
    String^ get () sealed;
    void set (String^ value) sealed;
}
```

``` fsharp
[<DataMemberAttribute>]
abstract Value : string with get, set
[<DataMemberAttribute>]
override Value : string with get, set
```

```jscript
  final function get Value () : String
final function set Value (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The value of the manifest property.  

### Implements

[IManifestProperty.Value](imanifestproperty-value-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

