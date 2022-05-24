---
title: ConfigurationBase.NameElement Property (Microsoft.Web.Media.TransformManager)
description: Describes the NameElement property and provides the property's namespace, assembly, syntax, and property value.
TOCTitle: NameElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.NameElement
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.nameelement(v=VS.90)
ms:contentKeyID: 35520928
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.NameElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.NameElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_NameElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# NameElement Property

Gets or sets an XML element that contains name details.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property NameElement As XElement
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As XElement

value = instance.NameElement

instance.NameElement = value
```

```csharp
  public XElement NameElement { get; set; }
```

```cpp
  public:
property XElement^ NameElement {
    XElement^ get ();
    void set (XElement^ value);
}
```

``` fsharp
  member NameElement : XElement with get, set
```

```jscript
  function get NameElement () : XElement
function set NameElement (value : XElement)
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The XML element that contains name details.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
