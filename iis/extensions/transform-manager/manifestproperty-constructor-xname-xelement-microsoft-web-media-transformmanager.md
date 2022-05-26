---
title: ManifestProperty Constructor (XName, XElement) (Microsoft.Web.Media.TransformManager)
description: ManifestProperty Constructor (XName, XElement) initializes a new instance of the ManifestProperty class using the specified name and value.
TOCTitle: ManifestProperty Constructor (XName, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.Xml.Linq.XName,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 33674380
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

# ManifestProperty Constructor (XName, XElement)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified name and value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    name As XName, _
    value As XElement _
)
'Usage

  Dim name As XName
Dim value As XElement

Dim instance As New ManifestProperty(name, value)
```

```csharp
  public ManifestProperty(
    XName name,
    XElement value
)
```

```cpp
  public:
ManifestProperty(
    XName^ name, 
    XElement^ value
)
```

``` fsharp
  new : 
        name:XName * 
        value:XElement -> ManifestProperty
```

```jscript
  public function ManifestProperty(
    name : XName, 
    value : XElement
)
```

### Parameters

  - name  
    Type: [System.Xml.Linq.XName](https://msdn.microsoft.com/library/bb347810)  
    The name of the manifest property.  

<!-- end list -->

  - value  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An XML element that contains a manifest property value.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
