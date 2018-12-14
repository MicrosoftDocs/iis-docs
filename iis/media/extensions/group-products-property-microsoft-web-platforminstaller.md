---
title: Group.Products Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Products Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Group.Products
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.group.products(v=VS.90)
ms:contentKeyID: 22049753
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Group.Products
- Microsoft.Web.PlatformInstaller.Group.get_Products
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Group.get_Products
- Microsoft.Web.PlatformInstaller.Group.Products
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Products Property

Gets a collection of products this group represents.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProductsAsICollection(OfProduct)
    Get
'Usage
DiminstanceAsGroupDimvalueAsICollection(OfProduct)

value = instance.Products
```

``` csharp
publicICollection<Product> Products { get; }
```

``` c++
public:
propertyICollection<Product^>^ Products {
    ICollection<Product^>^ get ();
}
```

``` jscript
function getProducts () : ICollection<Product>
```

#### Property Value

Type: ICollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
An System.Collections.ICollection of [Product](product-class-microsoft-web-platforminstaller.md) object instances.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Group Class](group-class-microsoft-web-platforminstaller.md)

[Group Members](group-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

