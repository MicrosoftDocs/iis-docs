---
title: ManifestProperty Constructor (String, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Constructor (String, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.String,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 35520876
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

# ManifestProperty Constructor (String, XElement)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified namespace and XML metadata element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    ns As String, _
    property As XElement _
)
'Usage

  Dim ns As String
Dim property As XElement

Dim instance As New ManifestProperty(ns, property)
```

```csharp
  public ManifestProperty(
    string ns,
    XElement property
)
```

```cpp
  public:
ManifestProperty(
    String^ ns,
    XElement^ property
)
```

``` fsharp
  new :
        ns:string *
        property:XElement -> ManifestProperty
```

```jscript
  public function ManifestProperty(
    ns : String,
    property : XElement
)
```

### Parameters

  - ns  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The namespace of the manifest property.  

<!-- end list -->

  - property  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An object that contains task-specific metadata.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
