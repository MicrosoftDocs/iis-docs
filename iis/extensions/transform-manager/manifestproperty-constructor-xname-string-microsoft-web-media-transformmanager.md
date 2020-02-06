---
title: ManifestProperty Constructor (XName, String) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Constructor (XName, String)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.Xml.Linq.XName,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 31477655
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

# ManifestProperty Constructor (XName, String)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified name and value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    name As XName, _
    value As String _
)
'Usage

  Dim name As XName
Dim value As String

Dim instance As New ManifestProperty(name, value)
```

```csharp
  public ManifestProperty(
    XName name,
    string value
)
```

```cpp
  public:
ManifestProperty(
    XName^ name, 
    String^ value
)
```

``` fsharp
  new : 
        name:XName * 
        value:string -> ManifestProperty
```

```jscript
  public function ManifestProperty(
    name : XName, 
    value : String
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

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

