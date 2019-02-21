---
title: ManifestPropertiesDictionary.Prefix Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Prefix Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Prefix
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestpropertiesdictionary.prefix(v=VS.90)
ms:contentKeyID: 35520821
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Prefix
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.get_Prefix
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.set_Prefix
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.get_Prefix
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Prefix
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.set_Prefix
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Prefix Property

Gets or sets the value from the prefix attribute of the XML element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Prefix As String
    Get
    Set
'Usage

  Dim instance As ManifestPropertiesDictionary
Dim value As String

value = instance.Prefix

instance.Prefix = value
```

```csharp
[DataMemberAttribute]
public string Prefix { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Prefix {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Prefix : string with get, set
```

```jscript
  function get Prefix () : String
function set Prefix (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The prefix value from the prefix attribute of the XML element.  

## See Also

### Reference

[ManifestPropertiesDictionary Class](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

