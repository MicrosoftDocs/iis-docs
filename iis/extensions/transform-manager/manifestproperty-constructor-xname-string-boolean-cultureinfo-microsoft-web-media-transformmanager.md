---
title: ManifestProperty Constructor (XName, String, Boolean, CultureInfo) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Constructor (XName, String, Boolean, CultureInfo)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.Xml.Linq.XName,System.String,System.Boolean,System.Globalization.CultureInfo)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 33674354
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestProperty Constructor (XName, String, Boolean, CultureInfo)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified name, value, culture, and whether the property is required.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    name As XName, _
    value As String, _
    required As Boolean, _
    cultureInfo As CultureInfo _
)
'Usage

  Dim name As XName
Dim value As String
Dim required As Boolean
Dim cultureInfo As CultureInfo

Dim instance As New ManifestProperty(name, value, _
    required, cultureInfo)
```

```csharp
  public ManifestProperty(
    XName name,
    string value,
    bool required,
    CultureInfo cultureInfo
)
```

```cpp
  public:
ManifestProperty(
    XName^ name, 
    String^ value, 
    bool required, 
    CultureInfo^ cultureInfo
)
```

``` fsharp
  new : 
        name:XName * 
        value:string * 
        required:bool * 
        cultureInfo:CultureInfo -> ManifestProperty
```

```jscript
  public function ManifestProperty(
    name : XName, 
    value : String, 
    required : boolean, 
    cultureInfo : CultureInfo
)
```

### Parameters

  - name  
    Type: [System.Xml.Linq.XName](https://msdn.microsoft.com/library/bb347810)  
    The name of the manifest property.  

<!-- end list -->

  - value  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The value of the manifest property.  

<!-- end list -->

  - required  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to specify that the manifest property is required; otherwise, false.  

<!-- end list -->

  - cultureInfo  
    Type: [System.Globalization.CultureInfo](https://msdn.microsoft.com/library/kx54z3k7)  
    The culture information of the manifest property.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

