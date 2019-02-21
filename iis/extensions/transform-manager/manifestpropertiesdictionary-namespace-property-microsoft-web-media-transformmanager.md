---
title: ManifestPropertiesDictionary.Namespace Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Namespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Namespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestpropertiesdictionary.namespace(v=VS.90)
ms:contentKeyID: 35520707
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.set_Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.get_Namespace
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.get_Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.Namespace
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary.set_Namespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Namespace Property

Gets or sets the value from the namespace attribute of the XML element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Namespace As String
    Get
    Set
'Usage

  Dim instance As ManifestPropertiesDictionary
Dim value As String

value = instance.Namespace

instance.Namespace = value
```

```csharp
[DataMemberAttribute]
public string Namespace { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Namespace {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Namespace : string with get, set
```

```jscript
  function get Namespace () : String
function set Namespace (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The value of the namespace attribute of the XML element.  

## See Also

### Reference

[ManifestPropertiesDictionary Class](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

