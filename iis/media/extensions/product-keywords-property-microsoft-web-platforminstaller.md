---
title: Product.Keywords Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Keywords Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Keywords
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.keywords(v=VS.90)
ms:contentKeyID: 22049526
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Keywords
- Microsoft.Web.PlatformInstaller.Product.get_Keywords
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_Keywords
- Microsoft.Web.PlatformInstaller.Product.Keywords
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Keywords Property

Gets a read-only collection of [Keyword](keyword-class-microsoft-web-platforminstaller.md) objects for the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyKeywordsAsReadOnlyCollection(OfKeyword)
    Get
'Usage
DiminstanceAsProductDimvalueAsReadOnlyCollection(OfKeyword)

value = instance.Keywords
```

``` csharp
publicReadOnlyCollection<Keyword> Keywords { get; }
```

``` c++
public:
propertyReadOnlyCollection<Keyword^>^ Keywords {
    ReadOnlyCollection<Keyword^>^ get ();
}
```

``` jscript
function getKeywords () : ReadOnlyCollection<Keyword>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Keyword](keyword-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Keyword](keyword-class-microsoft-web-platforminstaller.md) objects for the current product.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

