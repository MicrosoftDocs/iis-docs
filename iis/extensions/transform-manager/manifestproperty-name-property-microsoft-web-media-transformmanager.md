---
title: ManifestProperty.Name Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ManifestProperty.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.name(v=VS.90)
ms:contentKeyID: 35520908
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Name
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty.get_Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.set_Name
- Microsoft.Web.Media.TransformManager.ManifestProperty.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets or sets the Name element of the manifest property.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Property Name As XName
    Get
    Set
'Usage

  Dim instance As ManifestProperty
Dim value As XName

value = instance.Name

instance.Name = value
```

```csharp
  public XName Name { get; set; }
```

```cpp
  public:
virtual property XName^ Name {
    XName^ get () sealed;
    void set (XName^ value) sealed;
}
```

``` fsharp
  abstract Name : XName with get, set
override Name : XName with get, set
```

```jscript
  final function get Name () : XName
final function set Name (value : XName)
```

### Property Value

Type: [System.Xml.Linq.XName](https://msdn.microsoft.com/library/bb347810)  
The name of the manifest property.  

### Implements

[IManifestProperty.Name](imanifestproperty-name-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

