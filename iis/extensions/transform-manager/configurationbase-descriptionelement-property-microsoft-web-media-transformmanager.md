---
title: ConfigurationBase.DescriptionElement Property (Microsoft.Web.Media.TransformManager)
description: DescriptionElement Property gets or set the XML element that contains the description of the I I S Transform Manager configuration.
TOCTitle: DescriptionElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.DescriptionElement
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.descriptionelement(v=VS.90)
ms:contentKeyID: 35521184
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_DescriptionElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_DescriptionElement
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_DescriptionElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DescriptionElement Property

Gets or set the XML element that contains the description of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property DescriptionElement As XElement
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As XElement

value = instance.DescriptionElement

instance.DescriptionElement = value
```

```csharp
  public XElement DescriptionElement { get; set; }
```

```cpp
  public:
property XElement^ DescriptionElement {
    XElement^ get ();
    void set (XElement^ value);
}
```

``` fsharp
  member DescriptionElement : XElement with get, set
```

```jscript
  function get DescriptionElement () : XElement
function set DescriptionElement (value : XElement)
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The XML element that contains the description of the IIS Transform Manager configuration.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
