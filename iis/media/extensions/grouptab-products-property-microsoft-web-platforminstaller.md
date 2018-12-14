---
title: GroupTab.Products Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Products Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.GroupTab.Products
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.grouptab.products(v=VS.90)
ms:contentKeyID: 22049586
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.GroupTab.Products
- Microsoft.Web.PlatformInstaller.GroupTab.get_Products
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.GroupTab.get_Products
- Microsoft.Web.PlatformInstaller.GroupTab.Products
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Products Property

Gets the products that are associated with this group tab.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProductsAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsGroupTabDimvalueAsReadOnlyCollection(OfProduct)

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
A ReadOnlyCollection of [Product](product-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[GroupTab Class](grouptab-class-microsoft-web-platforminstaller.md)

[GroupTab Members](grouptab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

