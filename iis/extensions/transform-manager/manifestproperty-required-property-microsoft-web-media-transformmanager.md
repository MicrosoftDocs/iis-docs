---
title: ManifestProperty.Required Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Required Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.Required
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.required(v=VS.90)
ms:contentKeyID: 35520627
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Required
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.Required
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Required
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Required Property

Get or sets a value that specifies whether the manifest property is required.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Required As Boolean
    Get
    Set
'Usage

  Dim instance As ManifestProperty
Dim value As Boolean

value = instance.Required

instance.Required = value
```

```csharp
[DataMemberAttribute]
public bool Required { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool Required {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Required : bool with get, set
```

```jscript
  function get Required () : boolean
function set Required (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the manifest property is required; otherwise, false.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

