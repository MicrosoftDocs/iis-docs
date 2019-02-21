---
title: IisNamespaces.ExpressionEncoder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ExpressionEncoder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.ExpressionEncoder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.expressionencoder(v=VS.90)
ms:contentKeyID: 35520851
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_ExpressionEncoder
- Microsoft.Web.Media.TransformManager.IisNamespaces.ExpressionEncoder
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.ExpressionEncoder
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_ExpressionEncoder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ExpressionEncoder Property

Gets the URI of an expression encoder schema document.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property ExpressionEncoder As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.ExpressionEncoder
```

```csharp
  public static XNamespace ExpressionEncoder { get; }
```

```cpp
  public:
static property XNamespace^ ExpressionEncoder {
    XNamespace^ get ();
}
```

``` fsharp
  static member ExpressionEncoder : XNamespace
```

```jscript
  static function get ExpressionEncoder () : XNamespace
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace value "http://schemas.microsoft.com/Expression/Encoder/V4\#".  

## See Also

### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

