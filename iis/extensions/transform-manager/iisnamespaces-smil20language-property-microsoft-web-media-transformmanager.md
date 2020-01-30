---
title: IisNamespaces.Smil20Language Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Smil20Language Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.Smil20Language
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.iisnamespaces.smil20language(v=VS.90)
ms:contentKeyID: 35520937
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Smil20Language
- Microsoft.Web.Media.TransformManager.IisNamespaces.Smil20Language
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Smil20Language
- Microsoft.Web.Media.TransformManager.IisNamespaces.Smil20Language
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Smil20Language Property

Gets the URI of an XML based Synchronized Multimedia Integration Language (SMIL) namespace that is used to represent information about audiovisual presentations.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property Smil20Language As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.Smil20Language
```

```csharp
  public static XNamespace Smil20Language { get; }
```

```cpp
  public:
static property XNamespace^ Smil20Language {
    XNamespace^ get ();
}
```

``` fsharp
  static member Smil20Language : XNamespace
```

```jscript
  static function get Smil20Language () : XNamespace
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace value "<http://www.w3.org/2001/SMIL20/Language>".  

## See Also

### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

