---
title: ConfigurationBase.IdElement Property (Microsoft.Web.Media.TransformManager)
TOCTitle: IdElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.IdElement
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.idelement(v=VS.90)
ms:contentKeyID: 35520938
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_IdElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.IdElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_IdElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IdElement Property

Gets or sets the XML ID element of a configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property IdElement As XElement
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As XElement

value = instance.IdElement

instance.IdElement = value
```

```csharp
  public XElement IdElement { get; set; }
```

```cpp
  public:
property XElement^ IdElement {
    XElement^ get ();
    void set (XElement^ value);
}
```

``` fsharp
  member IdElement : XElement with get, set
```

```jscript
  function get IdElement () : XElement
function set IdElement (value : XElement)
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The XML ID element of the IIS Transform Manager configuration.  

## Remarks

This property is an XElement object whose value is the ID of this configuration object. The XElement contains more information than just the value; in particular, it contains namespace information.

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

