---
title: Language.AvailableProducts Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: AvailableProducts Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Language.AvailableProducts
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.language.availableproducts(v=VS.90)
ms:contentKeyID: 22049736
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Language.AvailableProducts
- Microsoft.Web.PlatformInstaller.Language.get_AvailableProducts
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Language.AvailableProducts
- Microsoft.Web.PlatformInstaller.Language.get_AvailableProducts
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AvailableProducts Property

Gets a read-only collection of products available for the current language.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAvailableProductsAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsLanguageDimvalueAsReadOnlyCollection(OfProduct)

value = instance.AvailableProducts
```

``` csharp
publicReadOnlyCollection<Product> AvailableProducts { get; }
```

``` c++
public:
propertyReadOnlyCollection<Product^>^ AvailableProducts {
    ReadOnlyCollection<Product^>^ get ();
}
```

``` jscript
function getAvailableProducts () : ReadOnlyCollection<Product>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Product](product-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Language Class](language-class-microsoft-web-platforminstaller.md)

[Language Members](language-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

