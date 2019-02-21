---
title: IisNamespaces.RdfSchema Property (Microsoft.Web.Media.TransformManager)
TOCTitle: RdfSchema Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.RdfSchema
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.rdfschema(v=VS.90)
ms:contentKeyID: 35520758
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.RdfSchema
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_RdfSchema
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_RdfSchema
- Microsoft.Web.Media.TransformManager.IisNamespaces.RdfSchema
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# RdfSchema Property

Gets the URI of a specific XML namespace related to Resource Description Framework (RDF) schema that is used to represent information about Web resources.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property RdfSchema As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.RdfSchema
```

```csharp
  public static XNamespace RdfSchema { get; }
```

```cpp
  public:
static property XNamespace^ RdfSchema {
    XNamespace^ get ();
}
```

``` fsharp
  static member RdfSchema : XNamespace
```

```jscript
  static function get RdfSchema () : XNamespace
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace value "http://www.w3.org/2000/01/rdf-schema\#".  

## See Also

### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

