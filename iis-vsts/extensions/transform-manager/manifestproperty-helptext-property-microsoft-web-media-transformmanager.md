---
title: ManifestProperty.HelpText Property (Microsoft.Web.Media.TransformManager)
TOCTitle: HelpText Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.HelpText
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.helptext(v=VS.90)
ms:contentKeyID: 35520856
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_HelpText
- Microsoft.Web.Media.TransformManager.ManifestProperty.HelpText
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_HelpText
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_HelpText
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_HelpText
- Microsoft.Web.Media.TransformManager.ManifestProperty.HelpText
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# HelpText Property

Gets or sets the help text that is associated with the manifest property.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property HelpText As String
    Get
    Set
'Usage

  Dim instance As ManifestProperty
Dim value As String

value = instance.HelpText

instance.HelpText = value
```

```csharp
[DataMemberAttribute]
public string HelpText { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ HelpText {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member HelpText : string with get, set
```

```jscript
  function get HelpText () : String
function set HelpText (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The help text that is associated with the manifest property.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

