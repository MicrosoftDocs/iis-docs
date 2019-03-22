---
title: ConfigurationBase.BaseNamespace Property (Microsoft.Web.Media.TransformManager)
TOCTitle: BaseNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.BaseNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.basenamespace(v=VS.90)
ms:contentKeyID: 35521160
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_BaseNamespace
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_BaseNamespace
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_BaseNamespace
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# BaseNamespace Property

Gets or sets the XML namespace for the configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property BaseNamespace As XNamespace
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As XNamespace

value = instance.BaseNamespace

instance.BaseNamespace = value
```

```csharp
  public XNamespace BaseNamespace { get; set; }
```

```cpp
  public:
property XNamespace^ BaseNamespace {
    XNamespace^ get ();
    void set (XNamespace^ value);
}
```

``` fsharp
  member BaseNamespace : XNamespace with get, set
```

```jscript
  function get BaseNamespace () : XNamespace
function set BaseNamespace (value : XNamespace)
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

