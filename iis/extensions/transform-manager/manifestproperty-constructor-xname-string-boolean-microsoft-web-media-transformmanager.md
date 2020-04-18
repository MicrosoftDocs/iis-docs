---
title: ManifestProperty Constructor (XName, String, Boolean) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Constructor (XName, String, Boolean)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.Xml.Linq.XName,System.String,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 33674377
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

# ManifestProperty Constructor (XName, String, Boolean)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified name and value, and whether the property is required.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    name As XName, _
    value As String, _
    required As Boolean _
)
'Usage

  Dim name As XName
Dim value As String
Dim required As Boolean

Dim instance As New ManifestProperty(name, value, _
    required)
```

```csharp
  public ManifestProperty(
    XName name,
    string value,
    bool required
)
```

```cpp
  public:
ManifestProperty(
    XName^ name, 
    String^ value, 
    bool required
)
```

``` fsharp
  new : 
        name:XName * 
        value:string * 
        required:bool -> ManifestProperty
```

```jscript
  public function ManifestProperty(
    name : XName, 
    value : String, 
    required : boolean
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

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
