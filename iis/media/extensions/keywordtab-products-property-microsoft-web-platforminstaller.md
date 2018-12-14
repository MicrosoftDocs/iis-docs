---
title: KeywordTab.Products Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Products Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.KeywordTab.Products
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.keywordtab.products(v=VS.90)
ms:contentKeyID: 22049626
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.KeywordTab.Products
- Microsoft.Web.PlatformInstaller.KeywordTab.get_Products
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.KeywordTab.get_Products
- Microsoft.Web.PlatformInstaller.KeywordTab.Products
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Products Property

Gets a read-only collection of products associated with the current keyword tab.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProductsAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsKeywordTabDimvalueAsReadOnlyCollection(OfProduct)

value = instance.Products
```

``` csharp
publicReadOnlyCollection<Product> Products { get; }
```

``` c++
public:
propertyReadOnlyCollection<Product^>^ Products {
    ReadOnlyCollection<Product^>^ get ();
}
```

``` jscript
function getProducts () : ReadOnlyCollection<Product>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Product](product-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[KeywordTab Class](keywordtab-class-microsoft-web-platforminstaller.md)

[KeywordTab Members](keywordtab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

