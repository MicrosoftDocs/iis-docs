---
title: Product.Updates Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Updates Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Updates
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.updates(v=VS.90)
ms:contentKeyID: 22049649
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Updates
- Microsoft.Web.PlatformInstaller.Product.get_Updates
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_Updates
- Microsoft.Web.PlatformInstaller.Product.Updates
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Updates Property

Gets a read-only collection of products that represents updates to the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyUpdatesAsReadOnlyCollection(OfProduct)
    Get
'Usage
DiminstanceAsProductDimvalueAsReadOnlyCollection(OfProduct)

value = instance.Updates
```

``` csharp
publicReadOnlyCollection<Product> Updates { get; }
```

``` c++
public:
propertyReadOnlyCollection<Product^>^ Updates {
    ReadOnlyCollection<Product^>^ get ();
}
```

``` jscript
function getUpdates () : ReadOnlyCollection<Product>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Product](product-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

